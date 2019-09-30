using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using DAL.UnitOfWork;
namespace BAL
{
    public class CustomerBL
    {
        private List<Stop> Stoplist;
        public List<StopDTO> getStops()
        {
             Stoplist = new UnitOfWork().StopRepo.GetAll().ToList();
            List<StopDTO> listdto = new List<StopDTO>();
            foreach (var l in Stoplist)
            {
                listdto.Add(new StopDTO()
                {
                    StopId = l.StopId,
                    StopName = l.StopName
                });
            }
            return listdto;
        }

        /// <summary>
        /// It take Bus boarding and deboarding station and Booking date and return all the busses.
        /// Input will be boarding station , deboarding station and date of journey.
        /// </summary>
        /// <returns> will return list of all the bus details of particular date and route</returns>
        public List<BusStatuDTO> GetBusOfGivenRoute(String startBus , String endBus, DateTime date){
            List<Stop> list = new UnitOfWork().StopRepo.GetAll().ToList();
            int stopIdStart = list.SingleOrDefault(u => u.StopName == startBus).StopId;
            int stopIdEnd = list.Where(u => u.StopName == endBus).SingleOrDefault().StopId;
            List<int> route1 = new UnitOfWork().RouteStopRepo.GetAll().Where(u => u.StopId ==stopIdStart  ).Select(u => u.RouteId).ToList();
            List<int> route2 = new UnitOfWork().RouteStopRepo.GetAll().Where(u=> u.StopId ==stopIdEnd).Select(u=> u.RouteId).ToList();
            List<int> IntersectOfRoute= route1.Intersect(route2).ToList();
            List<int> finalRoute = new List<int>();


            foreach(var routeId in IntersectOfRoute){
                int first = new UnitOfWork().RouteStopRepo.GetAll().Where(u=> u.StopId == stopIdStart && u.RouteId==routeId).Select(u=> u.StopOrder).FirstOrDefault();
                int second =new UnitOfWork().RouteStopRepo.GetAll().Where(u=> u.StopId == stopIdEnd && u.RouteId == routeId).Select(u=> u.StopOrder).FirstOrDefault();
                if(first < second)
                    finalRoute.Add(routeId);
                
            }

         // get all buses of given route and given date
            List<BusStatu> buses = new List<BusStatu>();
            foreach(int val in finalRoute){
                buses.AddRange(new UnitOfWork().BusStatusRepo.GetAll().Where(u=> u.RouteId==val && u.Date==date).ToList());
            }

            // if bus is not available on given date then we will generate bus-status
            if (buses.Count() == 0)
            {
                List<Bus> GivenRouteBus = new List<Bus>();
                foreach (int val in finalRoute)
                {
                    GivenRouteBus.AddRange(new UnitOfWork().BusRepo.GetAll().Where(u=> u.RouteId == val).ToList());
                }
                foreach (var val in GivenRouteBus)
                {
                    BusStatu busstatu = new BusStatu(){
                        BusRegistrationNumber = val.BusRegistrationNumber,
                        RouteId = val.RouteId,
                        SeatFilled = 0,
                        Date = date,
                    };
                    UnitOfWork uowork = new UnitOfWork();
                    uowork.BusStatusRepo.Add(busstatu);
                    uowork.Complete();
                }
                foreach (int val in finalRoute)
                {
                    buses.AddRange(new UnitOfWork().BusStatusRepo.GetAll().Where(u => u.RouteId == val && u.Date == date).ToList());
                }

            }

            List<BusStatuDTO> busstatusDto = new List<BusStatuDTO>();
            List<String> busStatus = new List<String>();

            foreach (var val in buses)
            {
                busstatusDto.Add(new BusStatuDTO()
                {
                    BusRegistrationNumber = val.BusRegistrationNumber,
                    SeatFilled = val.SeatFilled,
                    Date = val.Date,
                    RouteId = val.RouteId,
                    BusStatusId = val.BusStatusId,
                    Bus = new BusDTO()
                    {
                        BusDetail = new BusDetailDTO() { 
                            BusName =val.Bus.BusDetail.BusName,
                            TotalSeat = val.Bus.BusDetail.TotalSeat,
                            BusType = val.Bus.BusDetail.BusType,
                            Fare = val.Bus.BusDetail.Fare
                        },
                        Route = new RouteDTO(){
                            StartingPoint = val.Bus.Route.StartingPoint,
                            DroppingPoint = val.Bus.Route.DroppingPoint
                        },

                    },
                    BusTiming = new BusTimingDTO()
                    {
                        StartingTime = val.BusTiming.StartingTime
                    }

                });
             
            }
            return busstatusDto;
        }
    }
}
