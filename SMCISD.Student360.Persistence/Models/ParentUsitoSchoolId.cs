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
    public partial class ParentUsitoSchoolId
    {
        public int SchoolId { get; set; }
        [Column("ParentUSI")]
        public int ParentUsi { get; set; }
        [Column(TypeName = "date")]
        public DateTime? BeginDate { get; set; }
        [Column(TypeName = "date")]
        public DateTime? EndDate { get; set; }
        public long? Count { get; set; }
    }
}
