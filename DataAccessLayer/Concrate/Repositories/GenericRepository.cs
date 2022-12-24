﻿using DataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrate.Repositories
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {

        Context c = new Context();
        DbSet<T> _object;

        public GenericRepository()
        {
                _object = c.Set<T>();
        }
        public void Delete(T category)
        {
            var deletedEntity=c.Entry(category);
            deletedEntity.State = EntityState.Deleted;
            c.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> filter)
        {
            return _object.SingleOrDefault(filter);
        }

        public void Insert(T category)
        {
            var addedEntity= c.Entry(category);
            addedEntity.State = EntityState.Added;
           // _object.Add(category);
            c.SaveChanges();
        }

        public List<T> List()
        {
            return _object.ToList();
        }

      
        public List<T> List(Expression<Func<T, bool>> filter)
        {
            return _object.Where(filter).ToList(); 
        }

        public void Update(T category)
        {
            var updatedEntity= c.Entry(category);
            updatedEntity.State = EntityState.Modified;
            c.SaveChanges();
        }
    }
}
