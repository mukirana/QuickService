using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Repository;
namespace DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork , IDisposable
    {
        private BusBookingSystemEntities context = new BusBookingSystemEntities();
        private GenericRepository<Admin> adminRepo;
        private GenericRepository<Bus> busRepo;
        private GenericRepository<BusDetail> busDetailRepo;
        private GenericRepository<BusStatu> busStatusRepo;
        private GenericRepository<BusTiming> busTimingRepo;
        private GenericRepository<CancelBooking> cancelBookingRepo;
        private GenericRepository<Customer> customerRepo;
        private GenericRepository<PaymentDetail> paymentDetailRepo;
        private GenericRepository<Pricing> pricingRepo;
        private GenericRepository<Query> queryRepo;
        private GenericRepository<Refund> refundRepo;
        private GenericRepository<Route> routeRepo;
        private GenericRepository<RouteStop> routeStopRepo;
        private GenericRepository<SeatStatu> seatStatusRepo;
        private GenericRepository<Stop> stopRepo;
        private GenericRepository<TicketBooking> ticketBookingRepo;

        public GenericRepository<Admin> AdminRepo
        {
            get
            {
                if (adminRepo == null)
                {
                    adminRepo = new GenericRepository<Admin>(context);
                }
                return adminRepo;
            }
        }

        public GenericRepository<Bus> BusRepo
        {
            get
            {
                if (busRepo == null)
                {
                    busRepo = new GenericRepository<Bus>(context);
                }
                return busRepo;
            }
        }

        public GenericRepository<BusDetail> BusDetailRepo
        {
            get
            {
                if (busDetailRepo == null)
                {
                    busDetailRepo = new GenericRepository<BusDetail>(context);
                }
                return busDetailRepo;
            }
        }

        public GenericRepository<BusStatu> BusStatusRepo
        {
            get
            {
                if (busStatusRepo == null)
                {
                    busStatusRepo = new GenericRepository<BusStatu>(context);
                }
                return busStatusRepo;
            }
        }

        public GenericRepository<BusTiming> BusTimingRepo
        {
            get
            {
                if (busTimingRepo == null)
                {
                    busTimingRepo = new GenericRepository<BusTiming>(context);
                }
                return busTimingRepo;
            }
        }

        public GenericRepository<CancelBooking> CancelBookingRepo
        {
            get
            {
                if (cancelBookingRepo == null)
                {
                    cancelBookingRepo = new GenericRepository<CancelBooking>(context);
                }
                return cancelBookingRepo;
            }
        }

        public GenericRepository<Customer> CustmoerRepo
        {
            get
            {
                if (customerRepo == null)
                {
                    customerRepo = new GenericRepository<Customer>(context);
                }
                return customerRepo;
            }
        }

        public GenericRepository<PaymentDetail> PaymentDetailRepo
        {
            get
            {
                if (paymentDetailRepo == null)
                {
                    paymentDetailRepo = new GenericRepository<PaymentDetail>(context);
                }
                return paymentDetailRepo;
            }
        }

        public GenericRepository<Pricing> PricingRepo
        {
            get
            {
                if (pricingRepo == null)
                {
                    pricingRepo = new GenericRepository<Pricing>(context);
                }
                return pricingRepo;
            }
        }

        public GenericRepository<Query> QueryRepo
        {
            get
            {
                if (queryRepo == null)
                {
                    queryRepo = new GenericRepository<Query>(context);
                }
                return queryRepo;
            }
        }

        public GenericRepository<Refund> RefundRepo
        {
            get
            {
                if (refundRepo == null)
                {
                    refundRepo = new GenericRepository<Refund>(context);
                }
                return refundRepo;
            }
        }

        public GenericRepository<Route> RouteRepo
        {
            get
            {
                if (routeRepo == null)
                {
                    routeRepo = new GenericRepository<Route>(context);
                }
                return routeRepo;
            }
        }

        public GenericRepository<RouteStop> RouteStopRepo
        {
            get
            {
                if (routeStopRepo == null)
                {
                    routeStopRepo = new GenericRepository<RouteStop>(context);
                }
                return routeStopRepo;
            }
        }
        public GenericRepository<SeatStatu> SeatStatusRepo
        {
            get
            {
                if (seatStatusRepo == null)
                {
                    seatStatusRepo = new GenericRepository<SeatStatu>(context);
                }
                return seatStatusRepo;
            }
        }

        public GenericRepository<Stop> StopRepo
        {
            get
            {
                if (stopRepo == null)
                {
                    stopRepo = new GenericRepository<Stop>(context);
                }
                return stopRepo;
            }
        }

        public GenericRepository<TicketBooking> TicketBookingRepo
        {
            get
            {
                if (ticketBookingRepo == null)
                {
                    ticketBookingRepo = new GenericRepository<TicketBooking>(context);
                }
                return ticketBookingRepo;
            }
        }

        public void Complete()
        {
            context.SaveChangesAsync();
        }
        public void CompleteSync()
        {
            context.SaveChanges();
        }

        public void Dispose()
        {
            if (context != null)
            {
                context.Dispose();
            }
        }
    }
}
