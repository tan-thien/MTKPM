﻿using ClothingStore.Repositories;
using System.Threading.Tasks;

namespace ClothingStore.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Categories { get; }
        IProductRepository Products { get; }
        Task CompleteAsync();

    }
}
