using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        private static Cliente cliente;

        static void Main(string[] args)
        {
            try
            {

            Console.WriteLine("*******************************************");
            Console.WriteLine(" BEM VINDO AO BANCO DIGITAL DIO - BANKING");
            Console.WriteLine();

            Console.WriteLine("REALIZE AGORA O SEU CADASTRO. ");
            Console.Write("INFORME O NOME DO CLIENTE: ");
            string nome = Console.ReadLine().ToUpper();
            Console.Write("INFORME CPF COM 11 DÍGITOS: ");
            string cpf = Console.ReadLine();
            Console.Write("INFORME RG: ");
            string rg = Console.ReadLine();
            Console.WriteLine();

            Console.Write("INFORME O CEP COM 8 DÍGITOS: ");
            string cep = Console.ReadLine();
            Console.Write("ENDEREÇO. \nLOGRADOURO + Nº DA RESIDÊNCIA: ");
            string logradouro = Console.ReadLine().ToUpper();
            Console.Write("BAIRRO: ");
            string bairro = Console.ReadLine().ToUpper();
            Console.Write("CIDADE: ");
            string cidade = Console.ReadLine().ToUpper();
            Console.Write("ESTADO: ");
            string estado = Console.ReadLine().ToUpper();
            Console.Clear();

            Console.WriteLine("NOME: " + nome + "\nCPF: " + cpf + "\nRG: " + rg + "\n");
            Console.WriteLine("CEP: " + cep + "\nENDEREÇO: LOGRADOURO E NÚMERO: " + logradouro + "\nBAIRRO: " + bairro + "\nCIDADE: " + cidade + "\nESTADO: " + estado + "\n");
            Console.WriteLine();
            Console.WriteLine("DIGITE UMA SENHA DE 8 DÍGITOS CONTENDO LETRAS E NÚMEOS: ");
            string senha = Console.ReadLine();
            ContaCorrente conta = new ContaCorrente(cliente, 00);
            



            Console.WriteLine("SELECIONE A CONTA DESEJADA: ");
            Console.WriteLine("P- CONTA POUPANÇA: ");
            Console.WriteLine("C- CONTA CORRENTE: ");
            string OpCliente = Console.ReadLine();

            

                 while (OpCliente.ToUpper() != "X")
                 {
                    Endereco endereco = new Endereco(logradouro, cep, bairro, cidade, estado);
                    Cliente cliente = new Cliente(nome, cpf, rg, endereco);
                    conta.Abrir(senha);
                    conta.Sacar(10, senha);

                    switch (OpCliente)
                    {
                        case "C":
                            Console.WriteLine("CONTA CORRENTE SELECIONADA.");
                            
                            Console.WriteLine("Conta - " + conta.Situacao + "\n" + conta.NumeroConta + " - " + conta.DigitoVerificador);
                            break;

                        case "P":
                            //ContaPoupanca conta = new ContaPoupanca(cliente, 00);
                            break;

                        case "1":
                            Console.WriteLine();
                            break;

                        case "2":

                            break;

                        case "3":

                            break;

                                            
                    Console.WriteLine("Conta - " + conta.Situacao + "\n" + conta.NumeroConta + " - " + conta.DigitoVerificador);

                    Console.WriteLine("Saldo: " + conta.Saldo);

                    }
                    Console.WriteLine("DIGITE UMA DAS OPÇÕES ABAIXO: ");
                    Console.WriteLine("1- VERIFICAR SALDO");
                    Console.WriteLine("2- SACAR");
                    Console.WriteLine("3- DEPOSITAR");
                    Console.WriteLine("X- SAIR");

                    OpCliente = Console.ReadLine();
                }

            }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
        }
    }
}
