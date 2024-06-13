namespace Recapitulare_Paw_Animal
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
            this.btn_VarstaAnimal = new System.Windows.Forms.Button();
            this.btn_AdaugaAnimal = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.serializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.serializareToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_VarstaAnimal
            // 
            this.btn_VarstaAnimal.Location = new System.Drawing.Point(43, 53);
            this.btn_VarstaAnimal.Name = "btn_VarstaAnimal";
            this.btn_VarstaAnimal.Size = new System.Drawing.Size(147, 47);
            this.btn_VarstaAnimal.TabIndex = 0;
            this.btn_VarstaAnimal.Text = "Varsta Animal";
            this.btn_VarstaAnimal.UseVisualStyleBackColor = true;
            this.btn_VarstaAnimal.Click += new System.EventHandler(this.btn_VarstaAnimal_Click);
            // 
            // btn_AdaugaAnimal
            // 
            this.btn_AdaugaAnimal.Location = new System.Drawing.Point(43, 131);
            this.btn_AdaugaAnimal.Name = "btn_AdaugaAnimal";
            this.btn_AdaugaAnimal.Size = new System.Drawing.Size(147, 44);
            this.btn_AdaugaAnimal.TabIndex = 1;
            this.btn_AdaugaAnimal.Text = "Adauga Animal";
            this.btn_AdaugaAnimal.UseVisualStyleBackColor = true;
            this.btn_AdaugaAnimal.Click += new System.EventHandler(this.btn_AdaugaAnimal_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(278, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(453, 293);
            this.dataGridView1.TabIndex = 2;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializareToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // serializareToolStripMenuItem
            // 
            this.serializareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deserializareToolStripMenuItem,
            this.deserializareToolStripMenuItem1,
            this.serializareToolStripMenuItem1});
            this.serializareToolStripMenuItem.Name = "serializareToolStripMenuItem";
            this.serializareToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.serializareToolStripMenuItem.Text = "Meniu";
            // 
            // deserializareToolStripMenuItem
            // 
            this.deserializareToolStripMenuItem.Name = "deserializareToolStripMenuItem";
            this.deserializareToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializareToolStripMenuItem.Text = "serializare";
            this.deserializareToolStripMenuItem.Click += new System.EventHandler(this.deserializareToolStripMenuItem_Click);
            // 
            // deserializareToolStripMenuItem1
            // 
            this.deserializareToolStripMenuItem1.Name = "deserializareToolStripMenuItem1";
            this.deserializareToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.deserializareToolStripMenuItem1.Text = "deserializare";
            this.deserializareToolStripMenuItem1.Click += new System.EventHandler(this.deserializareToolStripMenuItem1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // serializareToolStripMenuItem1
            // 
            this.serializareToolStripMenuItem1.Name = "serializareToolStripMenuItem1";
            this.serializareToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.serializareToolStripMenuItem1.Text = "serializare";
            this.serializareToolStripMenuItem1.Click += new System.EventHandler(this.serializareToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_AdaugaAnimal);
            this.Controls.Add(this.btn_VarstaAnimal);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_VarstaAnimal;
        private System.Windows.Forms.Button btn_AdaugaAnimal;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializareToolStripMenuItem1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem serializareToolStripMenuItem1;
    }
}

