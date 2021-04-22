// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace SMCISD.Student360.Resources.Services.AttendanceLetters
{
    public class AttendaceLetterTypeGridDataModel {
        public int Count { get; set; }
        public string Type { get; set; }
        public int TypeId { get; set; }
        public int MaxLetterAge { get; set; }
        public int AverageLetterAge { get; set; }
    }
}
