
namespace Desafio.Dominio.Entidades
{
    public class Sala
    {
        public int IdSala { set; get; }
        public string CodigoSala { get; set; }
        public string NomeSala { get; set; }
        public int OrdemMatriz { get; set; }
        public int IdTipoSala { get; set; }
        public int IdTamanhoSala { get; set; }
        public virtual TipoSala TipoSala { get; set; }
        public virtual TamanhoSala TamanhoSala { get; set; }
        


    }
}
