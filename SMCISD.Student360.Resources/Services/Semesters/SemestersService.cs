// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.Queries;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCISD.Student360.Resources.Services.Semesters
{
    public interface ISemestersService 
    {
        Task<List<SemestersModel>> Get();
    }

    public class SemestersService : ISemestersService
    {
        private readonly ISemestersQueries _queries;
        public SemestersService(ISemestersQueries queries)
        {
            _queries = queries;
        }

        public async Task<List<SemestersModel>> Get()
        {
            var entityList = await _queries.Get();

            return entityList.Select(x => MapSemestersEntityToSemestersModel(x)).ToList();
        }
        private Persistence.Models.Semesters MapSemestersModelToSemestersEntity(SemestersModel model)
        {
            return new Persistence.Models.Semesters
            {
              SessionName = model.SessionName
            };
        }

        private SemestersModel MapSemestersEntityToSemestersModel(Persistence.Models.Semesters entity)
        {
            return new SemestersModel
            {
                SessionName = entity.SessionName
            };
        }

    }
}
