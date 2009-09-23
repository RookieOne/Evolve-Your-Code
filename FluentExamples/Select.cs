using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentExamples
{
    public class Select<T>
    {
        private readonly ListBox _listBox;

        public Select(ListBox listBox)
        {
            _listBox = listBox;
        }

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