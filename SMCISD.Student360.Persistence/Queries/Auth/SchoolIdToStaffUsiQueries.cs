// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.EntityFramework;
using SMCISD.Student360.Persistence.Models;
using System.Linq;

namespace SMCISD.Student360.Persistence.Queries.Auth
{
    public interface ISchoolIdToStaffUsiQueries
    {
        IQueryable<SchoolIdToStaffUsi> GetStaffSchools(int staffUsi);
    }

    public class SchoolIdToStaffUsiQueries : ISchoolIdToStaffUsiQueries

    {
        private readonly Student360Context _db;

        public SchoolIdToStaffUsiQueries(Student360Context db)
        {
            _db = db;
        }
        public IQueryable<SchoolIdToStaffUsi> GetStaffSchools(int staffUsi) =>  _db.SchoolIdToStaffUsi.Where(x => x.StaffUsi == staffUsi);

    }
}
