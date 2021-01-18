using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;

namespace lab11zavd2
{
    class Program
    {
        static bool Inputdata(ref double p, string buk)
        {
            string inp;
        vvod:
            inp = Interaction.InputBox(buk, "vvedenia", $"{p}");
            try
            {
                p = Convert.ToDouble(inp);
            }
            catch (System.FormatException)
            {
                if (MessageBox.Show("vi vveli ne 4islo" + "\npovtorit?", "uvaga", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    goto vvod;
                else
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
           st:
            double[] arr;
            arr = new double[10];
            string output = "";

            for (int i = 0; i < 10; i++)
            {
                if (!Inputdata(ref arr[i], $"vvedit {i} element:"))
                    return;

                if (arr[i] > 0)
                    arr[i] = Math.Sqrt(arr[i]);

                if (arr[i] < 0)
                    arr[i] = Math.Pow(arr[i], 1 / 3);

                output += $" array[{i}]={arr[i]}";
            }

            if (MessageBox.Show(output + "\n\nPovtor?", "Rezultat", MessageBoxButtons.YesNo) == DialogResult.Yes)
                goto st;

        }
    }
}
