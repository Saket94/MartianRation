using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartianRation.Models
{
    public class PacketRationResult
    {
        public PacketRationResult()
        {
            datalist = new List<PacketRationResult>();
        }
        public int PacketId { get; set; }
        public int? PacketTypeId { get; set; }
        public string PacketTypeName { get; set; }
        public string PacketContent { get; set; }
        public string Calories { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string strExpiryDate { get; set; }
        public string Quantity { get; set; }
        public DateTime? ScheduleDate { get; set; }
        public string strScheduleDate { get; set; }
        //public string StartDate { get; set; }
        public string QuantityText { get; set; }
        public List<PacketRationResult> datalist { get; set; }
        public int ScheduleCount { get; set; }
    }
}