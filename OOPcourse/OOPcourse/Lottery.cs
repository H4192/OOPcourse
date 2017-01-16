using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPcourse
{
    class Lottery : MenuItem
    {
        new static string name = "Lottery";
        public Lottery() : base( name )
        {

        }

        override public void MainF()
        {
            int rowCount = 0;
            Random rand = new Random();
            Console.WriteLine( "How many rows do you want?" );

            while ( rowCount <= 0 )
            {
                int.TryParse( Console.ReadLine(), out rowCount );
            }

            for ( int x = 0; x < rowCount; x++ )
            {
                int[] numbers = new int[7];
                for ( int y = 0; y < 7; y++ )
                {
                    bool bChecked = false;
                    while ( !bChecked )
                    {
                        int checkNumber = rand.Next(1,40);
                        if ( Array.IndexOf( numbers, checkNumber ) < 0 )
                        {
                            numbers[y] = checkNumber;
                            bChecked = true;
                        };
                    }
                }
                string str = "Row "+x+":";

                Array.Sort( numbers );
                str = str + " " + String.Join( ", ", numbers );

                Console.WriteLine( str );
            }

            Console.ReadLine();
        }
    }
}
