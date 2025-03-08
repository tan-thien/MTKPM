using System.Threading.Tasks;
using ClothingStore.Repositories;
using ClothingStore.Models;

namespace ClothingStore.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ClothingStoreContext _context;

        public ICategoryRepository Categories { get; }
        public IProductRepository Products { get; }

        public UnitOfWork(ClothingStoreContext context, IProductRepository productRepository)
        {
            _context = context;
            Categories = new CategoryRepository(context);
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
