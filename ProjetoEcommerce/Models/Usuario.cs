namespace ProjetoEcommerce.Models
{
    public class Usuario
    {
        public int Id { get; set; } //acessores
                                    // Ao usar ?, você está explicitamente dizendo que a propriedade
                                    // pode intencionalmente ter um valor nulo.
        public string? Nome { get; set; }
        public string? Email { get; set; }
        public string? Senha { get; set; }
    }
}
