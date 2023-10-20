using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }




        public void CadastrarHospedes(List<Pessoa> hospedes)
        {

          


                if (hospedes.Count <= Suite.Capacidade)
                {

                    Hospedes = hospedes;
                }
                else
                {

                throw new Exception("A quantidade de hóspedes não pode exceder a capacidade da suíte");
                

            }

           


        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }


        public int ObterQuantidadeHospedes()
        {

            int quantidade = Hospedes.Count;
            return quantidade;

        }

        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * Suite.ValorDiaria;
          



            if (DiasReservados >= 10)
            {
               
                valor = (DiasReservados * Suite.ValorDiaria) - (valor * 0.10M );

            }

            return valor;
        }


    }
}
