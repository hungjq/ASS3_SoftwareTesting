using OfficeOpenXml;
using OpenQA.Selenium;
using System.Configuration;

namespace CO3015_Assignment3.Utility
{
    public class TestingHelper
    {
        private static readonly string? UserName = ConfigurationManager.AppSettings["username"];
        private static readonly string? Password = ConfigurationManager.AppSettings["password"];
        private static readonly string? ProjectDirectory
            = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;

        public static bool IsLoginRequired(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://softtesting.gnomio.com/my/");
            Thread.Sleep(2000);

            return driver.FindElements(By.XPath("//a[@href='https://softtesting.gnomio.com/login/index.php']")).Any();
        }

        public static void Login(IWebDriver driver)
        {
            driver.Navigate().GoToUrl("https://softtesting.gnomio.com/my/");
            Thread.Sleep(2000);

            driver.FindElement(By.Id("username")).SendKeys(UserName);
            driver.FindElement(By.Id("password")).SendKeys(Password);
            Thread.Sleep(2000);

            driver.FindElement(By.Id("loginbtn")).Click();
            Thread.Sleep(2000);
        }

        public static string? GetCellDataFromExcelFile(string excelFileName, string cell)
        {
            using var xlPackage = new ExcelPackage(new FileInfo(
                Path.Combine(ProjectDirectory ?? throw new InvalidOperationException(), $"resource\\{excelFileName}")));

            var myWorksheet = xlPackage.Workbook.Worksheets.First();
            return myWorksheet.Cells[cell].Value != null ? myWorksheet.Cells[cell].Value.ToString() : string.Empty;
        }
    }
}
