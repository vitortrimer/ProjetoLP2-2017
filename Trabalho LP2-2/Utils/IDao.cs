using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabalho_LP2_2
{
    interface IDao
    {
        void Create(Object o);
        Object Read(int key);
        void Update(Object o);
        void Delete(int codigo);
        List<Object> ListAll();
        List<Object> ListByName(string nome);

    }
}
