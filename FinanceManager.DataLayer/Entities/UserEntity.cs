namespace FinanceManager.DataLayer.Entities
{
    public class UserEntity
    {
        public virtual int Id { get; set; }
        public virtual string UserName { get; set; }
        public virtual string Password { get; set; }
    }
}
