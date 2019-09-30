using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BAL
{
    public class Mapper
    {
        public List<SeatStatuDTO> SeatStatusMapper(List<SeatStatu> seatStatus, List<SeatStatuDTO> seatStatusDTO)
        { 
            foreach(var seat in seatStatus)
            {
                seatStatusDTO.Add(new SeatStatuDTO() { 
                
                 BusStatusId = seat.BusStatusId,
                 SeatNumber = seat.SeatNumber
                });
            }
            return seatStatusDTO;
           
        }
    }
}
