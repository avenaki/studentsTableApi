using StudentTableAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentTableAPI.Repository
{
    public interface IStudentRepository
    {
        void Add(Student s);
        Student Get(int id);
        void  Update(Student s);
        void Remove(int id);
        IEnumerable <Student> Get();
    }
}
