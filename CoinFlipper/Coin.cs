using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoinFlipper
{
    public class Coin
    {
        int lado = 0;

        public int Sortear()
        {
            lado = new Random().Next(2);
            return lado;
        }
    }
}
