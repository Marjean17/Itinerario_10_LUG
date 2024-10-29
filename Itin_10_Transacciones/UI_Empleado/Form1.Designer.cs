namespace UI_Empleado
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
            components = new System.ComponentModel.Container();
            btnAdd = new Button();
            btnModd = new Button();
            btnShow = new Button();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            contextMenuStrip3 = new ContextMenuStrip(components);
            contextMenuStrip4 = new ContextMenuStrip(components);
            dedToolStripMenuItem = new ToolStripMenuItem();
            deToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip4.SuspendLayout();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(88, 353);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(178, 34);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnModd
            // 
            btnModd.Location = new Point(88, 414);
            btnModd.Name = "btnModd";
            btnModd.Size = new Size(178, 34);
            btnModd.TabIndex = 1;
            btnModd.Text = "Confirmar Cambios";
            btnModd.UseVisualStyleBackColor = true;
            btnModd.Click += btnModd_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(627, 488);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(183, 34);
            btnShow.TabIndex = 2;
            btnShow.Text = "Listar";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(344, 45);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(491, 423);
            dataGridView1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            contextMenuStrip3.ImageScalingSize = new Size(24, 24);
            contextMenuStrip3.Name = "contextMenuStrip3";
            contextMenuStrip3.Size = new Size(61, 4);
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.ImageScalingSize = new Size(24, 24);
            contextMenuStrip4.Items.AddRange(new ToolStripItem[] { dedToolStripMenuItem, deToolStripMenuItem });
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(116, 68);
            // 
            // dedToolStripMenuItem
            // 
            dedToolStripMenuItem.Name = "dedToolStripMenuItem";
            dedToolStripMenuItem.Size = new Size(115, 32);
            dedToolStripMenuItem.Text = "ded";
            // 
            // deToolStripMenuItem
            // 
            deToolStripMenuItem.Name = "deToolStripMenuItem";
            deToolStripMenuItem.Size = new Size(115, 32);
            deToolStripMenuItem.Text = "de";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(247, 31);
            textBox1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 57);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 9;
            label1.Text = "DNI";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 142);
            label2.Name = "label2";
            label2.Size = new Size(171, 25);
            label2.TabIndex = 11;
            label2.Text = "Apellido y Nombres";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(45, 170);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(247, 31);
            textBox2.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(45, 232);
            label3.Name = "label3";
            label3.Size = new Size(115, 25);
            label3.TabIndex = 13;
            label3.Text = "Sueldo Bruto";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(45, 260);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(247, 31);
            textBox3.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(886, 562);
            Controls.Add(label3);
            Controls.Add(textBox3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(dataGridView1);
            Controls.Add(btnShow);
            Controls.Add(btnModd);
            Controls.Add(btnAdd);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAdd;
        private Button btnModd;
        private Button btnShow;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ContextMenuStrip contextMenuStrip3;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem dedToolStripMenuItem;
        private ToolStripMenuItem deToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
    }
}
