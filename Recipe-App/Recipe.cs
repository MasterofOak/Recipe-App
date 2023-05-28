namespace Recipe_App
{
    internal class Recipe
    {
        public Recipe(string name, Ingredient[] ingredients)
        {
            this.Name = name;
            this.ingredients = ingredients;
        }
        public string Name { get; set; }
        public Ingredient[] ingredients = new Ingredient[10];

        public float overallPrice()
        {
            float sum = 0;
            for(int i = 0; i< ingredients.Length; i++)
            {
                if (!(ingredients[i] == null)){
                    sum += ingredients[i].Price * ingredients[i].Amount;
                }
            }
            return sum;
        }
    }
}
