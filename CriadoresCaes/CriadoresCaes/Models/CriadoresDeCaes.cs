using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class CriadoresDeCaes
    {

        /// <summary>
        /// Data de compra do Cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        //************************************************************

        /// <summary>
        /// FK para o Cao
        /// </summary>
        [ForeignKey(nameof(Cao))]
        public int CaesFK { get; set; }
        public Caes Cao { get; set; }

        //************************************************************
        /// <summary>
        /// FK para o Criador do cao
        /// </summary>
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; }

    }
}
