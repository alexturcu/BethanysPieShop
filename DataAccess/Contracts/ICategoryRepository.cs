using DataAccess.Entities;
using System.Collections.Generic;

namespace DataAccess.Contracts
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
