// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.Queries;
using SMCISD.Student360.Resources.Services.Adadistrict;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCISD.Student360.Resources.Services.YtdschoolLevels
{
    public interface IYtdschoolLevelsService 
    {
        Task<List<YtdschoolLevelsModel>> Get();
    }

    public class YtdschoolLevelsService : IYtdschoolLevelsService
    {
        private readonly IYtdschoolLevelsQueries _queries;
        private readonly IAdadistrictService _adadistrictService;
        public YtdschoolLevelsService(IYtdschoolLevelsQueries queries, IAdadistrictService adadistrictService)
        {
            _queries = queries;
            _adadistrictService = adadistrictService;
        }

        public async Task<List<YtdschoolLevelsModel>> Get()
        {
            var entityList = await _queries.Get();

            return entityList.Select(x => MapYtdschoolLevelsEntityToYtdschoolLevelsModel(x)).ToList();
        }
      private Persistence.Models.YtdschoolLevels MapYtdschoolLevelsModelToYtdschoolLevelsEntity(YtdschoolLevelsModel model)
        {
            return new Persistence.Models.YtdschoolLevels
            {
                SchoolLevel = model.SchoolLevel,
                StudentAttendance = model.StudentAttendance,
                MaxStudentAttendance = model.MaxStudentAttendance,
                AttendancePercent = model.AttendancePercent,
                SchoolYear = model.SchoolYear
            };
        }

        private YtdschoolLevelsModel MapYtdschoolLevelsEntityToYtdschoolLevelsModel(Persistence.Models.YtdschoolLevels entity)
        {
            return new YtdschoolLevelsModel
            {
                SchoolLevel = entity.SchoolLevel,
                StudentAttendance = entity.StudentAttendance,
                MaxStudentAttendance = entity.MaxStudentAttendance,
                AttendancePercent = entity.AttendancePercent,
                SchoolYear = entity.SchoolYear
            };
        }
    }
}
