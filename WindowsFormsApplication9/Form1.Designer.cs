namespace WindowsFormsApplication9
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
            this.Title = new System.Windows.Forms.Label();
            this.yourweight = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnMercury = new System.Windows.Forms.Button();
            this.btnVenus = new System.Windows.Forms.Button();
            this.btnMars = new System.Windows.Forms.Button();
            this.btnJupiter = new System.Windows.Forms.Button();
            this.btnSaturn = new System.Windows.Forms.Button();
            this.btnUranus = new System.Windows.Forms.Button();
            this.btnNeptune = new System.Windows.Forms.Button();
            this.btnPluto = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(133, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(145, 24);
            this.Title.TabIndex = 0;
            this.Title.Text = "Menu of Planets";
            // 
            // yourweight
            // 
            this.yourweight.AutoSize = true;
            this.yourweight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yourweight.Location = new System.Drawing.Point(68, 48);
            this.yourweight.Name = "yourweight";
            this.yourweight.Size = new System.Drawing.Size(85, 13);
            this.yourweight.TabIndex = 1;
            this.yourweight.Text = "Your Weight(lbs)";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(159, 45);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "0";
            // 
            // btnMercury
            // 
            this.btnMercury.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMercury.Location = new System.Drawing.Point(56, 115);
            this.btnMercury.Name = "btnMercury";
            this.btnMercury.Size = new System.Drawing.Size(75, 23);
            this.btnMercury.TabIndex = 3;
            this.btnMercury.Text = "Mercury";
            this.btnMercury.UseVisualStyleBackColor = true;
            this.btnMercury.Click += new System.EventHandler(this.btnMercury_Click);
            // 
            // btnVenus
            // 
            this.btnVenus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnVenus.Location = new System.Drawing.Point(174, 115);
            this.btnVenus.Name = "btnVenus";
            this.btnVenus.Size = new System.Drawing.Size(75, 23);
            this.btnVenus.TabIndex = 4;
            this.btnVenus.Text = "Venus";
            this.btnVenus.UseVisualStyleBackColor = true;
            this.btnVenus.Click += new System.EventHandler(this.btnVenus_Click);
            // 
            // btnMars
            // 
            this.btnMars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnMars.Location = new System.Drawing.Point(288, 115);
            this.btnMars.Name = "btnMars";
            this.btnMars.Size = new System.Drawing.Size(75, 23);
            this.btnMars.TabIndex = 5;
            this.btnMars.Text = "Mars";
            this.btnMars.UseVisualStyleBackColor = true;
            this.btnMars.Click += new System.EventHandler(this.btnMars_Click);
            // 
            // btnJupiter
            // 
            this.btnJupiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnJupiter.Location = new System.Drawing.Point(56, 168);
            this.btnJupiter.Name = "btnJupiter";
            this.btnJupiter.Size = new System.Drawing.Size(75, 23);
            this.btnJupiter.TabIndex = 6;
            this.btnJupiter.Text = "Jupiter";
            this.btnJupiter.UseVisualStyleBackColor = true;
            this.btnJupiter.Click += new System.EventHandler(this.btnJupiter_Click);
            // 
            // btnSaturn
            // 
            this.btnSaturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnSaturn.Location = new System.Drawing.Point(175, 168);
            this.btnSaturn.Name = "btnSaturn";
            this.btnSaturn.Size = new System.Drawing.Size(75, 23);
            this.btnSaturn.TabIndex = 7;
            this.btnSaturn.Text = "Saturn";
            this.btnSaturn.UseVisualStyleBackColor = true;
            this.btnSaturn.Click += new System.EventHandler(this.btnSaturn_Click);
            // 
            // btnUranus
            // 
            this.btnUranus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnUranus.Location = new System.Drawing.Point(288, 168);
            this.btnUranus.Name = "btnUranus";
            this.btnUranus.Size = new System.Drawing.Size(75, 23);
            this.btnUranus.TabIndex = 8;
            this.btnUranus.Text = "Uranus";
            this.btnUranus.UseVisualStyleBackColor = true;
            this.btnUranus.Click += new System.EventHandler(this.btnUranus_Click);
            // 
            // btnNeptune
            // 
            this.btnNeptune.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNeptune.Location = new System.Drawing.Point(56, 218);
            this.btnNeptune.Name = "btnNeptune";
            this.btnNeptune.Size = new System.Drawing.Size(75, 23);
            this.btnNeptune.TabIndex = 9;
            this.btnNeptune.Text = "Neptune";
            this.btnNeptune.UseVisualStyleBackColor = true;
            this.btnNeptune.Click += new System.EventHandler(this.btnNeptune_Click);
            // 
            // btnPluto
            // 
            this.btnPluto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnPluto.Location = new System.Drawing.Point(174, 218);
            this.btnPluto.Name = "btnPluto";
            this.btnPluto.Size = new System.Drawing.Size(75, 23);
            this.btnPluto.TabIndex = 10;
            this.btnPluto.Text = "Pluto";
            this.btnPluto.UseVisualStyleBackColor = true;
            this.btnPluto.Click += new System.EventHandler(this.btnPluto_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnClear.Location = new System.Drawing.Point(288, 218);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label1.Location = new System.Drawing.Point(171, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Select a Planet";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(113, 284);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 355);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPluto);
            this.Controls.Add(this.btnNeptune);
            this.Controls.Add(this.btnUranus);
            this.Controls.Add(this.btnSaturn);
            this.Controls.Add(this.btnJupiter);
            this.Controls.Add(this.btnMars);
            this.Controls.Add(this.btnVenus);
            this.Controls.Add(this.btnMercury);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.yourweight);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label yourweight;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnMercury;
        private System.Windows.Forms.Button btnVenus;
        private System.Windows.Forms.Button btnMars;
        private System.Windows.Forms.Button btnJupiter;
        private System.Windows.Forms.Button btnSaturn;
        private System.Windows.Forms.Button btnUranus;
        private System.Windows.Forms.Button btnNeptune;
        private System.Windows.Forms.Button btnPluto;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}

