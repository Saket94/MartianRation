using MartianRation.Code.Repository;
using MartianRation.Data.Edmx;
using MartianRation.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MartianRation.Controllers
{
    public class RationController : Controller
    {
        // GET: Ration
        //public ActionResult Index()
        //{
        //    return View();
        //}

        private IGenericService<PacketRation> _packetRationService = null;
        private IGenericService<PacketType> _packetTypeService = null;

        /// <summary>
        /// RationController  non-parameterized  Constructor.
        /// it is used to initialize  Generic repository class object.
        /// </summary>
        public RationController()
        {
            this._packetRationService = new GenericService<Data.Edmx.PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();
        }

        /// <summary>
        ///RationController Parameterized Constructor contains Generic class type parameter.       
        /// </summary>
        public RationController(IGenericService<Data.Edmx.PacketRation> packetRationService, IGenericService<PacketType> packetTypeService)
        {
            this._packetRationService = packetRationService;
            this._packetTypeService = packetTypeService;
        }

        /// <summary>
        ///Packet Ration Defualt Action Method
        /// </summary>
        [HttpGet]
        public ActionResult PacketRation()
        {
            return View();
        }

        /// <summary>
        ///  Get Packet Ration from database and view on view page. 
        ///  GetData Action Method calling from Ajax calling.
        ///  This method return PaketRationModel list in the json.
        /// </summary>
        [HttpGet]
        public ActionResult GetData()
        {
            List<PacketRationModel> mdllist = new List<PacketRationModel>();
            try
            {
                var packetrationlist = _packetRationService.GetAll();
                foreach (var item in packetrationlist)
                {
                    PacketRationModel packetrationmodel = new PacketRationModel();
                    packetrationmodel.PacketId = item.PacketId;
                    packetrationmodel.PacketContent = item.PacketContent;
                    packetrationmodel.Quantity = item.Quantity;

                    packetrationmodel.PacketTypeName = item.PacketTypeId == 1 ? "Food" : "Water";
                    packetrationmodel.ExpiryDate = item.ExpiryDate == null ? "-" : item.ExpiryDate.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    packetrationmodel.PacketTypeCode = item.PacketTypeId == 1 ? "F" + item.PacketId : "W" + item.PacketId;
                    packetrationmodel.PacketContent = item.PacketContent == null ? "-" : item.PacketContent;
                    packetrationmodel.QuantityType = item.Quantity == null ? "-" : Convert.ToString(item.Quantity);
                    packetrationmodel.CaloriesContent = item.Calories == null ? "-" : Convert.ToString(item.Calories);
                    packetrationmodel.Calories = item.Calories;

                    mdllist.Add(packetrationmodel);
                }

                mdllist.ToList().OrderBy(x => x.PacketId);

            }
            catch (Exception ex) {
            };
            return Json(new { data = mdllist.ToList() }, JsonRequestBehavior.AllowGet);
        }

        /// <summary>
        /// Save  Action Method used to  Get Packet Ration from database and showing on view page.
        ///  This Action Method used to in both case save and edit functionality.
        ///  In the case of save id parameter value is zero and in case of edit id parameter value is selected paketrationid.
        ///  In case of Save it is return PaketType list by model, in case of edit it is return selected paketration info by model.
        /// </summary>
        [HttpGet]
        public ActionResult Save(int id)
        {
            PacketRationModel packetrationmodel = new PacketRationModel();
            try
            {
                if (id > 0)
                {
                    var result = _packetRationService.GetById(id);
                    if (result != null)
                    {
                        packetrationmodel.PacketId = result.PacketId;
                        packetrationmodel.PacketTypeId = result.PacketTypeId;
                        packetrationmodel.PacketTypeName = result.PacketTypeId == 1 ? "Food" : "Water";
                        packetrationmodel.PacketContent = result.PacketContent;
                        packetrationmodel.Calories = result.Calories;
                        if (result.ExpiryDate != null)
                        {
                            IFormatProvider culture = new CultureInfo("en-US", true);
                            packetrationmodel.ExpiryDate = result.ExpiryDate.Value.ToString("dd/MM/yyyy", culture);
                        }
                        packetrationmodel.Quantity = result.Quantity;
                        var packettypelist = _packetTypeService.GetAll();
                        packetrationmodel.PacketTypeList = new SelectList(packettypelist, "PacketTypeId", "PacketNameType", result.PacketTypeId);
                    }
                }
                else
                {
                    int selectedId = 0;
                    var packettypelist = _packetTypeService.GetAll();
                    packetrationmodel.PacketTypeList = new SelectList(packettypelist, "PacketTypeId", "PacketNameType", selectedId);
                }

            }
            catch (Exception ex)
            {
            }
            return View(packetrationmodel);
        }

        /// <summary>
        /// This Post Action Method used to save Packet Ration info into database 
        /// in the both case adding new record and update edited record.        
        /// </summary>
        [HttpPost]
        public ActionResult Save(PacketRationModel model)
        {
            bool status = false;
            try
            {
                if (model.PacketTypeId != null)
                {
                    if (model.PacketTypeId == 1 && model.ExpiryDate != null)
                    {
                        ModelState.Remove("Quantity");
                    }
                    else if (model.PacketTypeId == 2 && model.ExpiryDate == null)
                    {
                        ModelState.Remove("ExpiryDate");
                        ModelState.Remove("Calories");
                    }
                }

                if (ModelState.IsValid)
                {
                    if (model.PacketId > 0)
                    {
                        //Edit
                        var res = _packetRationService.GetById(model.PacketId);
                        if (res != null)
                        {
                            res.PacketId = model.PacketId;
                            res.PacketContent = model.PacketContent;
                            res.Calories = model.Calories;
                            if (model.ExpiryDate != null && model.ExpiryDate != "")
                            {
                                DateTime dtDate = DateTime.ParseExact(model.ExpiryDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                string strDate = dtDate.ToString("yyyy-MM-dd");
                                res.ExpiryDate = Convert.ToDateTime(strDate);
                            }
                            else
                            {
                                res.ExpiryDate = null;
                            }

                            res.Quantity = model.Quantity;
                            _packetRationService.Update(res);
                        }

                    }
                    else
                    {
                        //Save
                        PacketRation tab = new PacketRation();
                        tab.PacketTypeId = model.PacketTypeId;
                        tab.PacketContent = model.PacketContent;
                        tab.Calories = model.Calories;
                        if (model.ExpiryDate != null && model.ExpiryDate != "")
                        {
                            DateTime dtDate = DateTime.ParseExact(model.ExpiryDate, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                            string strDate = dtDate.ToString("yyyy-MM-dd");
                            tab.ExpiryDate = Convert.ToDateTime(strDate);
                        }

                        tab.Quantity = model.Quantity;

                        _packetRationService.Insert(tab);

                    }
                    _packetRationService.Save();
                    status = true;
                }
            }
            catch (Exception ex)
            {
            }
            return new JsonResult { Data = new { status = status } };
        }

        /// <summary>
        ///  Get Packet Ration selected info from database  for deletion.
        ///  This action method only one parameter integer id by this id get information from database.
        ///  This action method return info in the PacketRationModel and view on the deleting popup.       
        /// </summary>
        [HttpGet]
        public ActionResult Delete(int id)
        {
            PacketRationModel model = new PacketRationModel();
            try
            {
                var res = _packetRationService.GetById(id);
                if (res != null)
                {
                    var packetname = _packetTypeService.GetById(res.PacketTypeId).PacketNameType;
                    model.PacketId = res.PacketId;
                    model.PacketTypeId = res.PacketTypeId;
                    model.PacketTypeName = packetname;
                    model.PacketContent = res.PacketContent;
                    if (res.ExpiryDate != null)
                    {
                        model.ExpiryDate = res.ExpiryDate.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                    }
                    model.Quantity = res.Quantity;
                    model.Calories = res.Calories;
                }

            }
            catch (Exception ex)
            {

            }
            return View(model);
        }
        
        /// <summary>
        /// This post action method used to Delete  PacketRation selected info from database.        
        /// </summary>
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRation(PacketRationModel model)
        {
            var status = false;
            PacketRation tabObj = new Data.Edmx.PacketRation();
            try
            {
                tabObj.PacketId = model.PacketId;
                _packetRationService.Delete(tabObj.PacketId);

                _packetRationService.Save();

                status = true;
            }
            catch (Exception ex)
            {
                status = false;
            }
            return new JsonResult { Data = new { status = status } };
        }
    }
}