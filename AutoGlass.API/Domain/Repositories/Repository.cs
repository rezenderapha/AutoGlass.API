using AutoGlass.API.Domain.Context;
using AutoGlass.API.Domain.Repositories.Interfaces;
using System;

namespace AutoGlass.API.Domain.Repositories
{
    public class Repository : IRepository
    {
        private readonly AutoGlassContext _context;
        public Repository(AutoGlassContext context)
        {
            _context = context;
        }
        public void Add<T>(T entity) where T : class
        {
            _context.Add(entity);
        }

        public void Update<T>(T entity) where T : class
        {
            _context.Update(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            _context.Remove(entity);
        }

        public bool SaveChanges()
        {
            try
            {
                return (_context.SaveChanges()) > 0;
            }
            catch (Exception)
            {
               
                return false;
            } 
        }
    }
}
