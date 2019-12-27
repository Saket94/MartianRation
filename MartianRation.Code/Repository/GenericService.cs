using MartianRation.Data.Edmx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;

namespace MartianRation.Code.Repository
{
    public class GenericService<T> : IGenericService<T> where T : class
    {
        private MartianRationDBEntities _context = null;
        private DbSet<T> table = null;

        /// <summary>
        /// Generic class constructor. 
        /// </summary>
        public GenericService()
        {
            this._context = new MartianRationDBEntities();
            table = _context.Set<T>();
        }

        /// <summary>
        /// Generic class parameterize constructor. 
        /// </summary>
        public GenericService(MartianRationDBEntities _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }

        /// <summary>
        /// This method used to get all data.
        /// It is return table record as IEnumerable<T> type 
        /// </summary>
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        /// <summary>
        /// This method used to get record by id.
        /// It is return one record as T type 
        /// </summary>
        public T GetById(object id)
        {
            return table.Find(id);
        }

        /// <summary>
        /// This method used to insert record in the database table.
        /// In this method pass table type object as parameter.
        /// It's return type is void.
        /// </summary>
        public void Insert(T obj)
        {
            table.Add(obj);
        }

        /// <summary>
        /// This method used to update record in the database table.
        /// In this method pass table type object as parameter.
        /// It's return type is void.
        /// </summary>
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }

        /// <summary>
        /// This method used to delete record from the database table.
        /// In this method pass  object type id as parameter.
        /// It's return type is void.
        /// </summary>
        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        /// <summary>
        /// This method used to save changes in the database table.       
        /// It's return type is void.
        /// </summary>
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
