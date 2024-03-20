namespace ATV4CJ3010708part2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite 1 para exercicio 1");
            Console.WriteLine("Digite 2 para exercicio 2");
            Console.WriteLine("Digite 3 para exercicio 3");
            Console.WriteLine("Digite 4 para exercicio 4");
            Console.WriteLine("Digite 5 para exercicio 5");
            Console.WriteLine("Digite 6 para exercicio 6");
            Console.WriteLine("Digite 7 para exercicio 7");

            string opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":

                    //////EXERCICIO 1//////

                    Console.WriteLine("Escolha um numero da semana");
                    string escolha = Console.ReadLine();

                    switch (escolha)
                    {


                        case "1":
                            int variave1 = 50;
                            Console.WriteLine("Você escolheu Segunda-feira");
                            break;
                        case "2":
                            string variavel2 = "ola, Borges";
                            Console.WriteLine("Você escolheu Terça-feira");
                            break;
                        case "3":
                            string variavel3 = "50";
                            Console.WriteLine("você escolheu Quarta-feira");
                            break;
                        case "4":
                            int variavel4 = 50;
                            Console.WriteLine("Voce escolheu Quinta-feira");
                            break;
                        case "5":
                            int variavel5 = 50;
                            Console.WriteLine("Você escolheu Sexta-feira");
                            break;
                        case "6":
                            string variavel6 = "ola, Borges";
                            Console.WriteLine("Você escolheu Sabado");
                            break;
                        case "7":
                            string variavel7 = "50";
                            Console.WriteLine("você escolheu Domingo");
                            break;
                        case "8":
                            string variavel8 = "50";
                            Console.WriteLine("Sua escolha é invalida");
                            break;


                    }

                    break;

                default: Console.WriteLine("opcao invalida"); break;
                    

                    
                  

            }
        }
    }
}


      

