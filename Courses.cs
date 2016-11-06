using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    class Courses
     {
         private List<Course> _courses;
         public ReadOnlyCollection<Course> Valori { get { return _courses.AsReadOnly(); } }
 
         internal Courses()
         {
             _courses = new List<Course>();
         }
 
         internal Courses(List<Course> cursuri)
         {
             Contract.Requires(cursuri != null, "List of courses");
             _courses = cursuri;
         }
 
         internal void AdaugaCurs(Course curs)
         {
            Contract.Requires(curs != null, "course");
             _courses.Add(curs);
         }
 
         public override string ToString()
         {
             return _courses.Aggregate(new StringBuilder(), (builder, curs) =>
             {
                 if (builder.Length > 0) builder.Append(", ");
                 builder.Append(curs);
                 return builder;
             }).ToString();
         }
     }
 }