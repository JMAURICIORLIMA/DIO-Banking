using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************************************");
            Console.WriteLine("      BEM VINDO AO DIO - BANKING");
            Console.WriteLine("");
            
            try
            {
                    Endereco endereco = new Endereco("R: J. B. da C. A.", "53050-140", "Jd.Atântico", "Olinda", "PE");
                    Cliente cliente = new Cliente("José Maurício", "12312312312", "1233211", endereco);

                    ContaCorrente conta = new ContaCorrente(cliente, 100);
                    Console.WriteLine("Conta - " + conta.Situacao + "\n" + conta.NumeroConta + " - " + conta.DigitoVerificador);

                    string senha = "Abc@@123456";
                    conta.Abrir(senha);

                    Console.WriteLine("Conta - " + conta.Situacao + "\n" + conta.NumeroConta + " - " + conta.DigitoVerificador);

                    conta.Sacar(10, senha);
                    Console.WriteLine("Saldo: " + conta.Saldo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("SELECIONE A CONTA DESEJADA: ");
            Console.WriteLine("P- CONTA POUPANÇA: ");
            Console.WriteLine("C- CONTA CORRENTE: ");
            Console.WriteLine("DIGITE UMA DAS OPÇÕES ABAIXO: ");
            Console.WriteLine("1- VERIFICAR SALDO");
            Console.WriteLine("2- SACAR");
            Console.WriteLine("4- DEPOSITAR");
            Console.WriteLine("X- SAIR");
            //string OpCliente = Console.ReadLine(OpCliente);





        }
    }
}
