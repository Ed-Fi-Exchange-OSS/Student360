// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Security.Principal;
using System.Threading.Tasks;

namespace SMCISD.Student360.Persistence.Grid
{
    public interface IGridData
    {
        public Task<GridResponse> GetGridData(GridRequest request, IPrincipal currentUser);
    }
}
