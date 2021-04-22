// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCISD.Student360.Resources.Services.Cohort
{
    public interface ICohortService 
    {
        Task<List<CohortModel>> Get();
    }

    public class CohortService : ICohortService
    {
        private readonly ICohortQueries _queries;
        public CohortService(ICohortQueries queries)
        {
            _queries = queries;
        }

        public async Task<List<CohortModel>> Get()
        {
            var entityList = await _queries.Get();

            return entityList.Select(x => MapCohortEntityToCohortModel(x)).ToList();
        }

        private Persistence.Models.Cohort MapCohortModelToCohortEntity(CohortModel model)
        {
            return new Persistence.Models.Cohort
            {
                GraduationSchoolYear = model.GraduationSchoolYear
            };
        }

        private CohortModel MapCohortEntityToCohortModel(Persistence.Models.Cohort entity)
        {
            return new CohortModel
            {
                GraduationSchoolYear = entity.GraduationSchoolYear
            };
        }

    }
}
