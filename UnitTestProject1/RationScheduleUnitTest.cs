using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MartianRation.Code.Repository;
using MartianRation.Data.Edmx;
using MartianRation.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class RationScheduleUnitTest
    {
        private IGenericService<MartianRation.Data.Edmx.PacketRation> _rationScheduleService = null;
        private IGenericService<PacketType> _packetTypeService = null;

        /// <summary>
        /// Below test case is written to test the initial loading of the scheduled view without any error.
        /// </summary>
        [TestMethod]
        public void ViewScheduleIndexTestMethod()
        {

            this._rationScheduleService = new GenericService<MartianRation.Data.Edmx.PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            ViewScheduleController viewScheduleController = new ViewScheduleController(_rationScheduleService, _packetTypeService);
            // Act
            ViewResult result = viewScheduleController.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Below test case is written for testing the View Scheduled data for ration inventory.
        /// </summary>
        [TestMethod]
        public void ViewScheduleTestMethod()
        {

            this._rationScheduleService = new GenericService<MartianRation.Data.Edmx.PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            ViewScheduleController viewScheduleController = new ViewScheduleController(_rationScheduleService, _packetTypeService);
            // Act
            ViewResult result = viewScheduleController.Index("25/12/2019") as ViewResult;
            // Assert
            Assert.IsNotNull(result.Model);
        }

        /// <summary>
        /// Below test case is written for testing the View Scheduled data when we pass scheduled date as empty for ration inventory.
        /// </summary>
        [TestMethod]
        public void ViewScheduleTestEmptyMethod()
        {

            this._rationScheduleService = new GenericService<MartianRation.Data.Edmx.PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            ViewScheduleController viewScheduleController = new ViewScheduleController(_rationScheduleService, _packetTypeService);
            // Act
            string StrDate = "";
            ViewResult result = viewScheduleController.Index(StrDate) as ViewResult;
            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// Below test case is written for testing the View Scheduled data for multiple scheduled date as empty for ration inventory.
        /// </summary>
        [TestMethod]
        public void ViewScheduleTestListMethod()
        {
            this._rationScheduleService = new GenericService<MartianRation.Data.Edmx.PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            ViewScheduleController viewScheduleController = new ViewScheduleController(_rationScheduleService, _packetTypeService);
            // Act
            List<string> lstDate = new List<string>();
            lstDate.Add("25/12/2019");
            lstDate.Add("26/12/2019");
            lstDate.Add("27/12/2019");

            foreach(var item in lstDate)
            {
                ViewResult result = viewScheduleController.Index(item) as ViewResult;
                // Assert
                Assert.IsNotNull(result.Model);
            }
        }
    }
}
