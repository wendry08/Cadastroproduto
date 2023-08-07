using System;

public class Produto
{
    public string Codigo { get; set; }
    public double PrecoAquisicao { get; set; }
    public double ValorVenda { get; set; }
    public string Descricao { get; set; }
    public double Lucro { get; set; }

    public Produto()//sobrecarga 
    {

    }
    public Produto(string codigo,double precoaquisicao,double valorvenda,string descricao, double lucro)
    {
        Codigo = codigo;
        PrecoAquisicao = precoaquisicao;
        ValorVenda = valorvenda;
        Descricao = descricao;
        Lucro = lucro;

    }


}
