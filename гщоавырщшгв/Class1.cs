using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace гщоавырщшгв
{
    public class Class1
    {
        public static double Summ(DataGridView table)
        {
            double sum = 0;
            for (int i = 0; i < table.ColumnCount; i++)
            {
                if (Convert.ToInt32(table[i, 0].Value) > 3)
                    sum += Convert.ToInt32(table[i, 0].Value);
            }
            sum = Math.Sin(sum);
            return sum;
        }
    }
}
