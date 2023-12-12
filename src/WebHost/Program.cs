﻿using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Hosting;
using Store.Migrations;

namespace Web.Hosts;

public static class Program
{
    public static void Main(string[] args)
    {
        DatabaseMigrationManager.MigrateSchema().ConfigureAwait(false);
        CreateHostBuilder(args).Build().Run();
    }
    public static IHostBuilder CreateHostBuilder(string[] args) =>
                                    Host.CreateDefaultBuilder(args).ConfigureServices((x,y) =>
                                    {
                                        var config = x.Configuration;
                                        y.ConfigureServices(config);
                                    });
}