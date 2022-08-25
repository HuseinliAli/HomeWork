using System;

namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int ,string> dic = new MyDictionary<int , string>();
            dic.Add(1, "Beni Bana Baglar");
            dic.Add(2, "Nasilsiniz Agalar");
            dic.List();
        }
    }
}