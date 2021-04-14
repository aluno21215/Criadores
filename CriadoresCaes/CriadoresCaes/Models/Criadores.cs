using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class Criadores
    {
        public Criadores()
        {
            //Inicializar a lista de Cães do Criador
            ListaDeCaes = new HashSet<CriadoresDeCaes>();
        }

        /// <summary>
        /// Identificador do Criador
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do Criador
        /// </summary>
        [Required(ErrorMessage = "O Nome é de preenchimento obrigatório.")]
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} carateres.")]
        [RegularExpression("[A-ZÂÓÍÉ][a-záéíóúàèìòùâêîôûãôûäëïöüçñ]+(( | d[oa](s)? | (d)?e |-|'| d')[A-ZÂÓÍÉ][a-záéíóúàèìòùâêîôûãôûäëïöüçñ]+){1,3}",
         ErrorMessage = "Só são aceites letras.<br />A primeira letra de cada nome é uma Maiúscula seguida de minúsculas.<br />Deve escrever entre 2 e 4 nomes.")]
        public string Nome { get; set; }

        /// <summary>
        /// Nome Comercial do Criador
        /// </summary>
        [StringLength(20, ErrorMessage = "O {0} não pode ter mais de {1} carateres.")]
        [Display(Name = "Afixo")]
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do Criador
        /// </summary>

        [Required(ErrorMessage = "A Morada é de preenchimento obrigatório.")]
        [StringLength(60, ErrorMessage = "O {0} não pode ter mais de {1} carateres.")]
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal do Criador
        /// </summary>

        [Required(ErrorMessage = "O Código Postal é de preenchimento obrigatório.")]
        [StringLength(30, MinimumLength = 8, ErrorMessage = "O {0} deve ter entre {2} e {1} carateres.")]
        [RegularExpression("[1-9][0-9]{3}-[0-9]{3}( [a-zA-Z-áÁéÉçÇ]+)+", ErrorMessage = "Escreve um código postal válido")]
        [Display(Name = "Código Postal")]
        public string CodPostal { get; set; }

        /// <summary>
        /// Número de telemóvel do Criador
        /// </summary>
        [StringLength(14, MinimumLength = 9, ErrorMessage = "O {0} deve ter entre {2} e {1} caracteres.")]
        [RegularExpression("(00)?([0-9]{2,3})?[1-9][0-9]{8}", ErrorMessage = "Escreva, pf, um nº Telemóvel com 9 algarismos. Se quiser, pode acrescentar o indicativo nacional e o internacional. ")]
        [Display(Name = "Telemóvel")]
        public string Telemovel { get; set; } //ou se escreve o Telemovel e/ou email

        /// <summary>
        /// Email do Criador
        /// </summary>
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} caracteres.")]
        [EmailAddress(ErrorMessage = "o {0} introduzido não é válido")]
        [RegularExpression("((((aluno)|(es((tt)|(ta)|(gt))))[0-9]{4,5})|([a-z]+(.[a-z]+)*))@ipt.pt",
                          ErrorMessage = "Só são aceites emails do IPT.")]
        public string Email { get; set; }



        /*
           [abcdefghi ... xyz]      

            + --> 1 ou mais carateres
            * --> 0 ou mais carateres
            ? --> 1 ou 1 carater
           {} --> aceita os carateres, conforme o nº lá escrito

            ((aluno) | (es(tt) | (ta) | (gt) ) ) [0123456789] {4,5})


        "(((aluno)|(es(tt)|(ta)|(gt))) [0-9] {4,5}) | ([a-z]+(.[a-z]+)*))@ipt.pt"

        */





        /*********************************************************/
        /// <summary>
        /// Lista de Cães do Criador
        /// </summary>
        public ICollection<CriadoresDeCaes> ListaDeCaes { get; set; }





    }
}
