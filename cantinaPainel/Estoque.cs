using cantinaPainel;

internal class Estoque
{
    public Produto Produto { get; set; }
    public int Quantidade { get; set; }

    public Estoque (Produto produto, int quantidade)
    {
        Produto = produto;
        Quantidade = quantidade;
    }

    public void AdicionarQuantidade(int quantidade)
    {
        if (quantidade > 0) 
        {
            Quantidade += quantidade;
        }
    }

    public bool RemoverQuantidade(int quantidade)
    {
        if (quantidade > 0 && quantidade <= Quantidade)
        {
            Quantidade -= quantidade;
            return true;
        }
        return false;
    }

    public bool EstoqueBaixo(int limite = 5)
    {
        return Quantidade <= limite;
    }
    public override string ToString()
    {
        if (Produto == null)
            return $"Produto inválido | Qnt: {Quantidade}";

        return $"{Produto.Item} | Qnt: {Quantidade}";
    }
}
