﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence;
using SMCISD.Student360.Persistence.Auth;
using System;
using System.Collections.Generic;
using System.Text;

namespace SMCISD.Student360.Resources.Services.People
{
    public interface ICurrentUser
    {
        public int Usi { get; set; }
        public string UniqueId { get; set; }
        public string FirstName { get; set; }
        public string LastSurname { get; set; }
        public string ElectronicMailAddress { get; set; }
        public string Role { get; set; }
        public string AccessLevel { get; set; }
        public List<EdOrgAssociation> EdOrgAssociations { get; set; }
        public int? SchoolId { get; set; }
        public int? LocalEducationAgencyId { get; set; }
    }
    public class PeopleModel : ICurrentUser
    {
        public int Usi { get; set; }
        public string UniqueId { get; set; }
        public string FirstName { get; set; }
        public string LastSurname { get; set; }
        public string ElectronicMailAddress { get; set; }
        public string Role { get; set; }
        public string AccessLevel { get; set; } 
        public string LevelId { get; set; }
        public List<EdOrgAssociation> EdOrgAssociations { get; set; }
        public int? SchoolId { get; set; }
        public int? LocalEducationAgencyId { get; set; }
    }
}
