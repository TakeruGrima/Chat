using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Created by Timothée LE CORRE and Camille Melo

namespace Chat.Authentification
{
    public class Authentification : AuthentificationManager
    {
        List<User> users;//Liste d'utilisateurs

        public Authentification()
        {
            users = new List<User>();
        }

        //Ajouter un utilisateur
        public void AddUser(string login, string password)
        {
            foreach (User user in users)
            {
                if (user.CompareTo(new User(login, "")) == 0)
                {
                    throw new UserExistsException(login + " already exist");
                }
            }
            users.Add(new User(login, password));
        }

        //Supprimer un utilisateur
        public void RemoveUser(string login)
        {
            foreach (User user in users)
            {
                if (user.CompareTo(new User(login, "")) == 0)
                {
                    users.Remove(user);
                    return;
                }
            }
            throw new UserUnknownException(login + " don't exist");
        }

        //Méthode d'authentification
        public void Authentify(string login, string password)
        {
            if (users.Contains(new User(login, password)))
            {
                Console.WriteLine("The user is connected");
            }

            else
            {
                throw new WrongPasswordException("Mot de passe incorrect");
            }
        }

        //Charger le fichier des users
        public void Load(String path)
        {
            users = (List<User>)SerialTools.DeserializeBin(path);
        }

        //Sauvegarde les fichiers des users
        public void Save(String path)
        {
            SerialTools.SerializeBin(path,users);
        }
    }
}
