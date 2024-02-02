using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class Coin : Treasure{
        public int Value { get; set; }
        public Coin(string description, int score, int value) : base(description, score){
            Value = value;
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            board.UpdateTotalValue(Value);
            Console.WriteLine("Total Value is updated to: " + board.TotalValue);
        }
        public override void Display(){
            Console.WriteLine("Coin " + Description + " is displayed");
        }
    }
}
