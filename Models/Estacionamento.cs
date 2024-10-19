using System.Text.RegularExpressions;

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
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            Console.Write("Placa: ");
            string placa = Console.ReadLine();

            if (ValidaPlaca(placa) == true)
            {
                veiculos.Add(placa);
            }
            else
            {
                Console.WriteLine("Formato de Placa Inválido!");
            }

        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            Console.Write("Opção: ");
            string placa = Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                decimal valorTotal = 0; 
            
                bool success = int.TryParse(Console.ReadLine(), out int horas);

                if (success)
                {
                    valorTotal = precoInicial + (precoPorHora * horas);
                    veiculos.Remove(placa);
                    Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                }
                else
                {
                    Console.WriteLine("Valor Inválido para HORAS!");
                }
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

                foreach (string veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        private static bool ValidaPlaca(string placa)
        {
            Regex placaMercosul = new Regex("([A-Z]{3}[0-9]{1}[A-Z]{1}[0-9]{2})");
            Regex placaModeloAntigo = new Regex("([A-Z]{3}[-]{1}[0-9]{4})");
            
            var validaMercosul = placaMercosul.Match(placa.ToUpper());
            var validaModeloAntigo = placaModeloAntigo.Match(placa.ToUpper());
            

            if((validaMercosul.Success == true && placa.Length == 7) || (validaModeloAntigo.Success == true && placa.Length == 8))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
    }
}