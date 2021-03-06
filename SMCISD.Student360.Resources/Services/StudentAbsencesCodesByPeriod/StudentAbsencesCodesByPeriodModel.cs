﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace SMCISD.Student360.Resources.Services.StudentAbsencesCodesByPeriod
{
    public class StudentAbsencesCodesByPeriodModel
    {
        public int StudentUsi { get; set; }
        public string ClassPeriodName { get; set; }

        public List<AbsencesCodesByPeriodModel> AbsenceCodes { get; set; }
    }

    public class AbsencesCodesByPeriodModel
    {
        public string AbsenceCode { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
    }

    public class GeneralStudentDnaDataModel
    {
        public List<StudentAbsencesCodesByPeriodModel> Periods { get; set; }
        public string NameOfInstitution { get; set; }
        public string StreetNumberName { get; set; }
        public string ApartmentRoomSuiteNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public decimal? Gpa { get; set; }
    }
}
