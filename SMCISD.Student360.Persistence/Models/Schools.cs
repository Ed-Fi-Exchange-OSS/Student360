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
    public partial class Schools
    {
        public int SchoolId { get; set; }
        [Required]
        [StringLength(75)]
        public string NameOfInstitution { get; set; }
        [Required]
        [StringLength(50)]
        public string GradeLevel { get; set; }
        public int? LocalEducationAgencyId { get; set; }
    }
}
