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
    public partial class StudentAbsencesCodesByPeriod
    {
        [Required]
        [StringLength(50)]
        public string AbsenceCode { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        public int? Quantity { get; set; }
        [Column("StudentUSI")]
        public int StudentUsi { get; set; }
        [Required]
        [StringLength(60)]
        public string ClassPeriodName { get; set; }
    }
}
