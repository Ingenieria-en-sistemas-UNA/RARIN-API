using System.IO;
using System.Reflection;
using System.Threading.Tasks;
using DinkToPdf;
using DinkToPdf.Contracts;
using Microsoft.EntityFrameworkCore;
using Rarin_Technologies_API.Contexts;
using RazorLight;

namespace Rarin_Technologies_API.Abstraction
{
    public class ReportService : IReportService
    {
        private readonly IRazorLightEngine _razorEngine;
        private readonly IConverter _pdfConverter;
        private readonly ApplicationDbContext _context;
        private readonly GlobalSettings _globalSettings;
        private readonly ObjectSettings _objectSettings;

        public ReportService(IRazorLightEngine razorEngine,IConverter pdfConverter, ApplicationDbContext context)
        {
            _razorEngine = razorEngine;
            _pdfConverter = pdfConverter;
            this._context = context;
            _globalSettings = new GlobalSettings
            {
                ColorMode = ColorMode.Color,
                Orientation = Orientation.Portrait,
                PaperSize = PaperKind.A4,
                Margins = new MarginSettings() { Top = 10, Bottom = 10, Left = 10, Right = 10 },

            };

            _objectSettings = new ObjectSettings
            {
                PagesCount = true,
                WebSettings = { DefaultEncoding = "utf-8" },
               HeaderSettings = { FontName = "Arial", FontSize = 12, Line = true },
                FooterSettings = { FontName = "Arial", FontSize = 12, Line = true, Right = "Page [page] of [toPage]" }
            };

          
        }

        public async Task<byte[]> Create()
        {
            var model = Data.CarRepository.GetCars();
            var templatePath = Path.GetFullPath("~/Templates/PDFTemplate.cshtml").Replace("~\\", "");
            string template = await _razorEngine.CompileRenderAsync(templatePath,model);

            _globalSettings.DocumentTitle = "Reporte de Car";
            _objectSettings.HtmlContent = template;

            var pdf = new HtmlToPdfDocument()
            {

                GlobalSettings = _globalSettings,
                Objects = { _objectSettings }
            };

            byte[] file = _pdfConverter.Convert(pdf);

            return file;
        }
    

        public async Task<byte[]> CreateCategoryReport()
        {
            var categories = await _context.Categories.ToListAsync();
            var templatePath = Path.GetFullPath("~/Templates/ReporteCategoria.cshtml").Replace("~\\", "");
            string template = await _razorEngine.CompileRenderAsync(templatePath, categories);


            _globalSettings.DocumentTitle = "Reporte de Categorias";
            _objectSettings.HtmlContent = template;

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = _globalSettings,
                Objects = { _objectSettings }
            };

            byte[] file = _pdfConverter.Convert(pdf);

            return file;
        }


        public  async Task<byte[]> CreateClienteReport()
        {
            var clients = await _context.Clients.ToListAsync();
            var templatePath = Path.GetFullPath("~/Templates/ReporteCliente.cshtml").Replace("~\\", "");
            string template = await _razorEngine.CompileRenderAsync(templatePath, clients);

            _globalSettings.DocumentTitle = "Reporte de Cliente";
            _objectSettings.HtmlContent = template;

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = _globalSettings,
                Objects = { _objectSettings }
            };

            byte[] file = _pdfConverter.Convert(pdf);

            return file;
        }

        public async Task<byte[]> CreateProductReport()
        {
            var products = await _context.Products.ToListAsync();
            var templatePath = Path.GetFullPath("~/Templates/ReporteProduct.cshtml").Replace("~\\", "");
            string template = await _razorEngine.CompileRenderAsync(templatePath, products);

            _globalSettings.DocumentTitle = "Reporte de Producto";
            _objectSettings.HtmlContent = template;

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = _globalSettings,
                Objects = { _objectSettings }
            };

            byte[] file = _pdfConverter.Convert(pdf);

            return file;
        }

        public async Task<byte[]> CreateShoppingCarReport()
        {
            var shoppingCar = await _context.Products.ToListAsync();
            var templatePath = Path.GetFullPath("~/Templates/ReporteShoppingCars.cshtml").Replace("~\\", "");
            string template = await _razorEngine.CompileRenderAsync(templatePath, shoppingCar);

            _globalSettings.DocumentTitle = "Reporte de Tarjeta de Compras";
            _objectSettings.HtmlContent = template;

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = _globalSettings,
                Objects = { _objectSettings }
            };

            byte[] file = _pdfConverter.Convert(pdf);

            return file;
        }

     

        public async Task<byte[]> CreateUsersReport()
        {
            var users = await _context.Products.ToListAsync();
            var templatePath = Path.GetFullPath("~/Templates/ReporteUsuario.cshtml").Replace("~\\", "");
            string template = await _razorEngine.CompileRenderAsync(templatePath, users);

            _globalSettings.DocumentTitle = "Reporte de Usuarios";
            _objectSettings.HtmlContent = template;

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = _globalSettings,
                Objects = { _objectSettings }
            };

            byte[] file = _pdfConverter.Convert(pdf);

            return file;
        }

        public async Task<byte[]> CreateVoucherReport()
        {
            var vouchers = await _context.Products.ToListAsync();
            var templatePath = Path.GetFullPath("~/Templates/ReporteVoucher.cshtml").Replace("~\\", "");
            string template = await _razorEngine.CompileRenderAsync(templatePath, vouchers);

            _globalSettings.DocumentTitle = "Reporte de Vouchers";
            _objectSettings.HtmlContent = template;

            var pdf = new HtmlToPdfDocument()
            {
                GlobalSettings = _globalSettings,
                Objects = { _objectSettings }
            };

            byte[] file = _pdfConverter.Convert(pdf);

            return file;
        }
    }
}
