namespace CircusTrein
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.plant = new System.Windows.Forms.RadioButton();
            this.meat = new System.Windows.Forms.RadioButton();
            this.small = new System.Windows.Forms.RadioButton();
            this.medium = new System.Windows.Forms.RadioButton();
            this.large = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.animalList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.plant);
            this.groupBox1.Controls.Add(this.meat);
            this.groupBox1.Location = new System.Drawing.Point(30, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "What does it eat?";
            // 
            // plant
            // 
            this.plant.AutoSize = true;
            this.plant.Location = new System.Drawing.Point(7, 59);
            this.plant.Name = "plant";
            this.plant.Size = new System.Drawing.Size(98, 21);
            this.plant.TabIndex = 1;
            this.plant.Text = "Plant eater";
            this.plant.UseVisualStyleBackColor = true;
            // 
            // meat
            // 
            this.meat.AutoSize = true;
            this.meat.Checked = true;
            this.meat.Location = new System.Drawing.Point(7, 31);
            this.meat.Name = "meat";
            this.meat.Size = new System.Drawing.Size(97, 21);
            this.meat.TabIndex = 0;
            this.meat.TabStop = true;
            this.meat.Text = "Meat eater";
            this.meat.UseVisualStyleBackColor = true;
            // 
            // small
            // 
            this.small.AutoSize = true;
            this.small.Checked = true;
            this.small.Location = new System.Drawing.Point(6, 21);
            this.small.Name = "small";
            this.small.Size = new System.Drawing.Size(63, 21);
            this.small.TabIndex = 3;
            this.small.TabStop = true;
            this.small.Text = "Small";
            this.small.UseVisualStyleBackColor = true;
            // 
            // medium
            // 
            this.medium.AutoSize = true;
            this.medium.Location = new System.Drawing.Point(6, 48);
            this.medium.Name = "medium";
            this.medium.Size = new System.Drawing.Size(78, 21);
            this.medium.TabIndex = 4;
            this.medium.Text = "Medium";
            this.medium.UseVisualStyleBackColor = true;
            // 
            // large
            // 
            this.large.AutoSize = true;
            this.large.Location = new System.Drawing.Point(6, 75);
            this.large.Name = "large";
            this.large.Size = new System.Drawing.Size(66, 21);
            this.large.TabIndex = 5;
            this.large.Text = "Large";
            this.large.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.small);
            this.groupBox2.Controls.Add(this.large);
            this.groupBox2.Controls.Add(this.medium);
            this.groupBox2.Location = new System.Drawing.Point(30, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "How large is the animal?";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add animal";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(30, 42);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(200, 22);
            this.name.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Animal name";
            // 
            // animalList
            // 
            this.animalList.FormattingEnabled = true;
            this.animalList.ItemHeight = 16;
            this.animalList.Location = new System.Drawing.Point(261, 42);
            this.animalList.Name = "animalList";
            this.animalList.Size = new System.Drawing.Size(491, 276);
            this.animalList.TabIndex = 12;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(517, 336);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(235, 38);
            this.button2.TabIndex = 13;
            this.button2.Text = "Start calculating";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.animalList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton small;
        private System.Windows.Forms.RadioButton medium;
        private System.Windows.Forms.RadioButton large;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton plant;
        private System.Windows.Forms.RadioButton meat;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox animalList;
        private System.Windows.Forms.Button button2;
    }
}

