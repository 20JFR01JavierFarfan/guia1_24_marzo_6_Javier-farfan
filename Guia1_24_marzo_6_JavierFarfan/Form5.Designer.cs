namespace Guia1_24_marzo_6_JavierFarfan
{
    partial class Form5
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
            matriz1 = new DataGridViewTextBoxColumn();
            matriz2 = new DataGridViewTextBoxColumn();
            multiplicacion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(166, 151);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { matriz1, matriz2, multiplicacion });
            dataGridView1.Location = new Point(308, 128);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(342, 150);
            dataGridView1.TabIndex = 2;
            // 
            // matriz1
            // 
            matriz1.HeaderText = "matriz1";
            matriz1.Name = "matriz1";
            // 
            // matriz2
            // 
            matriz2.HeaderText = "matriz2";
            matriz2.Name = "matriz2";
            // 
            // multiplicacion
            // 
            multiplicacion.HeaderText = "multiplicacion";
            multiplicacion.Name = "multiplicacion";
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn matriz1;
        private DataGridViewTextBoxColumn matriz2;
        private DataGridViewTextBoxColumn multiplicacion;
    }
}