using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace hitchcock_christopher_finalProject
{
    public class GroceryItem
    {
        private string _name;
        private decimal _cost;

        public GroceryItem(string name, decimal cost)
        {
            _name = name;
            _cost = cost;
        }

        public string Name => _name;

        public decimal Cost => _cost;

        public virtual decimal TotalCost => 0;
        
        public virtual decimal Quantity => 0;

        protected virtual void CalculateTotal()
        {
            
        }
    }
}