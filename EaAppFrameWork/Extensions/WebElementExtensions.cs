using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaAppFrameWork.Extensions;

public static class WebElementExtensions
{

    public static void SelectDdlByText(this IWebElement element, string text)
    {
        var select = new SelectElement(element);
        select.SelectByText(text);
    }

    public static void ClearAndEnterText(this IWebElement element, string text)
    {
        element.Clear();
        element.SendKeys(text);
    }
}
