﻿using System;
using System.Collections.Generic;
using System.IO;
namespace userDatabase
{

    public class lotInfo
    {
        private person name;
        private car userCar;
        private bool reserved;
        private string reserveTimeTo;
        private string beginDate;
        private string reserveTime;
        private string endDate;
       

        List<lotInfo> availableLots = new List<lotInfo>();
        List<lotInfo> unavailableLots = new List<lotInfo>();

        public lotInfo() 
        {
            name = new person();
            userCar = new car();
            reserved = false;
            reserveTimeTo = "12:00:00";
            reserveTime = "11:59:59";
            
        }
        public lotInfo(person customer, bool reservation, string timeTo, string timeFrom, string b, string e, car userCar)
        {
            name = customer;
            this.userCar = userCar;
            reserved = reservation;
            reserveTimeTo = timeTo;
            reserveTime = timeFrom;
            beginDate = b;
            endDate = e;
        }
        
        public void countAvailableLots(int z)
        {
            for (int i = 0; i < z; i++)
            {
                availableLots.Add(new lotInfo());
            }
        }
        public void addReservation(person customer,string beginngDay, string endDay, string timeReserved, string timeTo, car customerCar)
        {
            unavailableLots.Add(new lotInfo(customer, true, timeTo, timeReserved, beginngDay, endDay, customerCar));
            
        }
        public void createNewAvailableLot(lotInfo lot)
        {
            for (int i = 0; i < unavailableLots.Count(); i++)
            {
                if (unavailableLots.Equals(lot))
                {
                    availableLots.Add(lot);
                }
            }
        }


    }
}