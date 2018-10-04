using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Modelos;
using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaDeObject listaDeIdades = new ListaDeObject();

            listaDeIdades.Adicionar(10);
            listaDeIdades.Adicionar(5);
            listaDeIdades.Adicionar(4);
            listaDeIdades.AdicionarVarios(16, 23, 60);

            for (int i = 0; i < listaDeIdades.Tamanho; i++)
            {
                int idade = (int)listaDeIdades[i];
                Console.WriteLine($"Idade no índice {i}: {idade}");
            }

            Console.WriteLine(SomaarVarios(1, 2, 3, 56465, 45));
            Console.WriteLine(SomaarVarios(1, 2, 3, 45));


            Console.ReadLine();
        }

        static int SomaarVarios(params int[] numeros)
        {
            int acumulador = 0;
            foreach (int numero in numeros)
            {
                acumulador += numero;
            }
            return acumulador;
        }

        static void TestaListaDeContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();

            lista.MeuMetodo(numero: 10);

            ContaCorrente contadoDoGui = new ContaCorrente(546, 56749676);

            ContaCorrente[] contas = new ContaCorrente[]
            {
                contadoDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787)
            };

            lista.AdicionarVarios(contas);
            lista.AdicionarVarios(
                contadoDoGui,
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 5679787)

                );

            //lista.EscreverListaNaTela();

            //lista.Remover(contadoDoGui);

            //Console.WriteLine("Após remover o item");

            //lista.EscreverListaNaTela();


            for (int i = 0; i < lista.Tamanho; i++)
            {


                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"Item na posição {i} = Conta {itemAtual.Numero}/{itemAtual.Agencia}");
            }
        }

        static void TestaArrayDeContaCorrente()
        {

            ContaCorrente[] contas = new ContaCorrente[]
            {
                new ContaCorrente(874, 5679787),
                new ContaCorrente(874, 1231324),
                new ContaCorrente(874, 4567899)
            };



            for (int indice = 0; indice < contas.Length; indice++)
            {
                ContaCorrente contaAtual = contas[indice];
                Console.WriteLine($"Conta {indice} {contaAtual.Numero}");
            }

        }

        static void TestaArrayInt()
        {
            // ARRAY de inteiros, com 5 possições!
            int[] idades = null;
            idades = new int[3];

            idades[0] = 15;
            idades[1] = 38;
            idades[2] = 35;
            //idades[3] = 50;
            //idades[4] = 28;
            //idades[5] = 60;

            Console.WriteLine(idades.Length);

            int acumulador = 0;
            for (int indice = 0; indice < idades.Length; indice++)
            {
                int idade = idades[indice];

                Console.WriteLine($"Acessando o array idade no índice {indice}");
                Console.WriteLine($"Valor da idades [{indice}] = {idade}");

                acumulador += idade;
            }

            int media = acumulador / idades.Length;

            Console.WriteLine($"Média de idade = {media}");

            //int idadeNoIndice4 = idades[4];

            //Console.WriteLine(idadeNoIndice4);

            //int[] outroArray = idades;
            //Console.WriteLine(outroArray[3]);

            //bool[] arrayDeBooleanos = new bool[10];

            //arrayDeBooleanos[0] = true;
            //arrayDeBooleanos[1] = false;
            //arrayDeBooleanos[2] = true;

        }
    }
}
