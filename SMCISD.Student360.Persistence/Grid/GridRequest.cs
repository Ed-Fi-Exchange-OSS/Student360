// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Collections.Generic;
using System.Linq;

namespace SMCISD.Student360.Persistence.Grid
{
    public class GridRequest
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public string SearchTerm { get; set; }
        public List<OrderByProperties> OrderBy { get; set; } = new List<OrderByProperties>();

        public List<Filter> Filters { get; set; } = new List<Filter>();

        public List<string> Select { get; set; } = new List<string>();

        public bool AllData { get; set; } = false;

    }


    public class OrderByProperties {
        public string Column { get; set; }
        public string Direction { get; set; } = "Ascending";
    }

    public class Filter
    {
        public string Column { get; set; }
        public string Operator { get; set; } = "==";
        public object Value { get; set; }

        public string Type { get; set; }
    }
}
