using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MartianRation.Code.Repository;
using MartianRation.Data.Edmx;
using MartianRation.Controllers;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class RationScheduleUnitTest
    {
        private IGenericService<MartianRation.Data.Edmx.PacketRation> _rationScheduleService = null;
        private IGenericService<PacketType> _packetTypeService = null;


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

    }
}
