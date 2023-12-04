using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CO3015_Assignment3
{
    public class A02OrderAction
    {
        public void RunTest()
        {
            TcA0201();
            TcA0202();
            TcA0203();
            TcA0204();
        }

        public void TcA0201()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0201)} started");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/order_update.php?form_id=43");
                Thread.Sleep(2000);
                

                IWebElement submitEle = driver.FindElement(By.Name("Submit2"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0201)} ended");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0201)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0201)} failed");
            }
            Console.WriteLine("==========================================================");
        }

        public void TcA0202()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0202)} started");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/order_update.php?form_id=43");
                Thread.Sleep(2000);

                IWebElement submitEle = driver.FindElement(By.Name("update"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0202)} ended");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0202)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0202)} failed");
            }
            Console.WriteLine("==========================================================");
        }

        public void TcA0203()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0203)} started");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/order_update.php?form_id=43");
                Thread.Sleep(2000);

                var selectEle = new SelectElement(driver.FindElement(By.Name("status")));
                selectEle.SelectByText("Closed");

                IWebElement submitEle = driver.FindElement(By.Name("update"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0203)} ended");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0203)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0203)} failed");
            }
            Console.WriteLine("==========================================================");
        }

        public void TcA0204()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0204)} started");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/order_update.php?form_id=43");
                Thread.Sleep(2000);

                var selectEle = new SelectElement(driver.FindElement(By.Name("status")));
                selectEle.SelectByText("Closed");

                IWebElement ele = driver.FindElement(By.Name("remark"));
                ele.SendKeys("This order is closed, thank you");
                Thread.Sleep(2000);

                IWebElement submitEle = driver.FindElement(By.Name("update"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.SwitchTo().Alert().Accept();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0204)} ended");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0204)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0204)} failed");
            }
            Console.WriteLine("==========================================================");
        }
    }
}
