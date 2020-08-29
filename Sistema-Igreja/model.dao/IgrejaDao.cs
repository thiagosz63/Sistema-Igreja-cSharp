using Sistema_Igreja.model.entitie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Igreja.model.dao
{
    interface IgrejaDao
    {
        int insertIgreja(RegisterIgreja obj);
        void updateIgreja(RegisterIgreja obj);
        DataSet findAllIgreja();
        void deleteByIdIgrejas(int? obj);
        DataSet search2(String coluna, String pesquisa);
    }
}
