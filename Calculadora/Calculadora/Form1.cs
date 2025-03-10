namespace Calculadora
{
    public partial class Form1 : Form
    {

        private string operacao = string.Empty;
        private int numeroUm, numeroDois;

        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoClicado(object sender, EventArgs e)
        {

            Button btn = sender as Button; // Converte sender para um bot�o

            if (btn != null)
            {

                if (btn.Text == "+" || btn.Text == "-" || btn.Text == "x" || btn.Text == "�")
                {
                    
                    operacao = btn.Text;

                }


                else if (btn.Text == "=")
                {

                    bool sucessoNumeroUm = int.TryParse(primeiroNumeroTextBox1.Text, out numeroUm);
                    bool sucessoNumeroDois = int.TryParse(segundoNumeroTextBox.Text, out numeroDois);

                    if (!sucessoNumeroUm || !sucessoNumeroDois)
                    {
                        MessageBox.Show("Por favor, insira n�meros v�lidos.");
                        return;
                    }

                    int resultado = 0;

                    switch (operacao)
                    {
                        case "+":
                            resultado = numeroUm + numeroDois;
                            break;
                        case "-":
                            resultado = numeroUm - numeroDois;
                            break;
                        case "x":
                            resultado = numeroUm * numeroDois;
                            break;
                        case "�":
                            if (numeroDois != 0)
                            {
                                resultado = numeroUm / numeroDois;
                            }
                            else
                            {
                                MessageBox.Show("N�o � poss�vel dividir por zero.");
                                return;
                            }
                            break;
                        default:
                            MessageBox.Show("Opera��o inv�lida.");
                            return;
                    }

                    resultadoLabel2.Text = $"{resultado}";
                }


            }


        }
    }

}