using CO3015_Assignment3.Utility;
using OfficeOpenXml;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Diagnostics;
using System;
using OpenQA.Selenium.Interactions;


namespace CO3015_Assignment3
{

    public class B6AddDisscusstionTopic
    {
        public IJavaScriptExecutor js { get; private set; }

        public B6AddDisscusstionTopic()
        {
            // Define License Context for EPPlus package
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
        }

        public void RunTest()
        {
            TestB601();
            TestB602();
            TestB603();
            TestB604();

            TestB611();
        }

        private void TestB611()
        {
            IWebDriver driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;

            try
            {

                Console.WriteLine($"Test case {nameof(TestB611)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//span[3]")).Click();
                driver.FindElement(By.XPath("//div/div[2]/div/div/div/div/a")).Click();
                driver.FindElement(By.LinkText("Add discussion topic")).Click();
                driver.FindElement(By.Id("id_subject")).Click();
                driver.FindElement(By.Id("id_subject")).Click();
                {
                    var element = driver.FindElement(By.Id("id_subject"));
                    Actions builder = new Actions(driver);
                    builder.DoubleClick(element).Perform();
                }

                var Topic = TestingHelper.GetCellDataFromExcelFile("B6.xlsx", "A2");
                var Content = TestingHelper.GetCellDataFromExcelFile("B6.xlsx", "B3");

                driver.FindElement(By.Id("id_subject")).SendKeys(Topic);
                driver.SwitchTo().Frame(0);
                {
                    var element = driver.FindElement(By.Id("tinymce"));
                    js.ExecuteScript("if(arguments[0].contentEditable === 'true') {arguments[0].innerText = arguments[1];}", element, Content);
                }
                driver.SwitchTo().DefaultContent();
                driver.FindElement(By.Id("id_submitbutton")).Click();

                Console.WriteLine($"Test case {nameof(TestB611)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB611)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB611)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        private void TestB604()
        {
            IWebDriver driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            try
            {

                Console.WriteLine($"Test case {nameof(TestB604)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//span[3]")).Click();
                driver.FindElement(By.XPath("//div/div[2]/div/div/div/div/a")).Click();
                driver.FindElement(By.LinkText("Add discussion topic")).Click();
                driver.FindElement(By.Id("id_subject")).Click();
                driver.FindElement(By.Id("id_subject")).Click();
                {
                    var element = driver.FindElement(By.Id("id_subject"));
                    Actions builder = new Actions(driver);
                    builder.DoubleClick(element).Perform();
                }
                driver.FindElement(By.Id("id_subject")).SendKeys("Normal Topic");
                driver.SwitchTo().Frame(0);
                {
                    var element = driver.FindElement(By.Id("tinymce"));
                    // make js loop and concat string it over 10000 characters
                }
                driver.SwitchTo().DefaultContent();
                driver.FindElement(By.Id("id_submitbutton")).Click();

                Console.WriteLine($"Test case {nameof(TestB604)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB604)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB604)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        private void TestB603()
        {
            IWebDriver driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            try
            {

                Console.WriteLine($"Test case {nameof(TestB603)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//span[3]")).Click();
                driver.FindElement(By.XPath("//div/div[2]/div/div/div/div/a")).Click();
                driver.FindElement(By.LinkText("Add discussion topic")).Click();
                driver.FindElement(By.Id("id_subject")).Click();
                driver.FindElement(By.Id("id_subject")).Click();
                {
                    var element = driver.FindElement(By.Id("id_subject"));
                    Actions builder = new Actions(driver);
                    builder.DoubleClick(element).Perform();
                }
                driver.FindElement(By.Id("id_subject")).SendKeys("In Moodle, a discussion topic is a forum thread within a course where students and instructors can engage in asynchronous discussions about a specific topic or question. It allows for deeper exploration of concepts, brainstorming of ideas, and collaborative learning.  Here\'s a breakdown of its functionalities:  Purpose:  Facilitate asynchronous discussions among students and instructors. Encourage critical thinking and deeper understanding of course material. Promote collaborative learning and peer interaction. Provide a space for students to ask questions and seek clarification. Key features:  Forum thread: Each discussion topic is organized as a thread, where users can post their initial thoughts and reply to others\' comments. Threaded replies: Users can reply directly to specific posts, creating a clear conversation flow. Moderation tools: Instructors can moderate discussions by deleting inappropriate posts, marking discussions as read, and pinning important messages. Subscription options: Users can choose to be notified of new posts in a discussion topic. Multiple forum types: Different forum types are available, such as Standard forums for open discussions, Q&A forums for asking and answering questions, and Single Simple forums for focused discussions on a single topic. Benefits of using discussion topics:  Promotes active learning: Students are actively engaged in the learning process by contributing to discussions and sharing their thoughts. Enhances understanding: Discussing concepts with peers can help students solidify their understanding and identify areas where they need further clarification. Develops critical thinking skills: Students learn to analyze information, form their own opinions, and defend their arguments through discussions. Improves communication skills: Students practice writing clear and concise messages, and learn to communicate effectively in a respectful and professional manner. Fosters a sense of community: Discussions can create a sense of community within the course, as students connect with their peers and instructors. Overall, discussion topics are a valuable tool in Moodle that can significantly enhance the learning experience for students and instructors.     Bard may display inaccurat");
                driver.SwitchTo().Frame(0);
                {
                    var element = driver.FindElement(By.Id("tinymce"));
                }
                driver.SwitchTo().DefaultContent();
                driver.FindElement(By.Id("id_submitbutton")).Click();

                Console.WriteLine($"Test case {nameof(TestB603)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB603)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB603)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }

        private void TestB602()
        {
            IWebDriver driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            try
            {

                Console.WriteLine($"Test case {nameof(TestB602)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);
                driver.FindElement(By.XPath("//span[3]")).Click();
                driver.FindElement(By.XPath("//div/div[2]/div/div/div/div/a")).Click();
                driver.FindElement(By.CssSelector("#module-967 .aalink")).Click();
                {
                    var element = driver.FindElement(By.LinkText("Add discussion topic"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element).Perform();
                }
                driver.FindElement(By.LinkText("Add discussion topic")).Click();
                {
                    var element = driver.FindElement(By.TagName("body"));
                    Actions builder = new Actions(driver);
                    builder.MoveToElement(element, 0, 0).Perform();
                }
                driver.FindElement(By.Id("id_submitbutton")).Click();
                Console.WriteLine($"Test case {nameof(TestB602)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB602)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB602)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }



        /// Test case for Block admin
        public void TestB601()
        {
            IWebDriver driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            try
            {

                Console.WriteLine($"Test case {nameof(TestB601)} started");

                TestingHelper.Login(driver);

                // sleep for 2 seconds
                Thread.Sleep(2000);

                driver.FindElement(By.XPath("//span[3]")).Click();
                driver.FindElement(By.XPath("//div/div[2]/div/div/div/div/a")).Click();
                driver.FindElement(By.LinkText("Add discussion topic")).Click();
                driver.FindElement(By.Id("id_subject")).Click();
                driver.FindElement(By.Id("id_subject")).Click();
                {
                    var element = driver.FindElement(By.Id("id_subject"));
                    Actions builder = new Actions(driver);
                    builder.DoubleClick(element).Perform();
                }
                driver.FindElement(By.Id("id_subject")).SendKeys("Normal Topic");
                js.ExecuteScript("window.scrollTo(0,318.3999938964844)");
                driver.SwitchTo().Frame(0);
                {
                    var element = driver.FindElement(By.Id("tinymce"));
                    js.ExecuteScript("if(arguments[0].contentEditable === 'true') {arguments[0].innerText = '<div class=\"chat-history-scroll-container ng-tns-c1385467139-2 ng-trigger ng-trigger-resetChat show-bottom-shadow\"><div class=\"conversation-container ng-tns-c1385467139-2 narrow-container ng-star-inserted\"><div class=\"ng-tns-c1187250912-40\"><div class=\"response-container ng-tns-c1832212363-41\"><div class=\"presented-response-container ng-tns-c1832212363-41\"><div class=\"response-container-content ng-tns-c1832212363-41\"><div class=\"response-content ng-trigger ng-trigger-responsePopulation ng-tns-c1832212363-41\"><div class=\"markdown markdown-main-panel\" dir=\"ltr\"><p data-sourcepos=\"1:1-1:183\">In Moodle, a discussion topic is a forum thread within a course where students and instructors can engage in asynchronous discussions about a specific topic or question. It allows for deeper exploration of concepts, brainstorming of ideas, and collaborative learning.</p><p data-sourcepos=\"3:1-3:42\">Here\'s a breakdown of its functionalities:</p><p data-sourcepos=\"5:1-5:12\"><strong>Purpose:</strong></p><ul data-sourcepos=\"7:1-7:25\"><li data-sourcepos=\"7:1-7:25\">Facilitate asynchronous discussions among students and instructors.</li><li data-sourcepos=\"8:1-8:74\">Encourage critical thinking and deeper understanding of course material.</li><li data-sourcepos=\"9:1-9:54\">Promote collaborative learning and peer interaction.</li><li data-sourcepos=\"10:1-10:17\">Provide a space for students to ask questions and seek clarification.</li></ul><p data-sourcepos=\"12:1-12:17\"><strong>Key features:</strong></p><ul data-sourcepos=\"14:1-14:83\"><li data-sourcepos=\"14:1-14:83\"><strong>Forum thread:</strong>&nbsp;Each discussion topic is organized as a thread,&nbsp;where users can post their initial thoughts and reply to others\' comments.</li><li data-sourcepos=\"15:1-15:103\"><strong>Threaded replies:</strong>&nbsp;Users can reply directly to specific posts,&nbsp;creating a clear conversation flow.</li><li data-sourcepos=\"16:1-16:154\"><strong>Moderation tools:</strong>&nbsp;Instructors can moderate discussions by deleting inappropriate posts,&nbsp;marking discussions as read,&nbsp;and pinning important messages.</li><li data-sourcepos=\"17:1-17:95\"><strong>Subscription options:</strong>&nbsp;Users can choose to be notified of new posts in a discussion topic.</li><li data-sourcepos=\"18:1-19:0\"><strong>Multiple forum types:</strong>&nbsp;Different forum types are available,&nbsp;such as Standard forums for open discussions,&nbsp;Q&amp;A forums for asking and answering questions,&nbsp;and Single Simple forums for focused discussions on a single topic.</li></ul><p data-sourcepos=\"20:1-20:37\"><strong>Benefits of using discussion topics:</strong></p><ul data-sourcepos=\"22:1-27:0\"><li data-sourcepos=\"22:1-22:144\"><strong>Promotes active learning:</strong>&nbsp;Students are actively engaged in the learning process by contributing to discussions and sharing their thoughts.</li><li data-sourcepos=\"23:1-23:165\"><strong>Enhances understanding:</strong>&nbsp;Discussing concepts with peers can help students solidify their understanding and identify areas where they need further clarification.</li><li data-sourcepos=\"24:1-24:152\"><strong>Develops critical thinking skills:</strong>&nbsp;Students learn to analyze information,&nbsp;form their own opinions,&nbsp;and defend their arguments through discussions.</li><li data-sourcepos=\"25:1-25:168\"><strong>Improves communication skills:</strong>&nbsp;Students practice writing clear and concise messages,&nbsp;and learn to communicate effectively in a respectful and professional manner.</li><li data-sourcepos=\"26:1-27:0\"><strong>Fosters a sense of community:</strong>&nbsp;Discussions can create a sense of community within the course,&nbsp;as students connect with their peers and instructors.</li></ul><p data-sourcepos=\"28:1-28:145\"><strong>Overall, discussion topics are a valuable tool in Moodle that can significantly enhance the learning experience for students and instructors.</strong></p></div><div class=\"response-footer ng-tns-c1187250912-40 gap complete\"><div class=\"sources-list-container\"><br data-mce-bogus=\"1\"></div></div></div></div></div><div class=\"response-container-footer ng-tns-c1832212363-41\"><div class=\"actions-container-v2 ng-star-inserted\"><div class=\"buttons-container-v2 ng-star-inserted\"><button class=\"mat-mdc-tooltip-trigger icon-button mdc-button mat-mdc-button mat-unthemed mat-mdc-button-base gmat-mdc-button ng-star-inserted\" aria-label=\"Good response\" aria-pressed=\"false\" aria-controls=\"feedback-form-3\"></button><button class=\"mat-mdc-tooltip-trigger icon-button mdc-button mat-mdc-button mat-unthemed mat-mdc-button-base gmat-mdc-button ng-star-inserted\" aria-label=\"Bad response\" aria-pressed=\"false\" aria-controls=\"feedback-form-3\"></button><div class=\"menu-button-wrapper\"><button class=\"mat-mdc-menu-trigger mat-mdc-tooltip-trigger icon-button mdc-button mat-mdc-button gmat-mdc-button-with-prefix mat-unthemed mat-mdc-button-base gmat-mdc-button ng-star-inserted\" aria-label=\"Modify response\" aria-haspopup=\"menu\" aria-expanded=\"false\">tune</button><button class=\"mat-mdc-menu-trigger mat-mdc-tooltip-trigger icon-button mdc-button mat-mdc-button gmat-mdc-button-with-prefix mat-unthemed mat-mdc-button-base gmat-mdc-button ng-star-inserted\" aria-label=\"Share &amp; export\" aria-haspopup=\"menu\" aria-expanded=\"false\">share</button></div><div class=\"menu-button-wrapper ng-star-inserted\"><br data-mce-bogus=\"1\"></div><div class=\"menu-button-wrapper ng-star-inserted\"><button class=\"mat-mdc-menu-trigger mat-mdc-tooltip-trigger icon-button mdc-button mat-mdc-button gmat-mdc-button-with-prefix mat-unthemed mat-mdc-button-base gmat-mdc-button\" aria-label=\"Show more options\" aria-haspopup=\"menu\" aria-expanded=\"false\" aria-describedby=\"cdk-describedby-message-ng-1-14\">more_vert</button></div></div></div></div></div><div id=\"feedback-form-3\" class=\"ng-tns-c1187250912-40\"></div><div id=\"factuality-form-3\" class=\"related-search-footer ng-tns-c1187250912-40 complete\"></div></div><div class=\"restart-chat-button-scroll-placeholder ng-tns-c1385467139-2 ng-star-inserted\"><br data-mce-bogus=\"1\"></div></div></div><div class=\"bottom-container ng-tns-c1385467139-2 narrow-container ng-star-inserted\"><div class=\"input-area-container ng-tns-c1385467139-2\"><div class=\"input-area ng-tns-c3294528854-5\" data-node-type=\"input-area\"><div class=\"image-uploader ng-star-inserted\"><button id=\"upload-local-image-button\" class=\"mat-mdc-tooltip-trigger mdc-icon-button mat-mdc-icon-button gmat-mdc-button-with-prefix mat-unthemed mat-mdc-button-base gmat-mdc-button ng-star-inserted\" aria-label=\"[BACKUP_MESSAGE_ID: 4346501862140223347] Open upload image modal\" aria-describedby=\"cdk-describedby-message-ng-1-6\">add_photo_alternate</button><button class=\"hidden-upload-local-image-button ng-star-inserted\" aria-hidden=\"true\" data-mce-tabindex=\"-1\"></button></div><div class=\"text-input-field ng-tns-c3294528854-5 ng-star-inserted\"><div class=\"text-input-field_textarea-wrapper ng-tns-c3294528854-5\"><div class=\"text-input-field-main-area ng-tns-c3294528854-5\"><div class=\"text-input-field_textarea-inner ng-tns-c3294528854-5\"><div class=\"ql-editor textarea ql-blank\" role=\"textbox\" contenteditable=\"true\" data-gramm=\"false\" aria-multiline=\"true\" aria-label=\"Input for prompt text\" data-placeholder=\"Enter a prompt here\"><p><br></p></div><div class=\"ql-clipboard\" contenteditable=\"true\" data-mce-tabindex=\"-1\"><br data-mce-bogus=\"1\"></div></div></div></div><div>mic</div></div><div class=\"send-button-container ng-tns-c3294528854-5 outer ng-star-inserted\"><button class=\"mat-mdc-tooltip-trigger send-button ng-tns-c3294528854-5 mdc-icon-button mat-mdc-icon-button gmat-mdc-button-with-prefix mat-primary mat-mdc-button-base gmat-mdc-button\" aria-label=\"Send message\" aria-disabled=\"true\" aria-describedby=\"cdk-describedby-message-ng-1-8\">send_spark</button></div></div></div><div class=\"capabilities-disclaimer ng-tns-c1385467139-2 ng-star-inserted\"><p class=\"gmat-caption ng-tns-c1385467139-2\">Bard may display inaccurat</p></div></div>'}", element);
                }
                driver.SwitchTo().DefaultContent();
                driver.FindElement(By.Id("id_submitbutton")).Click();
                Console.WriteLine($"Test case {nameof(TestB601)}: PASSED");

            }
            catch (Exception e)
            {
                Console.WriteLine($"{nameof(TestB601)}: {e.Message}");
                Console.WriteLine($"Test case {nameof(TestB601)}: FAILED");
            }
            finally
            {
                driver.Close();
                Console.WriteLine("==========================================================");
            }
        }



    }
}
