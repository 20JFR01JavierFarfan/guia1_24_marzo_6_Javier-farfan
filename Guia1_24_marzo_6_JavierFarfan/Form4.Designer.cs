namespace Guia1_24_marzo_6_JavierFarfan
{
    partial class Form4
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
            button1 = new Button();
            dataGridView1 = new DataGridView();
            vecto1 = new DataGridViewTextBoxColumn();
            vecto2 = new DataGridViewTextBoxColumn();
            sum = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(144, 211);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { vecto1, vecto2, sum });
            dataGridView1.Location = new Point(308, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 150);
            dataGridView1.TabIndex = 1;
            // 
            // vecto1
            // 
            vecto1.HeaderText = "vecto1";
            vecto1.Name = "vecto1";
            // 
            // vecto2
            // 
            vecto2.HeaderText = "vecto2";
            vecto2.Name = "vecto2";
            // 
            // sum
            // 
            sum.HeaderText = "sum";
            sum.Name = "sum";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn vecto1;
        private DataGridViewTextBoxColumn vecto2;
        private DataGridViewTextBoxColumn sum;
    }
}