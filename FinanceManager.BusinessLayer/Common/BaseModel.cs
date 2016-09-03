using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FinanceManager.BusinessLayer.Common
{
    public class BaseModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected virtual bool OnPropertyChanged<T>(ref T ValueRef, T newValue,
            [CallerMemberName] string propertyName = null)
        {
            if (Equals(ValueRef, newValue)) return false;
            ValueRef = newValue;
            OnPropertyChanged(propertyName);
            return true;
        }
        public enum TypeEnum
        {
            Income = 1,
            Expense = 0
        }
    }
}
