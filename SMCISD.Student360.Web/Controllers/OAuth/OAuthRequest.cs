// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMCISD.Student360.Api.Controllers.OAuth
{
    public class OAuthRequest
    {
        public string Client_id { get; set; }
        public string Client_secret { get; set; }
        public string Grant_type { get; set; }
    }
}
