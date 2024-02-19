using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Lib
{
    public class CustomStack
    {
        private int index;
        private ArrayList list;

        public CustomStack()
        {
            list = new ArrayList();
            index = -1;
        }

        public int Count
        {
            get { return list.Count; }
        }

        public void Push(object item)
        {
            list.Add(item);
            index++;
        }

        public object Pop()
        {
            object obj = list[index];
            list.RemoveAt(index);
            index--;
            return obj;
        }

        public void clear()


    }
}
