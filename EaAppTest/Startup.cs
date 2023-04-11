using EaAppFrameWork.Config;
using EaAppFrameWork.Driver;
using EaAppTest.Pages;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaAppTest;

public class Startup
{

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton(ConfigReader.ReadConfig())
        .AddScoped<IDriverFixture, DriverFixture>()
        .AddScoped<IDriverWait, DriverWait>()
        .AddScoped<IHeaders, Headers>()
        .AddScoped<ILoginPage, LoginPage>()
        .AddScoped<IManageUsersPage, ManageUsersPage>();
    }
}
