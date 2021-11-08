using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_DecimalBinaryCalculater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (rdoBinaryToDecimal.Checked == true)
            {
                // string Input 는 tboxInput 으로 변경
                string Input = tboxInput.Text;
                int length = Input.Length;

                int[] T = new int[length];
                int[] H = new int[length];
                int S = 0, K = 0, B = 0, Sign = 0;

                for (int i = 0; i < length; i++)
                {
                    T[i] = int.Parse(Input.Substring(i, 1));
                }


                if (T[0] == 0)
                {
                    Sign = 1;

                    for (int i = length - 1; i > 0; i--)
                    {
                        int test1 = T[i];
                        int test2 = ((int)(Math.Pow(2, length - i - 1)));

                        K = T[i] * ((int)(Math.Pow(2, length - i - 1)));
                        S = S + K;
                    }

                    S = S * Sign;

                    tboxResult.Text = S.ToString();
                }
                else
                {
                    Sign = -1;
                    B = 1;

                    for (int i = length - 1; i > 0; i--)
                    {
                        H[i] = T[i] - B;

                        if (T[i] == 0 && B == 1)
                            B = 1;
                        else
                            B = 0;

                        if (H[i] < 0)
                            H[i] = H[i] * -1;
                    }

                    for (int i = 0; i < length; i++)
                        T[i] = 1 - H[i];

                    for (int i = length - 1; i > 0; i--)
                    {
                        K = T[i] * ((int)(Math.Pow(2, length - i - 1)));
                        S = S + K;
                    }

                    S = S * Sign;

                    tboxResult.Text = S.ToString();
                }
            }

            if (rdoDecimalToBinary.Checked == true)
            {
                int Dec = int.Parse(tboxInput.Text);
                int[] S = new int[8];
                int i;

                for (i = 0; i < 8; i++)
                {
                    S[i] = 0;
                }

                int M = 1;
                int R = 1;

                i = 7;

                while (true)
                {
                    if (M == 0)
                    {
                        StringBuilder sb = new StringBuilder();

                        for (i = 0; i < 8; i++)
                        {
                            sb.Append(S[i].ToString());
                        }

                        tboxResult.Text = sb.ToString();
                        break;
                    }
                    else
                    {
                        M = Dec / 2;
                        R = Dec - M * 2;
                        S[i] = R;
                        Dec = M;
                        i = i - 1;
                    }
                }
            }
        }
    }
}
