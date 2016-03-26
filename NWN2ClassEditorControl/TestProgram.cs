using System;
using System.Collections.Generic;
using System.Text;

namespace BuzzX8.NWN2ClassEditorControl
{
    class TestProgram
    {
        public static void Main()
        {
            TwoDATable table = new TwoDATable("racialsubtypes.2da");
            //TwoDATable table2 = new TwoDATable("col1", "col2", "col3");

            table.SaveToFile("r.2da");

            Console.WriteLine(table[0, 0]);
            
        }
    }
}
