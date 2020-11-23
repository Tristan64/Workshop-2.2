using System;
using System.Collections.Generic;
using System.Text;
using Workshop_2._2.Model;

namespace Workshop_2._2.ViewModel
{
    class UserModifyWord
    {
        public void ModifyWord(string word)
        {
            UserWord userWord = new UserWord();
            NewUserWord newUserWord = new NewUserWord();
            if(word.Length>9 || word.Length < 0)
            {
                Console.WriteLine("Error : Invalid chain of caracter");
            }
            else
            {
                userWord.ChainWord = word;
                Console.WriteLine("Modification en cours...");
                word = word.ToUpper();
                newUserWord.NewChainWord = word;
                Console.WriteLine("Fin de la modification.");
                Console.WriteLine("Résultat : " + word);
            }
        }
    }
}
