using System.Threading.Tasks;
using ClothingStore.Repositories;
using ClothingStore.Models;

namespace ClothingStore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClothingStoreContext _context;

        public IProductRepository Products { get; }

        public UnitOfWork(ClothingStoreContext context, IProductRepository productRepository)
        {
            _context = context;
            Products = productRepository;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
