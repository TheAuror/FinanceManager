using System.Data.Entity;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.DataLayer
{
    public interface ISampleContext
    {
        IDbSet<CategoryEntity> Categorys { get; }
        IDbSet<ExpenseEntity> Expenses { get; }
        IDbSet<ExpenseItemEntity> ExpenseItems { get; }
        IDbSet<IncomeEntity> Incomes { get; }    
        IDbSet<IncomeItemEntity> IncomeItems { get; }
        IDbSet<UserEntity> Users { get; }  

        int SaveChanges();
    }
}
