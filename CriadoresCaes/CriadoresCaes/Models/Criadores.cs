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
        public string Nome { get; set; }

        /// <summary>
        /// Nome Comercial do Criador
        /// </summary>
        [StringLength(20, ErrorMessage = "O {0} não pode ter mais de {1} carateres.")]
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
        public string CodPostal { get; set; }

        /// <summary>
        /// Número de telemóvel do Criador
        /// </summary>
        [StringLength(14, MinimumLength = 9, ErrorMessage = "O {0} deve ter entre {2} e {1} carateres.")]
        [RegularExpression("(00)?([0-9]{2,3})?[1-9][0-9]{8}", ErrorMessage = "Escreva um número de telemóvel com 9 algarismos.")]
        public string Telemovel { get; set; } //ou se escreve o Telemovel e/ou email

        /// <summary>
        /// Email do Criador
        /// </summary>
        [StringLength(50, ErrorMessage = "O {0} não pode ter mais de {1} carateres.")] //parametro de indice 0 diz respeito oao nome do atibuto, neste caso = Email; 1 = StringLenght
        [EmailAddress(ErrorMessage = "O {0} introduzido não é válido.")]
        [RegularExpression("((((aluno)|(es((tt)|(ta)|(gt))))[0-9]{4,5})|([a-z]+(.[a-z]+)*))@ipt.pt", ErrorMessage = "Só são aceites emails do IPT.")]
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
