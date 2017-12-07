using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    class files
    {
        public static void unitetemp(string tempname, string first, string second) //нужно для работы кнопки "мутировать рейтинг и словарь"
        {
            string namef = text.pathv + tempname;
            //if (!File.Exists(namef))
            //{
            StreamWriter sw = new StreamWriter(File.Create(namef)); //создание временного файла
            using (var filer = new StreamReader(File.OpenRead(first))) //открытие файла с рейтингом паролей
            {
                while (!filer.EndOfStream)
                {
                    sw.WriteLine(filer.ReadLine()); //переписали рейтинг во временный файл
                }

            }
            using (var filed = new StreamReader(File.OpenRead(second))) //использование файла единого словаря
            {
                while (!filed.EndOfStream) //переписываем словарь под рейтинг
                {
                    sw.WriteLine(filed.ReadLine());
                }

            }
            sw.Close();

            //    }

        }
        public static void rdup(string filex) //класс: работа с файлами
        {
            var tempo = File.Create(text.pathv + "tempdup.txt"); //
            var sr = new StreamReader(File.OpenRead(@filex));
            var sw = new StreamWriter(tempo);
            var lines = new HashSet<int>(); // пустой хешсет
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine(); // считывает строку
                int hc = line.GetHashCode(); //получает ее хеш
                if (lines.Contains(hc)) //если есть хеш в строке то следующая итерация
                    continue;

                lines.Add(hc); //если нет то добавляет хеш в таблицу
                sw.WriteLine(line); //переписывает буфер
            }
            sw.Flush();
            sw.Close();
            sr.Close();
            File.Delete(filex); //замена реального файла набуфер
            File.Move(text.pathv + "tempdup.txt", filex);
        }
        public static int diccount() //класс: работа с файлами
        {

            return File.ReadLines(text.pathv + text.otf).Count();

        }

        public static int rcount()
        {
            return File.ReadLines(text.pratef).Count();
        }

        public static void ctfile(string filex)
        {
            StreamReader sr = new StreamReader(File.OpenRead(filex));
            StreamWriter sw = new StreamWriter(File.OpenWrite(text.pathv + text.tmutf));
            int k = 0;
            while (!sr.EndOfStream)
            {
                k++;
                Debug.WriteLine(k);
                string kek = sr.ReadLine();
                sw.WriteLine(kek);
            }
            sr.Close();
            sw.Close();
            
        }

        public static int mutcount() //класс: работа с файлами
        {
            return File.ReadLines(text.pathv + text.rate).Count();
        }

        
        public static void adddic(List<string> names) //класс: работа с файлами
        {
            using (StreamWriter outputf = File.AppendText(text.pathv + text.otf)) // открываем на добавление вниз готовый файл output
            {
                foreach (string name in names)
                {

                    using (var filer = new StreamReader(File.OpenRead(name))) // открываем на чтение файл который будем добавлять
                    {
                        while (!filer.EndOfStream) //тупо построчно дописываем его вниз файла и все
                        {


                            outputf.WriteLine(filer.ReadLine());

                        }
                    }


                }

            }
            rdup(text.pathv + text.otf);
            //сюда rdup

        }


    }
}
