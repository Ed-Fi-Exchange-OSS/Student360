// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMCISD.Student360.Persistence.Models
{
    public partial class StudentCourseTranscript
    {
        [StringLength(60)]
        public string CourseCode { get; set; }
        [StringLength(60)]
        public string CourseTitle { get; set; }
        public short SchoolYear { get; set; }
        public int SchoolId { get; set; }
        public int? LocalEducationAgencyId { get; set; }
        [Column("StudentUSI")]
        public int StudentUsi { get; set; }
        [Column(TypeName = "decimal(9, 2)")]
        public decimal? FinalNumericGradeEarned { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal? AttemptedCredits { get; set; }
        [Column(TypeName = "decimal(9, 3)")]
        public decimal EarnedCredits { get; set; }
        [Required]
        [StringLength(50)]
        public string CodeValue { get; set; }
    }
}
