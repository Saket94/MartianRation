using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace MartianRation.Models
{
    public class PacketRationModel
    {
        public PacketRationModel()
        {
            PacketTypeList = null;
        }
        
        public int PacketId { get; set; }
        [Required(ErrorMessage = "Please select packet type name")]
        [Display(Name = "Packet Type")]

        public int? PacketTypeId { get; set; }

        public string PacketTypeName { get; set; }

        [Display(Name = "Packet Content")]
        public string PacketContent { get; set; }

        [Display(Name = "Calories")]
        [Required (ErrorMessage = "Please enter calories")]
        public decimal? Calories { get; set; }

        [Display(Name = "Expiry Date")]
        [Required(ErrorMessage = "Please enter expiry date")]
        public string ExpiryDate { get; set; }
        
        [Display(Name = "Quantity")]
        [Required(ErrorMessage = "Please enter quantity")]
        public decimal? Quantity { get; set; }

        public SelectList PacketTypeList { get; set; }

        public string PacketTypeCode { get; set; }

        public string QuantityType { get; set; }

        public string CaloriesContent { get; set; }
    }
}