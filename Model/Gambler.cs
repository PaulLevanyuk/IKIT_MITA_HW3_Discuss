using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Model
{
   public abstract class Gambler
   {
       protected Gambler(string name)
       {
           Name = name;
       }
       public readonly string Name;
       private int _score;

       public void IncreaseScore(int digit)
       {
           _score ++;
       }
       public int Score
       {
           get { return _score; }
           private set { _score = value; }
       }

       public abstract void FetchNewNumber(int digit);

   }
}
