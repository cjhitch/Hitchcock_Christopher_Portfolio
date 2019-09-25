namespace hitchcock_christopher_finalProject
{
    // inherits from GroceryItem and implements ITotal interface
    public class BulkItem : GroceryItem, ITotal
    {
        private decimal _total;
        private decimal _quantity;
        private decimal _singleItemCost;
        // constructor for item with in bulk
        public BulkItem(string name, decimal cost, decimal quantity) : base(name, cost)
        {
            _quantity = quantity;
            _singleItemCost = cost;
            CalculateTotal();
        }
        // getter for single item cost
        public override decimal TotalCost => _total;
        // getter for item quantity
        public override decimal Quantity => _quantity;
        // interface implementation for total price of either quantity or weight
        public decimal Total
        {
            get { return _total; }
        }
        protected override void CalculateTotal()
        {
            _total = _quantity * _singleItemCost;
        }
        public override string ToString()
        {
            string name = $"||  Item: {base.Name}";
            string cost = $"||  Price: ${_total}";
            return string.Format("{0,-100}{1,-25:}", name, cost);
        }
    }
}