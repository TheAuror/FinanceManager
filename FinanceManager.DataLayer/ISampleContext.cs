using System.Data.Entity;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.DataLayer
{
    public interface ISampleContext
    {
        IDbSet<CategoryEntity> Categorys { get; }
        IDbSet<TransactionEntity> Transactions { get; }    
        IDbSet<TransactionItemEntity> TransactionItems { get; }
        IDbSet<UserEntity> Users { get; }  

        int SaveChanges();
    }
}
