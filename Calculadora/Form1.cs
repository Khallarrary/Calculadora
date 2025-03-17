namespace Calculadora
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void BotaoClicadoOperador(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (btn != null)
            {
                string textoAtual = displayTextBox.Text;

                // Impede que um operador seja inserido se já houver um no final
                if (textoAtual.Length > 0 && "+-x÷".Contains(textoAtual.Last()))
                {

                    return;
                }

                // Adiciona o operador ao display
                displayTextBox.Text += btn.Text;

            }
        }

        private void numeroButtonClicado(object sender, EventArgs e)
        {

            Button btn = sender as Button;

            if (btn != null)
            {
                // Adiciona o número digitado ao display
                displayTextBox.Text += btn.Text;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            // Limpa o display
            displayTextBox.Text = "";
        }


        /// <summary>
        /// Evento chamado quando o botão "=" (igual) é clicado.
        /// Realiza a operação matemática e exibe o resultado.
        /// </summary>
        private void igualButton_Click(object sender, EventArgs e)
        {
            string expressao = displayTextBox.Text;

            // Definição dos operadores permitidos
            char[] operadores = { '+', '-', '÷', 'x' };

            // Divide a expressão nos operadores
            string[] partes = expressao.Split(operadores);

            // Converte os números digitados de string para inteiro
            int numeroUm = Convert.ToInt32(partes[0]);
            int numeroDois = Convert.ToInt32(partes[1]);

            // Obtém o operador da expressão
            char operador = expressao.FirstOrDefault(c => "+-x÷".Contains(c));

            int resultado = 0;


            // Executa a operação com base no operador encontrado
            switch (operador)
            {
                case '+':
                    resultado = numeroUm + numeroDois;

                    break;
                case '-':

                    resultado = numeroUm - numeroDois;

                    break;
                case '÷':
                    if (numeroDois == 0)
                    {
                        MessageBox.Show("Erro: Divisão por 0");
                        return;
                    }
                    resultado = numeroUm / numeroDois;

                    break;
                case 'x':
                    resultado = numeroUm * numeroDois;

                    break;

            }

            // Exibe o resultado no display
            displayTextBox.Text = resultado.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (displayTextBox.Text.Length > 0) {

                // Remove o último caractere do display
                displayTextBox.Text = displayTextBox.Text.Substring(0, displayTextBox.Text.Length - 1);
            }
        }
    }
}
