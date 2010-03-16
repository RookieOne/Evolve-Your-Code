using System.Collections.Generic;
using System.Windows.Controls;

namespace FluentInterfaces.UiHelpers
{
    public class Selected<T>
    {
        public Selected(ListBox listBox)
        {
            _listBox = listBox;
        }

        readonly ListBox _listBox;

        public static Selected<T> From(ListBox listBox)
        {
            return new Selected<T>(listBox);
        }

        public IEnumerable<T> All()
        {
            var result = new List<T>();

            foreach (T item in _listBox.SelectedItems)
            {
                result.Add(item);
            }

            return result;
        }
    }
}