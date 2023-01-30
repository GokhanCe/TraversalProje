using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Abstarct
{
    public interface IGenericService<T>
    {
        void TAdd(T t);
        void TDelete(T t);
        void Update(T t);
        List<T> TGetList();
        T TGetByID(int id);
    }
}
