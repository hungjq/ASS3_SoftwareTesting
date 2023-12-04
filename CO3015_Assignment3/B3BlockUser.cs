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
            //LV0: MANUAL
/*            TestB301();
            TestB302();
            TestB303();
            TestB304();
*/
            //LV1: DATA DRIVEN
            TestB311();
            TestB312();
            TestB313();
            TestB314();
        }

        private static void RecoverBlockedUser(IWebDriver driver, string targetId = null)
        {
            if (string.IsNullOrEmpty(targetId))
            {
                targetId = TestingHelper.GetCellDataFromExcelFile("B3_data.xlsx", "B3");

                if (string.IsNullOrEmpty(targetId))
                {
                    throw new NullReferenceException("Null Target Id");
                }
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


        //LV0: MANUAL

        // Test case for Block admin
        /// Test case for Block admin
        public void TestB301()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                // Hardcoded values for demonstration, replace with actual values as needed
                var targetId = "13";

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
            var targetId = "47";
            RecoverBlockedUser(driver, targetId);

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
            var targetId = "47"; // Hardcoded value for demonstration
            RecoverBlockedUser(driver, targetId);

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
            string targetId = "47"; 
            RecoverBlockedUser(driver, targetId);

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

        //LV1: DATA DRIVEN

        /// Test case for Block admin
        public void TestB311()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                var targetId = TestingHelper.GetCellDataFromExcelFile("B3_data.xlsx", "B2");

                if (string.IsNullOrEmpty(targetId))
                {
                    throw new NullReferenceException("Null Target Id");
                }

                Console.WriteLine($"Test case {nameof(TestB311)} started");

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

                Console.WriteLine($"Test case {nameof(TestB311)}: PASSED");
                
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB311)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB311)}: FAILED");
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
        public void TestB312()
        {
            IWebDriver driver = new ChromeDriver();
            RecoverBlockedUser(driver);

            try
            {
                Console.WriteLine($"Test case {nameof(TestB312)} started");

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'cancel-confirm')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TestB312)}: PASSED");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB312)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB312)}: FAILED");
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
        public void TestB313()
        {
            IWebDriver driver = new ChromeDriver();
            RecoverBlockedUser(driver);

            try
            {
                Console.WriteLine($"Test case {nameof(TestB313)} started");

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'confirm-block')]")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TestB313)}: PASSED");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB313)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB313)}: FAILED");
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
        public void TestB314()
        {
            IWebDriver driver = new ChromeDriver();
            RecoverBlockedUser(driver);

            try
            {
                Console.WriteLine($"Test case {nameof(TestB314)} started");

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'confirm-block')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TestB314)}: PASSED");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB314)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB314)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }
    }
}
