/**************
*Universidade Paulista - UNIP Alphaville
*Sistema de Informação - 6°Semestre
*
*Sistemas Operacionais Abertos
*
*Aluno: João Victor Franco de Oliveira
*Matrícula: D62JDE-9
*
*Data de entrega: 14/10/2020
***************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testesimulador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] paginacao = new int[10] { 8, 2, 7, 1, 2, 3, 5, 6, 9, 4 };
            int[] fifo = new int[3] { 000, 000, 000 };
            int hit = 0;

            int Falta = 0;
            /*
         ****8 2 7 1 2 3 5 6 9 4***
             8 8 8 2 7 1 2 3 5 6
               2 2 7 1 2 3 5 6 9
                 7 1 2 3 5 6 9 4
            */
            

            Console.WriteLine("quantidade de paginas: " + paginacao.Length);
            for (int i = 0; i < 10; i++)
            {
                if (i < 3)
                {
                    if (paginacao[i] != fifo[0] && paginacao[i] != fifo[1] && paginacao[i] != fifo[2])/*(i < 3)*/
                    {
                        fifo[i] = paginacao[i];
                        Falta++;

                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine("valor da coluna: " + fifo[j]);
                        }
                        Console.WriteLine("-----------------------------------");
                    }
                }

                else
                {
                    if (paginacao[i] != fifo[0] && paginacao[i] != fifo[1] && paginacao[i] != fifo[2])
                    {
                        fifo[0] = fifo[1];
                        fifo[1] = fifo[2];
                        fifo[2] = paginacao[i];

                        Falta++;

                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine("Valor da coluna: " + fifo[j]);
                        }
                        Console.WriteLine("-----------------------------------");
                    }

                    else
                    {
                        Console.WriteLine("Houve uma repetição nessa coluna");
                        hit++;
                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine("Valor da coluna: " + fifo[j]);
                        }
                        Console.WriteLine("-----------------------------------");
                    }

                }

            }

            textBox1.Text = "" + paginacao.Length;
            textBox2.Text = "" + hit;
            textBox3.Text = "" + Falta;
            textBox4.Text = "" + paginacao[7] + "   |   " + paginacao[8] + "   |   " + paginacao[9];
            textBox5.Text = "" + paginacao[0] + "   |   " + paginacao[1] + "   |   " + paginacao[2] + "   |   " + paginacao[3] + "   |   " + paginacao[4] + "   |   " + paginacao[5] + "   |   " + paginacao[6] + "   |   " + paginacao[7] + "   |   " + paginacao[8] + "   |   " + paginacao[9];


            Console.WriteLine("Hit: " + hit);
            Console.WriteLine("Falta: " + Falta);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


    }
}
