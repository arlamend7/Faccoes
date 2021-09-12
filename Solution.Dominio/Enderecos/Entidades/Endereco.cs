namespace Solution.Dominio.Enderecos.Entidades
{
    public class Endereco
    {
        public virtual long Id { get; protected set; }
        public virtual string Bairro { get; protected set; }
        public virtual string Cidade { get; protected set; }
        public virtual string UF { get; protected set; }
    }
}
