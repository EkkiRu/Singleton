using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    class Singleton
    {
        /*1. Создать класс синглтон, 
в этом классе будет храниться объект List<int> LST с 100тыс рандомных значений в диапазоне от -1000 то 1000
2. Создать 2 обращения к этому классу 
3. Вывести сумму и количество всех положительных значений из коллекции LST. Если это синглтон, 
        эти значения должны совпадать у разных переменных, т.к. они будут смотреть на один и тот же объект*/
        static Singleton Instance;
        static List<int> LST = new List<int>();
        public static Singleton CreateOrGetInstance()
        {
            if (Instance == null)
                Instance = new Singleton();
            return Instance;
        }

        private Singleton()
        {
        }
        public override string ToString()
        {
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                LST.Add(random.Next());
                Console.WriteLine(LST[i].ToString());
            }
            return "";
        }
    }
}
