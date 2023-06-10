using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Services.repository
{
    public class Repository<TObject> : Irepository<TObject> where TObject : class 
    {
        Context _context;


        public Repository(Context context )
        {
            _context = context;
        }



        public ICollection<TObject> GetAll()
        {
            return _context.Set<TObject>().ToList();
        }


        public TObject Get(int id)
        {
            return _context.Set<TObject>().Find(id);
        }

      

        public TObject Find(Expression<Func<TObject, bool>> match)
        {

            return _context.Set<TObject>().FirstOrDefault(match);
        }

    

        public ICollection<TObject> FindAll(Expression<Func<TObject, bool>> match)
        {
            return _context.Set<TObject>().Where(match).ToList();
        }

      

        public TObject Add(TObject t)
        {
            _context.Set<TObject>().Add(t);
            _context.SaveChanges();
            return t;
        }


        public TObject Update(TObject updated, int key)
        {
            if (updated == null)
                return null;

            TObject existing = _context.Set<TObject>().Find(key);
            if (existing != null)
            {
                _context.Entry(existing).CurrentValues.SetValues(updated);
                _context.SaveChanges();
            }
            return existing;
        }


        public TObject Update(TObject item)
        {
            _context.Entry(item).CurrentValues.SetValues(item);
            _context.SaveChanges();
            return item;
        }

        public TObject GetSingle(Expression<Func<TObject, bool>> prediacte)
        {
            var res = _context.Set<TObject>().Where(prediacte).FirstOrDefault();
            return res;
        }


        public void Delete(TObject t)
        {
            _context.Set<TObject>().Remove(t);
            _context.SaveChanges();
        }


    }


    }

