using System.Collections.Generic;
using System.Windows.Controls;

namespace FluentInterfaces.UiHelpers
{
    public class Select<T>
    {
        public Select(ListBox listBox)
        {
            _listBox = listBox;
        }

        readonly ListBox _listBox;

        public static Select<T> On(ListBox listBox)
        {
            return new Select<T>(listBox);
        }

        public void These(IEnumerable<T> itemsToSelect)
        {
            foreach (T item in itemsToSelect)
            {
                _listBox.SelectedItems.Add(item);
            }
        }
    }
}