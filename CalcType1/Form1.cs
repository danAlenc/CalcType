using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcType1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) //Soma
        {
            Processos p = new Processos();

            //Configura os valores de numero1 e numero2 com base nos textBox
            p.setNumero1(txtNumero1.Text);
            p.setNumero2(txtNumero2.Text);

            // Obtém o valor da propriedade txtNumero1 como uma string
            string numero01String = p.getNumero1();
            string numero02String = p.getNumero2();

            // Tenta converter a string para double
            if (double.TryParse(numero01String, out double numero01) && double.TryParse(numero02String, out double numero02))
            {
                // Somando os valores
                double resultado = numero01 + numero02;

                //Define o resultado na propriedade Result do processos(set/get)
                p.setResult(resultado.ToString());

                //Configura o resultado no TexBox txtresult
                txtResult.Text = resultado.ToString();
                
            }
            else
            {
                // Lidar com o caso em que a conversão falha
                Console.WriteLine("Falha na conversão para double.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e) //Limpar os campos
        {
            txtNumero1.Text = "";
            txtNumero2.Text = "";
            txtResult.Text = "";
        }

        private void btSubtrair_Click(object sender, EventArgs e)
        {
            Processos p = new Processos();

            p.setNumero1(txtNumero1.Text);
            p.setNumero2(txtNumero2.Text);

            //Processo da linha 28 e 32 em uma unica linha
            double numero1 = double.TryParse(p.getNumero1(), out double parsedValue) ? parsedValue : 0.0;
            double numero2 = double.TryParse(p.getNumero2(), out double parsedValue1) ? parsedValue1 : 0.0;

            //Subtração
            double resultado = numero1 - numero2;

            p.setResult(resultado.ToString());
            txtResult.Text = resultado.ToString();
        }

        private void btMultiplicar_Click(object sender, EventArgs e)
        {
            Processos p = new Processos();

            p.setNumero1(txtNumero1.Text);
            p.setNumero2(txtNumero2.Text);

            double numero1 = double.TryParse(p.getNumero1(), out double parsedValue) ? parsedValue : 0.0;
            double numero2 = double.TryParse(p.getNumero2(), out double parsedValue1) ? parsedValue1 : 0.0;

            double resultado = numero1 * numero2;

            p.setResult(resultado.ToString());
            txtResult.Text = resultado.ToString();
        }

        private void btDividir_Click(object sender, EventArgs e)
        {
            Processos p = new Processos();

            p.setNumero1(txtNumero1.Text);
            p.setNumero2(txtNumero2.Text);

            double numero1 = double.TryParse(p.getNumero1(), out double parsedValue) ? parsedValue : 0.0;
            double numero2 = double.TryParse(p.getNumero2(), out double parsedValue1) ? parsedValue1 : 0.0;

            double resultado = numero1 / numero2;

            p.setResult(resultado.ToString());
            txtResult.Text = resultado.ToString();
        }

        private void btPorcentagem_Click(object sender, EventArgs e)
        {

        }
    }
}
