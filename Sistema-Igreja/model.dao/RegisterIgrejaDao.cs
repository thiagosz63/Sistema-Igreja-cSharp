using Sistema_Igreja.model.entitie;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Igreja.model.dao
{
    interface RegisterIgrejaDao
    {
        int insertIgreja(RegisterIgreja obj);
        void updateIgreja(RegisterIgreja obj);
        DataSet findAllIgreja();
    }
}
