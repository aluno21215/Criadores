using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    public class Fotografias
    {
        /// <summary>
        /// Identificador de cada fotografia
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Imagem
        /// </summary>
        public string Foto { get; set; }

        /// <summary>
        /// Data de fotografia
        /// </summary>
        public DateTime DataFoto { get; set; }

        /// <summary>
        /// Local da fotografia
        /// </summary>
        public string Local { get; set; }

        /***************************************************/
        //fOREIGNkEY BLA BLA BLA É SEMPRE NO LADO DO MUITOS!!!!!!

        [ForeignKey(nameof(Cao))]
        public int CaoFK { get; set; }
        public Caes Cao { get; set; }

    }

   

}
