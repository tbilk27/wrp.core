using System.ComponentModel.DataAnnotations;

namespace wrp.core.Entity.Enum
{
    public enum TipoLogradouro
    {   
        Rua = 0,
        [Display(Name = "Avenida")]
        Av = 1,
        [Display(Name = "Travessa")]
        Tr = 2,
        [Display(Name = "Praça")]
        Prc = 3
    }
    /*
     * Tipos recomendados pelos correios:
     * 
     * aeroporto, alameda, área, avenida, campo, chácara, colônia, condomínio, conjunto, distrito, esplanada, estação, estrada, favela, fazenda, feira, jardim, ladeira, lago, lagoa, largo, loteamento, morro, núcleo, parque, passarela, pátio, praça, quadra, recanto, residencial, rodovia, rua, setor, sítio, travessa, trecho, trevo, vale, vereda, via, viaduto, viela, vila
     * 
     */
}
