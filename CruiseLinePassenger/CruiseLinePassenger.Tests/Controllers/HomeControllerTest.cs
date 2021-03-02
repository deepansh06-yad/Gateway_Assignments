using CruiseLinePassenger;
using CruiseLinePassenger.Controllers;
using DAL.Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;
using Xunit;
using Assert = Xunit.Assert;

namespace CruiseLinePassenger.Tests.Controllers
{
    
    public class HomeControllerTest
    {
        private readonly Mock<ICruiseRepo> mocktempobj = new Mock<ICruiseRepo>();
        private readonly CruisePassengerController _passenger;
        public HomeControllerTest()
        {
            _passenger = new CruisePassengerController((BAL.Interface.ICruiseManager)mocktempobj.Object);
        }
        [Fact]
        public void Test_GetUser()
        {
            // Arrange

            var objresult = mocktempobj.Setup(x => x.GetCruisePassengersList()).Returns((List<Model.CruisePassengermodel>)User());
            // Act
            var response = _passenger.Get();

            // Assert
            Assert.Equal("3", response.ToString());
        }
        private static IHttpActionResult User()
        {
            List<DAL.Database.Passenger> passengers = new List<DAL.Database.Passenger>()
            {
                new DAL.Database.Passenger(){Id=1,FirstName="abc",LastName="abc",Phone="123456789"},
                 new DAL.Database.Passenger(){Id=2,FirstName="abc",LastName="abc",Phone="123456789"},
                  new DAL.Database.Passenger(){Id=3,FirstName="abc",LastName="abc",Phone="123456789"}
            };
            return (IHttpActionResult)passengers;
        }
    }
}
