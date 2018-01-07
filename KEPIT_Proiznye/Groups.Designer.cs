namespace KEPIT_Proiznye
{
    partial class Groups
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Groups));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.add = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.new_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(237, 224);
            this.listBox1.TabIndex = 0;
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.LightSteelBlue;
            this.add.FlatAppearance.BorderSize = 0;
            this.add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGreen;
            this.add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.add.Location = new System.Drawing.Point(258, 38);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(162, 23);
            this.add.TabIndex = 1;
            this.add.Text = "Додати";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.LightSteelBlue;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.delete.Location = new System.Drawing.Point(258, 67);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(162, 23);
            this.delete.TabIndex = 2;
            this.delete.Text = "Видалити";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(255, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 144);
            this.label1.TabIndex = 3;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // new_name
            // 
            this.new_name.BackColor = System.Drawing.Color.Lavender;
            this.new_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.new_name.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Bold);
            this.new_name.ForeColor = System.Drawing.Color.Black;
            this.new_name.Location = new System.Drawing.Point(258, 19);
            this.new_name.MaxLength = 12;
            this.new_name.Name = "new_name";
            this.new_name.Size = new System.Drawing.Size(162, 13);
            this.new_name.TabIndex = 4;
            this.new_name.Tag = "start";
            // 
            // Groups
            // 
            this.AcceptButton = this.add;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(432, 261);
            this.Controls.Add(this.new_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(448, 299);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(448, 299);
            this.Name = "Groups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагування списку груп";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox new_name;
    }
}