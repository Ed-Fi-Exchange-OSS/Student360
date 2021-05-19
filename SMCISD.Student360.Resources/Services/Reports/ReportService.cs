// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.Extensions.Configuration;
using SMCISD.Student360.Persistence.Models;
using SMCISD.Student360.Persistence.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMCISD.Student360.Resources.Services.Reports
{
    public interface IReportService
    {
        Task<List<ReportModel>> Get(int accessLevel);
    }
    public class ReportService : IReportService
    {
        private readonly IReportQueries _queries;
        private readonly IConfiguration _config;
        public ReportService(IReportQueries queries, IConfiguration config)
        {
            _queries = queries;
            _config = config;
        }

        public async Task<List<ReportModel>> Get(int accessLevel)
        {
            var entityList = await _queries.Get(accessLevel);

            return entityList.Select(x => MapReportEntityToReportModel(x)).ToList();
        }

        private ReportModel MapReportEntityToReportModel(Persistence.Models.Report entity)
        {
            return new ReportModel
            {
                Id = entity.Id,
                ReportName = entity.ReportName,
                ReportUri = entity.ReportUri,
                LevelId = entity.LevelId.Value
            };
        }
    }
}
