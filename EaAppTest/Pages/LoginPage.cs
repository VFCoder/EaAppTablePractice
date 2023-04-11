using EaAppFrameWork.Driver;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaAppTest.Pages;

public interface ILoginPage
{
    void ClickAbout();
    void ClickEmployeeList();
    void ClickLogin();
    void ClickRegister();
    void LoginDoNotRemember(string userName, string password);
    void LoginRemember(string userName, string password);
    void Register();
}

public class LoginPage : ILoginPage
{
    private readonly IDriverWait _driver;

    public LoginPage(IDriverWait driver)
    {
        _driver = driver;
    }

    #region "Header Elements and Actions"
    private IWebElement lnkAbout => _driver.FindElement(By.LinkText("About"));
    private IWebElement lnkEmployeeList => _driver.FindElement(By.LinkText("Employee List"));
    private IWebElement lnkRegister => _driver.FindElement(By.LinkText("Register"));
    private IWebElement lnkLogin => _driver.FindElement(By.LinkText("Login"));


    public void ClickAbout()
    {
        lnkAbout.Click();
    }

    public void ClickEmployeeList()
    {
        lnkEmployeeList.Click();
    }

    public void ClickRegister()
    {
        lnkRegister.Click();
    }

    public void ClickLogin()
    {
        lnkLogin.Click();
    }
    #endregion

    private IWebElement txtUserName => _driver.FindElement(By.Id("UserName"));
    private IWebElement txtPassword => _driver.FindElement(By.Id("Password"));
    private IWebElement btnRememberMe => _driver.FindElement(By.Id("RememberMe"));
    private IWebElement btnLogin => _driver.FindElement(By.CssSelector(".btn-default"));
    private IWebElement lnkRegisterNewUser => _driver.FindElement(By.LinkText("Register as a new user"));

    public void LoginDoNotRemember(string userName, string password) //how to code option to click remember me?
    {
        txtUserName.SendKeys(userName);
        txtPassword.SendKeys(password);
        btnLogin.Click();
    }

    public void LoginRemember(string userName, string password) //how to code option to click remember me?
    {
        txtUserName.SendKeys(userName);
        txtPassword.SendKeys(password);
        btnRememberMe.Click();
        btnLogin.Click();
    }

    public void Register()
    {
        lnkRegisterNewUser.Click();
    }
}
