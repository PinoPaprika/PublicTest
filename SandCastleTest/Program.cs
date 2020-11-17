using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandCastleTest
{
    /// <summary>
    /// cette classe est très très imporante.
    /// </summary>
    class ClassEnfant
    {
        /// <summary>
        /// cette variable est un entier
        /// </summary>
        int variable;
        public ClassEnfant(int variable)
        {
            this.variable = variable;
        }

        /// <summary>
        /// cette méthode permet de récuperer la variable
        /// </summary>
        /// <returns> elle retourn un int</returns>
        public int GetVariable()
        {
            return this.variable;
        }
    }

    /// <summary>
    /// cette classe est très  importante.
    /// </summary>
    class ClassParent : ClassEnfant
    {
        /// <summary>
        /// cette variable est un string
        /// </summary>
        string nom;

        public ClassParent(int variable,string nom) : base(variable)
        {
            this.nom = nom;
        }

        /// <summary>
        /// cette méthode permet de récuperer un nom
        /// </summary>
        /// <returns> elle retourn un string</returns>
        public string getNom()
        {
            return this.nom;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
