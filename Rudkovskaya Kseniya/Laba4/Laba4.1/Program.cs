﻿using System;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    class Program
    {
        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
        public static extern int MessageBox(int hWnd, String text, String caption, uint type);
        [DllImport("user32.dll", SetLastError = true)]
        static extern bool LockWorkStation();
        static void Main(string[] args)
        {
            Info();
        }

        public static void Info()
        {
            do
            {
                Bel();
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        MessageBox(0, "По данным переписи 2019 года, население республики составило\n9 413 446 человек", "Население", 0);
                        break;
                    case "2":
                        MessageBox(0, "Должность занимает\nАлександр Григорьевич Лукашенко\nс 20 июля 1994", "Президент", 0);
                        break;
                    case "3":
                        MessageBox(0, "Брестская 1 347,0\nВитебская 1 133,4\nГомельская 1 386,6\nГродненская 1 025,8\nг.Минск 2 020,6\nМинская 1 472,0\nМогилёвская 1 023,0", "Население в областях (тыс.чел.)", 0);
                        break;
                    case "4":
                        MessageBox(0, "15 марта — День конституции,\n2 апреля — День единения народов Беларуси и России,\n9 мая — День Победы(нерабочий день),\nВторое воскресенье мая — День Государственного герба Республики Беларусь и Государственного флага Республики Беларусь,\n3 июля — День независимости Республики Беларусь(День Республики)(нерабочий день).", "Государственные праздники", 0);
                        break;
                    case "5":
                        MessageBox(0, "Климат Беларуси умеренно континентальный, на западе переходный от морского к континентальному,\nформирующийся под влиянием воздушных масс Атлантики. В зимний период нередки оттепели.\nСредняя летняя температура колеблется от + 17° С на севере(июль), до + 18—19° С на юге,\nа зимняя — от −4, 5 °C на юго - западе до −8 °C на северо - востоке(январь).\nОсадки выпадают равномерно, с возрастанием с юга на север — от 500 мм на юге, до 800 мм на северо - западе.\nМаксимальное количество осадков обычно выпадает в осенне - зимний период.\nВ лесных районах толщина снежного покрова может составлять 1 - 1, 2 м.", "Климат", 0);
                        break;
                    case "6":
                        MessageBox(0, "В Беларуси созданы 2 заповедника и 4 национальных парка:\n-Березинский биосферный заповедник,\n-Национальный парк Беловежская пуща,\n-Национальный парк Браславские озёра,\n-Нарочанский национальный парк,\n-Припятский национальный парк,\n-Полесский государственный радиационно - экологический заповедник.", "Охраняемые территории", 0);
                        break;
                    case "7":
                        return;
                    default:
                        LockWorkStation(); Environment.Exit(0);
                        break;
                }
                Console.Clear();
            } while (true);
        }

        public static void Bel()
        {
            Console.Clear();
            Console.WriteLine("Что вы хотите узнать?");
            Console.WriteLine("1. Население Республики Беларусь");
            Console.WriteLine("2. Президент");
            Console.WriteLine("3. Кол-во проживающих в столице и в областях");
            Console.WriteLine("4. Государственные праздники");
            Console.WriteLine("5. Климат");
            Console.WriteLine("6. Охраняемые территории Руспублики");
            Console.WriteLine("7. Exit.");

            Console.WriteLine("\nВыберите номер от 1 до 7.");
        }
    }
}
   
