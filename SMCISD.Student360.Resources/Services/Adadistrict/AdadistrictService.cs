﻿// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCISD.Student360.Resources.Services.Adadistrict
{
    public interface IAdadistrictService 
    {
        Task<List<AdadistrictModel>> Get();
    }

    public class AdadistrictService : IAdadistrictService
    {
        private readonly IAdadistrictQueries _queries;
        public AdadistrictService(IAdadistrictQueries queries)
        {
            _queries = queries;
        }

        public async Task<List<AdadistrictModel>> Get()
        {
            var entityList = await _queries.Get();

            return entityList.Select(x => MapAdadistrictEntityToAdadistrictModel(x)).ToList();
        }

        private Persistence.Models.Adadistrict MapAdadistrictModelToAdadistrictEntity(AdadistrictModel model)
        {
            return new Persistence.Models.Adadistrict
            {
               StudentAttendance = model.StudentAttendance,
               MaxStudentAttendance = model.MaxStudentAttendance,
               AttendancePercent = model.AttendancePercent
            };
        }

        private AdadistrictModel MapAdadistrictEntityToAdadistrictModel(Persistence.Models.Adadistrict entity)
        {
            return new AdadistrictModel
            {
                StudentAttendance = entity.StudentAttendance,
                MaxStudentAttendance = entity.MaxStudentAttendance,
                AttendancePercent = entity.AttendancePercent
            };
        }

    }
}
