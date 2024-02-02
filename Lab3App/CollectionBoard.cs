using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public class CollectionBoard{
        public int TotalScore { get; set; }
        public int TotalValue { get; set; }  
        public void UpdateTotalScore(int score){
            TotalScore = TotalScore + score;
        }
        public void UpdateTotalValue(int value){
            TotalValue = TotalValue + value;
        }
        
    }
}
