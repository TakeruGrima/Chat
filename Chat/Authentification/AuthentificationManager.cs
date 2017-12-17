using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chat.Authentification
{
    public interface AuthentificationManager
    {
        //Ajouter un utilisateur
        void AddUser(string login, string password);

        //Supprimer un utilisateur
        void RemoveUser(string login);

        //Méthode d'authentification
        void Authentify(string login, string password);

        //Charger le fichier des users
        void Load(String path);

        //Sauvegarde les fichiers des users
        void Save(String path);
    }
}
