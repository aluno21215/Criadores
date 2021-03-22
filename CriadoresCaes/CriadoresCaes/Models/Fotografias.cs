using System;
using System.Collections.Generic;
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
        public string LocalFoto { get; set; }

    }
}
