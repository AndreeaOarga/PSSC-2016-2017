using Models.Generics;
using Models.Subject;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Student
{
    //Aggregate Root
    public class GradeReport
    {
        private ReadOnlyCollection<KeyValuePair<SubjectInformation, SubjectSituation>> _gradeReport;

        public GradeReport(ReadOnlyCollection<KeyValuePair<SubjectInformation, SubjectSituation>> gradeReport)
        {
            _gradeReport = gradeReport;
        }

        public SubjectSituation GetSubjectSituation(PlainText subjectName)
        {
            return _gradeReport.First(d => d.Key.Name == subjectName).Value;
        }
    }
}