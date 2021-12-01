using System;
using System.Collections.Generic;
using System.Text;

namespace Conversor
{
    class Conversor
    {
        //Criada as variáveis
        private double ReaisTotal;
        private double TaxaTotal;
        public double IOF = 0.0408;
        private double Taxa;
        //Encapsulamento
        public double DolarAtual { get; set; }
        public double QntDolar { get; set; }
        //Construtor
        public Conversor(double dolarAtual, double qntDolar)
        {
            DolarAtual = dolarAtual;
            QntDolar = qntDolar;
        }
        //Método de conversão sem as taxas
        public void Conversao()
        {
            ReaisTotal = DolarAtual * QntDolar;
        }
        ////Método de conversão com as taxas
        public void ConversaoTaxa()
        {
            TaxaTotal = Taxa + ReaisTotal;
            Taxa = (ReaisTotal * IOF);
        }
        //Método ToStrig usand override
        public override string ToString()
        {
            //Mostrando o "recibo" em console com todos os dados
            return "Valor total em reais sem IOF = " + ReaisTotal.ToString("C2") + "\nValor do imposto = " + Taxa.ToString("C2") + "(IOF:4,08%) " + "\nValor total com IOF incluso = " + TaxaTotal.ToString("C2");
        }
    }
}