// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace SMCISD.Student360.Resources.Services.StaffEducationOrganizationAssignmentAssociation
{
    public class StaffEducationOrganizationAssignmentAssociationModel
    {
        public Guid Id { get; set; }
        public DateTime BeginDate { get; set; }
        public int EducationOrganizationId { get; set; }
        public int StaffClassificationDescriptorId { get; set; }
        public int StaffUSI { get; set; }
        public string PositionTitle { get; set; }
        public DateTime? EndDate { get; set; }
        public int? OrderOfAssignment { get; set; }
        public int? EmploymentEducationOrganizationId { get; set; }
        public int? EmploymentStatusDescriptorId { get; set; }
        public DateTime? EmploymentHireDate { get; set; }
        public string CredentialIdentifier { get; set; }
        public int? StateOfIssueStateAbbreviationDescriptorId { get; set; }
        public string Discriminator { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
