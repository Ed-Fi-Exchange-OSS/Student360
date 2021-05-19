// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

namespace SMCISD.Student360.Resources.Services.StudentHighestAbsenceCourseCount
{
    public class StudentHighestAbsenceCourseCountModel
    {
        public int StudentUsi { get; set; }
        public string FirstName { get; set; }
        public string LastSurname { get; set; }
        public string GradeLevel { get; set; }
        public short? GraduationSchoolYear { get; set; }
        public short SchoolYear { get; set; }
        public string NameOfInstitution { get; set; }
        public int? HighestCourseCount { get; set; }
        public int SchoolId { get; set; }
        public string StudentUniqueId { get; set; }
        public string GradeDescription { get; set; }
    }
}
