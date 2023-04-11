using EaAppFrameWork.Config;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaAppFrameWork.Driver;

public class DriverFixture : IDriverFixture//, IDisposable
{
    private readonly TestSettings _testSettings;
    public IWebDriver Driver { get; }
    public DriverFixture(TestSettings testSettings)
    {
        _testSettings = testSettings;
        Driver = GetWebDriver();
        Driver.Navigate().GoToUrl(_testSettings.ApplicationUrl);

    }
    private IWebDriver GetWebDriver()
    {
        return _testSettings.BrowserType switch
        {
            BrowserType.Chrome => new ChromeDriver(),
            BrowserType.Firefox => new FirefoxDriver(),
            BrowserType.Safari => new SafariDriver(),
        };
    }

/*    public void Dispose()
    {
        Driver.Dispose();
    }*/
}

public enum BrowserType
{
    Chrome,
    Firefox,
    Safari
}