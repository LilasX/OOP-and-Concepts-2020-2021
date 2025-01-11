namespace WindowsLab1
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
            this.txt_kg = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonexit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_lbs = new System.Windows.Forms.TextBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttonconvert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_kg
            // 
            this.txt_kg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kg.Location = new System.Drawing.Point(168, 24);
            this.txt_kg.Name = "txt_kg";
            this.txt_kg.Size = new System.Drawing.Size(320, 44);
            this.txt_kg.TabIndex = 0;
            this.txt_kg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_kg_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kg";
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonexit.Location = new System.Drawing.Point(52, 179);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(107, 45);
            this.buttonexit.TabIndex = 2;
            this.buttonexit.Text = "Exit";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Lbs";
            // 
            // txt_lbs
            // 
            this.txt_lbs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lbs.Location = new System.Drawing.Point(168, 92);
            this.txt_lbs.Name = "txt_lbs";
            this.txt_lbs.Size = new System.Drawing.Size(320, 44);
            this.txt_lbs.TabIndex = 3;
            this.txt_lbs.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_lbs_KeyPress);
            // 
            // buttonclear
            // 
            this.buttonclear.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonclear.Location = new System.Drawing.Point(212, 179);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(107, 45);
            this.buttonclear.TabIndex = 5;
            this.buttonclear.Text = "Clear";
            this.buttonclear.UseVisualStyleBackColor = false;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttonconvert
            // 
            this.buttonconvert.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonconvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonconvert.Location = new System.Drawing.Point(363, 179);
            this.buttonconvert.Name = "buttonconvert";
            this.buttonconvert.Size = new System.Drawing.Size(125, 45);
            this.buttonconvert.TabIndex = 6;
            this.buttonconvert.Text = "Convert";
            this.buttonconvert.UseVisualStyleBackColor = false;
            this.buttonconvert.Click += new System.EventHandler(this.buttonconvert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 296);
            this.Controls.Add(this.buttonconvert);
            this.Controls.Add(this.buttonclear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_lbs);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_kg);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_kg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonexit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_lbs;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttonconvert;
    }
}

