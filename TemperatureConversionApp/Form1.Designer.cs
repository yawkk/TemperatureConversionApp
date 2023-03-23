namespace TemperatureConversionApp
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
            this.farhenheight = new System.Windows.Forms.Label();
            this.celcuis = new System.Windows.Forms.Label();
            this.kelvin = new System.Windows.Forms.Label();
            this.txt_farhenheight = new System.Windows.Forms.TextBox();
            this.txt_celcius = new System.Windows.Forms.TextBox();
            this.txt_kelvin = new System.Windows.Forms.TextBox();
            this.btn_farhenheight = new System.Windows.Forms.Button();
            this.btn_celcius = new System.Windows.Forms.Button();
            this.btn_kelvin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // farhenheight
            // 
            this.farhenheight.AutoSize = true;
            this.farhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.farhenheight.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.farhenheight.Location = new System.Drawing.Point(53, 79);
            this.farhenheight.Name = "farhenheight";
            this.farhenheight.Size = new System.Drawing.Size(167, 29);
            this.farhenheight.TabIndex = 0;
            this.farhenheight.Text = "Farhenheight";
            this.farhenheight.Click += new System.EventHandler(this.ferhenheight_Click);
            // 
            // celcuis
            // 
            this.celcuis.AutoSize = true;
            this.celcuis.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celcuis.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.celcuis.Location = new System.Drawing.Point(121, 163);
            this.celcuis.Name = "celcuis";
            this.celcuis.Size = new System.Drawing.Size(100, 29);
            this.celcuis.TabIndex = 1;
            this.celcuis.Text = "Celsius";
            this.celcuis.Click += new System.EventHandler(this.celcuis_Click);
            // 
            // kelvin
            // 
            this.kelvin.AutoSize = true;
            this.kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kelvin.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.kelvin.Location = new System.Drawing.Point(136, 247);
            this.kelvin.Name = "kelvin";
            this.kelvin.Size = new System.Drawing.Size(85, 29);
            this.kelvin.TabIndex = 2;
            this.kelvin.Text = "Kelvin";
            this.kelvin.Click += new System.EventHandler(this.kelvin_Click);
            // 
            // txt_farhenheight
            // 
            this.txt_farhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_farhenheight.Location = new System.Drawing.Point(320, 86);
            this.txt_farhenheight.Name = "txt_farhenheight";
            this.txt_farhenheight.Size = new System.Drawing.Size(146, 34);
            this.txt_farhenheight.TabIndex = 3;
            this.txt_farhenheight.TextChanged += new System.EventHandler(this.btn_farhenheight_Click);
            // 
            // txt_celcius
            // 
            this.txt_celcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_celcius.Location = new System.Drawing.Point(319, 164);
            this.txt_celcius.Name = "txt_celcius";
            this.txt_celcius.Size = new System.Drawing.Size(146, 34);
            this.txt_celcius.TabIndex = 4;
            this.txt_celcius.TextChanged += new System.EventHandler(this.ferhenheight_Click);
            // 
            // txt_kelvin
            // 
            this.txt_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kelvin.Location = new System.Drawing.Point(318, 254);
            this.txt_kelvin.Name = "txt_kelvin";
            this.txt_kelvin.Size = new System.Drawing.Size(146, 34);
            this.txt_kelvin.TabIndex = 5;
            // 
            // btn_farhenheight
            // 
            this.btn_farhenheight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_farhenheight.Location = new System.Drawing.Point(529, 85);
            this.btn_farhenheight.Name = "btn_farhenheight";
            this.btn_farhenheight.Size = new System.Drawing.Size(113, 37);
            this.btn_farhenheight.TabIndex = 6;
            this.btn_farhenheight.Text = "convert";
            this.btn_farhenheight.UseVisualStyleBackColor = true;
            this.btn_farhenheight.Click += new System.EventHandler(this.btn_farhenheight_Click);
            // 
            // btn_celcius
            // 
            this.btn_celcius.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_celcius.Location = new System.Drawing.Point(529, 163);
            this.btn_celcius.Name = "btn_celcius";
            this.btn_celcius.Size = new System.Drawing.Size(113, 35);
            this.btn_celcius.TabIndex = 7;
            this.btn_celcius.Text = "convert";
            this.btn_celcius.UseVisualStyleBackColor = true;
            this.btn_celcius.Click += new System.EventHandler(this.btn_celcius_Click);
            // 
            // btn_kelvin
            // 
            this.btn_kelvin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kelvin.Location = new System.Drawing.Point(529, 253);
            this.btn_kelvin.Name = "btn_kelvin";
            this.btn_kelvin.Size = new System.Drawing.Size(113, 37);
            this.btn_kelvin.TabIndex = 8;
            this.btn_kelvin.Text = "convert";
            this.btn_kelvin.UseVisualStyleBackColor = true;
            this.btn_kelvin.Click += new System.EventHandler(this.btn_kelvin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kelvin);
            this.Controls.Add(this.btn_celcius);
            this.Controls.Add(this.btn_farhenheight);
            this.Controls.Add(this.txt_kelvin);
            this.Controls.Add(this.txt_celcius);
            this.Controls.Add(this.txt_farhenheight);
            this.Controls.Add(this.kelvin);
            this.Controls.Add(this.celcuis);
            this.Controls.Add(this.farhenheight);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label farhenheight;
        private System.Windows.Forms.Label celcuis;
        private System.Windows.Forms.Label kelvin;
        private System.Windows.Forms.TextBox txt_farhenheight;
        private System.Windows.Forms.TextBox txt_celcius;
        private System.Windows.Forms.TextBox txt_kelvin;
        private System.Windows.Forms.Button btn_farhenheight;
        private System.Windows.Forms.Button btn_celcius;
        private System.Windows.Forms.Button btn_kelvin;
    }
}

