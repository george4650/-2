using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using гщоавырщшгв;

namespace Практическая_работа_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        //Очистить
        private void button2_Click(object sender, EventArgs e)
        {
            rez.Clear();
            table.ColumnCount = 5;
            table.RowCount = 1;
            kolvo.Value = 5;
            for (int i = 0; i < table.ColumnCount; i++) table[i, 0].Value = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table.ColumnCount = 5;
            table.RowCount = 1;
        }
        //Кол-во значений
        private void kolvo_ValueChanged(object sender, EventArgs e)
        {
            table.ColumnCount = Convert.ToInt32(kolvo.Value);//Кол-во столбцов
            
        }
        //Выход
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Заполнить
        private void button4_Click(object sender, EventArgs e)
        {
            int RandMax = Convert.ToInt32(diapozon.Value);
            Random Rand = new Random();
            for (int i = 0; i < table.ColumnCount; i++) table[i, 0].Value = Rand.Next(RandMax);
        }
        //рассчёт
        private void button1_Click(object sender, EventArgs e)
        {
            double sum=гщоавырщшгв.Class1.Summ(table);
            rez.Text = sum.ToString();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Практическая работа № 2, 15 вариант\n" +
                "Ввести n целых чисел. Вычислить sin суммы чисел > 3. Результат вывести на экран.   \n" +
                "Бароян Гиоргий ИСП-31");
        }
    }
}
