
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FacebookLoginSel.Pages
{
    class ArticlePage
    {

        IWebDriver driver;
        public ArticlePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div//div[contains(text(),\"What's on your mind, Pratiksha?\")]")]
        public IWebElement WriteSomethingBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='rq0escxv datstx6m k4urcfbm a8c37x1j']//div[@class='_5rp7']//div[@class='_5rpb']//div[@class='notranslate _5rpu']//div//div//div[@class='_1mf _1mj']")]
        public IWebElement EnterSomethingInBox;        
        [FindsBy(How = How.XPath, Using = "//i[@class='hu5pjgll bixrwtb6 sp_oShqasXqSne sx_0d1609']")]
        public IWebElement ChooseFileButton;
        [FindsBy(How = How.XPath, Using = "//div[@class='_3-w4 _3-w6']")]
        public IWebElement NewsFeedBox;
        [FindsBy(How = How.XPath, Using = "//div[@class='oajrlxb2 s1i5eluu qu0x051f esr5mh6w e9989ue4 r7d6kgcz rq0escxv nhd2j8a9 pq6dq46d p7hjln8o kvgmc6g5 cxmmr5t8 oygrvhab hcukyx3x cxgpxx05 d1544ag0 sj5x9vvc tw6a2znq oqcyycmt esuyzwwr f1sip0of lzcic4wl l9j0dhe7 abiwlrkh p8dawk7l ehryuci6 bp9cbjyn beltcj47 p86d2i9g aot14ch1 kzx2olss rt8b4zig n8ej3o3l agehan2d sk4xxmp2 lrazzd5p gigivrx4 sf5mxxl7 g0qnabr5 lrwzeq9o iqfcb0g7 lsqurvkf id6903cd jq4qci2q m5l1wtfr taijpn5t sn7ne77z oqhjfihn bwm1u5wc']")]
        public IWebElement PostButton;
        [FindsBy(How = How.XPath, Using = "//i[@class='hu5pjgll lzf7d6o1 sp_Vau-pnpl2UP sx_edeabd']")]
        public IWebElement DropdownList;
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'Log Out')]")]
        public IWebElement LogoutButton;


        public void UploadThArticle()
        {
            Thread.Sleep(2000);
            WriteSomethingBox.Click();
            Thread.Sleep(3000);
            EnterSomethingInBox.SendKeys("Testing....");
            Thread.Sleep(5000);
            ChooseFileButton.Click();
            Thread.Sleep(3000);
            Process.Start("F:\\AutoITFolder\\image.exe");
            Thread.Sleep(3000);
            //NewsFeedBox.Click();
            //Thread.Sleep(3000);
            PostButton.Click();
            Thread.Sleep(20000);
            DropdownList.Click();
            Thread.Sleep(5000);
            LogoutButton.Click();
          
        }
    }
}
