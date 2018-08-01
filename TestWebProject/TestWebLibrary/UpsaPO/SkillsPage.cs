using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestWebLibrary.PageObjects;

namespace TestWebLibrary.UpsaPO
{
    public class SkillsPage:BasePage
    {
        private static readonly By label = By.ClassName("btn-empl-tab-2"); //unique element to check the page
        
        public SkillsPage() : base(label, "EDIT MY SKILLS")
        {
        }
    }
}
