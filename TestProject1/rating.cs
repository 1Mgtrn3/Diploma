using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    class rating
    {

        public void applymute(int k, string filex, BackgroundWorker bw, Stream kek) //применение мутаций
        {
            int final = File.ReadLines(filex).Count() *k;
            StreamWriter mutfile = new StreamWriter(kek);
            using (var outp = new StreamReader(File.OpenRead(filex)))
            {
                int i = 0;
                while (!outp.EndOfStream)
                {
                    int m = k;
                    string line = outp.ReadLine();
                    using (var mut = new StreamReader(File.OpenRead(text.pathv + text.rate)))
                    {
                        
                        while (m != 0)
                        {
                            i++;
                            string[] muts = mut.ReadLine().Split(new string[] { " " }, StringSplitOptions.None); //тут мы получили массив строк из той штуки. щас надо просто сделать конкатинацию и все
                            mutfile.WriteLine(muts[0] + line + muts[1]);
                           // Debug.WriteLine(i);
                            int perc = Convert.ToInt32(((float)(i) / final) * 100);
                            if (perc % 5 == 0)
                            {
                                bw.ReportProgress(perc, i + " / ");
                                Debug.WriteLine(i + " / " + final + " / " + perc);
                            }
                            
                            m--;
                        }
                    }
                }
            }
            mutfile.Close();

        }
        public static void checkmut(string filex) //класс: рейтинг мутаций
        {
            var sr2 = new StreamReader(File.OpenRead(@filex));
            while (!sr2.EndOfStream)
            {
                string line = sr2.ReadLine();
                var sr3 = new StreamReader(File.OpenRead(@filex));
                while (!sr3.EndOfStream)
                {
                    string line2 = sr3.ReadLine();
                    if ((line2 != line) && (line2.Contains(line)))
                    {
                        string[] pair = line2.Split(new string[] { line }, StringSplitOptions.None);
                        //    foreach(string segment in pair){
                        //     MessageBox.Show(pair[0]);
                        using (StreamWriter start = File.AppendText(text.pathv + text.startf))
                        {

                            start.WriteLine(pair[0]);

                        }

                        //     MessageBox.Show(pair[1]);
                        using (StreamWriter end = File.AppendText(text.pathv + text.endf))
                        {

                            end.WriteLine(pair[1]);

                        }

                        //                     }
                    }
                }
                sr3.Close();
            }
            sr2.Close();
        }
        public static int counting(string sfile, string efile) //подсчет рейтинга мутаций
        {
            //сюда запишем объединение файлов
            if (File.Exists(text.pathv + text.startf) && File.Exists(text.pathv + text.rstartf)) //если файлы с мутациями и рейтинга и словаря существуют
            {
                files.unitetemp(text.ustartf, text.pathv + text.rstartf, text.pathv + text.startf);
                files.unitetemp(text.uendf, text.pathv + text.rendf, text.pathv + text.endf);
            }
            else //если существует только рейтинг
            {
                string ustart = text.pathv + text.ustartf;
                string uend = text.pathv + text.uendf;


                
                StreamWriter sw = new StreamWriter(File.Create(ustart)); //создание объединенного файла начала
                StreamWriter sw2 = new StreamWriter(File.Create(uend)); //создание объединенного файла конца
                var rstart = new StreamReader(File.OpenRead(text.pathv + text.rstartf)); 
                var rend = new StreamReader(File.OpenRead(text.pathv + text.rendf));

               
                    while (!rstart.EndOfStream)
                    {
                        sw.WriteLine(rstart.ReadLine()); 
                        sw2.WriteLine(rend.ReadLine());
                    }

                    sw.Close();
                    sw2.Close();
                    rstart.Close();
                    rend.Close();

                
            }


            var tempo = File.Create(text.pathv + "tempo"); // создали зачем-то временный файл файл
            var ratef = File.Create(text.pathv + text.rate); //создали рейтинговый файл (возможно зря, но к этому вернемся)
            var sr1 = new StreamReader(File.OpenRead(sfile)); //открыли файл начальных мутаций
            var sr2 = new StreamReader(File.OpenRead(efile)); // открыли файл конечных мутаций
            var sw1 = new StreamWriter(tempo); //открыли временный файл для записи
            while (!sr1.EndOfStream) //цикл который работает на одном файле, но там просто одинаковое количество строк
            {
                string s = sr1.ReadLine(); //в переменные записываем начальную и конечную мутацию
                string e = sr2.ReadLine();

                sw1.WriteLine(s + " " + e); // в буферный файл фигачим их соединение

            }

            sw1.Close(); //закрываем поток записи в буферный файл
            tempo.Close(); //закрываем поток который создавал буферный файл 
            sr1.Close(); //все понятно
            sr2.Close();

            var ratefw = new StreamWriter(ratef); //открываем поток записи в файл рейтинга
            var lines = File.ReadAllLines(text.pathv + "tempo"); //считываем в массив все что хотели из временног файла
            List<string> linesList = new List<string>(lines); //создаем список на основе массива (могли блядь тупо со списком все время работать)
            var lineCountDict = linesList.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count()); // делаем словарь
            var sortedDict = from entry in lineCountDict orderby entry.Value descending select entry; //сортируем словарь
            //var ss = File.Create(sfile); //заного создаем файл начальных мутаций
            //var se = File.Create(efile); //заного создаем файл конечных мутаций
            //var sw3 = new StreamWriter(ss); //создаем потоки записи в них
            //var sw4 = new StreamWriter(se);
            int i = 0;
            foreach (var val in sortedDict) //используем словарь
            {
                if (val.Key != " ")
                {
                    ratefw.WriteLine(val.Key + " " + val.Value);
                }
                // в файл рейтинга фигачим собственно мутации в рейтинге
                //       string[] pair = val.Key.Split(new string[] { " " }, StringSplitOptions.None); //создаем массив - табличку куда фигачим наши мутации (уже без дубликатов)
                //sw3.WriteLine(pair[0]); //записываем в файл начала и конца мутации уже без дубликатов
                //sw4.WriteLine(pair[1]);
                i++;
            }
            ratefw.Close(); //все закрываем
            ratef.Close();
            //sw3.Close();
            //sw4.Close();
            //ss.Close();
            //se.Close();

            File.Delete(text.pathv + "tempo"); //удаляем временный файл
            return i;

        }
    }
}
