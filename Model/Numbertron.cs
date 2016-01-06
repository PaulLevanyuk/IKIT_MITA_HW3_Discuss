using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Numbertron
    {
        public delegate void NewNumberDelegate(int digit);

        public event NewNumberDelegate NewNumberevent;
        
        public void Generate()
        {
            var rn = new Random();
            NewNumberevent?.Invoke(rn.Next(0,100));
        }
    }
}
