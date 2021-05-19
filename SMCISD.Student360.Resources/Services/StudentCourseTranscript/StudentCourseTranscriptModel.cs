// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

namespace SMCISD.Student360.Resources.Services.StudentCourseTranscript
{
    public class StudentCourseTranscriptModel
    {
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public short SchoolYear { get; set; }
        public int SchoolId { get; set; }
        public int? LocalEducationAgencyId { get; set; }
        public int StudentUsi { get; set; }
        public decimal? FinalNumericGradeEarned { get; set; }
        public decimal? AttemptedCredits { get; set; }
        public decimal EarnedCredits { get; set; }
    }
}
