using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourse
{
    class MainProgram
    {
        static private List<MenuItem> menuItems = new List<MenuItem>();
        static void Main( string[] args )
        {
            AddToList( new SortNames() );
            AddToList( new Lottery() );
            AddToList(new Labra2());

            while ( true )
            {
                Console.Clear();
                Console.Title = "OOP course";
                int choise = -1;
                Console.WriteLine( " Available exercises " );
                for ( int i = 0; i < menuItems.Count; i++ )
                {
                    MenuItem currentMenu = menuItems[i];
                    Console.WriteLine( ( i  ) + ": " + currentMenu.name);
                }

                Console.Write( "Choose: " );
                if(int.TryParse( Console.ReadLine(), out choise ) )
                {
                    Console.WriteLine( choise );
                    if ( choise > -1 && choise < menuItems.Count )
                    {
                        menuItems[choise].MainF();
                    }
                }
                
                
            }
           

        }

        static void AddToList(MenuItem obj)
        {
            menuItems.Add( obj );
        }
    }
}
