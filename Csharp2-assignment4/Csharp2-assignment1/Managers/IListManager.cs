﻿/// IListManager.cs
/// Ann-Marie Bergström  ai2436 2018

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp2_assignment
{
    interface IListManager<T>
    {
        //int Count { get; }

        bool AddItem(T anItem);

        T GetItem(int index);

        bool ChangeItem(int index, T anItem);

        bool RemoveItem(int index);

        List<string> ToStringList();

        string[] ToStringArray();

        void BinarySerialize(string fileName);

        void BinaryDeSerialize(string fileName);

        void XMLSerialize(string fileName);

        void XMLDeSerialize(string fileName);

    }
}
