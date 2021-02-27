using System;

namespace Week4_HomeWork._2
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, string> calısanlar = new MyDictionary<string, string>();

            calısanlar.Add("Ahmet Yüksek", "Full-Stack Developer");
            calısanlar.Add("Ali Korkmaz", "Game Developer");
            calısanlar.Add("Ayşe Kılınç", "Front-End Developer");
            calısanlar.Add("Büşra Demir", "Back-End Developer");

            calısanlar.List();
            calısanlar.Count();

        }
    }
}
