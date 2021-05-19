// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using SMCISD.Student360.Persistence.Security;

namespace SMCISD.Student360.Persistence.Models
{
    public partial class StudentHighestAbsenceCourseCount : IStudent { }

    public partial class StudentAbsencesLocation : IStudent { }
    public partial class StudentExtraHourGrid : IStudent { }
    public partial class StudentExtraHourCurrentGrid : IStudent { }

    public partial class StudentExtraHourHistory : IStudent { }

    public partial class StudentAttendanceDetail : IStudent { }
    public partial class Schools : ISchool { }
    public partial class StudentCourseTranscript : IStudent { }

    public partial class StudentAbsencesByCourse : IStudent { }

    public partial class AttendanceLetterGrid : IStudent { }

}
 