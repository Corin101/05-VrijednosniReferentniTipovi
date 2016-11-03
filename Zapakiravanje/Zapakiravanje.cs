﻿using System;
using System.Collections;

namespace Vsite.CSharp
{
    class RefTip
    {
        public int X;
    }

    struct VrijednTip
    {
        public int X;
    }

    public class Zapakiravanje
    {
        public static void DodavanjeKlaseUArrayList()
        {
            ArrayList lista = new ArrayList();
            RefTip rt = new RefTip();

            for (int i = 0; i < 10; ++i)
            {
                rt.X = i;
                lista.Add(rt);
            }

            foreach (RefTip r in lista)
            {
                Console.WriteLine(r.X);
            }
            //  Dodati petlju koja će ispisati član X za svaki element kolekcije lista.

        }

        public static void DodavanjeStruktureUArrayList()
        {
            ArrayList lista = new ArrayList();
            VrijednTip vt = new VrijednTip();

            for (int i = 0; i < 10; ++i)
            {
                vt.X = i;
                lista.Add(vt);
            }
            foreach (VrijednTip r in lista)
            {
                Console.WriteLine(r.X);
            }
            //  Dodati petlju koja će ispisati član X za svaki element kolekcije lista.

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Dodavanje klase");
            DodavanjeKlaseUArrayList();

            Console.WriteLine("Dodavanje strukture");
            DodavanjeStruktureUArrayList();

            Console.WriteLine("GOTOVO!!!");
            Console.ReadLine();
        }
    }
}
