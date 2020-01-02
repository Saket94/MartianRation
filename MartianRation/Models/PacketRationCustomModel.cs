using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MartianRation.Models
{
    public class PacketRationCustomModel
    {
        public int PacketId { get; set; }
        public object PacketTypeId { get; set; }
        public string PacketTypeName { get; set; }
        public string PacketContent { get; set; }
        public double? Calories { get; set; }
        public string ExpiryDate { get; set; }
        public double? Quantity { get; set; }
        public object PacketTypeList { get; set; }
        public string PacketTypeCode { get; set; }
        public string QuantityType { get; set; }
        public string CaloriesContent { get; set; }
    }

    public class PacketRationDataModel
    {
        public List<PacketRationCustomModel> data { get; set; }
    }
}