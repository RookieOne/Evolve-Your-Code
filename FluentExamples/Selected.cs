using System.Collections.Generic;
using System.Windows.Forms;

namespace FluentExamples
{
    public class Selected<T>
    {
        private readonly ListBox _listBox;

        public Selected(ListBox listBox)
        {
            _listBox = listBox;
        }

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