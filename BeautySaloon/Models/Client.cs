using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautySaloon.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public bool IsRegularClient  { get; set; }
        public string Fname { get; set; }
        public float ClientPayment { get; set; }
    }
}