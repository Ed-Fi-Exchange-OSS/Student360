// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.EntityFramework;
using SMCISD.Student360.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCISD.Student360.Persistence.Queries
{
    public interface IReportQueries
    {
        Task<List<Report>> Get(int accessLevel);
    }
    public class ReportQueries : IReportQueries
    {
        private readonly Student360Context _db;

        public ReportQueries(Student360Context db)
        {
            _db = db;
        }
        public async Task<List<Report>> Get(int accessLevel)
        {
            // return _db.Report.Where(x => x.LevelId == accessLevel).ToList();
            return _db.Report.ToList();
        }
    }
}
