using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    public class Lanche
    {
        public int LancheId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(100)]
        public string DescricaoCurta { get; set; }
        [StringLength(255)]
        public string DescricaoDetalhada { get; set; }
        [Column(TypeName="decimal(18,2)")]
        public decimal Preco { get; set; }
        [StringLength(200)]
        public string ImagemUrl { get; set; }
        [StringLength(200)]
        public string ImagemThumbnailUrl { get; set; }
        public bool IsLanchePreferido { get; set; }
        public bool EmEstoque { get; set; }
        public int CategoriaId { get; set; }
        public virtual Categoria Categoria { get; set; }

        public Lanche(int lancheId, string nome, string descricaoCurta, string descricaoDetalhada, decimal preco, string imagemUrl, string imagemThumbnail, bool isLanchePreferido, bool emEstoque, int categoriaId)
        {
            LancheId = lancheId;
            Nome = nome;
            DescricaoCurta = descricaoCurta;
            DescricaoDetalhada = descricaoDetalhada;
            Preco = preco;
            ImagemUrl = imagemUrl;
            ImagemThumbnailUrl = imagemThumbnail;
            IsLanchePreferido = isLanchePreferido;
            EmEstoque = emEstoque;
            CategoriaId = categoriaId;
        }

        public Lanche() { }
    }
}
