using Microsoft.VisualStudio.TestTools.UnitTesting;
using HalvorsonCredit.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalvorsonCredit.Controllers.Tests
{
    [TestClass()]
    public class AuthenticationControllerTests
    {
        [TestMethod()]
        public void Check_Authentication_Failure()
        {
            JwtAuthenticationManager manager = new JwtAuthenticationManager("FakeKey12341234");

            user user = new user
            {
                username = "testUsername",
                password = "testPassword"
            };

            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }

        [TestMethod()]
        public void bad_input_Check()
        {


            JwtAuthenticationManager manager = new JwtAuthenticationManager("AuthTest12345!@#$%");


            var user = new user
            {
                username = "test1",
            };


            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNull(ret);
        }

        [TestMethod()]
        public void Check_Successful_Response()
        {

            JwtAuthenticationManager manager = new JwtAuthenticationManager("AuthTest12345!@#$%");


            var user = new user
            {
                username = "test1",
                password = "pwd"
            };


            var ret = manager.Authenticate(user.username, user.password);

            Assert.IsNotNull(ret);
        }

        [TestMethod()]
        public void Key_Character_Counter()
        {
                Boolean result = false;

                JwtAuthenticationManager manager = new JwtAuthenticationManager("AuthTest12345!@#$%");
                var user = new user
                {
                    username = "test1",
                    password = "pwd"
                };



                var ret = manager.Authenticate(user.username, user.password);

                if (ret.Length == 195)
                {
                    result = true;
                }

                Assert.IsTrue(result);

        }



   

        [TestMethod()]
        public void format_Test()
        {

            JwtAuthenticationManager manager = new JwtAuthenticationManager("AuthTest12345!@#$%");

            Boolean result = false;

            var user = new user
            {
                username = "test1",
                password = "pwd"
            };


            var ret = manager.Authenticate(user.username, user.password);

            if (ret is string)
            {
                result = true;
            }

            Assert.IsTrue(result);

        }
    }
}