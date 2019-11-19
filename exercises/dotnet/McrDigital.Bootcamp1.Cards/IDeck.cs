using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    interface IDeck
    {

        GenericCard Deal();
        void Shuffle();
        string[] GetCards();
    }
}
