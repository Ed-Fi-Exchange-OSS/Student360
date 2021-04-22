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
    [Table("AttendanceLetterType", Schema = "student360")]
    public partial class AttendanceLetterType
    {
        public AttendanceLetterType()
        {
            AttendanceLetters = new HashSet<AttendanceLetters>();
        }

        [Key]
        public int AttendanceLetterTypeId { get; set; }
        [Required]
        [StringLength(50)]
        public string CodeValue { get; set; }
        [Required]
        [StringLength(75)]
        public string ShortDescription { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid Id { get; set; }

        [InverseProperty("AttendanceLetterType")]
        public virtual ICollection<AttendanceLetters> AttendanceLetters { get; set; }
    }
}
