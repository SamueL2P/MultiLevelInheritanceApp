using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiLevelInheritanceApp.Models;

namespace MultiLevelInheritanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {   

            //Inheritance can be used to inherit properties and methods from base class to derived class.
            //More unique and new methods / properties can be then added to derived class.

            //Inheritance allows code reusability.
            
            //Can lead to tight coupling between class.
            
            Chess chess = new Chess();

            //Calling methods of Game and Parent class from child class (chess)

            Console.WriteLine($"Grandparent (Game) class method : {chess.Play()}" + 
                $"\nParent (BoardGame) class method : {chess.MovePiece()}" +
                $"\nChild (Chess) class method : {chess.GiveCheck()}");

            Console.WriteLine($"\nScore : {chess.score} \nTurn : {chess.turn}");

       
            
        }
    }
}
