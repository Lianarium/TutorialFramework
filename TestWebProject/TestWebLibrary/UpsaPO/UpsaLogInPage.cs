using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestWebLibrary.PageObjects;

namespace TestWebLibrary.UpsaPO
{
    public class UpsaLogInPage : BasePage
    {
        private static readonly By login = By.ClassName("modernButton");
        private readonly BaseElement loginfield = new BaseElement(By.Name("login"));
        private readonly BaseElement passwordfield = new BaseElement(By.Name("password"));
        private readonly BaseElement loginbutton = new BaseElement(By.ClassName("modernButton"));
        public UpsaLogInPage( ) : base(login , "LOGIN")
        {

           
        }

        public UpsaLogInPage FillLoginField(string loginkey)
        {
            this.loginfield.WaitForElementIsVisible();
            this.loginfield.Click();
            this.loginfield.SendKeys(loginkey);
            return new UpsaLogInPage();
        }

        public UpsaLogInPage FillPasswordField(string passwordkey)
        {
            this.passwordfield.WaitForElementIsVisible();
            this.passwordfield.Click();
            this.passwordfield.SendKeys(passwordkey);
            return new UpsaLogInPage();
        }

        public ProfilePage ClickToLogIn()
        {
            this.loginbutton.WaitForElementIsVisible();
            this.loginbutton.Click();
            return new ProfilePage();
        }

    }
}
