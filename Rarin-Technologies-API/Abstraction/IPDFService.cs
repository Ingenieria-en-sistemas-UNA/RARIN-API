using System.Threading.Tasks;

namespace Rarin_Technologies_API.Abstraction
{
    public interface IPDFService
    {
        Task<byte[]> Create();
    }
}
