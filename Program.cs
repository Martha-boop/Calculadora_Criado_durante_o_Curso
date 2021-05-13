using System;

namespace Calculadora
{
    class Program
    {
        enum Menu { Somar = 1, subtracao = 2, divisao = 3, multiplicacao = 4, potencia = 5, raiz = 6, sair = 7 }
        static void Main(string[] args)
        {
            bool Escolheusair = false;
            while (!Escolheusair)//Enquanto o usuario Não(!) escolher sair exiba o menu.
            {
                Console.WriteLine("Seja bem vindo ao Calc,selecione umas das opções!");
                Console.WriteLine("1-Somar\n2-Subtracão\n3-Divisão\n4-Multiplicação\n5-Potência\n6-Raiz\n7-Sair");

                /* string opcaoTxt = Console.ReadLine(); Umas das formas de se fazer! 
                int opcaoInt = int.Parse(opcaoTxt);
                 Menu opcao = (Menu)opcaoInt;*/


                // int indice = int.Parse(Console.ReadLine()); outra forma de fazer! 
                // Menu opcao = (Menu)indice;
                // Console.WriteLine(opcao);

                Menu opcao = (Menu)int.Parse(Console.ReadLine());// A forma mais limpa!
                
                switch (opcao)
                {
                    case Menu.raiz:
                        raiz();
                        break;
                    case Menu.potencia:
                        pot();
                        break;
                    case Menu.subtracao:
                        Sub();
                        break;
                    case Menu.multiplicacao:
                        Mult();
                        break;
                            
                    case Menu.divisao:
                        Div();
                        break;
                           
                    case Menu.Somar:
                        soma();
                        break;
                    case Menu.sair:
                        Escolheusair = true;
                        break;
                }
                


                Console.Clear();
            }

        }
        static void soma()
        { 
            Console.WriteLine("Soma de dois numeros!");
            Console.WriteLine("Digite o primeiro numero!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero!");
            int b = int.Parse(Console.ReadLine());
            int reslt = a + b;
            Console.WriteLine("O resultado é!" + reslt);
            Console.WriteLine("Aperte enter para voltar ao menu!");
            Console.ReadLine();
        }
        static void Div()
        {
            Console.WriteLine("Digite a Divisão dos dois numeros!");
            Console.WriteLine("Digite o primeiro numero!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero!");
            int b = int.Parse(Console.ReadLine());
            float result = (float)a/(float)b;
            Console.WriteLine(" O resultado é!" + result);
            Console.WriteLine("Aperte enter para voltar ao menu!");
            Console.ReadLine();
            
        }
        static void Mult()
        {
            Console.WriteLine("Digite a Multiplicação dos dois numeros!");
            Console.WriteLine("Digite o primeiro numero!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero!");
            int b = int.Parse(Console.ReadLine());
            int result = a * b;
            Console.WriteLine("O resultado é !" + result);
            Console.WriteLine("Aperte enter para voltar ao menu!");
            Console.ReadLine();
        }
        static void Sub()
        {
            Console.WriteLine("Digite a Subtração de dois numeros!");
            Console.WriteLine("Digite o primeiro numero!");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero!");
            int b = int.Parse(Console.ReadLine());
            int reult = a - b;
            Console.WriteLine("O resultado é!" + reult);
            Console.WriteLine("aperte enter para voltar ao menu!");
            Console.ReadLine();
        }
        static void pot()
        {
            Console.WriteLine("Digite a potência de um numero!");
            Console.WriteLine("Digite a base!");
            int baseNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o expoente!");
            int expo = int.Parse(Console.ReadLine());
            int result = (int)Math.Pow(baseNum, expo);//Math.pow siguinifica potência.
            Console.WriteLine("O resulatado é!" + result);
            Console.WriteLine("Aperte enter para voltar ao menu!");
            Console.ReadLine();
        }
        static void raiz()
        {
            Console.WriteLine("Digite a raiz de um numero!");
            Console.WriteLine("Digite o numero!");
            int a = int.Parse(Console.ReadLine());
            double result = Math.Sqrt(a);//Math.Sqrt siguinifica raiz quadrada. Double  por que tem muitas casas decimais
            Console.WriteLine("O resultado é!" + result);
            Console.WriteLine("Aperte enter para voltar ao menu!");
            Console.ReadLine();

        }
        

    }




}       
       
    
