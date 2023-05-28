namespace Recipe_App
{
    internal class Ingredient { 
        public Ingredient(string name, float amount, float price)
        {
            this.Name = name;
            this.Amount = amount;
            this.Price = price;
        }

        public string Name { get; set; }
        public float Amount { get; set; }
        public float Price { get; set; }

        public string ConcatinateValues()
        {
            return this.Name + " " + this.Amount + " grams/litr ";
        }
    }
}
