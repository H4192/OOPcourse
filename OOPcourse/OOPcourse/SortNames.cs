using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPcourse
{
    class SortNames : MenuItem
    {
        new static string name  = "SortNames";
        public SortNames() : base(name)
        {

        }

        override public void MainF()
        {
            string oldLine = "You entered names: ";
            string newLine = "The entered names alphabetically: ";

            Console.WriteLine( "Enter 5 names" );
            string[] names = new string[5];

            for ( int i = 0; i < 5; i++ ) { names[i] = Console.ReadLine(); }

            oldLine = oldLine + String.Join( " ", names );
            Array.Sort( names );
            newLine = newLine + String.Join( " ", names );


            Console.WriteLine( oldLine );
            Console.WriteLine( newLine );
            Console.ReadLine();
        }
    }
}
