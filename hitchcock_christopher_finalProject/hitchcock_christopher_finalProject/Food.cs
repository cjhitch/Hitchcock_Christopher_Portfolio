namespace hitchcock_christopher_finalProject
{
    // inherits from GroceryItem and implements ITotal interface
    public class Food : GroceryItem, ITotal
    {
        private decimal _total;
        private decimal _weight;
        private decimal _singleItemCost;
        // constructor for Food
        public Food(string name, decimal cost, decimal weight) : base(name, cost)
        {
            _weight = weight;
            _singleItemCost = cost;
            CalculateTotal();
        }
        // getter for single item cost
        public override decimal TotalCost => _total;
        // getter for item weight
        public override decimal Quantity => _weight;
        // interface implementation for total price of either quantity or weight
        public decimal Total
        {
            get { return _total; }
        }
        protected override void CalculateTotal()
        {
            _total = _weight * _singleItemCost;
        }
        public override string ToString()
        {
            string name = $"||  Item: {base.Name}";
            string cost = $"||  Price: ${_total}";
            return string.Format("{0,-100}{1,-25:}", name, cost);
        }
    }
}