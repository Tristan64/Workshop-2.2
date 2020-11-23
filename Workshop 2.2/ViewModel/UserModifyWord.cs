using System;
using System.Collections.Generic;
using System.Text;
using Workshop_2._2.Model;

namespace Workshop_2._2.ViewModel
{
    class UserModifyWord
    {

        public UserWord userWord;
        public NewUserWord newUserWord;

        public UserModifyWord()
        {
            userWord = new UserWord();
           newUserWord = new NewUserWord();
        }
        public void ModifyWord()
        {
            if(userWord.ChainWord.Length>9 || userWord.ChainWord.Length < 0)
            {
                throw new InvalidOperationException("Invalid character chain");
            }
            else
            {
                newUserWord.NewChainWord = userWord.ChainWord.ToUpper();
            }
        }
    }
}
