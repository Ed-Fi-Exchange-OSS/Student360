// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Text;

namespace SMCISD.Student360.Persistence.Enum
{
    public class AttendanceLetterStatusEnum : Enumeration<AttendanceLetterStatusEnum>
    {
        public static readonly AttendanceLetterStatusEnum AutoCancelled = new AttendanceLetterStatusEnum(1, "Auto-Cancelled");
        public static readonly AttendanceLetterStatusEnum AdminOverride = new AttendanceLetterStatusEnum(2, "Admin Override");
        public static readonly AttendanceLetterStatusEnum Sent = new AttendanceLetterStatusEnum(3, "Sent");
        public static readonly AttendanceLetterStatusEnum Open = new AttendanceLetterStatusEnum(4, "Open");
        public static readonly AttendanceLetterStatusEnum Archived = new AttendanceLetterStatusEnum(5, "Archived");
        public AttendanceLetterStatusEnum(int value, string displayName) : base(value, displayName)
        {
        }
    }
}
