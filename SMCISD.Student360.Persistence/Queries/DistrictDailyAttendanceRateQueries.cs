﻿using Microsoft.EntityFrameworkCore;
using SMCISD.Student360.Persistence.EntityFramework;
using SMCISD.Student360.Persistence.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCISD.Student360.Persistence.Queries
{
    public interface IDistrictDailyAttendanceRateQueries 
    {
        Task<List<DistrictDailyAttendanceRate>> Get();  
    }

    public class DistrictDailyAttendanceRateQueries : IDistrictDailyAttendanceRateQueries

    {
        private readonly Student360Context _db;

        public DistrictDailyAttendanceRateQueries(Student360Context db)
        {
            _db = db;
        }
        public async Task<List<DistrictDailyAttendanceRate>> Get() => await _db.DistrictDailyAttendanceRate.ToListAsync();
    }
}
