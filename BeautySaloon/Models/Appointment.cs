//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BeautySaloon.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Appointment
    {
        public int ID { get; set; }
        public System.DateTime Date { get; set; }
        public int Apointee_ID { get; set; }
        public int Operation_ID { get; set; }
    }
}
