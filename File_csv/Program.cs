﻿using System;
using System.Collections.Generic;
using System.IO;

namespace File_csv
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"F:\Codegym\Mon1\C#\TH8_File n Serialization\File_and_Serialization\File_csv\file CSV\Nation.csv"))
            {
                List<string> list1 = new List<string>();
                List<string> list2 = new List<string>();
                List<string> list3 = new List<string>();
                List<string> list4 = new List<string>();
                List<string> list5 = new List<string>();
                List<string> list6 = new List<string>();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var values = line.Split(';');

                    list1.Add(values[0]);
                    list2.Add(values[0]);
                    list3.Add(values[0]);
                    list4.Add(values[0]);
                    list5.Add(values[0]);
                    list6.Add(values[0]);
                }
                Console.WriteLine("Nation:");
                foreach (var item in list1)
                    Console.WriteLine(item);
            }
        }
    }
}
