using MySql.Data.MySqlClient;
using Sistema_Igreja.model.entitie;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sistema_Igreja.model.dao
{
    interface RegisterDao
    {
        void insert(Register obj);
        void update(Register obj);
        void deleteById(Register obj);
        Register findById(int id); 
        DataTable select();
        //List<Register> findByDepartment(Department department);
    }
}
