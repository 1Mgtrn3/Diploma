using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters.Binary;




namespace TestProject1
{
    public partial class Form1 : Form
    {

        string ptop = "";
        List<string> dic = new List<string>();
        string dicf = "D:\\d1\\dic.txt";
        string ratef = "D:\\d1\\rating.txt";
        int knum = 0;
        string progress = "";
        string mutfile = "";


        public Form1()
        {
            InitializeComponent();
            //datagrid
            dataGridView1.AllowUserToAddRows = false;
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Начало"; //текст в шапке
            column1.Width = 50; //ширина колонки
            column1.ReadOnly = true;     
            column1.Name = "start"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
            column1.Frozen = true; //флаг, что данная колонка всегда отображается на своем месте
            column1.CellTemplate = new DataGridViewTextBoxCell(); //тип нашей колонки

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Конец";
            column2.Name = "end";
            column2.Width = 50;
            column2.Frozen = true;
            column2.CellTemplate = new DataGridViewTextBoxCell();


            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Количество";
            column3.Name = "Count";
            column3.Width = 70;
            column3.Frozen = true;
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var cpos = new DataGridViewColumn();
            cpos.HeaderText = "#";
            cpos.Name = "Rate";
            cpos.Width = 30;
            cpos.Frozen = true;
            cpos.CellTemplate = new DataGridViewTextBoxCell();

        
            if (File.Exists(dicf))
            {
                int num = files.diccount();
                label6.Text = "Паролей в общем словаре: " + num.ToString();
                if (num > 0)
                {
                    button12.Enabled = true;
                    button13.Enabled = true;
                }
                
                
            }
            
            if (File.Exists(ratef)){
                button11.Enabled = false;
                
                
            }
            else
            {
                button14.Enabled = false;
                button8.Enabled = false;
                button1.Enabled = false;
            }

            if (File.Exists(text.pathv + text.rate))
            {
                int k = files.mutcount();
                knum = k;
                if (k > 0)
                {
                    label8.Text = "Мутаций в рейтинге: " + k.ToString();
                }
                fillGrid(false);
            }
            else
            {

                button13.Enabled = false;
                button8.Enabled = false;
                button1.Enabled = false;

            }

        }

        private void fillGrid(bool upd)
        {
            if (upd) { 

            int j = 0;
            using (var filer = new StreamReader(File.OpenRead(text.pathv + text.rate))) // открываем на чтение файл который будем добавлять
            {


                DataTable try4 = new DataTable();
                try4.Clear();
                try4.Columns.Add("#");
                try4.Columns.Add("Начало");
                try4.Columns.Add("Конец");
                try4.Columns.Add("Количество");

                while (!filer.EndOfStream)
                {
                    DataRow rowtry = try4.NewRow();
                    string k = filer.ReadLine();


                    string[] data1 = k.Split(new string[] { " " }, StringSplitOptions.None);
                    rowtry["#"] = j.ToString();
                    rowtry["Начало"] = data1[0];
                    rowtry["Конец"] = data1[1];
                    rowtry["Количество"] = data1[2];

                    int m = j + 1;

                    try4.Rows.Add(rowtry);
                    Debug.WriteLine(rowtry["#"] + " / " + rowtry["Начало"] + " / " + rowtry["Конец"] + " / " + rowtry["Количество"]);

                    j++;
                }
             
                BinaryFormatter serializer = new BinaryFormatter();
                var vtest = File.Create(text.pathv + text.binrate);
                serializer.Serialize(vtest, try4);
                this.Invoke(new Action(() =>
                dataGridView1.DataSource = try4
                
                ));
                this.Invoke(new Action(() =>
                setWidth()

                ));
                vtest.Close();
            }
             
            }
            else
            {
                var vtest = File.OpenRead(text.pathv + text.binrate);
                BinaryFormatter serializer = new BinaryFormatter();
                DataTable try4 = (DataTable)serializer.Deserialize(vtest);
                dataGridView1.DataSource = try4;
                vtest.Close();
                setWidth();
            }

        }
        public void setWidth()
        {
            dataGridView1.Columns[0].Width = 30; //30,50,50,70
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Width = 50;
            dataGridView1.Columns[3].Width = 70;
        }
      

        public void progress_update()
        {
            progressBar1.Increment(1);
        }
      

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            label4.Text = e.UserState.ToString();


            this.Invoke(new Action(() =>
            progressBar1.Value = e.ProgressPercentage
            ));
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) //воркер для рейтинга
        {

            var text1 = new analysis();
            text1.versdel(ratef, false, sender as BackgroundWorker);


        }
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            DialogResult result = new DialogResult();

            Invoke((Action)(() => {  result = saveFileDialog1.ShowDialog(); }));
          //  DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var syncStream = Stream.Synchronized(myStream);
                    var text1 = new rating();
                    int m = (int)numericUpDown1.Value;
                    //label4.Enabled = false;
                    text1.applymute(m, ratef, sender as BackgroundWorker, syncStream);
                    
                    myStream.Close();
                }
                else
                {
                    e.Cancel = true;

                }
            }
            //сохранение файла
            
        }

 
        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int k = rating.counting(text.pathv + text.ustartf, text.pathv + text.uendf);
            label8.Text = "Мутаций в рейтинге: " + k.ToString();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
           // fillGrid(true);
            label4.Text = "Подсчет рейтинга мутаций...";
            progressBar1.Value = 50;
            backgroundWorker6.RunWorkerAsync();
            if(File.Exists(text.pathv + text.dicp)){
                button8.Enabled = true;
                button13.Enabled = true;
                button1.Enabled = true;

            }
            else
            {
                button1.Enabled = true;
                button8.Enabled = true;
            }

       

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e) //мутировать рейтинг
        {
            backgroundWorker2.RunWorkerAsync();
          //  text.applymute((int)numericUpDown1.Value);
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        //    MessageBox.Show("Processing ended successfully!");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var lineCount = File.ReadLines(text.pathv + text.otf).Count();
            
            int prog = lineCount / 100;
            int m = 10000 % prog;
            label4.Text = m.ToString() + " " + prog.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

 
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e) //добавить рейтинг
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (DialogResult.OK == result)
            {
                ptop = openFileDialog1.FileName;
                File.Copy(ptop, ratef);
               
                button11.Enabled = false;
                button14.Enabled = true;
                button1.Enabled = true;
                button8.Enabled = true;

                
                backgroundWorker1.RunWorkerAsync();
            }
            
           


        }

        private void button10_Click(object sender, EventArgs e) //добавить словари
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            DialogResult result = openFileDialog1.ShowDialog();
            if (DialogResult.OK == result)
            {
                dic.AddRange(openFileDialog1.FileNames);
                files.adddic(dic);
                button12.Enabled = true;
                dic.Clear();
                label6.Text = "Паролей в общем словаре: " + files.diccount().ToString();

            }

        }

        private void button13_Click(object sender, EventArgs e) //мутировать словарь и рейтинг
        {
            backgroundWorker4.RunWorkerAsync();
        }

        private void button12_Click(object sender, EventArgs e) //проверить общий словарь на мутации
        {
            backgroundWorker3.RunWorkerAsync();

        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (DialogResult.OK == result)
            {
                ptop = openFileDialog1.FileName;
                File.Delete(ratef);
                File.Copy(ptop, ratef);
                backgroundWorker1.RunWorkerAsync();

            }
            
            
        }

        private void button5_Click(object sender, EventArgs e) //сбросить мутации
        {
            // пересоздаем файлы 
            File.Create(text.pathv + text.ustartf); //начало
            File.Create(text.pathv + text.uendf);//конец
            File.Delete(text.pathv + text.rate); //рейтинг
            

            dataGridView1.DataSource = null;
            File.Delete(text.pathv + text.binrate);
            dataGridView1.Rows.Clear();

            dataGridView1.Refresh();
            label8.Text = "Мутаций в рейтинге: 0";
            button8.Enabled = false;
            button13.Enabled = false;
            button1.Enabled = false;


        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e) //воркер для проверки словаря
        {
            var text1 = new analysis();
            text1.versdel(dicf, true, sender as BackgroundWorker);

        }

        private void backgroundWorker3_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            label4.Text = e.UserState.ToString();
            this.Invoke(new Action(() =>
            progressBar1.Value = e.ProgressPercentage
            ));
            //сюда пойдет прогрессбар
        }

        private void backgroundWorker3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            int k = rating.counting(text.pathv + text.ustartf, text.pathv + text.uendf);
            label8.Text = "Мутаций в рейтинге: " + k.ToString();
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
         //   fillGrid(true);
            backgroundWorker6.RunWorkerAsync();
            button13.Enabled = true;
            MessageBox.Show("Processing ended successfully!");
        }

        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            //сохранение файла 
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            DialogResult result = new DialogResult();

            Invoke((Action)(() => { result = saveFileDialog1.ShowDialog(); }));
            //  DialogResult result = saveFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    var text1 = new rating();
                    files.unitetemp("unittemp",text.pratef, text.pathv + text.dicp ); //соединяем файл рейтинга и файл словаря в один
                    text1.applymute((int)numericUpDown1.Value, text.pathv + "unittemp", sender as BackgroundWorker, myStream);
                    .
                    myStream.Close();
                }
                else
                {
                    e.Cancel = true;

                }
            }
            //сохранение файла
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
progress = progressBar1.Value.ToString() + " %";
if (!backgroundWorker5.IsBusy) { backgroundWorker5.RunWorkerAsync(); }

            this.Invoke(new Action(() =>
            progressBar1.Value = e.ProgressPercentage
            
            ));


        }

        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
             this.Invoke(new Action(() =>
            label4.Text = progress
              ));
        }

        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            fillGrid(true);
        }

        private void backgroundWorker6_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //this.Invoke(new Action(() =>
            //progressBar1.Value = e.ProgressPercentage

            //));
        }

        private void backgroundWorker6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            label4.Text = "Подсчет рейтинга завершен!";
        }

        private void backgroundWorker4_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress = progressBar1.Value.ToString() + " %";
            if (!backgroundWorker5.IsBusy) { backgroundWorker5.RunWorkerAsync(); }

            this.Invoke(new Action(() =>
            progressBar1.Value = e.ProgressPercentage

            ));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text Files (.txt)|*.txt|All Files (*.*)|*.*";
            openFileDialog1.Multiselect = false;
            DialogResult result = openFileDialog1.ShowDialog();
            if (DialogResult.OK == result)
            {
                mutfile = openFileDialog1.FileName;
               
                backgroundWorker7.RunWorkerAsync();
            }
        }

        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {

            files.ctfile(mutfile);
            
            var myStream = File.OpenWrite(mutfile);
            var syncStream = Stream.Synchronized(myStream);
            var text1 = new rating();
            int m = (int)numericUpDown1.Value;
            //label4.Enabled = false;
            text1.applymute(m, text.pathv + text.tmutf, sender as BackgroundWorker, syncStream);
            // Code to write the stream goes here.
            myStream.Close();
        }

        private void backgroundWorker7_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progress = progressBar1.Value.ToString() + " %";
            if (!backgroundWorker5.IsBusy) { backgroundWorker5.RunWorkerAsync(); }

            this.Invoke(new Action(() =>
            progressBar1.Value = e.ProgressPercentage

            ));

        }

        private void backgroundWorker7_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        


        
    }
}
