﻿using WebSchool.Models;
using System;
using System.Linq;

namespace WebSchool.Data
{
    public static class DbInitializer
    {
        public static void Initialize(SchoolContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Students.Any())
            {
                return;   // DB has been seeded
            }

            var students = new Student[]
            {
            new Student{FirstMidName="Ivan",LastName="Ivanov",EnrollmentDate=DateTime.Parse("2005-09-01")},
            new Student{FirstMidName="Milena",LastName="Todorova",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Ana",LastName="Mihaleva",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Izabel",LastName="Minkova",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Georgi",LastName="Georgiev",EnrollmentDate=DateTime.Parse("2002-09-01")},
            new Student{FirstMidName="Alex",LastName="Petrov",EnrollmentDate=DateTime.Parse("2001-09-01")},
            new Student{FirstMidName="Sara",LastName="Kuncheva",EnrollmentDate=DateTime.Parse("2003-09-01")},
            new Student{FirstMidName="Nina",LastName="Asenova",EnrollmentDate=DateTime.Parse("2005-09-01")}
            };
            foreach (Student s in students)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();

            var courses = new Course[]
            {
            new Course{CourseID=1050,Title="Chemistry",Credits=3,},
            new Course{CourseID=4022,Title="Economics",Credits=3,},
            new Course{CourseID=4041,Title="Sport",Credits=3,},
            new Course{CourseID=1045,Title="Math",Credits=4,},
            new Course{CourseID=3141,Title="French",Credits=4,},
            new Course{CourseID=2021,Title="Portugese",Credits=3,},
            new Course{CourseID=2042,Title="Programming",Credits=4,}
            };
            foreach (Course c in courses)
            {
                context.Courses.Add(c);
            }
            context.SaveChanges();

            var enrollments = new Enrollment[]
            {
            new Enrollment{StudentID=1,CourseID=1050,Grade=Grade.A},
            new Enrollment{StudentID=1,CourseID=4022,Grade=Grade.C},
            new Enrollment{StudentID=1,CourseID=4041,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=1045,Grade=Grade.B},
            new Enrollment{StudentID=2,CourseID=3141,Grade=Grade.F},
            new Enrollment{StudentID=2,CourseID=2021,Grade=Grade.F},
            new Enrollment{StudentID=3,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=1050},
            new Enrollment{StudentID=4,CourseID=4022,Grade=Grade.F},
            new Enrollment{StudentID=5,CourseID=4041,Grade=Grade.C},
            new Enrollment{StudentID=6,CourseID=1045},
            new Enrollment{StudentID=7,CourseID=3141,Grade=Grade.A},
            };
            foreach (Enrollment e in enrollments)
            {
                context.Enrollments.Add(e);
            }
            context.SaveChanges();
        }
    }
}

