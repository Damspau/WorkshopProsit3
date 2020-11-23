using System;
using System.Collections.Generic;
using System.Text;

namespace WorkshopProsit3
{
    class Controller
    {
        public Controller()
        {
            View view = new View();
            view.wordEvent += convertWord;
            view.WaitInput();
        }

        public void  convertWord (string WordToConvert)
        {
            string toSend = WordToConvert.ToUpper();
            new Model().word = toSend;
            new DisplayView(toSend);
        }



    }
}
