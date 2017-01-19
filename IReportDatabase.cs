using System;
using System.Collections.Generic;

namespace Models.CQRS.Reporting
{
    public interface IReportDatabase
    {
        ModelsItemDto GetById(Guid id);
        void Add(ModelsItemDto item);
        void Delete(Guid id);
        List<ModelsItemDto> GetItems();
    }
}