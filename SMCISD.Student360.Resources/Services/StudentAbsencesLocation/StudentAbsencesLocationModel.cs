// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.Security;

namespace SMCISD.Student360.Resources.Services.StudentAbsencesLocation
{
    public class StudentAbsencesLocationModel : IStudent
    {
        public int StudentUsi { get; set; }
        public string StudentUniqueId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastSurname { get; set; }
        public string GradeLevel { get; set; }
        public short? GraduationSchoolYear { get; set; }
        public short? SchoolYear { get; set; }
        public int SchoolId { get; set; }
        public int? LocalEducationAgencyId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int? AdaAbsences { get; set; }
        public int? HighestCourseCount { get; set; }
        public int? DaysFromLastAbsence { get; set; }
    }

}
