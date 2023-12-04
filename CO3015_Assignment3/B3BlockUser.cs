using CO3015_Assignment3.Utility;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CO3015_Assignment3
{
    public class B3BlockUser
    {
        public B3BlockUser()
        {
            // Define License Context for EPPlus package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void RunTest()
        {
            TestB301();
            TestB302();
            TestB303();
            TestB304();
        }

        private static void RecoverBlockedUser(IWebDriver driver)
        {
            var targetId = TestingHelper.GetCellDataFromExcelFile("B3_data.xlsx", "B3");

            if (string.IsNullOrEmpty(targetId))
            {
                throw new NullReferenceException("Null Target Id");
            }

            TestingHelper.Login(driver);

            Console.WriteLine("Restoration started");

            driver.FindElement(By.XPath("//a[contains(@id, 'message-drawer-toggle')]")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//button[contains(@aria-controls, 'view-overview-messages-target')]"))
                .Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath($"//a[@data-user-id='{targetId}']")).Click();
            Thread.Sleep(2000);

            var requestUnblockBtnElement = driver.FindElement(By.XPath("//button[contains(@data-action, 'request-unblock')]"));

            if (requestUnblockBtnElement.Displayed)
            {
                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("//a[contains(@data-action, 'request-unblock')]")).Click();
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Not need to restore");
                return;
            }

            driver.FindElement(By.XPath("//button[contains(@data-action, 'confirm-unblock')]")).Click();
            Thread.Sleep(2000);

            Console.WriteLine("Restoration finished");
        }


        /// Test case for Block admin
        public void TestB301()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                var targetId = TestingHelper.GetCellDataFromExcelFile("B3_data.xlsx", "B2");

                if (string.IsNullOrEmpty(targetId))
                {
                    throw new NullReferenceException("Null Target Id");
                }

                Console.WriteLine($"Test case {nameof(TestB301)} started");

                TestingHelper.Login(driver);

                driver.FindElement(By.XPath("//a[contains(@id, 'message-drawer-toggle')]")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@aria-controls, 'view-overview-messages-target')]"))
                    .Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath($"//a[contains(@data-user-id, '{targetId}')]")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'okay-confirm')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TestB301)}: PASSED");
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB301)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB301)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        /// <summary>
        /// Test case for Cancel blocking
        /// </summary>
        public void TestB302()
        {
            IWebDriver driver = new ChromeDriver();
            RecoverBlockedUser(driver);

            try
            {
                Console.WriteLine($"Test case {nameof(TestB302)} started");

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'cancel-confirm')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TestB302)}: PASSED");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB302)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB302)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        /// <summary>
        /// Test case for Attempt to block a blocked user
        /// </summary>
        public void TestB303()
        {
            IWebDriver driver = new ChromeDriver();
            RecoverBlockedUser(driver);

            try
            {
                Console.WriteLine($"Test case {nameof(TestB303)} started");

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'confirm-block')]")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TestB303)}: PASSED");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB303)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB303)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        /// <summary>
        /// Test case for Block user successfully
        /// </summary>
        public void TestB304()
        {
            IWebDriver driver = new ChromeDriver();
            RecoverBlockedUser(driver);

            try
            {
                Console.WriteLine($"Test case {nameof(TestB304)} started");

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'confirm-block')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TestB304)}: PASSED");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB304)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB304)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }
    }
}
