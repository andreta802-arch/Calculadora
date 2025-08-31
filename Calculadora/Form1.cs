using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        string displayText = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            displayText += "0";
            Display.Text = displayText;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            displayText += "1";
            Display.Text = displayText;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            displayText += "2";
            Display.Text = displayText;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            displayText += "3";
            Display.Text = displayText;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            displayText += "4";
            Display.Text = displayText;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            displayText += "5";
            Display.Text = displayText;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            displayText += "6";
            Display.Text = displayText;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            displayText += "7";
            Display.Text = displayText;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            displayText += "8";
            Display.Text = displayText;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            displayText += "9";
            Display.Text = displayText;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            displayText += "+";
            Display.Text = displayText;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            displayText += "-";
            Display.Text = displayText;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            displayText += "*";
            Display.Text = displayText;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            displayText += "/";
            Display.Text = displayText;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            displayText += "%";
            Display.Text = displayText;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            displayText += "(";
            Display.Text = displayText;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            displayText = "";
            Display.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            displayText += ".";
            Display.Text = displayText;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
            try
            {
                // 2. Tokeniza a expressão (separa números e operadores)
                List<string> tokens = Tokenizar(displayText);

                // 3. Converte para notação pós-fixada (RPN)
                List<string> posfixa = ParaPosfixa(tokens);

                // 4. Calcula o resultado usando pilha
                double resultado = CalcularPosfixa(posfixa);

                // 5. Mostra o resultado
                Display.Text = resultado.ToString();
                displayText = resultado.ToString();
            }
            catch
            {
                Display.Text = "Erro";
            }
        }

        // Função para separar números e operadores, incluindo negativos
        List<string> Tokenizar(string expr)
        {
            List<string> tokens = new List<string>();
            string numero = "";
            for (int i = 0; i < expr.Length; i++)
            {
                char c = expr[i];

                // Se for dígito ou ponto, monta o número normalmente
                if (char.IsDigit(c) || c == '.')
                {
                    numero += c;
                }
                // Se for sinal de menos ou mais
                else if (c == '-' || c == '+')
                {
                    // Se for o primeiro caractere ou logo após um operador ou parêntese
                    if (i == 0 || "+-*/%(".Contains(expr[i - 1]))
                    {
                        numero += c; // Faz parte do número (ex: -6 ou +6)
                    }
                    else
                    {
                        // Finaliza número anterior, se houver
                        if (numero != "")
                        {
                            tokens.Add(numero);
                            numero = "";
                        }
                        tokens.Add(c.ToString()); // Adiciona operador
                    }
                }
                // Se for operador ou parêntese
                else if ("*/%()".Contains(c))
                {
                    if (numero != "")
                    {
                        tokens.Add(numero);
                        numero = "";
                    }
                    tokens.Add(c.ToString());
                }
            }
            if (numero != "")
                tokens.Add(numero);
            return tokens;
        }

        // Função para converter para notação pós-fixada (RPN)
        List<string> ParaPosfixa(List<string> tokens)
        {
            List<string> saida = new List<string>();
            Stack<string> operadores = new Stack<string>();
            Dictionary<string, int> precedencia = new Dictionary<string, int>
    {
        { "+", 1 }, { "-", 1 },
        { "*", 2 }, { "/", 2 }, { "%", 2 }
    };

            foreach (string token in tokens)
            {
                double n;
                if (double.TryParse(token, out n))
                {
                    saida.Add(token); // Número vai direto para saída
                }
                else if ("+-*/%".Contains(token))
                {
                    while (operadores.Count > 0 && operadores.Peek() != "(" &&
                           precedencia[operadores.Peek()] >= precedencia[token])
                    {
                        saida.Add(operadores.Pop()); // Desempilha operadores de maior ou igual precedência
                    }
                    operadores.Push(token); // Empilha operador atual
                }
                else if (token == "(")
                {
                    operadores.Push(token); // Empilha parêntese
                }
                else if (token == ")")
                {
                    while (operadores.Count > 0 && operadores.Peek() != "(")
                    {
                        saida.Add(operadores.Pop()); // Desempilha até achar "("
                    }
                    if (operadores.Count > 0)
                        operadores.Pop(); // Remove o "("
                }
            }
            while (operadores.Count > 0)
                saida.Add(operadores.Pop()); // Desempilha o resto

            return saida;
        }

        // Função para calcular a expressão pós-fixada
        double CalcularPosfixa(List<string> posfixa)
        {
            Stack<double> pilha = new Stack<double>();
            foreach (string token in posfixa)
            {
                double n;
                if (double.TryParse(token, out n))
                {
                    pilha.Push(n); // Empilha número
                }
                else
                {
                    // Desempilha dois números e aplica o operador
                    double b = pilha.Pop();
                    double a = pilha.Pop();
                    switch (token)
                    {
                        case "+": pilha.Push(a + b); break;
                        case "-": pilha.Push(a - b); break;
                        case "*": pilha.Push(a * b); break;
                        case "/": pilha.Push(a / b); break;
                        case "%": pilha.Push(a % b); break;
                    }
                }
            }
            return pilha.Pop(); // Resultado final
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}