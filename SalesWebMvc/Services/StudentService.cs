using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class StudentService
    {
        private readonly SalesWebMvcContext _context;

        public StudentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public ICollection<Student> findAll()
        {
            var query = from students in _context.Student
                        select students;
            var allStudents = query.ToList();
            return allStudents;
        }

        public int countAll()
        {
            var query = from students in _context.Student
                        select students;
            var allStudents = query.Count();
            return allStudents;
        }

        public void Insert(Student student)
        {
            _context.Student.Add(student);
            _context.SaveChanges();
        }
    }
}
