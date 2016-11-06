using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Models.Repositories
{
    class CommonRepository : ICommonRepository
    {
        private static List<Models.Subject.Subject> _subject = new List<Models.Subject.Subject>();

        public CommonRepository()
        {
        }

        public Models.Subject.Subject GetById(Guid Id)
        {
            var result = _subject.Find(p => p.GetID == Id);
            return result;
        }

        public void Add(Subject.Subject entity)
        {
            var result = _subject.FirstOrDefault(p => p.Equals(entity));
            if (result != null) throw new ExistingSubjectException();
            _subject.Add(entity);
        }

        public void Delete(Subject.Subject entity)
        {
            var result = _subject.FirstOrDefault(p => p.Equals(entity));
            if (result == null) throw new MissingSubjectException();
            _subject.Remove(entity);
        }

        public void Update(Subject.Subject entity)
        {
            _subject.Where(p => p.Equals(entity))
            .Select(S =>
            {
                S.SubjectInfo = new Models.Subject.SubjectInformation("Update subject");
                return S;
            }).ToList();
        }

        public void Save(Subject.Subject entity)
        {

            _subject.SaveDates();
           
        }
    }
}