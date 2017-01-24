using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_MVC_Servicios.Servicios.Base
{
    public interface IServicio<TModel>
    {
        Task Add(TModel modelo);
        Task Update(TModel modelo);
        Task Delete(int id);
        List<TModel> Get();
        TModel Get(int id);
        List<TModel> Get(Dictionary<String, String> args);
    }
}
