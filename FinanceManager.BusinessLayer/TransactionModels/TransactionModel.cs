using System;
using FinanceManager.BusinessLayer.CategoryModels;
using FinanceManager.BusinessLayer.Common;
using FinanceManager.BusinessLayer.UserModels;

namespace FinanceManager.BusinessLayer.TransactionModels
{
    public class TransactionModel : BaseModel
    {
        public virtual int Id { get; set; }
        public virtual int? UserId { get; set; }
        public virtual UserModel User { get; set; }
        public virtual int? ItemId { get; set; }
        public virtual TransactionItemModel Item { get; set; }
        public virtual int Value { get; set; }
        public virtual DateTime CreatedTime { get; set; }
        public virtual TypeEnum Type { get; set; }
        public virtual string UserName => User.UserName;

        public virtual string ItemName
        {
            get { return Item.Name ?? ""; }
            set
            {
                if (Item == null)
                {
                    Item = new TransactionItemModel();
                }
                Item.Name = value;                 
            }
        }
        public string TypeString => Type == TypeEnum.Income ? "Bevétel" : "Kiadás";
        public string CategoryName
        {
            get { return Item.Category.Name; }
            set
            {
                if (Item == null)
                {
                    Item = new TransactionItemModel();
                }
                if (Item.Category == null)
                {
                    Item.Category = new CategoryModel();
                }
                Item.Category.Name = value;                 
            }
        }
    }
}
