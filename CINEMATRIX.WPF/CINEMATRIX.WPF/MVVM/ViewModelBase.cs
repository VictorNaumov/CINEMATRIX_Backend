using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace CINEMATRIX.WPF.MVVM
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        /// <summary>Occurs after a property value changes.</summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected bool Set<T>(string propertyName, ref T field, T newValue)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
                return false;
            field = newValue;
            RaisePropertyChanged(propertyName);
            return true;
        }

        protected bool Set<T>(Expression<Func<T>> propertyExpression, ref T field, T newValue, Action action = null)
        {
            if (EqualityComparer<T>.Default.Equals(field, newValue))
                return false;
            field = newValue;
            RaisePropertyChanged(propertyExpression);
            action?.Invoke();
            return true;
        }

        public virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void RaisePropertyChanged<T>(Expression<Func<T>> propertyExpression)
        {
            if (PropertyChanged == null)
                return;
            var propertyName = GetPropertyName(propertyExpression);
            if (string.IsNullOrEmpty(propertyName))
                return;
            RaisePropertyChanged(propertyName);
        }

        protected static string GetPropertyName<T>(Expression<Func<T>> propertyExpression)
        {
            if (propertyExpression == null)
                throw new ArgumentNullException(nameof(propertyExpression));
            if (!(propertyExpression.Body is MemberExpression body))
                throw new ArgumentException("Invalid argument", nameof(propertyExpression));
            var member = body.Member as PropertyInfo;
            return (object)member != null
                ? member.Name
                : throw new ArgumentException("Argument is not a property", nameof(propertyExpression));
        }
    }
}
