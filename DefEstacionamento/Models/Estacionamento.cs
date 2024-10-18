using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace DefEstacionamento.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;

        private List<string> veiculos = new List<string>();

        public Estacionamento( decimal precoInicial, decimal precoPorHora){
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo(){
            WriteLine("Digite a placa do veículo para estacionar:");

            veiculos.Add(ReadLine());
        }

        public void RemoverVeiculo(){
            string placa = "";
            int horas = 0;
            decimal valorTotal = 0;

            WriteLine("Digite a placa do veículo para remover:");

            placa = ReadLine();

            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper())){
                WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                horas = Convert.ToInt16(ReadLine());

                valorTotal = precoInicial + (precoPorHora * horas);

                WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
                
                veiculos.Remove(placa);
            }
            else
            {
                WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }

        }

         public void ListarVeiculos(){

            if (veiculos.Any()){
                WriteLine("Os veículos estacionados são:");

                for (int i = 0; i < veiculos.Count ; i++)
                {
                    WriteLine($"{i}° {veiculos[i]}");
                }
            }
             else  
            {
             WriteLine("Não há veículos estacionados.");
            }
        }
    }
}