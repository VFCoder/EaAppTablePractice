using EaAppFrameWork.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaAppTest.Pages;

public interface IHeaders
{
    void ClickAbout();
    void ClickEmployeeDetails();
    void ClickEmployeeList();
    void ClickHelloUser();
    void ClickHome();
    void ClickHost();
    void ClickLogin();
    void ClickLogOff();
    void ClickManageUsers();
    void ClickRegister();
}

public class Headers : IHeaders
{
    private readonly IDriverWait _driver;
    public Headers(IDriverWait driver)
    {
        _driver = driver;
    }

    #region "Header Elements and Actions"
    private IWebElement lnkHome => _driver.FindElement(By.LinkText("Home"));
    private IWebElement lnkAbout => _driver.FindElement(By.LinkText("About"));
    private IWebElement lnkEmployeeList => _driver.FindElement(By.LinkText("Employee List"));
    private IWebElement lnkEmployeeDetails => _driver.FindElement(By.LinkText("Employee Details"));
    private IWebElement lnkManageUsers => _driver.FindElement(By.LinkText("Manage Users"));
    private IWebElement lnkHelloUser => _driver.FindElement(By.PartialLinkText("Hello"));
    private IWebElement lnkRegister => _driver.FindElement(By.CssSelector("a[id='registerLink']"));
    private IWebElement lnkLogin => _driver.FindElement(By.LinkText("Login"));
    private IWebElement lnkLogOff => _driver.FindElement(By.LinkText("Log off"));
    private IWebElement lnkHosting => _driver.FindElement(By.LinkText("Web hosting by Somee.com"));



    public void ClickHome()
    {
        lnkHome.Click();
    }

    public void ClickAbout()
    {
        lnkAbout.Click();
    }

    public void ClickEmployeeList()
    {
        lnkEmployeeList.Click();
    }

    public void ClickEmployeeDetails()
    {
        lnkEmployeeDetails.Click();
    }

    public void ClickManageUsers()
    {
        lnkManageUsers.Click();
    }

    public void ClickHelloUser()
    {
        lnkHelloUser.Click();
    }

    public void ClickRegister()
    {
        lnkRegister.Click();
    }

    public void ClickLogin()
    {
        lnkLogin.Click();
    }

    public void ClickLogOff()
    {
        lnkLogOff.Click();
    }

    public void ClickHost()
    {
        lnkHosting.Click();
    }
    #endregion

}
