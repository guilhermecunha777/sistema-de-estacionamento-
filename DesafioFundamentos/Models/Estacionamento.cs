namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            String placa = Console.ReadLine();

            if (!String.IsNullOrWhiteSpace(placa))
            {
                veiculos.Add(placa.ToUpper());
                Console.WriteLine($"veiculo com placa {placa.ToUpper()} foi adicionado com sucesso.");
            }
            else
            {
                Console.WriteLine("Placa invalida! tente novamente.");
            }
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            String placa = Console.ReadLine();

            // Pedir para o usuário digitar a placa e armazenar na variável placa
            // *IMPLEMENTE AQUI*
            
            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                // *IMPLEMENTE AQUI*

                int horas = 0;

                while (!int.TryParse(Console.ReadLine(), out horas) || horas < 0)
                {
                    Console.WriteLine("entrada inavlida. digite um numero inteiro positivo para as horas: ");
                }

                decimal valorTotal = precoInicial + precoPorHora * horas;

                veiculos.RemoveAll(x => x.ToUpper() == placa.ToUpper());
                Console.WriteLine($"o veiculo {placa.ToUpper()} foi removido e o preço total foi de: R$ {valorTotal:F2}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine($"- {veiculo}");
                }

            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
