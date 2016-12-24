using System.Collections.Generic;

namespace ProjectManagementTool
{
    class EnhancedList<T> : List<T>
    {
        public EnhancedList()
        {
        }

        public EnhancedList(IEnumerable<T> collection) : base(collection)
        {
        }

        public EnhancedList(int capacity) : base(capacity)
        {
        }

        public void MoveOneUpAt(int index)
        {
            if (index > 0)
            {
                var item = base[index];
                RemoveAt(index);
                Insert(index - 1, item);
            }
        }

        public void MoveOneDownAt(int index)
        {
            if (index < Count-1)
            {
                var item = base[index];
                RemoveAt(index);
                Insert(index + 1, item);
            }
        }

        public void MoveToTopAt(int index)
        {
            if (index > 0)
            {
                var item = base[index];
                RemoveAt(index);
                Insert(0, item);
            }
        }

        public void MoveToBottomAt(int index)
        {
            if (index < Count-1)
            {
                var item = base[index];
                RemoveAt(index);
                Add(item);
            }
        }

        public void MoveOneUp(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Equals(item))
                    MoveOneUpAt(i);
            }
        }

        public void MoveOneDown(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Equals(item))
                    MoveOneDownAt(i);
            }
        }

        public void MoveToTop(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Equals(item))
                    MoveToTopAt(i);
            }
        }

        public void MoveToBottom(T item)
        {
            for (int i = 0; i < Count; i++)
            {
                if (this[i].Equals(item))
                    MoveToBottomAt(i);
            }
        }
    }
}
