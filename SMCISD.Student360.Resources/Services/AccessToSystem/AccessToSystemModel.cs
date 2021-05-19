// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace SMCISD.Student360.Resources.Services.AccessToSystem
{
    public class AccessToSystemModel
    {
        public long Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public DateTime LastLogin { get; set; }
        public string SchoolCode { get; set; }
    }
}
