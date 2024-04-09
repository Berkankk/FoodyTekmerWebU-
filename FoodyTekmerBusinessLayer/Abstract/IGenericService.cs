using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodyTekmerBusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        void TAdd(T entity);  // Başlarında t harfi olmasının sebebi dtlayer da olan abstract ile karışmasın diye
        void TDelete(int id);
        void TUpdate(T entity);
        List<T> TGetAllList();
        T TGetById(int id);
    }
}
