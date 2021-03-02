using CruiseLinePassenger.Controllers;
using DAL.Repository;
using Moq;
using Newtonsoft.Json;
using NSubstitute;
using System.Collections.Generic;
using System.IO;
using System.Web.Http.Results;
using Xunit;

namespace Cruiselinepassengertest
{
    public class passengertest
    {
        private readonly Mock<ICruiseRepo> mocktempobj = new Mock<ICruiseRepo>();
        private readonly CruisePassengerController _passenger;
        public passengertest()
        {
            //Arrange
            _passenger = new CruisePassengerController(mocktempobj.Object);
            
        }
        [Fact]
        public void Test()
        {
            var result = mocktempobj.Setup(x => x.GetCruisePassengersList()).Returns(User());
            //Act
            var response = _passenger.Get();

            // Assert
            Assert.Equal("3", response.ToString());

        }
        private static List<Model.CruisePassengermodel> User()
        {
            List<Model.CruisePassengermodel> passengers = new List<Model.CruisePassengermodel>
            {
                new Model.CruisePassengermodel(){Id=1,FirstName="abc",LastName="abc",Phone="123456789"},
                 new Model.CruisePassengermodel(){Id=2,FirstName="abc",LastName="abc",Phone="123456789"},
                  new Model.CruisePassengermodel(){Id=3,FirstName="abc",LastName="abc",Phone="123456789"}
            };
            return passengers;
        }
        [Fact]
        public void Delete_passenger()
        {
            var user = new Model.CruisePassengermodel();
            user.Id = 1;
            //Arrange
            var resultobj = mocktempobj.Setup(x => x.DeletePassenger(user.Id)).Returns(true.ToString());
            //Act
            var response = _passenger.Delete(user.Id);
            // Assert
            Assert.True(response);
        }
        [Fact]
        public void test_getuserbyid()
        {
            //Arrange
            var user = new Model.CruisePassengermodel();
            user.Id = 1;
            user.FirstName = "mukesh";
            user.LastName = "abc";
            user.Phone = "12456";
            //Act
            var responseobj = mocktempobj.Setup(x => x.GetCruisePassengerById(user.Id));
            var result = _passenger.Get(user.Id);
            var isNull = Assert.IsType<OkNegotiatedContentResult<Model.CruisePassengermodel>>(result);
            //Assert
            Assert.NotNull(isNull);
        }
        [Fact]
        public void Test_Updateuser()
        {
            var model = JsonConvert.DeserializeObject<Model.CruisePassengermodel>(File.ReadAllText("Data/UpdateUser.json"));
            var result = mocktempobj.Setup(x => x.UpdatePassenger(model)).Returns(model.ToString());
            var response = _passenger.Put(model);
            //Assert
            Assert.Equal((IEnumerable<char>)model,response);
        }
        [Fact]
        public void Test_adduser()
        {
            var newpassenger = new Model.CruisePassengermodel();
            newpassenger.Id = 6;
            newpassenger.FirstName = "sam";
            newpassenger.LastName = "alex";
            newpassenger.Phone = "123456";
            //Act
            var response = mocktempobj.Setup(x => x.CreatePassenger(newpassenger)).Returns(AddUser().ToString());
            var result = _passenger.Post(newpassenger);
            //Assert
            Assert.NotNull(result);
        }

        private static Model.CruisePassengermodel AddUser()
        {
            var newUser = new Model.CruisePassengermodel();
            newUser.Id = 4;
            newUser.FirstName = "Shankar";
            newUser.LastName = "Pandian";
            newUser.Phone = "12345";
            return newUser;
        }


        //FalseTestcase

        [Fact]
        public void Test_Updateuseralse()
        {
            var model = JsonConvert.DeserializeObject<Model.CruisePassengermodel>(File.ReadAllText("Data/Updateuser.json"));
            var result = mocktempobj.Setup(x => x.UpdatePassenger(model)).Returns(model.ToString());
            var response = _passenger.Put(model);
            //Assert
            Assert.NotEqual((IEnumerable<char>)model, response);
        }
        [Fact]
        public void test_getuserbyidfalse()
        {
            //Arrange
            var user = new Model.CruisePassengermodel();
            user.Id = 9;
            user.FirstName = "mukesh";
            user.LastName = "arvind";
            user.Phone = "12456";
            //Act
            var responseobj = mocktempobj.Setup(x => x.GetCruisePassengerById(user.Id));
            var result = _passenger.Get(user.Id);
            var isNull = Assert.IsType<OkNegotiatedContentResult<Model.CruisePassengermodel>>(result);
            //Assert
            Assert.NotNull(isNull);
        }
        [Fact]
        public void GetUser()
        {
            var result = mocktempobj.Setup(x => x.GetCruisePassengersList()).Returns(User());
            //Act
            var response = _passenger.Get();

            // Assert
            Assert.Equal(6, response.ToString());

        }
        
    }
}
