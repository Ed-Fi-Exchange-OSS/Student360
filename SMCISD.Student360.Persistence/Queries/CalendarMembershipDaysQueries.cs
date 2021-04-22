// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using Microsoft.EntityFrameworkCore;
using SMCISD.Student360.Persistence.EntityFramework;
using SMCISD.Student360.Persistence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace SMCISD.Student360.Persistence.Queries
{
    public interface ICalendarMembershipDaysQueries
    {
        Task<List<CalendarMembershipDays>> Get();
        Task<CalendarMembershipDays> GetPastValidDateForEmails(int schoolId, int daysToSkip);
        Task<CalendarMembershipDays> GetFutureDateFromAbsenceDate(int schoolId, DateTime absenceDate, int days);
        Task<CalendarMembershipDays> GetPastDateFromAbsenceDate(int schoolId, DateTime absenceDate, int days);
    }

    public class CalendarMembershipDaysQueries : ICalendarMembershipDaysQueries

    {
        private readonly Student360Context _db;

        public CalendarMembershipDaysQueries(Student360Context db)
        {
            _db = db;
        }
        public async Task<List<CalendarMembershipDays>> Get() => await _db.CalendarMembershipDays.ToListAsync();

        public async Task<CalendarMembershipDays> GetPastValidDateForEmails(int schoolId, int daysToSkip)
        {
            var today = DateTime.Now.Date;
            return await _db.CalendarMembershipDays
                .Where(x => x.SchoolId == schoolId && x.Date.Date <= today)
                .OrderByDescending(x => x.Date).Skip(daysToSkip)
                .FirstOrDefaultAsync();
        }

        public async Task<CalendarMembershipDays> GetFutureDateFromAbsenceDate(int schoolId, DateTime absenceDate, int days)
        {
            var today = DateTime.Now.Date;
            var date = await _db.CalendarMembershipDays
                .Where(x => x.SchoolId == schoolId && x.Date.Date >= absenceDate)
                .OrderBy(x => x.Date).Skip(days)
                .FirstOrDefaultAsync();

            if (date == null)
                return await _db.CalendarMembershipDays.Where(x => x.SchoolId == schoolId).OrderByDescending(x => x.Date).FirstOrDefaultAsync();
            else
                return date;
        }

        public async Task<CalendarMembershipDays> GetPastDateFromAbsenceDate(int schoolId, DateTime absenceDate, int days)
        {
            var today = DateTime.Now.Date;
            var date = await _db.CalendarMembershipDays
                .Where(x => x.SchoolId == schoolId && x.Date.Date <= absenceDate)
                .OrderByDescending(x => x.Date)
                .Skip(days)
                .FirstOrDefaultAsync();

            if (date == null)
                return await _db.CalendarMembershipDays.Where(x => x.SchoolId == schoolId).OrderBy(x => x.Date).FirstOrDefaultAsync();
            else
                return date;
        }
    }
}

