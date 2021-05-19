// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace SMCISD.Student360.Resources.Services.Schools
{
    public class EducationOrganiztionInformationModel
    {
        public string StreetNumberName { get; set; }
        public string NameOfInstitution { get; set; }
        public string ShortNameOfInstitution { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public int EducationOrganizationId { get; set; }
        public string PrincipalFirstName { get; set; }
        public string PrincipalMiddleName { get; set; }
        public string PrincipalLastSurname { get; set; }
    }
}
