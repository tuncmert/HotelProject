﻿using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {

        public EfBookingDal(Context context) : base(context)
        {
        }

        public void BookingStatusApprove(int id)
        {
            var context = new Context();
            var value = context.Bookings.FirstOrDefault(x => x.BookingID == id);
            value.Status = "Onaylandı";
            context.SaveChanges();  

        }
    }
}
