using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rarin_Technologies_API.Abstraction;

namespace Rarin_Technologies_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PdfsController : ControllerBase
    {
        private readonly IPDFService _pdfService;

        public PdfsController(IPDFService pdfService)
        {
            _pdfService = pdfService;
        }

        [HttpGet("Create")]
        public async Task<IActionResult> CreatePdf()
        {
            var file = await _pdfService.Create();
            return File(file, "application/pdf");
        }
    }
}