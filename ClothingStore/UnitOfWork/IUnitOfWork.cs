using ClothingStore.Repositories;
using System.Threading.Tasks;

namespace ClothingStore.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        Task CompleteAsync();

    }
}
