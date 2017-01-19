using System;
using System.Collections.Generic;
using System.Linq;
using Models.CQRS.Domain;

namespace Models.CQRS.Reporting
{
    public class ReportDatabase : IReportDatabase
    {
        static List<ModelsItemDto> items = new List<ModelsItemDto>();

        public ModelsItemDto GetById(Guid id)
        {
            return items.Where(a => a.Id == id).FirstOrDefault();
        }

        public void Add(ModelsItemDto item)
        {
            items.Add(item);
        }

        public void Delete(Guid id)
        {
            items.RemoveAll(i => i.Id == id);
        }

        public List<ModelsItemDto> GetItems()
        {
            return items;
        } 
    }
}
