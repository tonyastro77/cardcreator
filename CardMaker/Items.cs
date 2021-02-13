using System.Collections.Generic;

namespace CardMaker
{
    class Items
    {
        public List<Class1> list;
        public Items()
        {
            list = new List<Class1>();
        }

        public void Add(Class1 statement)
        {
            list.Add(statement);
        }

        public string GetStatement(int x)
        {
            return list[x].statement;
        }
        public string GetAnswer(int x)
        {
            return list[x].answer;
        }
        public bool GetCanPass(int x)
        {
            return list[x].mayPass;
        }
        public int GetTotalNumber()
        {
            return list.Count;
        }
        public void RemoveAt(int x)
        {
            list.RemoveAt(x);
        }

        public void ClearList()
        {
            for (int x = list.Count - 1; x >= 0; x--)
            {
                list.RemoveAt(x);
            }
        }
    }
}
