﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;


namespace TAdotNET.Tests
{
    [TestClass]
    public class Test3 : BaseTest
    {
        [TestMethod]
        public void TestMethod3()
        {

            GetHomePage().GoTo("News");
            GetHomePage().ClickOnLaterButton();
            string firstArticleName = GetNewsPage().GetFirstArticleName();
            GetNewsPage().ClickOnSearchField();
            GetNewsPage().InputFirstArticleName();
            GetNewsPage().SearchFieldEnter();

            Assert.AreEqual(firstArticleName, GetSearchPage().SearchedArticleName());
        }
    }
}
