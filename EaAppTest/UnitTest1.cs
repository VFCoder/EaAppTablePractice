using AutoFixture.Xunit2;
using EaAppFrameWork.Config;
using EaAppFrameWork.Driver;
using EaAppTest.Models;
using EaAppTest.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EaAppTest;

public class UnitTest1 
{
    private readonly IDriverFixture _driverFixture;
    private readonly IHeaders _headers;
    private readonly ILoginPage _loginPage;
    private readonly IManageUsersPage _manageUsersPage;

    public UnitTest1(IDriverFixture DriverFixture, IHeaders Headers, ILoginPage LoginPage, IManageUsersPage ManageUsersPage)
    {
        _driverFixture = DriverFixture;
        _headers = Headers;
        _loginPage = LoginPage;
        _manageUsersPage = ManageUsersPage;
    }
    [Theory]
    [AutoData]
    public void Test1()
    {

        _headers.ClickLogin();
        _loginPage.LoginDoNotRemember("admin", "password");

        _headers.ClickManageUsers();
        _manageUsersPage.ClickRolesDdl("Specflow", "RoleName");        
        _manageUsersPage.SelectRole("Specflow", "Administrator");        
               
        _manageUsersPage.ClickAssign("Specflow");

    }

}