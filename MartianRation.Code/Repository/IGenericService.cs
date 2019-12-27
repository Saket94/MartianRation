using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MartianRation.Code.Repository
{   
    public interface IGenericService<T> where T : class
    {
        /// <summary>
        /// Here defined GetAll method implemented in the GenericSrvice Class.
        /// </summary>
        IEnumerable<T> GetAll();

        /// <summary>
        /// Here defined GetById method implemented in the GenericSrvice Class.
        /// </summary>
        T GetById(object id);

        /// <summary>
        /// Here defined Insert method implemented in the GenericSrvice Class.
        /// </summary>
        void Insert(T obj);

        /// <summary>
        /// Here defined Update method implemented in the GenericSrvice Class.
        /// </summary>
        void Update(T obj);

        /// <summary>
        /// Here defined Delete method implemented in the GenericSrvice Class.
        /// </summary>
        void Delete(object id);

        /// <summary>
        /// Here defined Save method implemented in the GenericSrvice Class.
        /// </summary>
        void Save();       
    }
}
