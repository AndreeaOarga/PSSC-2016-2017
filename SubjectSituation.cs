using Models.Generics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Subject
{
    public class SubjectSituation
    {
        public Attendance Attendance { get; internal set; }
        public List<Grade> ExamGrades { get; internal set; }
        public Grade ActivityGrade { get; internal set; }

        public SubjectSituation()
        {

        }

        public SubjectSituation(Attendance attendance, List<Grade> examGrades, Grade activityGrade)
        {
            Attendance = attendance;
            ExamGrades = examGrades;
            ActivityGrade = activityGrade;
        }

        public void AddExamGrade(Grade examGrade)
        {
            ExamGrades.Add(examGrade);
        }

        public void AddActivityGrade(Grade activityGrade)
        {
            ActivityGrade = activityGrade;
        }

        public void AddAttendance(Attendance attendance)
        {
            Attendance = attendance;
        }

        public decimal GetExamAverage(EvaluationType type)
        {
            Grade average;

            if(type.Equals(EvaluationType.Distributed))
            {
                average = new Grade((ExamGrades[0].Value + ExamGrades[1].Value) / 2);
            } else
            {
                average = new Grade(ExamGrades[0].Value);
            }

            return average.Value;
        }
    }
}
