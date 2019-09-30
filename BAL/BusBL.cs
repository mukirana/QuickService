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
    public class BusBL
    {
        public List<SeatStatuDTO> BookedSeats(int BusStatusId)
        {
            List<SeatStatu> SeatStatus = new UnitOfWork().SeatStatusRepo.GetAll().Where(u => u.BusStatusId == BusStatusId).ToList();
            List<SeatStatuDTO> SeatStatusDTO = new List<SeatStatuDTO>();
            SeatStatusDTO = new Mapper().SeatStatusMapper(SeatStatus, SeatStatusDTO);
            return SeatStatusDTO;

        }
    }
}
