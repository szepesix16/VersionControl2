using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample
{
    public class AccountControllerTestFixture
    {
        [Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)
        ]
        public void TestValidateEmail(string email, bool expectedResult)
        {

            var accountController = new AccountController();

            var actualResult = accountController.ValidateEmail(email);

            Assert.AreEqual(expectedResult, actualResult);

        }

        [Test,
            TestCase("abcdefgh", false),
            TestCase("A1S2D3F4", false),
            TestCase("a1s2d3f4", false),
            TestCase("A4", false),
            TestCase("A1B2c3d4", true)
        ]
        public void TestValidatePassWord(string password, bool expectedResult)
        {

            var accountController = new AccountController();

            var actualResult = accountController.ValidatePassWord(password);

            Assert.AreEqual(expectedResult, actualResult);


        }


    }
}
