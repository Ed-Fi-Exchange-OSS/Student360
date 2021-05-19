// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using RestSharp;
using System;
using System.IO;

namespace SMCISD.Student360.Recurrent
{
    class Program
    {
        public static IConfigurationRoot Configuration;
        static void Main(string[] args)
        {
            var host = new HostBuilder()
              .ConfigureHostConfiguration(config =>
              {
                  if (args != null)
                  {
                      // enviroment from command line
                      // e.g.: dotnet run --environment "Staging"
                      config.AddCommandLine(args);
                  }
              })
              .ConfigureAppConfiguration((context, builder) =>
              {
                  builder.SetBasePath(AppContext.BaseDirectory)
                      .AddJsonFile("appsettings.json", optional: false)
                      .AddJsonFile($"appsettings.{context.HostingEnvironment.EnvironmentName}.json", optional: true);

                  Console.WriteLine(context.HostingEnvironment.EnvironmentName);
                  Configuration = builder.Build();
              }).Build();

            var notificationEndPoint = Configuration["NotificationsApi"];

            var client = new RestClient(notificationEndPoint);
            var request = new RestRequest(Method.GET);

            System.Console.WriteLine($"-> Calling endpoint: {notificationEndPoint}");
            var watch = System.Diagnostics.Stopwatch.StartNew();
            var response = client.Execute(request);
            watch.Stop();

            System.Console.WriteLine($"--> Status:{response.StatusDescription}, Content: {response.Content} in ({watch.ElapsedMilliseconds}ms)");

            if (response.StatusCode != System.Net.HttpStatusCode.OK)
                Environment.Exit(-1);
#if DEBUG
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
#endif
        }
    }
}
