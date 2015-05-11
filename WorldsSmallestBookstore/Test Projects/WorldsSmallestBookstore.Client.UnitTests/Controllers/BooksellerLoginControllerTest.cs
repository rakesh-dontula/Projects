﻿using WorldsSmallestBookstore.Client.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using System.Web.Mvc;

namespace WorldsSmallestBookstore.Tests.Controllers
{
    
    
    /// <summary>
    ///This is a test class for BooksellerLoginControllerTest and is intended
    ///to contain all BooksellerLoginControllerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BooksellerLoginControllerTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion
                     
        /// <summary>
        ///A test for Index
        ///</summary>
        // 

        [TestMethod()]
        public void IndexTest()
        {
            
            // Arrange
            BooksellerLoginController target = new BooksellerLoginController(); // TODO: Initialize to an appropriate value


            // Act
            ViewResult result = target.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
   
        }
    }
}
