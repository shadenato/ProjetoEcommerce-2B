namespace ProjetoEcommerce.Models
{
    public class Cliente

    {
        //CRIANDO O ENCAPSULAMENTO DO OBJETO COM GET E SET
        public int Codigo { get; set; } //Acessores
                                        // Ao usar ?, você está explicitamente dizendo que a propriedade pode intencionalmente ter um valor nulo.
        public string? Nome { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public List<Cliente>? ListaCliente { get; set; }

    }
}

