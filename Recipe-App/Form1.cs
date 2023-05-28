using System.Data;

namespace Recipe_App
{
    public partial class Form1 : Form
    {
        List<TextBox> inputs = new List<TextBox>(); //Creating a list of future textBoxes
        DataTable table = new DataTable(); //Creating a new table object
        DateTime now = DateTime.Now; // Creating  a new DataTime object to get a current date
        public Form1()
        {
            InitializeComponent();
        }

        //Custom event to delegate a user's input 
        void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9'))
            {

                return;
            }
            if (e.KeyChar == '.')
            {

                e.KeyChar = ',';
                return;
            }
            e.Handled = true;
        }
        //Function to create textboxes based on user's input
        private void textBox_creater_Click(object sender, EventArgs e)
        {
            try
            {
                int count = Convert.ToInt16(ing_count.Text);
                if(count > 10)
                {
                    throw new Exception();
                }
                int top = 60;
                int left = 20;

                for (int i = 1; i <= count; i++)
                {
                    //Creating Labels for ingredients
                    Label lbl_Ing = new Label();
                    this.Controls.Add(lbl_Ing);
                    lbl_Ing.Location = new Point(left, top);
                    lbl_Ing.AutoSize = true;
                    lbl_Ing.MaximumSize = new Size(200, 0);
                    lbl_Ing.TextAlign = ContentAlignment.MiddleLeft;
                    lbl_Ing.Font = new Font("Arial Rounded MT Bold", 9);
                    lbl_Ing.Text = $"Ingredient-{i}";

                    //Creating textBoxes for ingredients
                    TextBox txt_ing = new TextBox();
                    this.Controls.Add(txt_ing);
                    txt_ing.Location = new Point(left * 8, top);
                    txt_ing.Width = 150;
                    txt_ing.Height = 100;
                    txt_ing.Font = new Font("Arial", 10);
                    txt_ing.BackColor = System.Drawing.ColorTranslator.FromHtml("#e7e393");
                    txt_ing.BorderStyle = BorderStyle.FixedSingle;

                    //Creating Labels for amount
                    Label lbl_amount = new Label();
                    this.Controls.Add(lbl_amount);
                    lbl_amount.Location = new Point(left * 16, top);
                    lbl_amount.AutoSize = true;
                    lbl_amount.MaximumSize = new Size(250, 0);
                    lbl_amount.TextAlign = ContentAlignment.MiddleLeft;
                    lbl_amount.Font = new Font("Arial Rounded MT Bold", 9);
                    lbl_amount.Text = "Amount of product(in kg/lt)";

                    //Creating textBoxes for amount
                    TextBox txt_amount = new TextBox();
                    this.Controls.Add(txt_amount);
                    txt_amount.Location = new Point(left * 29, top);
                    txt_amount.Width = 50;
                    txt_amount.Height = 100;
                    txt_amount.Font = new Font("Arial", 10);
                    txt_amount.BackColor = System.Drawing.ColorTranslator.FromHtml("#e7e393");
                    txt_amount.BorderStyle = BorderStyle.FixedSingle;
                    txt_amount.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

                    //Creating Labels for pricing
                    Label lbl_price = new Label();
                    this.Controls.Add(lbl_price);
                    lbl_price.Location = new Point(left * 32, top);
                    lbl_price.AutoSize = true;
                    lbl_price.MaximumSize = new Size(200, 0);
                    lbl_price.TextAlign = ContentAlignment.MiddleLeft;
                    lbl_price.Font = new Font("Arial Rounded MT Bold", 9);
                    lbl_price.Text = "Price per 1kg/litr";

                    //Creating textBoxes for pricing
                    TextBox txt_price = new TextBox();
                    this.Controls.Add(txt_price);
                    txt_price.Location = new Point(left * 40, top);
                    txt_price.Width = 50;
                    txt_price.Height = 100;
                    txt_price.Font = new Font("Arial",10);
                    txt_price.BackColor = System.Drawing.ColorTranslator.FromHtml("#e7e393");
                    txt_price.BorderStyle = BorderStyle.FixedSingle;
                    txt_price.KeyPress += new KeyPressEventHandler(TextBox_KeyPress);

                    top += 50;
                    inputs.Add(txt_ing);
                    inputs.Add(txt_amount);
                    inputs.Add(txt_price);
                }
            }
            catch
            {
                MessageBox.Show("Number needs to be greater than zero or not greater than 10! Try again!");
            }
            
        }

        private void add_recipe_btn_Click(object sender, EventArgs e)
        {
            try
            {
                //Checking if user created a textBoxes
                if (inputs.ElementAtOrDefault(1) == null)
                {
                    throw new Exception($"{MessageBox.Show("PLease create form fields!")}");
                }
                Ingredient[] ingredients = new Ingredient[10]; // Initializing an array of ingredient object
                int counter = 0;
                //Loop to iterate through eaxch objects and input data
                for (int i = 0; i < ingredients.Length; i++)
                {
                    if (inputs.ElementAtOrDefault(counter) != null)
                    {
                        Ingredient ingredient = new Ingredient(Convert.ToString(inputs[counter].Text), (float)Convert.ToDouble(inputs[counter + 1].Text), (float)Convert.ToDouble(inputs[counter + 2].Text));
                        ingredients[i] = ingredient;
                        counter += 3;
                    }

                }
                Recipe recipe = new Recipe(recipe_name.Text, ingredients); //Initializing our future recipe object
                MessageBox.Show($"Overall price of your recipe will be {recipe.overallPrice()} UAH ");
                WriteToDB(recipe);
                LoadDB();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please fill in all forms inputs!");
            }
        }
        //Function for loading our DB of recipes
        private void LoadDB()
        {
            string[] lines = System.IO.File.ReadAllLines(@"D:\Games\c++\\Recipe-App\Recipe-App\Recipre-DB.csv");
            string[] values;
            table.Rows.Clear();
            for (int i = 1; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split(';');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }
                table.Rows.Add(row);
            }
        }
        //Function to write a data to DB
        private void WriteToDB(Recipe recipe)
        {
            using (var writer = new StreamWriter(@"D:\Games\c++\Recipe-App\Recipe-App\Recipre-DB.csv", true))
            {
                string line = $"{recipe.Name};";
                for (int i = 0; i < recipe.ingredients.Length; i++)
                {
                    if (!(recipe.ingredients[i] == null))
                    {
                        line += recipe.ingredients[i].ConcatinateValues() + ";";
                    }
                    else
                    {
                        line += "-;";
                    }
                }
                line += recipe.overallPrice() + " UAH;";
                line += now;
                writer.WriteLine(line);
            }
        }
        //Function to reset number of textBoxes if user want more or less
        private void reset_btn_Click(object sender, EventArgs e)
        {
            foreach (var el in inputs)
            {
                el.Dispose();
            }
            inputs.Clear();
            foreach (Control ctrl in Controls)
            {
                if ((ctrl is Label) && (ctrl.Name !="question") && (ctrl.Name != "label1") && (ctrl.Name != "label2"))
                {
                    ctrl.Text = "";
                }
            }
        }
        //Function to style grid
        private void styleGrid()
        {
            grid.BorderStyle = BorderStyle.None;
            grid.AlternatingRowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#f1dabf");
            grid.RowsDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#92817a");
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SunkenVertical;
            grid.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            grid.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            grid.BackgroundColor = ColorTranslator.FromHtml("#362417");
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial",10); 
            grid.DefaultCellStyle.Font = new Font("Arial",10); 
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //On forms load we change each buttons style
            foreach (var button in this.Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderSize = 0;
            }
            //Creating a columns for our grid
            table.Columns.Add("Name");
            table.Columns.Add("Ing-1");
            table.Columns.Add("Ing-2");
            table.Columns.Add("Ing-3");
            table.Columns.Add("Ing-4");
            table.Columns.Add("Ing-5");
            table.Columns.Add("Ing-6");
            table.Columns.Add("Ing-7");
            table.Columns.Add("Ing-8");
            table.Columns.Add("Ing-9");
            table.Columns.Add("Ing-10");
            table.Columns.Add("Price");
            table.Columns.Add("Date");
            grid.DataSource = table;
            styleGrid();
            LoadDB();
        }

        //Function for filtering information in grid
        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                var rows = table.Select(string.Format("[Name] like '%" + searchBox.Text + "%' " +
                "OR [Date] like '%" + searchBox.Text + "%'" +
                "OR [Price] like '%" + searchBox.Text + "%'"));

                grid.DataSource = rows.CopyToDataTable();
                grid.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("There is no such item that corresponds to your input");
            }
        }
    }
}