// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.EntityFrameworkCore;
using SMCISD.Student360.Persistence.Auth;
using SMCISD.Student360.Persistence.EntityFramework;
using SMCISD.Student360.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SMCISD.Student360.Persistence.Commands
{
    public interface IStaffAccessLevelCommands
    {
        Task<List<StaffAccessLevel>> Get();
    }

    public class StaffAccessLevelCommands : IStaffAccessLevelCommands

    {
        private readonly Student360Context _db;
        private readonly IAuthenticationProvider _auth;

        public StaffAccessLevelCommands(Student360Context db, IAuthenticationProvider auth)
        {
            _db = db;
            _auth = auth;
        }

        

        public async Task<List<StaffAccessLevel>> Get()
        {
            return await _db.StaffAccessLevel.ToListAsync();          
            
        }

       
    }
}
