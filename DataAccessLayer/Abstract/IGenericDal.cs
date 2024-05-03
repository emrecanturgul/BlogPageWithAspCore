using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class 
    {    //generic amacı burda tnaımlanmış olan metotları tek tek Iblogdal da tanımlamamak 
        void Insert(T e);
        void Delete(T e);
        void Update(T e);
        List<T> GetListAll();
        T GetById(int id); 

    }
}
