namespace Recapitulare_Paw_Animal
{
    partial class Form2
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
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_denumire = new System.Windows.Forms.TextBox();
            this.dtp_dataNasterii = new System.Windows.Forms.DateTimePicker();
            this.cb_habitat = new System.Windows.Forms.ComboBox();
            this.tb_inaltime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(169, 43);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(200, 22);
            this.tb_id.TabIndex = 0;
            // 
            // tb_denumire
            // 
            this.tb_denumire.Location = new System.Drawing.Point(169, 101);
            this.tb_denumire.Name = "tb_denumire";
            this.tb_denumire.Size = new System.Drawing.Size(200, 22);
            this.tb_denumire.TabIndex = 1;
            // 
            // dtp_dataNasterii
            // 
            this.dtp_dataNasterii.Location = new System.Drawing.Point(169, 164);
            this.dtp_dataNasterii.Name = "dtp_dataNasterii";
            this.dtp_dataNasterii.Size = new System.Drawing.Size(200, 22);
            this.dtp_dataNasterii.TabIndex = 2;
            // 
            // cb_habitat
            // 
            this.cb_habitat.FormattingEnabled = true;
            this.cb_habitat.Items.AddRange(new object[] {
            "Savana",
            "Padure",
            "Jungla",
            "Strada"});
            this.cb_habitat.Location = new System.Drawing.Point(169, 219);
            this.cb_habitat.Name = "cb_habitat";
            this.cb_habitat.Size = new System.Drawing.Size(200, 24);
            this.cb_habitat.TabIndex = 3;
            // 
            // tb_inaltime
            // 
            this.tb_inaltime.Location = new System.Drawing.Point(169, 278);
            this.tb_inaltime.Name = "tb_inaltime";
            this.tb_inaltime.Size = new System.Drawing.Size(200, 22);
            this.tb_inaltime.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Denumire";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Data Nasterii";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Habitat";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Inaltime";
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(38, 354);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(133, 40);
            this.btn_Save.TabIndex = 10;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(236, 354);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(133, 40);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_inaltime);
            this.Controls.Add(this.cb_habitat);
            this.Controls.Add(this.dtp_dataNasterii);
            this.Controls.Add(this.tb_denumire);
            this.Controls.Add(this.tb_id);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_denumire;
        private System.Windows.Forms.DateTimePicker dtp_dataNasterii;
        private System.Windows.Forms.ComboBox cb_habitat;
        private System.Windows.Forms.TextBox tb_inaltime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Cancel;
    }
}