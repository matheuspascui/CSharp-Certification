using System;
public class SistemaDePagamentos
{
    public static void Main(string[] args)
    {
        /* A ideia deste programa é verificar se seu pagamento está sendo feito no dia correto, em atraso ou adiantado.
        Com base na data do pagamento, você terá opções diferentes. Sinta-se livre para explorar as opções! */

        // string tipoPagamento = Console.ReadLine();
        // Console.WriteLine(tipoPagamento);

        Console.WriteLine("*******************************************************************************************************************");
        Console.WriteLine("* Bem-vindo ao Sistema de Pagamentos! Aqui te ajudamos a pagar sua conta, seja em dia, atrasada ou até adiantada! *");
        Console.WriteLine("*                                                                                                                 *");
        Console.WriteLine("* Por favor, informe o tipo do seu pagamento:                                                                     *");
        Console.WriteLine("* 1 - Boleto Bancário                                                                                             *");
        Console.WriteLine("* 2 - Carnê                                                                                                       *");
        Console.WriteLine("* 3 - Cartão                                                                                                      *");
        Console.WriteLine("*******************************************************************************************************************");
        string tipoDePagamento = Console.ReadLine();

        if (tipoDePagamento == "1")
        {
            double valorBoleto = 0;
            Console.WriteLine("Por favor, digite o tipo do seu boleto:\n1 - Em dia\n2 - Atrasado");
            string tipoDeBoleto = Console.ReadLine();
            if (tipoDeBoleto == "1")
            {
                Console.WriteLine("Por favor, digite o valor do seu boleto:");
                valorBoleto = Console.ReadLine();
                Console.WriteLine($"Pronto! Seu boleto no valor de {valorBoleto} foi devidamente pago.");
            }
            else if  (tipoDeBoleto == "2")
            {
                Console.WriteLine("Como seu boleto venceu, você deve gerar um novo no sistema. Saindo...");
            }
            else
            {
                Console.WriteLine("Desculpe, opção inválida. Saindo...");
            }
        }
        else if (tipoDePagamento == "2")
        {
            Console.WriteLine("Escolha a opção do Carnê:\n1 - Dia exato do pagamento\n2 - Atrasado\n3 - Adiantar parcelas");
            string opcaoCarne = Console.ReadLine();
            if (opcaoCarne == "1")
            {
                Console.WriteLine("Digite o valor do Carnê:");
                float valorCarne = Console.ReadLine();
                Console.WriteLine($"Pronto! Seu Carnê no valor de {valorCarne} foi pago!");
            }
            else if(opcaoCarne == "2")
            {
                Console.WriteLine("Digite o valor do carnê:");
                float valorCarne = Console.ReadLine();
                Console.WriteLine("Devido ao atraso será aplicada uma multa de 5% sobre o valor do carnê.");
                valorCarne = valorCarne + (valorCarne * 5) / 100;
                Console.WriteLine($"Pronto! Sua parcela em atraso já foi quitado, no valor de: {valorCarne}");
            }
            else if (opcaoCarne == "3")
            {
                Console.WriteLine("Digite o valor do carnê:");
                float valorCarne = Console.ReadLine();
                Console.WriteLine("como você está pagando adiantado, receberá um desconto de 10% na sua parcela! :)");
                valorCarne = valorCarne - (valorCarne * 10) / 100;
                Console.WriteLine($"Pronto! Sua parcela foi paga no valor de {valorCarne}.");
            }
            else
            {
                Console.WriteLine("Desculpe, opção inválida. Saindo...");
            }
        }
        else if (tipoDePagamento == "3")
        {
            Console.WriteLine("Oops! Pagamentos por cartão ainda estão sendo implementados, agradecemos a compreensão. Saindo...");
        }
        else
        {
            Console.WriteLine("Oops! Parece que essa opção não é válida.");
        }

    }
}