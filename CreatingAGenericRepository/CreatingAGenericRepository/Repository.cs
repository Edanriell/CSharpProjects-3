﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CreatingAGenericRepository
{
    public interface IRepository<TAggregate>
        where TAggregate : class
    {
        int Create(TAggregate aggregate);
        void Delete(int id);
        void Update(TAggregate aggregate);
        TAggregate Get(int id);
        IEnumerable<TAggregate> Get();
        void Dispose();
    }

    public interface IAggregate
    {
        int Id { get; set; }
    }

    public class Repository<TAggregate> : IRepository<TAggregate>
        where TAggregate : class, IAggregate
    {
        private readonly DbSet<TAggregate> _dbSet;
        private readonly DbContext _context;

        public Repository(DbContext context)
        {
            _dbSet = context.Set<TAggregate>();
            _context = context;
        }

        public int Create(TAggregate aggregate)
        {
            var added = _dbSet.Add(aggregate);
            _context.SaveChanges();

            return added.Entity.Id;
        }

        public void Delete(int id)
        {
            var toRemove = _dbSet.Find(id);
            if (toRemove != null)
            {
                _dbSet.Remove(toRemove);
            }

            _context.SaveChanges();
        }

        public void Update(TAggregate aggregate)
        {
            _dbSet.Update(aggregate);
            _context.SaveChanges();
        }

        public TAggregate Get(int id)
        {
            return _dbSet.Find(id)!;
        }

        public IEnumerable<TAggregate> Get()
        {
            return _dbSet.ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
