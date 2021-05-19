// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.



using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace SMCISD.Student360.Web.Attributes
{
    [AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = true)]
    public class NoAuthFilterAttribute : ActionFilterAttribute
    {
       
    }
}
