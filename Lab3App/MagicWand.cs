using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class MagicWand : Tool {
        public MagicWand(string description) : base(description) { }
        public override void Display(){
            Console.WriteLine("Magic Wand " + Description + " is displayed");
        }
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }
    }
}
