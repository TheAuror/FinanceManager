using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Moq;

namespace FinanceManager.Tests
{
    public static class TestHelpers
    {
        public static void SetDataSource<T>(this Mock<DbSet<T>> dbSet,
            IEnumerable<T> dataSource)
            where T : class
        {
            var query = dataSource.AsQueryable();
            dbSet.As<IQueryable<T>>()
                .Setup(m => m.Provider).Returns(query.Provider);
            dbSet.As<IQueryable<T>>()
                .Setup(m => m.Expression).Returns(query.Expression);
            dbSet.As<IQueryable<T>>()
                .Setup(m => m.ElementType).Returns(query.ElementType);
            dbSet.As<IQueryable<T>>()
                .Setup(m => m.GetEnumerator()).Returns(() => query
                .GetEnumerator());
        }
    }
}
