namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.wishlist2 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Selection = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.Fillbutton = new System.Windows.Forms.Button();
            this.Sortbutton = new System.Windows.Forms.Button();
            this.Clearbutton = new System.Windows.Forms.Button();
            this.Countbutton = new System.Windows.Forms.Button();
            this.Closebutton = new System.Windows.Forms.Button();
            this.selectionOutputBox = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // wishlist2
            // 
            this.wishlist2.FormattingEnabled = true;
            this.wishlist2.Location = new System.Drawing.Point(69, 46);
            this.wishlist2.Name = "wishlist2";
            this.wishlist2.Size = new System.Drawing.Size(136, 147);
            this.wishlist2.TabIndex = 0;
            this.wishlist2.SelectedIndexChanged += new System.EventHandler(this.wishlist2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Wish list";
            // 
            // Selection
            // 
            this.Selection.AutoSize = true;
            this.Selection.Location = new System.Drawing.Point(64, 235);
            this.Selection.Name = "Selection";
            this.Selection.Size = new System.Drawing.Size(51, 13);
            this.Selection.TabIndex = 2;
            this.Selection.Text = "Selection";
            this.Selection.Click += new System.EventHandler(this.Selection_Click);
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(64, 265);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(35, 13);
            this.Count.TabIndex = 3;
            this.Count.Text = "Count";
            this.Count.Click += new System.EventHandler(this.Count_Click);
            // 
            // Fillbutton
            // 
            this.Fillbutton.Location = new System.Drawing.Point(387, 64);
            this.Fillbutton.Name = "Fillbutton";
            this.Fillbutton.Size = new System.Drawing.Size(75, 23);
            this.Fillbutton.TabIndex = 4;
            this.Fillbutton.Text = "Fill";
            this.Fillbutton.UseVisualStyleBackColor = true;
            this.Fillbutton.Click += new System.EventHandler(this.Fillbutton_Click);
            // 
            // Sortbutton
            // 
            this.Sortbutton.Location = new System.Drawing.Point(387, 107);
            this.Sortbutton.Name = "Sortbutton";
            this.Sortbutton.Size = new System.Drawing.Size(75, 23);
            this.Sortbutton.TabIndex = 5;
            this.Sortbutton.Text = "Sort";
            this.Sortbutton.UseVisualStyleBackColor = true;
            this.Sortbutton.Click += new System.EventHandler(this.Sortbutton_Click);
            // 
            // Clearbutton
            // 
            this.Clearbutton.Location = new System.Drawing.Point(387, 152);
            this.Clearbutton.Name = "Clearbutton";
            this.Clearbutton.Size = new System.Drawing.Size(75, 23);
            this.Clearbutton.TabIndex = 6;
            this.Clearbutton.Text = "Clear";
            this.Clearbutton.UseVisualStyleBackColor = true;
            this.Clearbutton.Click += new System.EventHandler(this.Clearbutton_Click);
            // 
            // Countbutton
            // 
            this.Countbutton.Location = new System.Drawing.Point(387, 190);
            this.Countbutton.Name = "Countbutton";
            this.Countbutton.Size = new System.Drawing.Size(75, 23);
            this.Countbutton.TabIndex = 7;
            this.Countbutton.Text = "Count";
            this.Countbutton.UseVisualStyleBackColor = true;
            this.Countbutton.Click += new System.EventHandler(this.Countbutton_Click);
            // 
            // Closebutton
            // 
            this.Closebutton.Location = new System.Drawing.Point(387, 235);
            this.Closebutton.Name = "Closebutton";
            this.Closebutton.Size = new System.Drawing.Size(75, 23);
            this.Closebutton.TabIndex = 8;
            this.Closebutton.Text = "Close";
            this.Closebutton.UseVisualStyleBackColor = true;
            // 
            // selectionOutputBox
            // 
            this.selectionOutputBox.Location = new System.Drawing.Point(138, 228);
            this.selectionOutputBox.Name = "selectionOutputBox";
            this.selectionOutputBox.Size = new System.Drawing.Size(100, 20);
            this.selectionOutputBox.TabIndex = 9;
            this.selectionOutputBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(138, 265);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 10;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(596, 352);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.selectionOutputBox);
            this.Controls.Add(this.Closebutton);
            this.Controls.Add(this.Countbutton);
            this.Controls.Add(this.Clearbutton);
            this.Controls.Add(this.Sortbutton);
            this.Controls.Add(this.Fillbutton);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Selection);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wishlist2);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox wishlist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Fillbuttonbox;
        private System.Windows.Forms.Button Sortbuttonbox;
        private System.Windows.Forms.Button Clearbuttonbox;
        private System.Windows.Forms.Button Countbuttonbox;
        private System.Windows.Forms.Button Closebuttonbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ListBox wishlist2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Selection;
        private System.Windows.Forms.Label Count;
        private System.Windows.Forms.Button Fillbutton;
        private System.Windows.Forms.Button Sortbutton;
        private System.Windows.Forms.Button Clearbutton;
        private System.Windows.Forms.Button Countbutton;
        private System.Windows.Forms.Button Closebutton;
        private System.Windows.Forms.TextBox selectionOutputBox;
        private System.Windows.Forms.TextBox textBox4;
    }
}

