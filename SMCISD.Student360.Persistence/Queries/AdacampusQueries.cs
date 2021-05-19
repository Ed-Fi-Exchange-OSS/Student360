// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.EntityFrameworkCore;
using SMCISD.Student360.Persistence.EntityFramework;
using SMCISD.Student360.Persistence.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCISD.Student360.Persistence.Queries
{
    public interface IAdacampusQueries 
    {
        Task<List<Adacampus>> Get();  
    }

    public class AdacampusQueries : IAdacampusQueries

    {
        private readonly Student360Context _db;

        public AdacampusQueries(Student360Context db)
        {
            _db = db;
        }
        public async Task<List<Adacampus>> Get() => await _db.Adacampus.ToListAsync();
    }
}
