using System;
using System.Collections.Generic;
using System.Text;

namespace McrDigital.Bootcamp1.Cards
{
    interface IGenericCard<T>
    {
        bool Snap(T other);
    }
}
