using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game.Models
{
    public class Card
    {

        private Tuple<string, string> values;  
        public Card(string color, string value)
        {
            values = new Tuple<string, string>(color, value);
        }
        public Tuple<string, string> Values
        {
            get { return values; }
        }
    }
}
