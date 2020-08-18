using Sistema_Igreja.model.entitie;
using System;
using System.Collections.Generic;

namespace Sistema_Igreja.model.dao
{
    interface RegisterDao
    {
        void insert(Register obj);
        void update(Register obj);
        void deleteById(Register obj);
        Register findById(int id);
        List<Register> findAll();
        //List<Register> findByDepartment(Department department);
    }
}
