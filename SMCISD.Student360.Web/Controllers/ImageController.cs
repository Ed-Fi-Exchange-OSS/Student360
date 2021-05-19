// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMCISD.Student360.Persistence.Grid;
using SMCISD.Student360.Resources.Providers.Image;
using SMCISD.Student360.Web.Attributes;

namespace SMCISD.Student360.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ImageController : ControllerBase
    {
        private readonly IImageProvider _imgProvider;
        public ImageController(IImageProvider imgProvider)
        {
            _imgProvider = imgProvider;
        }

        [HttpGet("student/{studentUniqueId}")]
        public async Task<ActionResult<string>> GetStudentProfile(string studentUniqueId)
        {
            return await _imgProvider.GetStudentImageUrlAsync(studentUniqueId);
        }
    }
}
