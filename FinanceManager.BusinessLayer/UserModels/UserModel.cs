using FinanceManager.BusinessLayer.Common;

namespace FinanceManager.BusinessLayer.UserModels
{
    public class UserModel : BaseModel
    {
        public virtual int? Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
    }
}
