namespace DelegatePump.GUI
{
    partial class MainForm
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBox_ID = new System.Windows.Forms.TextBox();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonOn1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttonOn2 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.buttonAddDelegate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(39, 148);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(135, 35);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add Pump";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pump ID";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(184, 148);
            this.listBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(260, 104);
            this.listBox1.TabIndex = 2;
            // 
            // textBox_ID
            // 
            this.textBox_ID.Location = new System.Drawing.Point(145, 42);
            this.textBox_ID.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox_ID.Name = "textBox_ID";
            this.textBox_ID.Size = new System.Drawing.Size(121, 26);
            this.textBox_ID.TabIndex = 3;
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Electric",
            "Hydrolic",
            "Pneumatic"});
            this.comboBoxType.Location = new System.Drawing.Point(406, 40);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 28);
            this.comboBoxType.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 40);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pump Type";
            // 
            // buttonOn1
            // 
            this.buttonOn1.Location = new System.Drawing.Point(39, 217);
            this.buttonOn1.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOn1.Name = "buttonOn1";
            this.buttonOn1.Size = new System.Drawing.Size(135, 35);
            this.buttonOn1.TabIndex = 6;
            this.buttonOn1.Text = "Switch ON All";
            this.buttonOn1.UseVisualStyleBackColor = true;
            this.buttonOn1.Click += new System.EventHandler(this.buttonOn1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(39, 293);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 113);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(500, 293);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(406, 113);
            this.textBox2.TabIndex = 11;
            // 
            // buttonOn2
            // 
            this.buttonOn2.Location = new System.Drawing.Point(500, 217);
            this.buttonOn2.Margin = new System.Windows.Forms.Padding(5);
            this.buttonOn2.Name = "buttonOn2";
            this.buttonOn2.Size = new System.Drawing.Size(136, 35);
            this.buttonOn2.TabIndex = 10;
            this.buttonOn2.Text = "Switch ON All";
            this.buttonOn2.UseVisualStyleBackColor = true;
            this.buttonOn2.Click += new System.EventHandler(this.buttonOn2_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 20;
            this.listBox2.Location = new System.Drawing.Point(646, 148);
            this.listBox2.Margin = new System.Windows.Forms.Padding(5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(260, 104);
            this.listBox2.TabIndex = 9;
            // 
            // buttonAddDelegate
            // 
            this.buttonAddDelegate.Location = new System.Drawing.Point(500, 148);
            this.buttonAddDelegate.Margin = new System.Windows.Forms.Padding(5);
            this.buttonAddDelegate.Name = "buttonAddDelegate";
            this.buttonAddDelegate.Size = new System.Drawing.Size(136, 35);
            this.buttonAddDelegate.TabIndex = 8;
            this.buttonAddDelegate.Text = "Add Delegate";
            this.buttonAddDelegate.UseVisualStyleBackColor = true;
            this.buttonAddDelegate.Click += new System.EventHandler(this.buttonAddDelegate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "CoreTempMonitor 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(642, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "CoreTempMonitor 2 (Delegates)";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 420);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.buttonOn2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.buttonAddDelegate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonOn1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.textBox_ID);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdd);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBox_ID;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonOn1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttonOn2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button buttonAddDelegate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}