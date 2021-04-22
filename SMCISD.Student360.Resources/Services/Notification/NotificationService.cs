// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.Queries;
using SMCISD.Student360.Resources.Providers.Notifications;
using SMCISD.Student360.Resources.Services.StudentAbsencesForEmail;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCISD.Student360.Resources.Services.Notification
{
    public interface INotificationService 
    {
        Task SendNotifications();
    }

    public class NotificationService : INotificationService
    {
        private readonly IEnumerable<INotificationProvider> _providers;
        public NotificationService(IEnumerable<INotificationProvider> providers)
        {
            _providers = providers;
        }

        public async Task SendNotifications()
        {
            foreach (var provider in _providers)
             await provider.SendNotifications();
        }
    }
}
