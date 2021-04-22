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
    public partial class Adacampus
    {
        [Required]
        [StringLength(75)]
        public string NameOfInstitution { get; set; }
        public int? StudentAttendance { get; set; }
        public int? MaxStudentAttendance { get; set; }
        [Column(TypeName = "decimal(29, 13)")]
        public decimal? AttendancePercent { get; set; }
    }
}
