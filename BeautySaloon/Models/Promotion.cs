using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BeautySaloon.Models
{
    public class Promotion
    {
        private string GeneratePromoCode() {
            var random = new Random();
            string s = string.Empty;
            for(int i = 0; i < 10; i++)
            {
                s = String.Concat(s, random.Next(10).ToString());
            }
            return s;
        }
        public long GenerateDiscount()
        {
            var random = new Random();
            int mynum = random.Next(5, 13);
            

            return 0;
        }

    }
}