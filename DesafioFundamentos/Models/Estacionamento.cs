namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal _precoInicial = 0;
        private decimal _precoPorHora = 0;
        private Dictionary<int, Veiculo> veiculosDictionary = new Dictionary<int, Veiculo>();
        private int _numVeiculo = 1;
        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            _precoInicial = precoInicial;
            _precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*

            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            Console.WriteLine("Digite a cor do veículo:");
            string cor = Console.ReadLine();
            Console.WriteLine("Digite o ano do veículo:");
            int ano = 0;
            int.TryParse(Console.ReadLine(), out ano);
            Console.WriteLine("Digite o modelo do veículo:");
            string modelo = Console.ReadLine();
            Console.WriteLine("Digite o fabricante do veículo:");
            string fabricante = Console.ReadLine();
            var veiculo = new Veiculo(placa, cor, ano, modelo, fabricante);
            this.veiculosDictionary.Add(_numVeiculo, veiculo);
            _numVeiculo++;

            Console.WriteLine("Sucesso: " + veiculo.ToString());
        }

        public void RemoverVeiculo()
        {

            // Verifica se o veículo existe
            if (veiculosDictionary.Any())
            {

                Console.WriteLine("Digite o código do veículo para remover:");
                int codigo = 0;
                int.TryParse(Console.ReadLine(), out codigo);
                if (codigo != 0)
                {
                    Veiculo veiculo;
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                    int horas = Convert.ToInt32(Console.ReadLine());
                    decimal valorTotal = _precoInicial + (_precoPorHora * horas);
                    veiculosDictionary.TryGetValue(codigo, out veiculo);
                    veiculosDictionary.Remove(codigo);
                    Console.WriteLine($"Total a pagar: R$ {valorTotal} \n Veiculo removido com sucesso: " + veiculo.ToString());
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou o código corretamente");
                }
            }

        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (this.veiculosDictionary.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
