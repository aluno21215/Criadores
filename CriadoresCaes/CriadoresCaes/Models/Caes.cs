using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CriadoresCaes.Models
{
    /// <summary>
    /// Descrição de cada um dos cães
    /// </summary>
    public class Caes
    {
        public Caes()
        {
            //inicializar a lista de Fotografias de cada um dos cães 
            ListasDeFotografias = new HashSet<Fotografias>();
            //inicializar a lista de Criadores do cão
            ListaCriadores = new HashSet<CriadoresDeCaes>();
        }
      
        /// <summary>
        /// Identificador de cada Cão
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Nome do Cão
        /// </summary>
        public string Nome { get; set; }

        /// <summary>
        /// Sexo do Cão
        /// M - Masculino
        /// F - Feminino
        /// </summary>
        public string Sexo { get; set; }

        /// <summary>
        /// Data de nascimento do Cão
        /// </summary>
        public DateTime DataNasc { get; set; }

        /// <summary>
        /// Registo do Cão no Livro de Origens Português (LOP)
        /// </summary>
        public string LOP { get; set; }

        //***********************************************************************//
        //fOREIGNkEY BLA BLA BLA É SEMPRE NO LADO DO MUITOS!!!!!!

        /// <summary>
        /// FK para a Raça do Cão
        /// </summary>
      /*  [ForeignKey("Raca")] //esta anotação indica que o atributo 'RacaFK' está a executar o .....
                            //e que representa uma FK para a classe Raca
                            //ForeignKey é o que está por baixo, RacaFK, neste caso */
        [ForeignKey(nameof(Raca))]
        public int RacaFK { get; set; } //atributo para ser usado na SGBD e no C#. Representa a FK para a Raça do Cão
        public Racas Raca { get; set; } //atributo para ser usado no C#. Representa a FK para a Raça do Cão

        /* Se estivésse-mps a criar a tabela 'Caes' em SQL
         * CREATE TABLE Caes (
         * Id INT PRIMARY KEY,
         * Nome VARCHAR(30) NOT NULL,
         * RacaFK INT NOT NULL,
         * LOP VARCHAR(20)
         * FOREIGN KEY (RacaFK) REFERENCES Racas(Id)
         * )
         *
         */



        /*###############################################################
        // Associar os cães ás suas fotografias*/
        /// <summary>
        /// Lista de Fotografias do cão
        /// </summary>
        public ICollection<Fotografias> ListasDeFotografias { get; set; }


        /*********************************************************/
        /// <summary>
        /// Lista dos Criadores associados a um cão
        /// </summary>
        public ICollection<CriadoresDeCaes> ListaCriadores { get; set; }




    }
}
