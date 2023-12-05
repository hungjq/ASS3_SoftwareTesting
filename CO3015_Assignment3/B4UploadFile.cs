using CO3015_Assignment3.Utility;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace CO3015_Assignment3
{
    public class B4UploadFile
    {
        public B4UploadFile()
        {
            // Define License Context for EPPlus package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void RunTest()
        {
            //LV0
            /*            TestB401();
                        TestB402();
                        TestB403();
                        TestB404();
                        TestB405();*/

            //LV1
            TestB411();
            TestB412();
            TestB413();
            TestB414();
            TestB415();
        }

        private void CleanStorage(IWebDriver driver)
        {

            /*driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
            Thread.Sleep(3000);


            // Select all files
            driver.FindElement(By.Id("selectall")).Click();
            Thread.Sleep(1000);

            // Click the button to open the file upload dialog
            driver.FindElement(By.Id("action-menu-toggle-0")).Click();
            Thread.Sleep(1000);

            // Click the button to open the file upload dialog
            driver.FindElement(By.Id("action-menuaction-delete")).Click();
            Thread.Sleep(1000);

            // Click the button to open the file upload dialog
            driver.FindElement(By.Id("id_submitbutton")).Click();
            Thread.Sleep(1000);

            // Click the button to open the file upload dialog
            driver.FindElement(By.Id("id_submitbutton")).Click();
            Thread.Sleep(1000);*/
        }

        //<summary>
        //Test case B401: Upload a file under 100MB to the Private files area
        //</summary>
        public void TestB401()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB401)} started");

                TestingHelper.Login(driver);
                

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);

                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']")).Click();
                Thread.Sleep(2000);


                string filePath = "D:\\HK231\\Software Testing\\Proj3\\CO3015_Ass3-main\\CO3015_Assignment3\\resource\\under100mb.md"; // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);
                
                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(3000);

                driver.FindElement(By.Name("submitbutton")).Click();
                Thread.Sleep(1000);

                if (driver.FindElements(By.XPath("//div[@class='toast-body d-flex']")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB401)}: PASSED");
                }
                else
                {
                    Console.WriteLine($"Test case {nameof(TestB401)}: FAILED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB401)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB401)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        //<summary>
        //Test case B402: Upload a file under 100MB with custom name to the Private files area
        //</summary>

        public void TestB402()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB402)} started");

                TestingHelper.Login(driver);

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);

                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Name("title")).SendKeys("README.md");
                Thread.Sleep(1000);

                string filePath = "D:\\HK231\\Software Testing\\Proj3\\CO3015_Ass3-main\\CO3015_Assignment3\\resource\\under100mb.md"; // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);

                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(3000);

                driver.FindElement(By.Name("submitbutton")).Click();
                Thread.Sleep(1000);

                if (driver.FindElements(By.XPath("//div[@class='toast-body d-flex']")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB402)}: PASSED");
                }
                else
                {
                    Console.WriteLine($"Test case {nameof(TestB402)}: FAILED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB402)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB402)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }
        
        //<summary>
        //Test case B403: Upload a file with over 255 characters custom name
        //</summary>

        public void TestB403()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB403)} started");

                TestingHelper.Login(driver);

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);

                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']")).Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Name("title")).SendKeys("Nike’s “Dream Crazier” ad is one of the most powerful and empowering pieces of advertising to date, particularly in its depiction of women in sports overcoming societal barriers. One of the most notable aspects of the ad is its focus on female athletes’ strengthand Apart from counting YOLO.");
                Thread.Sleep(1000);

                string filePath = "D:\\HK231\\Software Testing\\Proj3\\CO3015_Ass3-main\\CO3015_Assignment3\\resource\\under100mb.md"; // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);

                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(3000);

                if (driver.FindElements(By.Id("yui_3_18_1_1_1701742237898_915")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB403)}: PASSED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB403)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB403)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        //<summary>
        //Test case B404: Upload a file with invalid author name 
        //</summary>

        public void TestB404()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB404)} started");

                TestingHelper.Login(driver);

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);

                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']"))
                    .Click();
                Thread.Sleep(2000);

                driver.FindElement(By.Name("author")).SendKeys("Nike’s “Dream Crazier” ad is one of the most powerful and empowering pieces of advertising to date, particularly in its depiction of women in sports overcoming societal barriers. One of the most notable aspects of the ad is its focus on female athletes’ strengthand Apart from counting YOLO.");
                Thread.Sleep(1000);

                string filePath = "D:\\HK231\\Software Testing\\Proj3\\CO3015_Ass3-main\\CO3015_Assignment3\\resource\\under100mb.md"; // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);

                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(3000);

                if (driver.FindElements(By.Id("yui_3_18_1_1_1701742237898_915")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB404)}: PASSED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB404)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB404)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        //<summary>
        //Test case B405: Upload a file over100MB to the Private files area
        //</summary>

        public void TestB405()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB405)} started");

                TestingHelper.Login(driver);

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);
                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']"))
                    .Click();
                Thread.Sleep(2000);

                

                string filePath = "D:\\HK231\\Software Testing\\Proj3\\CO3015_Ass3-main\\temp\\over100mb.xd"; // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);

                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(5000);

                if (driver.FindElements(By.Id("yui_3_18_1_1_170174234598_915")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB405)}: PASSED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB405)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB405)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        //LEVEL 1: DATA DRIVEN TESTING
        
        //<summary>
        //Test case B11: Upload a file under 100MB to the Private files area
        //</summary>

        public void TestB411()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB411)} started");

                TestingHelper.Login(driver);

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);
                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']"))
                    .Click();
                Thread.Sleep(2000);

                string filePath = TestingHelper.GetCellDataFromExcelFile("B4_data.xlsx","B2"); // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);

                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(3000);

                driver.FindElement(By.Name("submitbutton")).Click();
                Thread.Sleep(1000);

                if (driver.FindElements(By.XPath("//div[@class='toast-body d-flex']")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB411)}: PASSED");
                }
                else
                {
                    Console.WriteLine($"Test case {nameof(TestB411)}: FAILED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB411)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB411)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        public void TestB412()
        {
            //Test case B12: Upload a file under 100MB with custom name to the Private files area
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB412)} started");

                TestingHelper.Login(driver);

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);
                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']"))
                    .Click();
                Thread.Sleep(2000);

                string fileName = TestingHelper.GetCellDataFromExcelFile("B4_data.xlsx", "C3");
                driver.FindElement(By.Name("title")).SendKeys(fileName);
                Thread.Sleep(1000);

                string filePath = TestingHelper.GetCellDataFromExcelFile("B4_data.xlsx", "B2"); // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);

                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(3000);

                driver.FindElement(By.Name("submitbutton")).Click();
                Thread.Sleep(1000);

                if (driver.FindElements(By.XPath("//div[@class='toast-body d-flex']")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB412)}: PASSED");
                }
                else
                {
                    Console.WriteLine($"Test case {nameof(TestB412)}: FAILED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB412)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB412)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        public void TestB413()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB413)} started");

                TestingHelper.Login(driver);

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);
                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']")).Click();
                Thread.Sleep(2000);

                string fileName = TestingHelper.GetCellDataFromExcelFile("B4_data.xlsx", "C4");

                driver.FindElement(By.Name("title")).SendKeys(fileName);
                Thread.Sleep(1000);

                string filePath = TestingHelper.GetCellDataFromExcelFile("B4_data.xlsx", "B2"); // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);

                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(3000);

                if (driver.FindElements(By.Id("yui_3_18_1_1_1701742237898_915")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB413)}: PASSED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB413)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB413)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }
        public void TestB414()
        {
            //Test case B414: Upload a file with invalid author name
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB414)} started");

                TestingHelper.Login(driver);

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);
                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']"))
                    .Click();
                Thread.Sleep(2000);

                string authorName = TestingHelper.GetCellDataFromExcelFile("B4_data.xlsx", "D5");
                driver.FindElement(By.Name("author")).SendKeys(authorName);
                Thread.Sleep(1000);

                string filePath = TestingHelper.GetCellDataFromExcelFile("B4_data.xlsx", "B2"); // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);

                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(3000);

                if (driver.FindElements(By.Id("yui_3_18_1_1_1701742237898_915")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB414)}: PASSED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB414)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB414)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        public void TestB415()
        {
            //Test case B415: Upload a file with invalid author name
            IWebDriver driver = new ChromeDriver();

            try
            {
                Console.WriteLine($"Test case {nameof(TestB415)} started");

                TestingHelper.Login(driver);

                driver.Navigate().GoToUrl("https://school.moodledemo.net/user/files.php");
                Thread.Sleep(3000);

                CleanStorage(driver);
                // Click the button to open the file upload dialog
                driver.FindElement(By.XPath("//a[@role='button' and @title='Add...']"))
                    .Click();
                Thread.Sleep(2000);


                string filePath = TestingHelper.GetCellDataFromExcelFile("B4_data.xlsx", "B6"); // Replace with the actual file path
                driver.FindElement(By.Name("repo_upload_file")).SendKeys(filePath);

                driver.FindElement(By.XPath("//button[text()='Upload this file']")).Click();
                Thread.Sleep(3000);

                if (driver.FindElements(By.Id("yui_3_18_1_1_1701742237898_915")) != null)
                {

                    Console.WriteLine($"Test case {nameof(TestB415)}: PASSED");
                }

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB415)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB415)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }


    }
}
