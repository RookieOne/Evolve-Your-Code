using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Reflection;

namespace WpfViewModelExample.ViewModels
{
    /// <summary>
    /// View Model base class using expressions for Property Changed
    /// Idea copied from JP Hamilton
    /// </summary>
    public class ViewModel2 : INotifyPropertyChanged
    {
        private string _text;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                OnPropertyChanged(this, m => m.Text);
            }
        }

        private string GetPropertyName(LambdaExpression lambdaExpression)
        {
            Expression e = lambdaExpression;

            bool done = false;

            while (!done)
            {
                switch (e.NodeType)
                {
                    case ExpressionType.Convert:
                        e = ((UnaryExpression) e).Operand;
                        break;
                    case ExpressionType.Lambda:
                        e = ((LambdaExpression) e).Body;
                        break;

                    case ExpressionType.MemberAccess:
                        var propertyInfo = ((MemberExpression) e).Member as PropertyInfo;

                        return propertyInfo != null
                                   ? propertyInfo.Name
                                   : string.Empty;

                    default:
                        done = true;
                        break;
                }
            }

            return string.Empty;
        }

        protected void OnPropertyChanged<T>(T viewModel, Expression<Func<T, object>> expr)
        {
            var propertyName = GetPropertyName(expr);

            var handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}