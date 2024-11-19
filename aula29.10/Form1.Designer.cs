namespace aula29._10
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
            panel1 = new Panel();
            lbl2end = new Label();
            lbl1nm = new Label();
            bt1save = new Button();
            txtendereco2 = new TextBox();
            txtbnome = new TextBox();
            dgNomes = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgNomes).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(dgNomes);
            panel1.Controls.Add(lbl2end);
            panel1.Controls.Add(lbl1nm);
            panel1.Controls.Add(bt1save);
            panel1.Controls.Add(txtendereco2);
            panel1.Controls.Add(txtbnome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 426);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // lbl2end
            // 
            lbl2end.AutoSize = true;
            lbl2end.Location = new Point(14, 70);
            lbl2end.Name = "lbl2end";
            lbl2end.Size = new Size(74, 20);
            lbl2end.TabIndex = 4;
            lbl2end.Text = "Endereço:";
            lbl2end.Click += lbl2end_Click;
            // 
            // lbl1nm
            // 
            lbl1nm.AutoSize = true;
            lbl1nm.Location = new Point(17, 19);
            lbl1nm.Name = "lbl1nm";
            lbl1nm.Size = new Size(53, 20);
            lbl1nm.TabIndex = 3;
            lbl1nm.Text = "Nome:";
            lbl1nm.Click += lbl1nm_Click;
            // 
            // bt1save
            // 
            bt1save.Location = new Point(549, 122);
            bt1save.Name = "bt1save";
            bt1save.Size = new Size(94, 29);
            bt1save.TabIndex = 2;
            bt1save.Text = "Salvar";
            bt1save.UseVisualStyleBackColor = true;
            bt1save.Click += button1_Click;
            // 
            // txtendereco2
            // 
            txtendereco2.Location = new Point(94, 67);
            txtendereco2.Name = "txtendereco2";
            txtendereco2.Size = new Size(549, 27);
            txtendereco2.TabIndex = 1;
            txtendereco2.TextChanged += txtendereco2_TextChanged;
            // 
            // txtbnome
            // 
            txtbnome.Location = new Point(94, 12);
            txtbnome.Name = "txtbnome";
            txtbnome.Size = new Size(549, 27);
            txtbnome.TabIndex = 0;
            // 
            // dgNomes
            // 
            dgNomes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgNomes.Location = new Point(45, 187);
            dgNomes.Name = "dgNomes";
            dgNomes.RowHeadersWidth = 51;
            dgNomes.Size = new Size(677, 236);
            dgNomes.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgNomes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button bt1save;
        private TextBox txtendereco2;
        private TextBox txtbnome;
        private Label lbl1nm;
        private Label lbl2end;
        private DataGridView dgNomes;
    }
}
