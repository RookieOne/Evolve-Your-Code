using System.Collections.Generic;
using System.Windows.Controls;

namespace FluentInterfaces.UiHelpers
{
    public class Add<T>
    {
        private readonly IEnumerable<T> _items;

        private Add(IEnumerable<T> items)
        {
            _items = items;
        }

        public static Add<T> From(IEnumerable<T> items)
        {
            return new Add<T>(items);
        }

        public void To(ComboBox comboBox)
        {
            foreach (T item in _items)
                comboBox.Items.Add(item);
        }

        public void To(ListBox listBox)
        {
            foreach (T item in _items)
                listBox.Items.Add(item);
        }
    }
}