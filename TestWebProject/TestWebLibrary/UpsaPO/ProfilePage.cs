using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestWebLibrary.PageObjects;

namespace TestWebLibrary.UpsaPO
{
    public class ProfilePage : BasePage
    {

        private static readonly By label  = By.ClassName("profile-card-row employee-name"); //unique element to check the page
        private readonly BaseElement employeetitle = new BaseElement(By.ClassName("profile-card-row employee-title"));
        private readonly BaseElement editProfile = new BaseElement(By.ClassName("class='profile-card-row employee-title"));
        public ProfilePage() : base(label, "Alina Apet")
        { 
        }

        public string GetEmployeeTitle()
        {
            employeetitle.WaitForElementIsVisible();
            return employeetitle.GetText();
        }
    }
}
