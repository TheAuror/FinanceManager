using FinanceManager.DataLayer;

namespace FinanceManager.BusinessLayer.Common
{
    public class BaseService
    {
        protected readonly ISampleContext Context;

        public BaseService(ISampleContext context)
        {
            Context = context;
        }
    }
}
