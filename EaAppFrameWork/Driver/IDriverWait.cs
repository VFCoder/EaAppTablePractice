using OpenQA.Selenium;

namespace EaAppFrameWork.Driver
{
    public interface IDriverWait
    {
        IWebElement FindElement(By elementlocator);
        IEnumerable<IWebElement> FindElements(By elementlocator);
    }
}