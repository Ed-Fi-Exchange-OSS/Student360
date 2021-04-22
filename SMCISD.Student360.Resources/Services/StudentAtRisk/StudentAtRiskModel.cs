﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.Security;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMCISD.Student360.Resources.Services.StudentAtRisk
{
    public partial class StudentAtRiskModel 
    {
        public int StudentUsi { get; set; }
        public bool IsHomeless { get; set; }
        public bool Section504 { get; set; }
        public bool Ar { get; set; }
        public bool Ssi { get; set; }
        public bool Ell { get; set; }
        public bool PREPregnant { get; set; }
        public bool PREParent { get; set; }
        public bool AEP { get; set; }
        public bool Expelled { get; set; }
        public bool Dropout { get; set; }
        public bool LEP { get; set; }
        public bool FosterCare { get; set; }
        public bool ResidentialPlacementFacility { get; set; }
        public bool Incarcerated { get; set; }
        public bool AdultEd { get; set; }
        public bool PRS { get; set; }
        public bool NotAdvanced { get; set; }
    }
}
