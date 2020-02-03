using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoProduto
    {
        [Display(Name = "Mercadoria para Revenda")]
        MERCADORIA_REVENDA = 0,
        [Display(Name = "Matéria Prima")]
        MATERIAL_PRIMA = 1,
        [Display(Name = "Embalagem")]
        EMBALAGEM = 2,
        [Display(Name = "Produto em Processo")]
        PRODUTO_EM_PROCESSO = 3,
        [Display(Name = "Produto Acabado")]
        PRODUTO_ACABADO = 4,
        [Display(Name = "Subproduto")]
        SUBPRODUTO = 5,
        [Display(Name = "Produto Intermediário")]
        PRODUTO_INTERMEDIARIO = 6,
        [Display(Name = "Material de Uso/Consumo")]
        MATERIAL_USO_CONSUMO = 7,
        [Display(Name = "Ativo Imobilizado")]
        ATIVO_IMOBILIZADO = 8,
        [Display(Name = "Serviços")]
        SERVICOS = 9,
        [Display(Name = "Outros Insumos")]
        OUTROS_INSUMOS = 10,
        [Display(Name = "Outros")]
        OUTROS = 99
    }
}
