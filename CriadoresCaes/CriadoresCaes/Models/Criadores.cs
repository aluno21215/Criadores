using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class Criadores
    {
        public Criadores()
        {
            //Inicializar a lista de Cães do Criador
            ListaDeCaes = new HashSet<CriadoresCaes>();
        }

        /// <summary>
        /// Identificador do Criador
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Nome do Criador
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Nome Comercial do Criador
        /// </summary>
        public string NomeComercial { get; set; }

        /// <summary>
        /// Morada do Criador
        /// </summary>
        public string Morada { get; set; }

        /// <summary>
        /// Código Postal do Criador
        /// </summary>
        public int CodPostal { get; set; }

        /// <summary>
        /// Número de telemóvel do Criador
        /// </summary>
        public string Telemovel { get; set; }

        /// <summary>
        /// Email do Criador
        /// </summary>
        public string Email { get; set; }

        /*********************************************************/
        /// <summary>
        /// Lista de Cães do Criador
        /// </summary>
        public ICollection<CriadoresCaes> ListaDeCaes { get; set; }
    }
}
