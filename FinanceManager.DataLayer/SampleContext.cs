using System.Data.Entity;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.DataLayer
{
    public class SampleContext : DbContext, ISampleContext
    {
        public SampleContext():this("CzinegeZeno")
        {
                
        }

        public SampleContext(string connectionString):base(connectionString)
        {
            
        }

        public IDbSet<CategoryEntity> Categorys => Set<CategoryEntity>();

        public IDbSet<TransactionEntity> Transactions => Set<TransactionEntity>();

        public IDbSet<TransactionItemEntity> TransactionItems => Set<TransactionItemEntity>();

        public IDbSet<UserEntity> Users => Set<UserEntity>();
    }
}
