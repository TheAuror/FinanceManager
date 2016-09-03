using System.Data.Entity;
using FinanceManager.DataLayer.Entities;

namespace FinanceManager.DataLayer
{
    public class SampleContext : DbContext, ISampleContext
    {
        public SampleContext():this("FinanceManager")
        {
                
        }

        public SampleContext(string connectionString):base(connectionString)
        {
            
        }

        public IDbSet<CategoryEntity> Categorys => Set<CategoryEntity>();

        public IDbSet<ExpenseEntity> Expenses => Set<ExpenseEntity>();

        public IDbSet<ExpenseItemEntity> ExpenseItems => Set<ExpenseItemEntity>();

        public IDbSet<IncomeEntity> Incomes => Set<IncomeEntity>();

        public IDbSet<IncomeItemEntity> IncomeItems => Set<IncomeItemEntity>();

        public IDbSet<UserEntity> Users => Set<UserEntity>();
    }
}
