﻿using Microsoft.EntityFrameworkCore;
using StudentCoreUsingMVC.DataAccessLayer;
using StudentCoreUsingMVC.Models;

namespace StudentCoreUsingMVC.Repository
{
    public class StudentRepository : IStudentRepository
    {
        public readonly StudentContext _studentContext;
        public StudentRepository(StudentContext con)
        {
            _studentContext = con;
        }
        public bool DeleteStudents(int id)
        {
            Student stuDel = _studentContext.Students.Find(id);
            _studentContext.Remove(stuDel);
           _studentContext.SaveChanges();
            return true;

        }

        

        public DbSet<Student> GetAllStudents()
        {
            return _studentContext.Students;

        }

        public Student GetStudent(int id)
        {
            Student student = _studentContext.Students.Find(id);
            return student;
        }

        public bool InsertStudents(Student stud)
        {

             _studentContext.Students.Add(stud);
            _studentContext.SaveChanges();
            return true;
        }

        public bool UpdateStudents(int id, Student stud)
        {

    
            Student s = _studentContext.Students.Find(id);
            s.StudentName = stud.StudentName;
            s.subject = stud.subject;
            s.Marks = stud.Marks;
            _studentContext.Update(s);
            _studentContext.SaveChanges();
            return true;
        }
    }
}
