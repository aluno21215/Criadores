using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class CriadoresDeCaes
    {
        /// <summary>
        /// PK para atbela do relacionamento entre Cães e Criadores
        /// </summary>
        [Key]
        public int Id { get; set; }


        /// <summary>
        /// Data de compra do Cão
        /// </summary>
        public DateTime DataCompra { get; set; }

        //************************************************************

        /// <summary>
        /// FK para o Cao
        /// </summary>
        //[Key, Column(Order = 1)]
        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Caes Cao { get; set; }

        //************************************************************
        /// <summary>
        /// FK para o Criador do cao
        /// </summary>
       // [Key, Column(Order = 2)]
        [ForeignKey(nameof(Criador))]
        public int CriadorFK { get; set; }
        public Criadores Criador { get; set; }

    }
}
