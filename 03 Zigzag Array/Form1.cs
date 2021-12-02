using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Zigzag_Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int R = 0;

            ArrayList arrHeight = new ArrayList();
            for (int i = 0; i < int.Parse(tboxHeight.Text); i++)
            {
                List<int> arrWidth = new List<int>();

                for (int y = 0; y < int.Parse(tboxWidth.Text); y++)
                {
                    R += 2;
                    arrWidth.Add(R);
                }

                arrHeight.Add(arrWidth);
            }

            for (int i = 0; i < arrHeight.Count; i++)
            {
                if (i % 2 == 1)
                {
                    List<int> a = (List<int>)arrHeight[i];

                    a.Reverse();

                    arrHeight[i] = a;
                }
            }

            DataTable dt = new DataTable();

            for (int i = 0; i < int.Parse(tboxWidth.Text); i++)
            {
                DataColumn dc = new DataColumn($"{i}", typeof(int));
                dt.Columns.Add(dc);
            }

            foreach (var item in arrHeight)
            {
                DataRow dr = dt.NewRow();
                List<int> a = (List<int>)item;

                for (int i = 0; i < int.Parse(tboxWidth.Text); i++)
                {
                    dr[$"{i}"] = a[i];                    
                }

                dt.Rows.Add(dr);
            }

            dgvResult.DataSource = dt;
        }
    }
}
