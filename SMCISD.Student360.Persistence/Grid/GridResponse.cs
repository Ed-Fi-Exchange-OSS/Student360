// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Collections;
using System.Collections.Generic;

namespace SMCISD.Student360.Persistence.Grid
{
    public class GridResponse : IGridResponse
    {
        public IEnumerable<object> Data { get; set; }
        public int TotalCount { get; set; }
        public int FilteredCount { get; set; }
        public long QueryExecutionMs { get; set; }
        public IEnumerable<object> Metadata { get; set; }

    }

    public interface IGridResponse
    {
        public IEnumerable<object> Data { get; set; }
        public int TotalCount { get; set; }
        public int FilteredCount { get; set; }
        public long QueryExecutionMs { get; set; }
    }
}
