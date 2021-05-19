// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

namespace SMCISD.Student360.Resources.Services.YtdgradeLevel
{
    public class YtdgradeLevelModel
    {
        public int? StudentAttendance { get; set; }
        public int? MaxStudentAttendance { get; set; }
        public decimal? AttendancePercent { get; set; }
        public string GradeLevel { get; set; }
        public short? SchoolYear { get; set; }
    }

}
