// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCISD.Student360.Resources.Services.DistrictDailyAttendanceRate
{
    public interface IDistrictDailyAttendanceRateService 
    {
        Task<List<DistrictDailyAttendanceRateModel>> Get();
    }

    public class DistrictDailyAttendanceRateService : IDistrictDailyAttendanceRateService
    {
        private readonly IDistrictDailyAttendanceRateQueries _queries;
        public DistrictDailyAttendanceRateService(IDistrictDailyAttendanceRateQueries queries)
        {
            _queries = queries;
        }

        public async Task<List<DistrictDailyAttendanceRateModel>> Get()
        {
            var entityList = await _queries.Get();

            return entityList.Select(x => MapDistrictDailyAttendanceRateEntityToDistrictDailyAttendanceRateModel(x)).ToList();
        }

        private Persistence.Models.DistrictDailyAttendanceRate MapDistrictDailyAttendanceRateModelToDistrictDailyAttendanceRateEntity(DistrictDailyAttendanceRateModel model)
        {
            return new Persistence.Models.DistrictDailyAttendanceRate
            {
                Membership = model.Membership,
                Present = model.Present,
                Date = model.Date
            };
        }

        private DistrictDailyAttendanceRateModel MapDistrictDailyAttendanceRateEntityToDistrictDailyAttendanceRateModel(Persistence.Models.DistrictDailyAttendanceRate entity)
        {
            return new DistrictDailyAttendanceRateModel
            {
                Membership = entity.Membership,
                Present = entity.Present,
                Date = entity.Date
            };
        }

    }
}
