using ConsoleApp29.data;
using ConsoleApp29.entities;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp29
{
    internal class Program
    {
        static void Main(string[] args)//
        {
            using (coursedbcontext coursedbcontext = new coursedbcontext())
            {
                //crud operations
                //mm
               //hhg

                coursedbcontext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
                student st = new student()
                {
                    fname = "abeer",
                      address = "123 Main St",
                      age = 1,
                      email="abbeer@gmail.com",
                      password="1234",
                      phonenumber="01128457",
                      lname="reda"
                      

                };
                department d1 = new department()
                {
                   
                    name = "abeer",
                    hiringdate = 1 / 4 / 2005
                };
                course c1 = new course()
                {
                    name = "zyad",
                    description = "c#",
                    Duration = 2
                };
                instructor instructor = new instructor()
                {
                    name = "ahmed",
                    salary = 3000,
                    bouns = 690,
                    address = "obour",
                    HourRate = 8
                };
                Topic topic = new Topic()
                {
                    Name = "programming"
                };
                var student1=coursedbcontext.Student.FirstOrDefault(s=>s.age==1);
                if(student1 != null)
                {
                    student1.fname = "amir";
                }
                coursedbcontext.SaveChanges();
                #region insert
                //coursedbcontext.Add(st1);//added
                //coursedbcontext.Department.Add(d1);
                //coursedbcontext.Add(c1);
                //coursedbcontext.Add(instructor);
                //coursedbcontext.Add(topic);
                //coursedbcontext.SaveChanges();

            }
            #endregion
            
            //  coursedbcontext.Database.Migrate();
            //deallocate,free,delete db connection
            //try
            //{
            //    //crud operations
            //}
            //finally
            //{
            //    //[close|free] database connection
            //    coursedbcontext.Dispose();
            //} 



        }
    }
}