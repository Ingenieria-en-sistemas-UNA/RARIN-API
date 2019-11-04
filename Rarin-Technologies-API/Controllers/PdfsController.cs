using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rarin_Technologies_API.Abstraction;

namespace Rarin_Technologies_API.Controllers
{
    [EnableCors("AllowOrigin")]
    [Route("api/[controller]")]
    [ApiController]
    public class PdfsController : ControllerBase
    {
        private readonly IPDFService _pdfService;

        public PdfsController(IPDFService pdfService)
        {
            _pdfService = pdfService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Member")]
        [HttpGet("Create")]
        public async Task<IActionResult> CreatePdf()
        {
            var file = await _pdfService.Create();
            return File(file, "application/pdf");
        }
    }
}