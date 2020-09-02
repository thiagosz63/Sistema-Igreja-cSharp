using Sistema_Igreja.model.dao.impl;
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
        DataSet findAllIgreja();
        void deleteByIdIgrejas(int? obj);
        DataSet search2(String coluna, String pesquisa);
        int insertIgreja(RegisterIgreja igrejaOpe);
        void updateIgreja(RegisterIgreja igrejaOpe);

        DataSet findByComboBox2();
    }
}
