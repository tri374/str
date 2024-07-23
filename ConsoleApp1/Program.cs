using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Xml.Linq;
public class Program
{

    class Node
    {
        public int Value;
        public Node Next;
    }
    class List
    {
        public Node FirstNode;
        public int GetValue(int index)
        {
            if (index == 0)
                return FirstNode.Value;
            else
            {
                Node CurrectNode = FirstNode;
                if (CurrectNode.Next != null)
                {
                    for (int i = 0; i < index; i++)
                    CurrectNode = CurrectNode.Next;
                }
                return CurrectNode.Value;
            }
        }
        public void Push(int newValue)
        {
            if (FirstNode == null)
            {
                FirstNode = new Node() { Value = newValue };
            }
            else
            {
                Node CurrectNode = FirstNode;
                while (CurrectNode.Next != null)
                {
                    CurrectNode = CurrectNode.Next;
                }
                Node NewNode = new Node() { Value = newValue };
                CurrectNode.Next = NewNode;
            }

        }
        public void Delete(int index)
        {
            if (index == 0)
                FirstNode = FirstNode.Next;
            else
            {
                Node CurrectNode = FirstNode;
                if (CurrectNode.Next != null)
                {
                    for (int i = 0; i < index-1; i++)
                        CurrectNode = CurrectNode.Next;
                }
                CurrectNode.Next = CurrectNode.Next.Next;
            }
        }
        public int GetLength()
        {
            int length = 0;
            if (FirstNode == null)
            {
                return 0;
            }
            Node CurrectNode = FirstNode;
            while (CurrectNode.Next != null)
            {
                CurrectNode = CurrectNode.Next;
                length++;
            } 
            return length+1;
        }
    }
    static void Main(string[] args)
    {
        List list = new List();
        DateTime date1 = DateTime.Now;
        for (int i = 0; i <= 100000;  i++)
        {
            list.Push(i);
        }
        DateTime date2 = DateTime.Now;
        Console.WriteLine(date2.Subtract(date1)); // 10эл. - 00:00:00.0054566;100эл. - 00:00:00.0064691;1000эл. - 00:00:00.0088136;10000эл. - 00:00:00.0657253;100000эл. - 
    }
}


