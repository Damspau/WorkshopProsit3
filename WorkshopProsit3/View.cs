using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopProsit3
{
    class View
    {
        public delegate void wordAdded (string wordToConvert);

        public event wordAdded wordEvent;
        public View()
        {
            

        }

        public void WaitInput ()
        {
            Console.WriteLine("rentrez le mot à convertir");
            string wordToConvert = Console.ReadLine();

            wordEvent?.Invoke(wordToConvert);
        }
    }
}
