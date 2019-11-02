using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KongoRiver_Employees._Codes
{
    public class Params
    {
        private string _serveur, _database, _nom_user, _mot_de_passe;

        public string Base_de_donnees
        {
            get
            {
                return _database;
            }

            set
            {
                _database = value;
            }
        }

        public string Mot_de_passe
        {
            get
            {
                return _mot_de_passe;
            }

            set
            {
                _mot_de_passe = value;
            }
        }

        public string Nom_user
        {
            get
            {
                return _nom_user;
            }

            set
            {
                _nom_user = value;
            }
        }

        public string Serveur
        {
            get
            {
                return _serveur;
            }

            set
            {
                _serveur = value;
            }
        }
        public override string ToString()
        {
            return
                string.Format
                (
                    "Data Source ={0};Initial Catalog={1};User ID={2};Password= {3};",
                    _serveur, _database, _nom_user, _mot_de_passe
                );
        }
    }
}
