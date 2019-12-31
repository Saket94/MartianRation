using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MartianRation.Code.Repository;
using MartianRation.Data.Edmx;
using MartianRation.Controllers;
using MartianRation.Models;
using System.Web.Mvc;

namespace UnitTestProject1
{
    [TestClass]
    public class MartianRationUnitTest
    {
        private IGenericService<MartianRation.Data.Edmx.PacketRation> _packetRationService = null;
        private IGenericService<PacketType> _packetTypeService = null;

        /// <summary>
        /// Below test case is written to test the initial loading of the view without any error.
        /// </summary>
        [TestMethod]
        public void RationPacket_TestMethod()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            RationController rationController = new RationController(_packetRationService, _packetTypeService);
            // Act
            ViewResult result = rationController.PacketRation() as ViewResult;
            // Assert
            // Assert.AreEqual(result);
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Below test case is written for getting and checking the records returned from GetData() action method of controller class.
        /// </summary>
        [TestMethod]
        public void GetRationData_TestMethod()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            RationController rationController = new RationController(_packetRationService, _packetTypeService);

            // Act
            ActionResult result = rationController.GetData() as ActionResult;
            // Assert
            Assert.IsNotNull(result);
        }

        /// <summary>
        /// Below test case is written for testing the update ration food record functionality for the ration management screen.
        /// </summary>
        [TestMethod]
        public void UpdateRationFoodData_TestMethod()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            RationController rationController = new RationController(_packetRationService, _packetTypeService);

            PacketRationModel model = new PacketRationModel();

            model.Calories = Convert.ToDecimal(2000.00);
            model.ExpiryDate = DateTime.Now.ToString("dd/MM/yyyy");
            model.PacketContent = "Biscuits";
            model.PacketId = 8;
            model.PacketTypeId = 1;
            model.Quantity = null;

            // Act
            JsonResult result = rationController.Save(model) as JsonResult;
            // Assert
            Assert.IsTrue(Convert.ToString(result.Data) == "{ status = True }");
            //Assert.IsNotNull(result);

        }

        /// <summary>
        /// Below test case is written for testing the update ration water record without content functionality for the ration management screen.
        /// </summary>
        [TestMethod]
        public void UpdateRationWaterData_TestMethod()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            RationController rationController = new RationController(_packetRationService, _packetTypeService);
            PacketRationModel model = new PacketRationModel();
            model.PacketId = 9;
            model.PacketTypeId = 2;
            model.Quantity = Convert.ToDecimal(1);

            // Act
            JsonResult result = rationController.Save(model) as JsonResult;
            // Assert
            Assert.IsTrue(Convert.ToString(result.Data) == "{ status = True }");
            //Assert.IsNotNull(result);

        }

        /// <summary>
        /// Below test case is written for testing the update ration water record with content functionality for the ration management screen.
        /// </summary>
        [TestMethod]
        public void UpdateRationWaterWithContentData_TestMethod()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            RationController rationController = new RationController(_packetRationService, _packetTypeService);
            PacketRationModel model = new PacketRationModel();
            model.PacketId = 33;
            model.PacketTypeId = 2;
            model.PacketContent = "Test Water Content";
            model.Quantity = Convert.ToDecimal(2);

            // Act
            JsonResult result = rationController.Save(model) as JsonResult;
            // Assert
            Assert.IsTrue(Convert.ToString(result.Data) == "{ status = True }");
            //Assert.IsNotNull(result);

        }

        /// <summary>
        /// Below test case is written for testing the insert ration food record functionality for the ration management screen.
        /// </summary>
        [TestMethod]
        public void InsertRationFoodData_TestMethod()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            RationController rationController = new RationController(_packetRationService, _packetTypeService);

            PacketRationModel model = new PacketRationModel();

            model.Calories = Convert.ToDecimal(2000.00);
            model.ExpiryDate = DateTime.Now.ToString("dd/MM/yyyy");
            model.PacketContent = "Burger";
            //model.PacketId = 8; this is not needed for Insert record as its auto generated by database.
            model.PacketTypeId = 1;
            model.Quantity = null;

            // Act
            JsonResult result = rationController.Save(model) as JsonResult;
            // Assert
            Assert.IsTrue(Convert.ToString(result.Data) == "{ status = True }");
            //Assert.IsNotNull(result);

        }

        /// <summary>
        /// Below test case is written for testing the insert ration water record without packet content functionality for the ration management screen.
        /// </summary>
        [TestMethod]
        public void InsertRationWaterData_TestMethod()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            RationController rationController = new RationController(_packetRationService, _packetTypeService);
            PacketRationModel model = new PacketRationModel();
            //model.PacketId = 8; this is not needed for Insert record as its auto generated by database.
            model.PacketTypeId = 2;
            model.Quantity = Convert.ToDecimal(2);

            // Act
            JsonResult result = rationController.Save(model) as JsonResult;
            // Assert
            Assert.IsTrue(Convert.ToString(result.Data) == "{ status = True }");
            //Assert.IsNotNull(result);

        }

        /// <summary>
        /// Below test case is written for testing the insert ration water record with packet content functionality for the ration management screen.
        /// </summary>
        [TestMethod]
        public void InsertRationWaterWithContentData_TestMethod()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            RationController rationController = new RationController(_packetRationService, _packetTypeService);
            PacketRationModel model = new PacketRationModel();
            //model.PacketId = 8; this is not needed for Insert record as its auto generated by database.
            model.PacketTypeId = 2;
            model.PacketContent = "Test Water Content";
            model.Quantity = Convert.ToDecimal(2);

            // Act
            JsonResult result = rationController.Save(model) as JsonResult;
            // Assert
            Assert.IsTrue(Convert.ToString(result.Data) == "{ status = True }");
            //Assert.IsNotNull(result);

        }

        /// <summary>
        /// Below test case is written for testing the delete ration record functionality for the ration management screen.
        /// </summary>
        [TestMethod]
        public void DeleteRationData_TestMethod()
        {
            this._packetRationService = new GenericService<PacketRation>();
            this._packetTypeService = new GenericService<PacketType>();

            RationController rationController = new RationController(_packetRationService, _packetTypeService);
            PacketRationModel model = new PacketRationModel();
            model.Calories = null;
            model.ExpiryDate = null;
            model.PacketContent = null;
            model.PacketId = 53; //If Delete Test method throws error that means that id is not present in the database or already deleted.
            model.PacketTypeId = null;
            model.Quantity = null;

            // Act
            JsonResult result = rationController.DeleteRation(model) as JsonResult;
            // Assert
            if (Convert.ToString(result.Data) == "{ status = True }")
            {
                Assert.IsTrue(Convert.ToString(result.Data) == "{ status = True }");
            }
            else
            {
                Assert.IsFalse(Convert.ToString(result.Data) == "{ status = False }");
            }
            //Assert.IsNotNull(result);

        }

    }
}
