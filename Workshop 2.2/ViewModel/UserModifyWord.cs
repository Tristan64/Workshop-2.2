using System;
using System.Collections.Generic;
using System.Text;
using Workshop_2._2.Model;

namespace Workshop_2._2.ViewModel
{
    class UserModifyWord
    {
        public string ModifyWord(string word)
        {
            UserWord userWord = new UserWord();
            NewUserWord newUserWord = new NewUserWord();
            if(word.Length>9 || word.Length < 0)
            {
                throw new InvalidOperationException("Invalid character chain");
            }
            else
            {
                userWord.ChainWord = word;
                newUserWord.NewChainWord = word.ToUpper();
                return newUserWord.NewChainWord;
            }
        }
    }
}
