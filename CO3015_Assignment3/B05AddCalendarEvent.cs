using CO3015_Assignment3.Utility;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CO3015_Assignment3
{
    public class B05AddCalendarEvent
    {
        public B05AddCalendarEvent()
        {
            // Define License Context for EPPlus package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void RunTest()
        {
            TcB0501();
            TcB0502();
            TcB0503();
        }

        public void TcB0501()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            try
            {
                Console.WriteLine($"Test case {nameof(TcB0501)} started");

                TestingHelper.Login(driver);

                // expected to be empty
                var eventName = TestingHelper.GetCellDataFromExcelFile("B05_data.xlsx", "B2");

                driver.Navigate().GoToUrl("https://softtesting.gnomio.com/calendar/view.php?view=month");
                Thread.Sleep(1000);

                driver.FindElement(By.XPath("//button[@data-action='new-event-button']")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Name("name")).SendKeys(eventName);
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'save')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TcB0501)} executed successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcB0501)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcB0501)} failed");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        public void TcB0502()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TcB0502)} started");

                TestingHelper.Login(driver);

                // name data
                var eventName = TestingHelper.GetCellDataFromExcelFile("B05_data.xlsx", "B3");
                var day = TestingHelper.GetCellDataFromExcelFile("B05_data.xlsx", "C3");
                var month = TestingHelper.GetCellDataFromExcelFile("B05_data.xlsx", "D3");
                var year = TestingHelper.GetCellDataFromExcelFile("B05_data.xlsx", "E3");

                driver.Navigate().GoToUrl("https://softtesting.gnomio.com/calendar/view.php?view=month");
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[@data-action='new-event-button']")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Name("name")).SendKeys(eventName);
                Thread.Sleep(2000);

                var yearSelectElement = new SelectElement(driver.FindElement(By.Name("timestart[year]")));
                yearSelectElement.SelectByText(year);

                var monthSelectElement = new SelectElement(driver.FindElement(By.Name("timestart[month]")));
                monthSelectElement.SelectByText(month);

                var daySelectElement = new SelectElement(driver.FindElement(By.Name("timestart[day]")));
                daySelectElement.SelectByText(day);

                Console.WriteLine($"Test case {nameof(TcB0502)} executed successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcB0502)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcB0502)} failed");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        public void TcB0503()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TcB0503)} started");

                TestingHelper.Login(driver);

                // name data
                var eventName = TestingHelper.GetCellDataFromExcelFile("B05_data.xlsx", "B4");
                var day = TestingHelper.GetCellDataFromExcelFile("B05_data.xlsx", "C4");
                var month = TestingHelper.GetCellDataFromExcelFile("B05_data.xlsx", "D4");
                var year = TestingHelper.GetCellDataFromExcelFile("B05_data.xlsx", "E4");

                driver.Navigate().GoToUrl("https://softtesting.gnomio.com/calendar/view.php?view=month");
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//button[@data-action='new-event-button']")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Name("name")).SendKeys(eventName);
                Thread.Sleep(2000);

                var yearSelectElement = new SelectElement(driver.FindElement(By.Name("timestart[year]")));
                yearSelectElement.SelectByText(year);

                var monthSelectElement = new SelectElement(driver.FindElement(By.Name("timestart[month]")));
                monthSelectElement.SelectByText(month);

                var daySelectElement = new SelectElement(driver.FindElement(By.Name("timestart[day]")));
                daySelectElement.SelectByText(day);

                driver.FindElement(By.XPath("//button[contains(@data-action, 'save')]")).Click();
                Thread.Sleep(2000);

                Console.WriteLine($"Test case {nameof(TcB0503)} executed successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcB0503)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcB0503)} failed");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }
    }
}
