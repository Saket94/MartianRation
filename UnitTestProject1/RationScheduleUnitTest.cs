using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MartianRation.Code.Repository;
using MartianRation.Data.Edmx;
using MartianRation.Controllers;
using System.Web.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace UnitTestProject1
{
    [TestClass]
    public class RationScheduleUnitTest
    {
        private IGenericService<MartianRation.Data.Edmx.PacketRation> _rationScheduleService = null;
        private IGenericService<PacketType> _packetTypeService = null;

        private TestContext testContextInstance;
        public TestContext TestContext
        {
            get { return testContextInstance; }
            set { testContextInstance = value; }
        }

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
        /// Below is data-driven test case is written for testing the View Scheduled data for multiple scheduled date and empty date for ration view schedules.
        /// </summary>
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", @"|DataDirectory|\TestCasesData\ViewSchedule.xml", "Test_ScheduleDate", DataAccessMethod.Sequential)]
        public void ViewScheduleTestListMethod()
        {
            this._rationScheduleService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            string chkScheduleDate = Convert.ToString(TestContext.DataRow["ScheduleDate"]);
            
            ViewScheduleController viewScheduleController = new ViewScheduleController(_rationScheduleService, _packetTypeService);
            // Act
            ViewResult result = viewScheduleController.Index(chkScheduleDate) as ViewResult;
            // Assert
            if (chkScheduleDate != "")
            {
                Assert.IsNotNull(result.Model);
            }
            else
            {
                Assert.IsNull(result);
            }
        }
    }
}
