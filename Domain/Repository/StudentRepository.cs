using StudentTableAPI.Context;
using StudentTableAPI.Models;

using System.Collections.Generic;
using System.Linq;

using System.Xml.Linq;

namespace StudentTableAPI.Repository
{
    public class StudentRepository: IStudentRepository
    {
        private readonly EFContext _context;
        public StudentRepository(EFContext context)
        {
            _context = context;
        }
        public void Add(Student s)
        {
            _context.Students.Add(s);
            _context.SaveChanges();
           
        }

        public Student Get(int id)
        {
            return _context.Students.FirstOrDefault(u => u.StudNumber == id);
        }

        public void Update(Student s)
        {
            var studentToEdit = _context.Students.FirstOrDefault(u => u.StudNumber == s.StudNumber);
            studentToEdit.Name = s.Name;
            studentToEdit.Surname = s.Surname;
            studentToEdit.Patronymic = s.Patronymic;
            studentToEdit.IsBachelor = s.IsBachelor;
            studentToEdit.HasScholarship = s.HasScholarship;
            studentToEdit.BirthDate = s.BirthDate;
            studentToEdit.AverageScore = s.AverageScore;
            studentToEdit.PreviousAverageScore = s.PreviousAverageScore;
            studentToEdit.Schedule = s.Schedule;
            _context.SaveChanges();
           

        }
        public IEnumerable<Student> Get()
        {
            return _context.Students.ToList();
        }

        public IEnumerable<Student> Remove(int id)
        {
            var studentToRemove = Get(id);
            _context.Students.Remove(studentToRemove);
            _context.SaveChanges();
            return _context.Students.ToList();


        }

     
    }
}
