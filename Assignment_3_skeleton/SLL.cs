using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        private LinkedList<Node> sllADT = new LinkedList<Node>();

        public void Append(object data)
        {
            sllADT.Append(data);
        }

        public void Clear()
        {
            sllADT.Clear();
        }

        public bool Contains(object data)
        {
            return sllADT.Contains(data);
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= sllADT.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                sllADT.Remove((Node)Retrieve(index));
            }
        }

        public int IndexOf(object data)
        {
            int index = 0;
            foreach (var node in sllADT)
            {
                if (node.Equals(data))
                {
                    return index;
                }
                index++;
            }
            return -1;
            /*return sllADT.FindIndex(data);*/
        }

        public void Insert(object data, int index)
        {
            if (index < 0 || (index >= sllADT.Count))
            { throw new IndexOutOfRangeException(); }
            else
            {
                sllADT.AddAfter((LinkedListNode<Node>)data, (Node)Retrieve(index - 1));
            }
        }

        public bool IsEmpty()
        {
            return sllADT.Count == 0;
        }

        public void Prepend(object data)
        {
            sllADT.AddFirst((Node)data);
        }

        public void Replace(object data, int index)
        {
            if (index < 0 || index > sllADT.Count)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                Node current = (Node)Retrieve(index);
                if (current != null)
                {
                    sllADT.Remove(current);
                    sllADT.AddAfter(sllADT.Find(Retrieve(index - 1)), data);
                }
            }
        }

        public object Retrieve(int index)
        {
            if (index < 0 || index > sllADT.Count - 1)
            {
                throw new IndexOutOfRangeException();
            }
            else if (sllADT.ElementAt(index) == null)
            {
                return null;
            }
            else
            {
                return sllADT.ElementAt(index);
            }
        }

        public int Size()
        {
            return sllADT.Count;
        }
    }
}
