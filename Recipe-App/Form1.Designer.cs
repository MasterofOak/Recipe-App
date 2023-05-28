namespace Recipe_App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_creater = new System.Windows.Forms.Button();
            this.question = new System.Windows.Forms.Label();
            this.ing_count = new System.Windows.Forms.TextBox();
            this.grid = new System.Windows.Forms.DataGridView();
            this.add_recipe_btn = new System.Windows.Forms.Button();
            this.reset_btn = new System.Windows.Forms.Button();
            this.recipe_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_creater
            // 
            this.textBox_creater.AutoSize = true;
            this.textBox_creater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(77)))), ((int)(((byte)(39)))));
            this.textBox_creater.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_creater.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox_creater.Location = new System.Drawing.Point(12, 672);
            this.textBox_creater.Name = "textBox_creater";
            this.textBox_creater.Padding = new System.Windows.Forms.Padding(10);
            this.textBox_creater.Size = new System.Drawing.Size(200, 60);
            this.textBox_creater.TabIndex = 0;
            this.textBox_creater.Text = "Create";
            this.textBox_creater.UseVisualStyleBackColor = false;
            this.textBox_creater.Click += new System.EventHandler(this.textBox_creater_Click);
            // 
            // question
            // 
            this.question.AutoSize = true;
            this.question.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.question.Location = new System.Drawing.Point(12, 635);
            this.question.Name = "question";
            this.question.Size = new System.Drawing.Size(448, 23);
            this.question.TabIndex = 1;
            this.question.Text = "How many ingredients does your recipe has?";
            this.question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ing_count
            // 
            this.ing_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.ing_count.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ing_count.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ing_count.ForeColor = System.Drawing.Color.Black;
            this.ing_count.Location = new System.Drawing.Point(466, 633);
            this.ing_count.Name = "ing_count";
            this.ing_count.Size = new System.Drawing.Size(186, 30);
            this.ing_count.TabIndex = 2;
            // 
            // grid
            // 
            this.grid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.grid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.grid.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.grid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.grid.Location = new System.Drawing.Point(862, 12);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 62;
            this.grid.RowTemplate.Height = 33;
            this.grid.Size = new System.Drawing.Size(1050, 720);
            this.grid.TabIndex = 3;
            // 
            // add_recipe_btn
            // 
            this.add_recipe_btn.AutoSize = true;
            this.add_recipe_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(77)))), ((int)(((byte)(39)))));
            this.add_recipe_btn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.add_recipe_btn.FlatAppearance.BorderSize = 4;
            this.add_recipe_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.add_recipe_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.add_recipe_btn.Location = new System.Drawing.Point(218, 672);
            this.add_recipe_btn.Name = "add_recipe_btn";
            this.add_recipe_btn.Padding = new System.Windows.Forms.Padding(10);
            this.add_recipe_btn.Size = new System.Drawing.Size(229, 60);
            this.add_recipe_btn.TabIndex = 4;
            this.add_recipe_btn.Text = "Add Recipe";
            this.add_recipe_btn.UseVisualStyleBackColor = false;
            this.add_recipe_btn.Click += new System.EventHandler(this.add_recipe_btn_Click);
            // 
            // reset_btn
            // 
            this.reset_btn.AutoSize = true;
            this.reset_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(77)))), ((int)(((byte)(39)))));
            this.reset_btn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reset_btn.ForeColor = System.Drawing.SystemColors.Window;
            this.reset_btn.Location = new System.Drawing.Point(453, 672);
            this.reset_btn.Name = "reset_btn";
            this.reset_btn.Padding = new System.Windows.Forms.Padding(10);
            this.reset_btn.Size = new System.Drawing.Size(199, 60);
            this.reset_btn.TabIndex = 6;
            this.reset_btn.Text = "Reset";
            this.reset_btn.UseVisualStyleBackColor = false;
            this.reset_btn.Click += new System.EventHandler(this.reset_btn_Click);
            // 
            // recipe_name
            // 
            this.recipe_name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.recipe_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.recipe_name.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.recipe_name.Location = new System.Drawing.Point(168, 10);
            this.recipe_name.Name = "recipe_name";
            this.recipe_name.Size = new System.Drawing.Size(241, 30);
            this.recipe_name.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(22, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 8;
            this.label1.Text = "Recipe Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchBox
            // 
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(227)))), ((int)(((byte)(147)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchBox.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.searchBox.Location = new System.Drawing.Point(186, 581);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(150, 30);
            this.searchBox.TabIndex = 9;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search table by ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(201)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1924, 744);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.recipe_name);
            this.Controls.Add(this.reset_btn);
            this.Controls.Add(this.add_recipe_btn);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.ing_count);
            this.Controls.Add(this.question);
            this.Controls.Add(this.textBox_creater);
            this.Name = "Form1";
            this.Text = "My Recipe Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button textBox_creater;
        private Label question;
        private TextBox ing_count;
        private DataGridView grid;
        private Button add_recipe_btn;
        private Button reset_btn;
        private TextBox recipe_name;
        private Label label1;
        private TextBox searchBox;
        private Label label2;
    }
}