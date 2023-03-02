using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace StaffServiceTests_1;

public class StaffServiceTests
{
    [Test]
    public void Authorization()
    {
        var options = new ChromeOptions();
        options.AddArguments("--no-sandbox", "--start-maximized", "--disable-extensions");
        var driver = new ChromeDriver(options);

        driver.Navigate().GoToUrl("https://staff-testing.testkontur.ru");

        Thread.Sleep(3000);
        driver.Quit();
    }
}