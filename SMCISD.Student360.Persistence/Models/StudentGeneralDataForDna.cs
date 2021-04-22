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
    public partial class StudentGeneralDataForDna
    {
        [Column("StudentUSI")]
        public int StudentUsi { get; set; }
        [Required]
        [StringLength(75)]
        public string NameOfInstitution { get; set; }
        [Required]
        [StringLength(150)]
        public string StreetNumberName { get; set; }
        [StringLength(50)]
        public string ApartmentRoomSuiteNumber { get; set; }
        [Required]
        [StringLength(30)]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        public string State { get; set; }
        [Required]
        [StringLength(17)]
        public string PostalCode { get; set; }
        [Column(TypeName = "decimal(18, 4)")]
        public decimal? Gpa { get; set; }
        public string Sex { get; set; }
    }
}
