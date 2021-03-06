﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMCISD.Student360.Persistence.Models
{
    public partial class AttendanceLetterGrid
    {
        public int AttendanceLetterId { get; set; }
        public int AttendanceLetterTypeId { get; set; }
        public int AttendanceLetterStatusId { get; set; }
        [Required]
        [StringLength(60)]
        public string ClassPeriodName { get; set; }
        public DateTime FirstAbsence { get; set; }
        public DateTime LastAbsence { get; set; }
        [Required]
        [StringLength(32)]
        public string StudentUniqueId { get; set; }
        [Required]
        [StringLength(75)]
        public string FirstName { get; set; }
        [StringLength(75)]
        public string MiddleName { get; set; }
        [Required]
        [StringLength(75)]
        public string LastSurname { get; set; }
        public string Comments { get; set; }
        public DateTime? ResolutionDate { get; set; }
        [Required]
        [StringLength(50)]
        public string GradeLevel { get; set; }
        public short SchoolYear { get; set; }
        public int SchoolId { get; set; }
        [StringLength(50)]
        public string UserCreatedUniqueId { get; set; }
        [StringLength(75)]
        public string UserFirstName { get; set; }
        [StringLength(75)]
        public string UserLastSurname { get; set; }
        [StringLength(100)]
        public string UserRole { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Status { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }
        public int? LocalEducationAgencyId { get; set; }
        [Column("StudentUSI")]
        public int StudentUsi { get; set; }
        public string GradeDescription { get; set; }
    }
}
