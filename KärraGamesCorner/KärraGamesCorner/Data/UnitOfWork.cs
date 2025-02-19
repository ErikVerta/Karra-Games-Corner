﻿using KärraGamesCorner.Data.Models;
using KärraGamesCorner.Interfaces;

namespace KärraGamesCorner.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<ApplicationUser> Users { get; private set; }
        public IRepository<Genre> Genres { get; private set; }
        public IRepository<Order> Orders { get; private set; }
        public IRepository<Product> Products { get; private set; }
        public IRepository<Token> Tokens { get; private set; }
        public IRepository<CartProduct> CartProducts { get; private set; }

        private readonly ApplicationDbContext context;

        public event Func<Task> OnChange;

        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;

            Users = new GenericRepository<ApplicationUser>(context);
            Genres = new GenericRepository<Genre>(context);
            Products = new GenericRepository<Product>(context);
            Tokens = new GenericRepository<Token>(context);
            CartProducts = new GenericRepository<CartProduct>(context);
            Orders = new GenericRepository<Order>(context);
        }

        public async Task CommitAsync()
        {
            try
            {
                await context.SaveChangesAsync();
                OnChange?.Invoke();
            }
            catch
            {
                throw;
            }
        }
    }
}
