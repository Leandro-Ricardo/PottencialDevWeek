namespace src.Models;

public class Contrato
{
    public Contrato()
    {
        this.DataCriacao = DateTime.Now;
        this.Valor = 0;
        this.TokenId = "000000";
        this.Pago = false;
    }

    public Contrato(string tokenId, double valor)
    {
        this.DataCriacao = DateTime.Now;
        this.TokenId = tokenId;
        this.Valor = valor;
        this.Pago = false;
    }
    public DateTime DataCriacao { get; set; }
    public String TokenId { get; set; }
    public Double Valor { get; set; }
    public bool Pago { get; set; }
}