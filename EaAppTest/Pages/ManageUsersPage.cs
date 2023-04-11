using EaAppFrameWork.Driver;
using EaAppFrameWork.Extensions;
using EaAppTest.Models;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EaAppTest.Pages;

public interface IManageUsersPage
{
    void ClickAbout();
    void ClickEmployeeDetails();
    void ClickEmployeeList();
    void ClickHelloUser();
    void ClickHome();
    void ClickLogOff();
    void ClickManageUsers();

    void ClickRolesDdl(string userName, string operation);
    void SelectRole(string userName, string operation);
    void ClickAssign(string userName);

}

public class ManageUsersPage : IManageUsersPage
{
    private readonly IDriverWait _driver;

    public ManageUsersPage(IDriverWait driver)
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
    private IWebElement lnkLogOff => _driver.FindElement(By.LinkText("Log off"));

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

    public void ClickLogOff()
    {
        lnkLogOff.Click();
    }
    #endregion

    private IWebElement tblList => _driver.FindElement(By.CssSelector(".table"));
    private IWebElement tblDdl => _driver.FindElement(By.XPath("//*[@value='Specflow']//following::td[2]//child::*[@value='Guest']"));
    private IWebElement btnAssign => _driver.FindElement(By.XPath("//*[@value='Specflow']//following::td[3]//child::*[@value='Assign']"));



    public void ClickRolesDdl(string userName, string operation)
    {

        tblList.PerformActionOnCell("Roles", "UserName", userName, operation);

    }
    
    public void SelectRole(string userName, string operation)
    {

        tblList.PerformActionOnCell("Roles", "UserName", userName, operation);

    }

    
    public void ClickAssign(string userName)
    {
        tblList.PerformActionOnCell("3", "UserName", userName);
    }





}
