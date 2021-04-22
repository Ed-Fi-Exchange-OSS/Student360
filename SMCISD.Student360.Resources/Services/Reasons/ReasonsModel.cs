// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace SMCISD.Student360.Resources.Services.Reasons
{
    public class ReasonsModel
    {
        public string Description { get; set; }
        public string Value { get; set; }
        public bool HasHours { get; set; }
        public int ReasonId { get; set; }

        public DateTime CreateDate { get; set; }
    }
}
