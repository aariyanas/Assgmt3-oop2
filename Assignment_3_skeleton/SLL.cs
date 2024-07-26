using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        private LinkedListADT sllADT;

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
            throw new NotImplementedException();
        }

        public int IndexOf(object data)
        {
            throw new NotImplementedException();
        }

        public void Insert(object data, int index)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return sllADT.IsEmpty();
        }

        public void Prepend(object data)
        {
            sllADT.Prepend(data);
        }

        public void Replace(object data, int index)
        {
            throw new NotImplementedException();
        }

        public object Retrieve(int index)
        {
            throw new NotImplementedException();
        }

        public int Size()
        {
            return sllADT.Size();
        }
    }
}
