﻿using System;
using System.Text;


namespace DespesasReceitas
{
    class Receitas
    {
        public string Receita { get; set; }
        public double ValorReceita { get; set; }
        public DateTime DataReceita { get; set; }

        public Receitas(string receita, double valorReceita, DateTime dataReceita)
        {
            Receita = receita;
            ValorReceita = valorReceita;
            DataReceita = dataReceita;
        }
        override public string ToString()
        {
            return string.Format("Receita: {0}\nValor: R$ {1}; Data: {2}", Receita, ValorReceita, DataReceita.ToString("dd/MM/yyyy"));
        }
    }
}
