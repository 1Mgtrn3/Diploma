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
    class analysis
    {


        public void versdel(string filex, bool dic, BackgroundWorker bw) //класс: анализ 
        {


            var lineCount = File.ReadLines(@filex).Count();
            int prog = lineCount / 100;
            //        var sr2 = new StreamReader(File.OpenRead(pathv + "tempotf")); //  читаем файл который будем менять
            int i = 0;
            //       int k = 0;

            List<string> filet = new List<string>(); //начало переноса файла в список
            filet.AddRange(File.ReadAllLines(@filex)); //считываем файл в список

            for (int j = 0; j < filet.Count; j++) //здесь будем идти по списку
            {
                List<string> matchvalues = filet.FindAll(x => x.Contains(filet[j])); //ищем все сточки с вхождением текущего значения из списка
                if (matchvalues.Count() == 0) //если не найдено, то просто i++(для прогресса) и дальше по тексту
                {
                    i++;

                }
                else //если найдены версиии
                {
                    List<string> start1 = new List<string>(); //список для начальных мутаций
                    List<string> end1 = new List<string>();
                    //тут у нас есть набор из слов которые таки содержат

                    for (int b = 0; b < matchvalues.Count - 1; b++) // иду по набору слов чтобы удалить оригинал
                    {

                        if (matchvalues[b] == filet[j]) //если оригинал, то удаляем из списка на расстрел
                        {
                            i++;
                            matchvalues.RemoveAt(b); //удаляю его

                        }
                        else
                        { // таки если не оригинал то записываю мутации
                            string[] pair = matchvalues[b].Split(new string[] { filet[j] }, StringSplitOptions.None);

                            start1.Add(pair[0]);

                            end1.Add(pair[1]);
                        }


                    }

                    var result = filet.Except(matchvalues);
                    filet = result.ToList();


                    i++;
                    if (dic)
                    {
                        File.AppendAllLines(text.pathv + text.startf, start1);
                        File.AppendAllLines(text.pathv + text.endf, end1);
                    }
                    else
                    {
                        File.AppendAllLines(text.pathv + text.rstartf, start1);
                        File.AppendAllLines(text.pathv + text.rendf, end1);
                    }
                    
                    
                }

                int perc = Convert.ToInt32(((float)(j + 1) / filet.Count) * 100);
                
                Debug.WriteLine(j + 1 + " / " + filet.Count);
               
                if (perc <= 100)
                {
                    bw.ReportProgress(perc, j + 1 + " / " + filet.Count);
                }
                else
                {
                    bw.ReportProgress(100, j + 1 + " / " + filet.Count);
                }

                // }


                if (filet.Count + 1 == j) //проверка не конец ли файла
                {
                    break;
                }
            }
            if (dic)
            {
                var kek = File.Create(text.pathv + text.dicp);

                kek.Close();
                File.WriteAllLines(text.pathv + text.dicp, filet);

            }
            else
            {
                var kek = File.Create(text.pratef);

                kek.Close();
                File.WriteAllLines(text.pratef, filet);
            }
            

          


        }
    }

}
