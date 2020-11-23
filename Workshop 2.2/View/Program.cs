using System;
using Workshop_2._2.ViewModel;

namespace Workshop_2._2
{
    class Program
    {

        static void Main(string[] args)
        {
            UserModifyWord viewModel = new UserModifyWord();
            Console.WriteLine("Hello !");
            Console.WriteLine("Please write a chain of 1-8 characters");
            viewModel.userWord.ChainWord = Console.ReadLine();
            viewModel.ModifyWord();
            Console.WriteLine(viewModel.newUserWord.NewChainWord);
        }
    }
}
