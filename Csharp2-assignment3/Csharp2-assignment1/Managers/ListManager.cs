/// ListManager.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    public class ListManager<T>: IListManager<T>, IEnumerable<T>
    {
        private List<T> itemList; //declare list of items

        //public int Count { get; }

        public ListManager()
        {
            itemList = new List<T>(); //create list of items
        }

        /// <summary>
        /// Add item to list
        /// </summary>
        /// <param name="anItem"></param>
        public bool AddItem(T anItem)
        {
            if (anItem == null) return false;
            else
            {
                itemList.Add(anItem);
                return true;
            }           
        }

        /// <summary>
        /// Return the item at the given index in the list of items.
        /// </summary>
        /// <param name="index"></param>
        public T GetItem(int index)
        {
            var item = itemList[index]; //get item from list
            return item; //return item
        }

        /// <summary>
        /// Replace item at specified index in list
        /// </summary>
        /// <param name="anItem"></param>
        public bool ChangeItem(int index, T anItem)
        {
            if (anItem == null) return false;
            else
            {
                itemList.RemoveAt(index);
                itemList.Insert(index, anItem);
                return true;
            }
        }

        /// <summary>
        /// Delete the item at the given index in the list of items.
        /// </summary>
        /// <param name="index"></param>
        public void RemoveItem(int index)
        {
            itemList.RemoveAt(index);
        }

        #region support functions
        /// <summary>
        /// Check if index is valid.
        /// </summary>
        /// <param name="index"></param>
        public bool ValidateIndex(int index)
        {
            if (index >= 0 && index < itemList.Count) return true; 
            else return false;
        }

        public void Sort(IComparer<T> comparer)
        {
            itemList.Sort(comparer);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)itemList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<T>)itemList).GetEnumerator();
        }

        public List<string> ToStringList()
        {
            var outList = new List<string>();

            foreach (var item in itemList)
            {
                outList.Add(item.ToString());
            }
            return outList;
        }

        public string[] ToStringArray()
        {
            return ToStringList().ToArray();
        }
        #endregion
    }
}
