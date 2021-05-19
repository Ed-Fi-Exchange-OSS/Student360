// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SMCISD.Student360.Resources.Google.Providers;
using SMCISD.Student360.Resources.Providers;
using SMCISD.Student360.Resources.Providers.Image;
using SMCISD.Student360.Resources.Providers.Messaging;
using SMCISD.Student360.Resources.Providers.Notifications;
using SMCISD.Student360.Resources.Providers.Pdf;

namespace SMCISD.Student360.Api.Infrastructure.IoC
{
    public static class IoCConfig
    {
        public static void RegisterDependencies(IServiceCollection container, IConfiguration configuration)
        {
            // Register other dependencies
            RegisterProviders(container);

            // Register resources/services dependencies
            Resources.Infrastructure.IoC.IoCConfig.RegisterDependencies(container, configuration);
        }

        private static void RegisterProviders(IServiceCollection container)
        {
            // Register the Token Validator
            container.AddScoped<ITokenValidationProvider, GoogleTokenValidationProvider>();

            // Notification Providers
            container.AddTransient<INotificationProvider, ElementaryNotificationProvider>();
            container.AddTransient<INotificationProvider, SecondaryNotificationProvider>();
            container.AddTransient<INotificationProvider, CampusNotificationProvider>();

            container.AddScoped<IImageProvider, ConventionBasedImageProvider>();
            container.AddScoped<IMessagingProvider, EmailMessagingProvider>();
            container.AddScoped<IPdfProvider, PdfProvider>();
        }
    }
}
