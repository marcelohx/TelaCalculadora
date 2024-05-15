using System;
using System.Windows.Forms;

namespace TelaCalculadora_2
{
    public partial class Calculadora : Form
    {
        //Area das variaveis
        private int num1;
        private int num2;
        private int resultado = 0;
        private int valor1;
        private int numero;

        Model modelo;
        //Construtor
        public Calculadora()
        {
            InitializeComponent();
            modelo = new Model();
            consultarNum1 = 0;
            consultarNum2 = 0;
        }//Fim do construtor

        //Metodo GET e SET
        public int consultarNum1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int consultarNum2
        {
            get { return num2; }
            set { num2 = value; }
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void telaCalculo_TextChanged(object sender, EventArgs e)
        {

        }

        private void porcento_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "%";
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            resultado = 0;
            telaCalculo.Text = "";
        }

        private void limparTudo_Click(object sender, EventArgs e)
        {
            resultado = 0;
            telaCalculo.Text = "";
        }

        private void mais_Click(object sender, EventArgs e)
        {
            resultado += numero;
            telaCalculo.Text = "" + resultado;
        }

        private void sete_Click(object sender, EventArgs e)
        {

            telaCalculo.Text += "7";
            numero = 7;
        }

        private void oito_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "8";
            numero = 8;
        }

        private void nove_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "9";
            numero = 9;
        }

        private void menos_Click(object sender, EventArgs e)
        {
            
            resultado -= numero;
            telaCalculo.Text = "" + resultado;
            
        }

        private void quatro_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "4";
            numero = 4;
        }

        private void cinco_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "5";
            numero = 5;
        }

        private void seis_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "6";
            numero = 6;
        }

        private void multiplicacao_Click(object sender, EventArgs e)
        {
            resultado *= numero;
            telaCalculo.Text = "" + resultado;
           
        }

        private void um_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "1";
            numero = 1;
        }

        private void dois_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "2";
            numero = 2;
        }

        private void tres_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "3";
            numero = 3;
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            
            resultado /= numero;
            telaCalculo.Text = "" + resultado;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += "0";
            numero = 0;
        }

        private void virgula_Click(object sender, EventArgs e)
        {
            telaCalculo.Text += ",";
        }

        private void igual_Click(object sender, EventArgs e)
        {
             
         
            telaCalculo.Text = "" + resultado;

            
            /*
            //Definir ate onde o num1 pode ser digitado
            do
            {
                consultarNum1 = Convert.ToInt32(Console.ReadLine());
            } while (flag != 0);
            flag = 1;
            //Definir ate onde o num2 pode ser digitado
            do
            {
                consultarNum2 = Convert.ToInt32(Console.ReadLine());
            } while (flag != 0);
            flag = 1;


            switch (telaCalculo.Text)
            {
                case "1":
                    if(telaCalculo.Text == "+")
                    {
                        telaCalculo.Text = "" + (consultarNum1 + consultarNum2);
                    }
                    break;
                case "2": 
                    if(telaCalculo.Text == "-")
                    {
                        telaCalculo.Text = "" + (consultarNum1 - consultarNum2);
                    }
                    break;
                case "3":
                    if(telaCalculo.Text == "*")
                    {
                        telaCalculo.Text = "" + consultarNum1 * consultarNum2;
                    }
                    break;
                case "4":
                    if(telaCalculo.Text == "/")
                    {
                        if (consultarNum2 <= 0)
                        {
                            telaCalculo.Text = "Impossivel calcular";
                        }
                        else
                        {
                            telaCalculo.Text = "" + (consultarNum1 / consultarNum2);
                        }
                    }
                    break;
            }
            */
        }
    }
}
