// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Resources.Services.Reasons;
using System;

namespace SMCISD.Student360.Resources.Services.StudentExtraHours
{
    public class StudentExtraHoursModel
    {
        public int StudentExtraHoursId { get; set; }
        public int Version { get; set; }
        public string StudentUniqueId { get; set; }
        public string GradeLevel { get; set; }
        public string FirstName { get; set; }
        public string LastSurname { get; set; }
        public DateTime Date { get; set; }
        public int? Hours { get; set; }
        public short SchoolYear { get; set; }
        public string UserCreatedUniqueId { get; set; }
        public string UserRole { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastSurname { get; set; }
        public string UserName { get => UserFirstName + " " + UserLastSurname; }
        public string Comments { get; set; }
        public int ReasonId { get; set; }
        public ReasonsModel Reason { get; set; }
        public DateTime CreateDate { get; set; }
        public Guid Id { get; set; }
    }
}
