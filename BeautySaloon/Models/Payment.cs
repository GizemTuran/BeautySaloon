using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautySaloon.Models
{
    public class Payment
    {
        public int PaymentRecords { get; set; }
        public int PaymentCash { get; set; }
        public int PaymentCredit { get; set; }
    }
}