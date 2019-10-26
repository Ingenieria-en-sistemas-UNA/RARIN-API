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
        Task<byte[]> CreateUsersReport();
        Task <byte[]>CreateShoppingCarReport();
    }
}
