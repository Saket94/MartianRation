﻿using MartianRation.Code.Repository;
using MartianRation.Data.Edmx;
using MartianRation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MartianRation.Controllers
{
    public class ViewScheduleController : Controller
    {
        private MartianRationDBEntities _context = new MartianRationDBEntities();
        private IGenericService<PacketRation> _packetRationService = null;
        private IGenericService<PacketType> _packetTypeService = null;

        /// <summary>
        ///ViewScheduleController non-parameterized Constructor       
        /// it is used to initialize  Generic repository class object.
        /// </summary>
        public ViewScheduleController()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();
        }

        /// <summary>
        ///ViewScheduleController Parameterized Constructor pass two generic class type parameters.        
        /// </summary>
        public ViewScheduleController(IGenericService<PacketRation> packetRationService, IGenericService<PacketType> packetTypeService)
        {
            this._packetRationService = packetRationService;
            this._packetTypeService = packetTypeService;
        }

        /// <summary>
        ///Get action method to showing ViewScheduler page.
        /// </summary>
        [HttpGet]
        public ActionResult Index()
        {
            PacketRationResult model = new PacketRationResult();
            return View(model);
        }

        /// <summary>
        ///Post action method to showing Scheduler records on  ViewScheduler page.
        ///In this method pass one parameter selected date as string.
        ///
        /// </summary>
        [HttpPost]
        public ActionResult Index(string selectedDate)
        {
            if(string.IsNullOrEmpty(selectedDate))
            {
                return RedirectToAction("Index");
            }
            DateTime startDate = DateTime.ParseExact(selectedDate, "dd/MM/yyyy", null);
            PacketRationResult model = new PacketRationResult();
            try
            {
                var result = _context.getViewSchedule(startDate).OrderBy(x => x.ScheduleDate).ToList();
                var chkcount = result.GroupBy(x => x.ScheduleDate).Select(x => x.First()).ToList().Count();

                if(result.Count > 0)
                {
                    model.ScheduleCount = chkcount;

                    foreach (var item in result)
                    {
                        int PacketTypeId = Convert.ToInt32(item.PacketTypeId);
                        PacketRationResult packetRation = new PacketRationResult();
                        packetRation.PacketId = item.PacketId;
                        packetRation.PacketTypeId = item.PacketTypeId;
                        packetRation.PacketTypeName = _packetTypeService.GetById(PacketTypeId).PacketNameType;
                        packetRation.PacketContent = item.PacketContent != null ? item.PacketContent : "-";
                        packetRation.Calories = item.Calories;
                        packetRation.ExpiryDate = item.ExpiryDate != null ? item.ExpiryDate : null;
                        packetRation.StrExpiryDate = item.ExpiryDate == null ? "-" : Convert.ToDateTime(item.ExpiryDate.ToString()).ToString("dd/MM/yyyy");
                        packetRation.Quantity = item.Quantity;
                        packetRation.StrScheduleDate = Convert.ToDateTime(item.ScheduleDate.ToString()).ToString("dd/MM/yyyy");
                        packetRation.QuantityText = item.QuantityText;

                        model.datalist.Add(packetRation);
                    }
                }                            
            }
            catch (Exception ex)
            {
            }
            return View(model);
        }
    }
}