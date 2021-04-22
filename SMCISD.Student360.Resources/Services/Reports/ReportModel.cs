﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

namespace SMCISD.Student360.Resources.Services.Reports
{
    public class ReportModel
    {
        public int Id { get; set; }
        public string ReportName { get; set; }
        public string ReportUri { get; set; }
        public int LevelId { get; set; }
    }
}
