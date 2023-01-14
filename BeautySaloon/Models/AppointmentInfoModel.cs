using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BeautySaloon.Models
{
    public class AppointmentInfoModel
    {
        public DateTime date { get; set; }
        public int selectedItem { get; set; }
    }
}