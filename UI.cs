using System;
using System.Collections.Generic;
using System.Text;

namespace harkkaC1
{
   class UI
    {
        public void AskCharacterStats(ref Character thisPerson)
        {
            int tmp;

            Console.Write("Give Character a name: ");
            thisPerson.SetName(Console.ReadLine());

            Console.Write("Give Player name: ");
            thisPerson.SetPlayerName(Console.ReadLine());

            Console.Write("Give Character an armor class (1-6): ");
            int.TryParse(Console.ReadLine(), out tmp);
            thisPerson.SetArmorClass(tmp);

        }
    }
}
