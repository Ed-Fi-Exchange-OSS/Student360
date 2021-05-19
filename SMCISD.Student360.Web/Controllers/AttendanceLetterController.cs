// SPDX-License-Identifier: Apache-2.0
// Licensed to the Ed-Fi Alliance under one or more agreements.
// The Ed-Fi Alliance licenses this file to you under the Apache License, Version 2.0.
// See the LICENSE and NOTICES files in the project root for more information.

using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMCISD.Student360.Persistence.Grid;
using SMCISD.Student360.Resources.Services.AttendanceLetters;
using SMCISD.Student360.Web.Attributes;

namespace SMCISD.Student360.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AttendanceLetterController : ControllerBase
    {
        private readonly IAttendanceLetterService _service;
        public AttendanceLetterController(IAttendanceLetterService service)
        {
            _service = service;
        }

        [HttpPost()]
        public async Task<ActionResult<GridResponse>> GetGridData([FromBody]GridRequest request)
        {
            return await _service.GetGridData(request, User);
        }

        [NoAuthFilter]
        [HttpGet("status")]
        public async Task<ActionResult<List<AttendanceLetterStatusModel>>> GetAttendanceLetterStatus()
        {
            return await _service.GetAttendanceLetterStatus();
        }

        [NoAuthFilter]
        [HttpPut("bulk")]
        public async Task<ActionResult<List<AttendanceLetterModel>>> UpdateAttendanceLetterBulk([FromBody] List<AttendanceLetterModel> letters)
        {
            return await _service.UpdateLetterBulk(letters, User);
        }

        [NoAuthFilter]
        [HttpPut("send")]
        public async Task<ActionResult> SendAttendanceLetterBulk([FromBody] List<AttendanceLetterModel> letters)
        {
            var pdf = await _service.SendLetterBulk(letters, User);
            Response.Headers.Add("Access-Control-Expose-Headers","*");
            return File(pdf.FileContent, "application/octet-stream", fileDownloadName: pdf.FileName);
        }

        [NoAuthFilter]
        [HttpPut("reprint")]
        public async Task<ActionResult> ReprintAttendanceLetterBulk([FromBody] List<AttendanceLetterModel> letters)
        {
            var pdf = await _service.ReprintLetterBulk(letters, User);
            Response.Headers.Add("Access-Control-Expose-Headers", "*");
            return File(pdf.FileContent, "application/zip", fileDownloadName: pdf.FileName);
        }
    }
}
