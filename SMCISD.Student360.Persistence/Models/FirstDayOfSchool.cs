﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SMCISD.Student360.Persistence.Models
{
    public partial class FirstDayOfSchool
    {
        [Column(TypeName = "date")]
        public DateTime? Date { get; set; }
    }
}
