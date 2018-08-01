using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using TestWebLibrary.PageObjects;

namespace TestWebLibrary.UpsaPO
{
    public class MyProfilePanel : BasePage
    {
        private static readonly By label = By.XPath("//*[@class='page-caption']"); //unique element to check the page
        private readonly BaseElement generalTab = new BaseElement(By.Id("empl-tab-1"));
        private readonly BaseElement skillsTab = new BaseElement(By.Id("empl-tab-2"));
        private readonly BaseElement personalTab = new BaseElement(By.Id("empl-tab-3"));
        private readonly BaseElement pastProjectsTab = new BaseElement(By.XPath(""));
        private readonly BaseElement trainCoursesTab = new BaseElement(By.XPath(""));
        private readonly BaseElement educationTab = new BaseElement(By.XPath(""));
        private readonly BaseElement imrotationTab = new BaseElement(By.XPath(""));
        private readonly BaseElement travelTab = new BaseElement(By.XPath(""));


        protected MyProfilePanel( ) : base(label, "MY PROFILE")
        {

        }





    }
}
