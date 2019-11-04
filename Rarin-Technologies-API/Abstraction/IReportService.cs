using System.Threading.Tasks;

namespace Rarin_Technologies_API.Abstraction
{
    public interface IReportService
    {
        Task<byte[]> Create();

        Task<byte[]> CreateCategoryReport();
        Task<byte[]> CreateProductReport();
        Task<byte[]> CreateClienteReport();
        Task<byte[]> CreateVoucherReport();
        Task<byte[]> CreatePersonReport();
        Task <byte[]>CreateShoppingCarReport();
       Task<byte[]> CreateVoucherPdfByController(int id);
       // Task<byte[]> CreateVoucherPdfByController();
       // Task CreateVoucherPdfByController(int id);
    }
}
