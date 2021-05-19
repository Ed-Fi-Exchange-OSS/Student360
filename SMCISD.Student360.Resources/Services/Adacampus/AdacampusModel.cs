// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

namespace SMCISD.Student360.Resources.Services.Adacampus
{
    public class AdacampusModel
    {
        public string NameOfInstitution { get; set; }
        public int? StudentAttendance { get; set; }
        public int? MaxStudentAttendance { get; set; }
        public decimal? AttendancePercent { get; set; }
    }

}
