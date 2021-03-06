﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeObject
    {

        private Object[] _itens;
        private int _proximaPosicao;

        public int Tamanho
        {
            get
            {
                return _proximaPosicao;
            }
        }

        public ListaDeObject(int capacidadeIncial = 5)
        {
            _itens = new Object[capacidadeIncial];
            _proximaPosicao = 0;
        }

        public void MeuMetodo(string texto = "Texto padrao", int numero = 5)
        {

        }

        public void Adicionar(Object item)
        {
            VerificaCapacidade(_proximaPosicao + 1);

            //Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");

            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        //public void EscreverListaNaTela()
        //{
        //    for (int i = 0; i < _proximaPosicao; i++)
        //    {
        //        Object conta = _itens[i];
        //        Console.WriteLine($"Conta no índice {i} numero {conta.Agencia} {conta.Numero}");
        //    }
        //}

        public void AdicionarVarios(params Object[] itens)
        {

            foreach (Object itenm in itens)
            {
                Adicionar(itenm);
            }
        }

        public void Remover(Object item)
        {
            int indiceItem = -1;

            for (int i = 0; i < _proximaPosicao; i++)
            {
                Object itemAtul = _itens[i];

                if (itemAtul.Equals(item))
                {
                    indiceItem = i;
                    break;
                }
            }


            for (int i = indiceItem; i < _proximaPosicao - 1; i++)
            {
                _itens[i] = _itens[i + 1];
            }

            _proximaPosicao--;
            _itens[_proximaPosicao] = null;
        }

        public Object GetItemIndice(int indice)
        {
            if (indice < 0 || indice >= _proximaPosicao)
            {
                throw new ArgumentOutOfRangeException(nameof(indice));
            }

            return _itens[indice];
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
            {
                return;
            }

            int novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
            {
                novoTamanho = tamanhoNecessario;
            }

            //Console.WriteLine("Aumentando capacidade da lista!");

            Object[] novoArray = new Object[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
            {
                novoArray[indice] = _itens[indice];
                //Console.WriteLine(".");
            }

            _itens = novoArray;
        }

        public Object this[int indice]
        {
            get
            {
                return GetItemIndice(indice);
            }

        }
    }
}

