using OpenQA.Selenium;

namespace EaAppFrameWork.Driver
{
    public interface IDriverFixture
    {
        IWebDriver Driver { get; }
    }
}