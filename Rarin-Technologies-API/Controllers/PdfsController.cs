using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
<<<<<<< HEAD
=======
using Microsoft.AspNetCore.Cors;
>>>>>>> f2a3a4595675d38487649a02402b6808f973bdb5
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
        private readonly IReportService _reportService;
        private object _pdfService;

        public PdfsController(IReportService reportService)
        {
            _reportService = reportService;
        }

        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Member")]
        [HttpGet("Create")]
        public async Task<IActionResult> CreatePdf()
        {
            var file = await _reportService.CreateCategoryReport();
            return File(file, "application/pdf");

        
        }
        [HttpGet("Product")]/**/
        public async Task<IActionResult> pdfProduct()
        {
            var file = await _reportService.CreateProductReport();
            return File(file, "application/pdf");
        }


        [HttpGet("Client")]
        public async Task<IActionResult> pdfClient()
        {
            var file = await _reportService.CreateClienteReport();
            return File(file, "application/pdf");
        }

        [HttpGet("Shopping")]/**/
        public async Task<IActionResult> pdfShoppingCar()
        {
            var file = await _reportService.CreateShoppingCarReport();
            return File(file, "application/pdf");
        }

        [HttpGet("User")]/**/
        public async Task<IActionResult> pdfUser()
        {
            var file = await _reportService.CreatePersonReport();
            return File(file, "application/pdf");
        }
        [HttpGet("Voucher")]
        public async Task<IActionResult> pdfVoucher()
        {
            var file = await _reportService.CreateVoucherReport();
            return File(file, "application/pdf");
        }
       // [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin,Member")]
        [HttpGet("create/vouchers/{id}")]
        public async Task<IActionResult> createVoucherById(int id)
        {
            var file = await _reportService.CreateVoucherPdfByController(id);
            return File(file, "application/pdf");
           
        }
    }

}
