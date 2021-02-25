using System;
using System.Collections;

namespace switcher
{
    class Program
    {
        static ArrayList list = new ArrayList();
        static void Main(string[] args)
        {
            setConst();
            while (true)
            {
                Console.Write("Расшифровать: ");
                Console.WriteLine("\n" + puntoSwitch(Console.ReadLine()));
                Console.WriteLine(" ");
            }
        }

        static string puntoSwitch(string toDec)
        {
            string dec = "";
            Boolean wayFound = false;
            for(int i = 0; i<toDec.Length; i++)
            {
                for(int j = 0; j<list.Count; j++)
                {
                    if (list[j].ToString()[0] == toDec[i]) 
                    {
                        dec += list[j].ToString()[1];
                        wayFound = true;
                        break;
                    }
                }
                if (!wayFound)
                {
                    dec += toDec[i];
                } else wayFound = false;
            }

            return dec;
        }

        static void setConst()
        {
            list.Add("qй");
            list.Add("wц");
            list.Add("eу");
            list.Add("rк");
            list.Add("tе");
            list.Add("yн");
            list.Add("uг");
            list.Add("iш");
            list.Add("oщ");
            list.Add("pз");
            list.Add("[х");
            list.Add("]ъ");
            list.Add("aф");
            list.Add("sы");
            list.Add("dв");
            list.Add("fа");
            list.Add("gп");
            list.Add("hр");
            list.Add("jо");
            list.Add("kл");
            list.Add("lд");
            list.Add(";ж");
            list.Add("'э");
            list.Add("\\");
            list.Add("zя");
            list.Add("xч");
            list.Add("cс");
            list.Add("vм");
            list.Add("bи");
            list.Add("nт");
            list.Add("mь");
            list.Add(",б");
            list.Add(".ю");
            list.Add("/.");
        }
    }
}
