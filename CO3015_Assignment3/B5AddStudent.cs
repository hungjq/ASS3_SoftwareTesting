using CO3015_Assignment3.Utility;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System;


namespace CO3015_Assignment3
{
    public class B5AddStudent
    {
        public B5AddStudent()
        {
            // Define License Context for EPPlus package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void RunTest()
        {
            TestB501();
        }



        /// Test case for Block admin
        public void TestB501()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                var targetId = TestingHelper.GetCellDataFromExcelFile("B3_data.xlsx", "B2");

                if (string.IsNullOrEmpty(targetId))
                {
                    throw new NullReferenceException("Null Target Id");
                }

                Console.WriteLine($"Test case {nameof(TestB501)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);

                driver.FindElement(By.CssSelector(".card-text")).Click();
                driver.FindElement(By.CssSelector(".multiline")).Click();
                driver.FindElement(By.LinkText("Participants")).Click();
                driver.FindElement(By.CssSelector("#enrolusersbutton-1 .btn")).Click();
                Thread.Sleep(2000);

                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//div[@id=\'fitem_id_userlist\']/div[2]/div[3]/span")).Click();
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//li/span/span")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[contains(.,\'Enrol selected users and cohorts\')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TestB501)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB501)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB501)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

    }
}
