using System;

namespace Atividade_2__Alice_Reis
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            float saldo;

            void CadastrarUsuario()
            {
                Console.WriteLine("Informe o seu nome:");
                nome = Console.ReadLine();
                Console.WriteLine("Informe o saldo da sua conta");
                saldo = float.Parse(Console.ReadLine());


            }


                void ConsultarConta()
            {
                Console.WriteLine("A conta de " + nome + " tem R$ " + saldo);


            }

                    void ApagarConta()
            {

                saldo = 0;
                nome = " ";
            }

                        CadastrarUsuario();
                        ConsultarConta();
                        ApagarConta();
                        ConsultarConta();

            Console.ReadKey();


        }

        


                }
            }
        
 