using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.UpsaPO;
using TestWebLibrary.Utils;

namespace TestWebProject.Test
{
    [TestFixture]
    class UpsaTests : BaseTest
    {
        ProfilePage profilePage = new ProfilePage();
        UpsaLogInPage logInPage = new UpsaLogInPage();


        [SetUp]
        public void SetUp()
        {
            logInPage.FillLoginField(ConfigManager.ConfigLogin);
            logInPage.FillPasswordField(ConfigManager.ConfigPassword);
            profilePage = logInPage.ClickToLogIn();
        }
       
        [Test]
        public void checkLabel()
        {
           Assert.AreEqual("Junior Software Test Automation Engineer", profilePage.GetEmployeeTitle() ); 
        }
    }
}
