using MySql.Data.MySqlClient;
using Sistema_Igreja.model.entitie;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sistema_Igreja.model.dao
{
    interface RegisterDao
    {
        int insert(Register obj);
        void update(Register obj);
        void deleteById(int? obj);
        DataSet findByComboBox();
        DataSet findAll();
        //List<Register> findByDepartment(Department department);
    }
}
