﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System;

namespace ApiConsul
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args)
        {
            var config = new ConfigurationBuilder().AddCommandLine(args).Build();
            string ip = config["ip"];
            int port = Convert.ToInt32(config["port"]);
            return WebHost.CreateDefaultBuilder(args).UseStartup<Startup>().UseUrls($"http://{ip}:{port}").Build();
        }
    }
}