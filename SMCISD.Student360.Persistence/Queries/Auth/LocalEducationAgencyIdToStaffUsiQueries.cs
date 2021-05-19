// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.EntityFramework;
using SMCISD.Student360.Persistence.Models;
using System.Linq;

namespace SMCISD.Student360.Persistence.Queries.Auth
{
    public interface ILocalEducationAgencyIdToStaffUsiQueries
    {
        IQueryable<LocalEducationAgencyIdToStaffUsi> GetStaffLocalEducationAgencies(int staffUsi);
    }

    public class LocalEducationAgencyIdToStaffUsiQueries : ILocalEducationAgencyIdToStaffUsiQueries

    {
        private readonly Student360Context _db;

        public LocalEducationAgencyIdToStaffUsiQueries(Student360Context db)
        {
            _db = db;
        }
        public IQueryable<LocalEducationAgencyIdToStaffUsi> GetStaffLocalEducationAgencies(int staffUsi) =>  _db.LocalEducationAgencyIdToStaffUsi.Where(x => x.StaffUsi == staffUsi);

    }
}
