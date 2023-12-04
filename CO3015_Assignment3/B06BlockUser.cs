using CO3015_Assignment3.Utility;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CO3015_Assignment3
{
    public class B06BlockUser
    {
        public B06BlockUser()
        {
            // Define License Context for EPPlus package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void RunTest()
        {
            TcB0601();
            TcB0602();
            TcB0603();
            TcB0604();
        }

        private static void RecoverBlockedUser(IWebDriver driver)
        {
            var targetId = TestingHelper.GetCellDataFromExcelFile("B06_data.xlsx", "B3");

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

        /// <summary>
        /// Test case for Block admin
        /// </summary>
        public void TcB0601()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                var targetId = TestingHelper.GetCellDataFromExcelFile("B06_data.xlsx", "B2");

                if (string.IsNullOrEmpty(targetId))
                {
                    throw new NullReferenceException("Null Target Id");
                }

                Console.WriteLine($"Test case {nameof(TcB0601)} started");

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

                Console.WriteLine($"Test case {nameof(TcB0601)} executed successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcB0601)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcB0601)} failed");
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
        public void TcB0602()
        {
            IWebDriver driver = new ChromeDriver();
            RecoverBlockedUser(driver);

            try
            {
                Console.WriteLine($"Test case {nameof(TcB0602)} started");

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'cancel-confirm')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TcB0602)} executed successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcB0602)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcB0602)} failed");
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
        public void TcB0603()
        {
            IWebDriver driver = new ChromeDriver();
            RecoverBlockedUser(driver);

            try
            {
                Console.WriteLine($"Test case {nameof(TcB0603)} started");

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'confirm-block')]")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TcB0603)} executed successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcB0603)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcB0603)} failed");
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
        public void TcB0604()
        {
            IWebDriver driver = new ChromeDriver();
            RecoverBlockedUser(driver);

            try
            {
                Console.WriteLine($"Test case {nameof(TcB0604)} started");

                driver.FindElement(By.Id("conversation-actions-menu-button")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.LinkText("Block user")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'confirm-block')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TcB0604)} executed successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcB0604)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcB0604)} failed");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }
    }
}
