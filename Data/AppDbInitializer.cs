using LearningEnvironment2.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearningEnvironment2.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();
                ////Faculty
                if (!context.Faculties.Any())
                {
                    context.Faculties.AddRange(new List<Faculty>()
                    {
                        new Faculty()
                        {
                            Name="Faculty1",
                            Telephone=12345678,
                            Email="faculty1@gmail.com"

                        },
                        new Faculty()
                        {
                            Name="Faculty2",
                            Telephone=12345238,
                            Email="faculty2@gmail.com"

                        },
                        new Faculty()
                        {
                            Name="Faculty3",
                            Telephone=1223678,
                            Email="faculty3@gmail.com"
                        },
                        new Faculty()
                        {
                             Name="Faculty4",
                            Telephone=12442678,
                            Email="faculty4@gmail.com"
                        },
                        new Faculty()
                        {
                            Name="Faculty5",
                            Telephone=34567879,
                            Email="faculty5@gmail.com"
                        }
                    });
                    context.SaveChanges();
                }


                //Course
                if (!context.Courses.Any())
                {
                    context.Courses.AddRange(new List<Course>()
                    {
                        new Course()
                        {
                            Name = "Course 1",
                            ImageURL = "https://www.21clhk.org/wp-content/uploads/2020/12/Creativity-in-Mathematics.png",
                            Description = "This is the description of the first Course",
                            ECTS = 5,
                            FacultyId=1,
                            ProfessorId=10
                        },
                        new Course()
                        {
                            Name = "Course 2",
                            ImageURL = "https://i.imgur.com/t4l5aLX.jpg",
                            Description = "This is the description of the first Course",
                            ECTS = 6,
                            FacultyId=1,
                            ProfessorId=9
                        },
                        new Course()
                        {
                            Name = "Course 3",
                            ImageURL = "http://online.hbs.edu/Style%20Library/api/resize.aspx?imgpath=/PublishingImages/Money_Graph.jpg&w=1200&h=630",
                            Description = "This is the description of the first Course",
                            ECTS = 4,
                            FacultyId=2,
                            ProfessorId=8
                        },
                        new Course()
                        {
                            Name = "Course 4",
                            ImageURL = "https://media.istockphoto.com/vectors/math-theory-mathematics-calculus-on-class-chalkboard-algebra-and-vector-id1265965042?k=20&m=1265965042&s=612x612&w=0&h=gxerbJWXamMUhILt59B7DlQlleffNvPGWLFNRWWVEBI=",
                            Description = "This is the description of the first Course",
                            ECTS = 4,
                            FacultyId=5,
                            ProfessorId=7
                        },
                        new Course()
                        {
                            Name = "Course 5",
                            ImageURL = "https://study.com/cimages/course-image/computer-science-202-network-and-system-security_1030285_large.jpeg",
                            Description = "This is the description of the first Course",
                            ECTS = 6,
                            FacultyId=5,
                            ProfessorId=6
                        },
                    });
                    context.SaveChanges();
                }

                ////Course_Students
                if (!context.Course_Students.Any())
                {
                    context.Course_Students.AddRange(new List<Course_Student>()
                    {
                        new Course_Student()
                        {
                            CourseId=20,
                            StudentId=1,


                        },
                        new Course_Student()
                        {
                            CourseId = 21,
                            StudentId = 1
                        },

                         new Course_Student()
                        {
                            CourseId = 22,
                            StudentId = 2
                        },
                         new Course_Student()
                        {
                            CourseId = 24,
                            StudentId = 2
                        },

                        new Course_Student()
                        {
                            CourseId = 23,
                            StudentId = 3
                        },
                        new Course_Student()
                        {
                            CourseId = 20,
                            StudentId = 3
                        },


                    });
                    context.SaveChanges();
                }


                ////Students
                if (!context.Students.Any())
                {
                    context.Students.AddRange(new List<Student>()
                    {
                        new Student()
                        {
                            Name="Jane",
                            LastName="Doe",
                            Email="janedoe@gmail.com",
                            Age=20,
                            AcademicYear=2,
                            StudentStatus=true

                        },
                        new Student()
                        {
                            Name="Jane2",
                            LastName="Doe2",
                            Email="janedoe2@gmail.com",
                            Age=20,
                            AcademicYear=3,
                            StudentStatus=true
                        },
                        new Student()
                        {
                            Name="Jack",
                            LastName="Doe",
                            Email="jackdoe@gmail.com",
                            Age=21,
                            AcademicYear=3,
                            StudentStatus=true
                        },
                        new Student()
                        {
                            Name="Jack2",
                            LastName="Doe2",
                            Email="jackdoe2@gmail.com",
                            Age=22,
                            AcademicYear=3,
                            StudentStatus=true
                        },
                        new Student()
                        {
                             Name="Jill",
                            LastName="John",
                            Email="jill@gmail.com",
                            Age=20,
                            AcademicYear=1,
                            StudentStatus=false
                        }
                    });
                    context.SaveChanges();
                }

                //Professors
                if (!context.Professors.Any())
                {
                    context.Professors.AddRange(new List<Professor>()
                    {
                        new Professor()
                        {
                             Name="Prof",
                            LastName="P",
                            Email="p@gmail.com",
                            AcademicGrade="Doctor Of Science",
                            FieldOfStudy="Mathematics",
                            Specialization="Algebra",
                            Image="http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Professor()
                        {
                             Name="Nick",
                            LastName="Smith",
                            Email="nick@gmail.com",
                            AcademicGrade="MBA",
                            FieldOfStudy="Economics",
                            Specialization="Macroeconomy",
                            Image="http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Professor()
                        {
                            Name="Ana",
                            LastName="Ana",
                            Email="ana@gmail.com",
                            AcademicGrade="Master",
                            FieldOfStudy="Computer Science",
                            Specialization="Networks",
                            Image="http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Professor()
                        {
                             Name="Betty",
                            LastName="White",
                            Email="b.white@gmail.com",
                            AcademicGrade="PhD",
                            FieldOfStudy="Art",
                            Specialization="Abstract Art",
                            Image="http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Professor()
                        {
                            Name="Will",
                            LastName="Miller",
                            Email="will@gmail.com",
                            AcademicGrade="Master",
                            FieldOfStudy="Mathematics",
                            Specialization="Arithmetics",
                            Image="http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }

                //Admins

                if (!context.Admins.Any())
                {
                    context.Admins.AddRange(new List<Admin>()
                    {
                        new Admin()
                        {

                            Name="Alex",
                            LastName="Miller",
                            Email="am@hotmail.com",
                            Certifications="Cisco CCNA"

                        },
                        new Admin()
                        {

                            Name="Kilian",
                            LastName="Maxwell",
                            Email="kilian@gmail.com",
                            Certifications="Cisco CCIE"
                        },
                        new Admin()
                        {

                            Name="Olli",
                            LastName="Ronan",
                            Email="olli.r@gmail.com",
                            Certifications="CompTIA A+"
                        },
                        new Admin()
                        {

                            Name="Catherine",
                            LastName="Waldorf",
                            Email="cath_waldorf@gmail.com",
                            Certifications="Cisco CCNA"
                        },
                        new Admin()
                        {

                            Name="Rory",
                            LastName="Gilmore",
                            Email="rory.gilmore@gmail.com",
                            Certifications="CompTIA Server+ Certification"

                        }
                    });
                    context.SaveChanges();
                }
            }

        }
    }
}

