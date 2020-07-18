using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float saldo = 100;
            float saque = 10;
            saldo = saldo - saque; 
            
            
            MessageBox.Show("O saldo do senhor após o saque é:" + saldo);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int idadeMilton = 15;
            int idadeHugo = 39;
            int idadeNathalia = 16;
            float mediaIdades = 0;

            mediaIdades = (idadeHugo + idadeMilton + idadeNathalia) / 3;
            MessageBox.Show("MEDIA DAS IDADES DOS PUTO:"+mediaIdades);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado =" + piQuebrado);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = 4;
            int b = 10;
            int c = 5;
            Double Delta = b * b - 4 * a * c;
            Double a1 = -b + Math.Sqrt(Delta);
            Double a2 = -b - Math.Sqrt(Delta);
            MessageBox.Show("a1:"+a1);
            MessageBox.Show("a2:"+a2);



        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Double NFvalor = 5352;
            if (NFvalor <= 999)
            {
                MessageBox.Show("Imposto de 2%");
            }
            else if (NFvalor <= 2999) 
            {
                MessageBox.Show("Imposto de 2.5%");
            }
            else if (NFvalor <= 9999)
            {
                MessageBox.Show("Imposto de 2.8%");
            }
            else
            {
                MessageBox.Show("Imposto de 3%");
            }
        
        
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string resultado = "";
            int valor = 15;
            resultado += valor < 10 ? MessageBox.Show("Menor que 10") : MessageBox.Show("Maior que 10");
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int SOMA = 0;
            for (int i = 0; i <= 1000; i++)
            {
                
                SOMA += i;
             }
            MessageBox.Show(SOMA.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++) 
            {
                if (i % 3 == 0)
                {
                    MessageBox.Show(i.ToString());
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int soma = 0;
            int multiplos = 0;
            int conta = 0;
            for (int i = 0; i <= 100; i++)
            {
                soma+=i;
                if (i % 3 == 0)
                {
                    multiplos += i;
                }

            }
            conta = soma - multiplos;
            MessageBox.Show(conta.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 30; i++)
            {
                if((i % 3 == 0) || (i % 4 == 0))
                {
                    MessageBox.Show(i.ToString());
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int fatorial = 1;
            for (int n = 1; n <= 10; n++)
            {
                fatorial = n * fatorial;
                MessageBox.Show(fatorial.ToString());
            }
                    
                    
                
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("0");
            for (int i = 0; i <= 10; i++)
            {
                i = i - 1 + i - 2;
                MessageBox.Show(i.ToString());
                 

            }
        }
    }
}
