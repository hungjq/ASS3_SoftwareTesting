using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CO3015_Assignment3
{
    public class A01AddMenu
    {
        public void RunTest()
        {
            TcA0101();
            TcA0102();
            TcA0103();
            TcA0104();
            TcA0105();
            TcA0106();
            TcA0107();
            TcA0108();
            TcA0109();
        }

        /// <summary>
        /// Add a new menu without "Name"
        /// </summary>
        public void TcA0101()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0101)} started");

                //create the reference for the browser  
                IWebDriver driver = new ChromeDriver();

                // navigate to URL
                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/add_menu.php");
                Thread.Sleep(2000);

                //identify the google search button  
                IWebElement submitEle = driver.FindElement(By.Name("submit"));

                // click on the Google search button  
                submitEle.Click();
                Thread.Sleep(3000);

                //close the browser  
                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0101)} ended");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0101)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0101)} failed");
            }
            Console.WriteLine("==========================================================");
        }


        /// <summary>
        /// Add a new menu without "About"
        /// </summary>
        public void TcA0102()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0102)} started");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/add_menu.php");
                Thread.Sleep(2000);

                IWebElement ele = driver.FindElement(By.Name("d_name"));
                ele.SendKeys("Chinese food");
                Thread.Sleep(2000);

                IWebElement submitEle = driver.FindElement(By.Name("submit"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0102)} ended");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0102)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0102)} failed");
            }
            Console.WriteLine("==========================================================");
        }

        /// <summary>
        /// Add a new menu without "Price"
        /// </summary>
        public void TcA0103()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0103)} started");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/add_menu.php");
                Thread.Sleep(2000);

                IWebElement nameEle = driver.FindElement(By.Name("d_name"));
                nameEle.SendKeys("Chinese food");
                Thread.Sleep(2000);

                IWebElement aboutEle = driver.FindElement(By.Name("about"));
                aboutEle.SendKeys("It's definitely a chinese dish");
                Thread.Sleep(2000);

                IWebElement submitEle = driver.FindElement(By.Name("submit"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0103)} ended");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0103)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0103)} failed");
            }
            Console.WriteLine("==========================================================");
        }

        /// <summary>
        /// Add a new menu with invalid "Price"
        /// </summary>
        public void TcA0104()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0104)} started");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/add_menu.php");
                Thread.Sleep(2000);

                IWebElement nameEle = driver.FindElement(By.Name("d_name"));
                nameEle.SendKeys("Chinese food");
                Thread.Sleep(2000);

                IWebElement aboutEle = driver.FindElement(By.Name("about"));
                aboutEle.SendKeys("It's definitely a chinese dish");
                Thread.Sleep(2000);

                IWebElement priceEle = driver.FindElement(By.Name("price"));
                priceEle.SendKeys("-50");
                Thread.Sleep(2000);

                IWebElement submitEle = driver.FindElement(By.Name("submit"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0104)} ended");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0104)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0104)} failed");
            }
            Console.WriteLine("==========================================================");
        }

        /// <summary>
        /// Add a new menu with empty "Image"
        /// </summary>
        public void TcA0105()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0105)} started\n");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/add_menu.php");
                Thread.Sleep(2000);

                IWebElement nameEle = driver.FindElement(By.Name("d_name"));
                nameEle.SendKeys("Chinese food");
                Thread.Sleep(2000);

                IWebElement aboutEle = driver.FindElement(By.Name("about"));
                aboutEle.SendKeys("It's definitely a chinese dish");
                Thread.Sleep(2000);

                IWebElement priceEle = driver.FindElement(By.Name("price"));
                priceEle.SendKeys("50");
                Thread.Sleep(2000);

                IWebElement submitEle = driver.FindElement(By.Name("submit"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0105)} ended\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0105)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0105)} failed");
            }
            Console.WriteLine("==========================================================\n");

        }

        /// <summary>
        /// Add a new menu with an invalid image format
        /// </summary>
        public void TcA0106()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0106)} started\n");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/add_menu.php");
                Thread.Sleep(2000);

                IWebElement nameEle = driver.FindElement(By.Name("d_name"));
                nameEle.SendKeys("Chinese food");
                Thread.Sleep(2000);

                IWebElement aboutEle = driver.FindElement(By.Name("about"));
                aboutEle.SendKeys("It's definitely a chinese dish");
                Thread.Sleep(2000);

                IWebElement priceEle = driver.FindElement(By.Name("price"));
                priceEle.SendKeys("50");
                Thread.Sleep(2000);

                IWebElement imageEle = driver.FindElement(By.Name("file"));

                var projectDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;

                if (projectDir != null)
                {
                    var parentFullName = Path.Combine(projectDir, "resource\\invalid_file.exe");
                    imageEle.SendKeys(parentFullName);
                }
                else
                {
                    throw new FileNotFoundException();
                }

                Thread.Sleep(2000);

                IWebElement submitEle = driver.FindElement(By.Name("submit"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0106)} ended\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0106)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0106)} failed");
            }
            Console.WriteLine("==========================================================\n");
        }

        /// <summary>
        /// Add a new menu with an image that exceeds the limit size
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        public void TcA0107()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0107)} started\n");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/add_menu.php");
                Thread.Sleep(2000);

                IWebElement nameEle = driver.FindElement(By.Name("d_name"));
                nameEle.SendKeys("Chinese food");
                Thread.Sleep(2000);

                IWebElement aboutEle = driver.FindElement(By.Name("about"));
                aboutEle.SendKeys("It's definitely a chinese dish");
                Thread.Sleep(2000);

                IWebElement priceEle = driver.FindElement(By.Name("price"));
                priceEle.SendKeys("50");
                Thread.Sleep(2000);

                IWebElement imageEle = driver.FindElement(By.Name("file"));

                var projectDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;

                if (projectDir != null)
                {
                    var parentFullName = Path.Combine(projectDir, "resource\\exceed_limit_image.png");
                    imageEle.SendKeys(parentFullName);
                }
                else
                {
                    throw new FileNotFoundException();
                }

                Thread.Sleep(2000);

                IWebElement submitEle = driver.FindElement(By.Name("submit"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0107)} ended\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0107)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0107)} failed");
            }
            Console.WriteLine("==========================================================\n");
        }

        /// <summary>
        /// Add a new menu without "Category"
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        public void TcA0108()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0108)} started\n");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/add_menu.php");
                Thread.Sleep(2000);

                IWebElement nameEle = driver.FindElement(By.Name("d_name"));
                nameEle.SendKeys("Chinese food");
                Thread.Sleep(2000);

                IWebElement aboutEle = driver.FindElement(By.Name("about"));
                aboutEle.SendKeys("It's definitely a chinese dish");
                Thread.Sleep(2000);

                IWebElement priceEle = driver.FindElement(By.Name("price"));
                priceEle.SendKeys("50");
                Thread.Sleep(2000);

                IWebElement imageEle = driver.FindElement(By.Name("file"));

                var projectDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;

                if (projectDir != null)
                {
                    var parentFullName = Path.Combine(projectDir, "resource\\valid_image.jpg");
                    imageEle.SendKeys(parentFullName);
                }
                else
                {
                    throw new FileNotFoundException();
                }

                Thread.Sleep(2000);

                IWebElement submitEle = driver.FindElement(By.Name("submit"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0108)} ended\n");
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0108)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0108)} failed");
            }
            Console.WriteLine("==========================================================\n");
        }

        /// <summary>
        /// Add a new menu successfully
        /// </summary>
        /// <exception cref="FileNotFoundException"></exception>
        public void TcA0109()
        {
            try
            {
                Console.WriteLine($"Test case {nameof(TcA0109)} started\n");
                IWebDriver driver = new ChromeDriver();

                driver.Navigate().GoToUrl("http://localhost/online-food-ordering-system-in-php/admin/add_menu.php");
                Thread.Sleep(2000);

                IWebElement nameEle = driver.FindElement(By.Name("d_name"));
                nameEle.SendKeys("Chinese food");
                Thread.Sleep(2000);

                IWebElement aboutEle = driver.FindElement(By.Name("about"));
                aboutEle.SendKeys("It's definitely a chinese dish");
                Thread.Sleep(2000);

                IWebElement priceEle = driver.FindElement(By.Name("price"));
                priceEle.SendKeys("50");
                Thread.Sleep(2000);

                IWebElement imageEle = driver.FindElement(By.Name("file"));

                var projectDir = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;

                if (projectDir != null)
                {
                    var parentFullName = Path.Combine(projectDir, "resource\\valid_image.jpg");
                    imageEle.SendKeys(parentFullName);
                }
                else
                {
                    throw new FileNotFoundException();
                }

                Thread.Sleep(2000);

                var selectEle = new SelectElement(driver.FindElement(By.Name("res_name")));
                selectEle.SelectByText("Hari Burger");

                IWebElement submitEle = driver.FindElement(By.Name("submit"));
                submitEle.Click();
                Thread.Sleep(3000);

                driver.Close();
                Console.WriteLine($"Test case {nameof(TcA0109)} ended\n");

                driver.FindElement(By.LinkText("Lương Duy Hưng"));
            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TcA0109)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TcA0109)} failed");
            }
            Console.WriteLine("==========================================================\n");
        }
    }
}
