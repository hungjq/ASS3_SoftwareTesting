using CO3015_Assignment3.Utility;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System;
using OpenQA.Selenium.Interactions;


namespace CO3015_Assignment3
{
    public class B5TakeQuiz
    {
        public B5TakeQuiz()
        {
            // Define License Context for EPPlus package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void RunTest()
        {
            TestB501();
            TestB502();
            TestB503();
            TestB504();
            TestB505();
        }



        /// Test case for Block admin
        public void TestB501()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {

                Console.WriteLine($"Test case {nameof(TestB501)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//span[3]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(".modtype_quiz .aalink")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//form/button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("id_submitbutton")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[3]/input[2]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[3]/div[2]/div/fieldset/div/div[2]/input")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[4]/div[2]/div/fieldset/div/div[3]/input[2]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[5]/div[2]/div/fieldset/div/div[4]/input")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("mod_quiz-next-nav")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[contains(.,\'Submit all and finish\')]")).Click();
                {
                    var element = driver.FindElement(By.XPath("//button[contains(.,\'Submit all and finish\')]"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element, 0, 0).Perform();
                }
                driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();

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

        public void TestB502()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {

                Console.WriteLine($"Test case {nameof(TestB502)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//span[3]")).Click();
                driver.FindElement(By.CssSelector(".modtype_quiz .aalink")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//form/button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("id_submitbutton")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[3]/input[2]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[3]/div[2]/div/fieldset/div/div[2]/input")).Click();
                Thread.Sleep(1000);

                driver.FindElement(By.LinkText("Back")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//form/button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[3]/div[2]/div/fieldset/div/div[2]/input")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("mod_quiz-next-nav")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[contains(.,\'Submit all and finish\')]")).Click();
                {
                    var element = driver.FindElement(By.XPath("//button[contains(.,\'Submit all and finish\')]"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element, 0, 0).Perform();
                }

                Console.WriteLine($"Test case {nameof(TestB502)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB502)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB502)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        public void TestB503()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {

                Console.WriteLine($"Test case {nameof(TestB503)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//span[3]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(".modtype_quiz .aalink")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//form/button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//a[contains(text(),\'Settings\')]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//a[contains(.,\'Timing\')]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("id_timelimit_enabled")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("fitem_id_timelimit")).Click();
                Thread.Sleep(1000);
                Thread.Sleep(1000);
                driver.FindElement(By.Id("id_submitbutton")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[contains(.,\'Preview quiz\')]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("id_submitbutton")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("q107:1_answer0")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.LinkText("Finish review")).Click();

                Console.WriteLine($"Test case {nameof(TestB503)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB503)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB503)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        public void TestB504()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {

                Console.WriteLine($"Test case {nameof(TestB504)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//span[3]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(".modtype_quiz .aalink")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//form/button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//div[2]/nav/ul/li[2]/a")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("collapseElement-1")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("id_timeopen_year")).Click();
                {
                    var dropdown = driver.FindElement(By.Id("id_timeopen_year"));
                    dropdown.FindElement(By.XPath("//option[. = '2042']")).Click();
                }
                driver.FindElement(By.Id("id_submitbutton")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[contains(.,\'Preview quiz\')]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("mod_quiz-next-nav")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[contains(.,\'Submit all and finish\')]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
                Thread.Sleep(1000);
                Console.WriteLine($"Test case {nameof(TestB504)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB504)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB504)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        public void TestB505()
        {
            IWebDriver driver = new ChromeDriver();

            try
            {

                Console.WriteLine($"Test case {nameof(TestB505  )} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                // sleep for 2 seconds
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//span[3]")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.CssSelector(".modtype_quiz .aalink")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//form/button")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("id_submitbutton")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.Id("mod_quiz-next-nav")).Click();
                Thread.Sleep(1000);
                driver.FindElement(By.XPath("//button[contains(.,\'Submit all and finish\')]")).Click();
                {
                    var element = driver.FindElement(By.XPath("//button[contains(.,\'Submit all and finish\')]"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
                {
                    var element = driver.FindElement(By.TagName("body"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element, 0, 0).Perform();
                }
                driver.FindElement(By.CssSelector(".modal-footer > .btn-primary")).Click();
                Console.WriteLine($"Test case {nameof(TestB505)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB505)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB505)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

    }
}
