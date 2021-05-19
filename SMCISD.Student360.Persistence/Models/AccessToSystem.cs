// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMCISD.Student360.Persistence.Models
{
    [Table("AccessToSystem", Schema = "dbo")]
    public partial class AccessToSystem
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Email { get; set; }
        [Required]
        [StringLength(100)]
        public string FullName { get; set; }
        public DateTime LastLogin { get; set; }
        [Required]
        [StringLength(50)]
        public string SchoolCode { get; set; }
    }
}
