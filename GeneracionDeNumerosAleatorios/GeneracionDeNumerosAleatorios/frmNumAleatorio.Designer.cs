
namespace GeneracionDeNumerosAleatorios
{
    partial class frmNumAleatorio
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
            this.titulo = new System.Windows.Forms.Panel();
            this.titulo1 = new System.Windows.Forms.Label();
            this.ingresoDeNumeros = new System.Windows.Forms.Panel();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblG = new System.Windows.Forms.Label();
            this.lblK = new System.Windows.Forms.Label();
            this.lblM = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblX0 = new System.Windows.Forms.Label();
            this.btnMultiplicativo = new System.Windows.Forms.RadioButton();
            this.btnMixto = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iteracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numAleatorio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnProximo = new FontAwesome.Sharp.IconButton();
            this.titulo.SuspendLayout();
            this.ingresoDeNumeros.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.Controls.Add(this.titulo1);
            this.titulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titulo.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo.Location = new System.Drawing.Point(0, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(743, 56);
            this.titulo.TabIndex = 0;
            // 
            // titulo1
            // 
            this.titulo1.AutoSize = true;
            this.titulo1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.titulo1.Location = new System.Drawing.Point(12, 9);
            this.titulo1.Name = "titulo1";
            this.titulo1.Size = new System.Drawing.Size(489, 40);
            this.titulo1.TabIndex = 0;
            this.titulo1.Text = "Generador de Números Aleatorios";
            this.titulo1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ingresoDeNumeros
            // 
            this.ingresoDeNumeros.Controls.Add(this.textBox6);
            this.ingresoDeNumeros.Controls.Add(this.textBox5);
            this.ingresoDeNumeros.Controls.Add(this.btnGenerar);
            this.ingresoDeNumeros.Controls.Add(this.textBox4);
            this.ingresoDeNumeros.Controls.Add(this.textBox3);
            this.ingresoDeNumeros.Controls.Add(this.textBox2);
            this.ingresoDeNumeros.Controls.Add(this.lblG);
            this.ingresoDeNumeros.Controls.Add(this.lblK);
            this.ingresoDeNumeros.Controls.Add(this.lblM);
            this.ingresoDeNumeros.Controls.Add(this.lblC);
            this.ingresoDeNumeros.Controls.Add(this.lblA);
            this.ingresoDeNumeros.Controls.Add(this.textBox1);
            this.ingresoDeNumeros.Controls.Add(this.lblX0);
            this.ingresoDeNumeros.Controls.Add(this.btnMultiplicativo);
            this.ingresoDeNumeros.Controls.Add(this.btnMixto);
            this.ingresoDeNumeros.Dock = System.Windows.Forms.DockStyle.Top;
            this.ingresoDeNumeros.Location = new System.Drawing.Point(0, 56);
            this.ingresoDeNumeros.Name = "ingresoDeNumeros";
            this.ingresoDeNumeros.Size = new System.Drawing.Size(743, 211);
            this.ingresoDeNumeros.TabIndex = 1;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox6.Location = new System.Drawing.Point(577, 116);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 29);
            this.textBox6.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox5.Location = new System.Drawing.Point(578, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 29);
            this.textBox5.TabIndex = 13;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerar.Location = new System.Drawing.Point(297, 167);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(122, 31);
            this.btnGenerar.TabIndex = 3;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox4.Location = new System.Drawing.Point(319, 116);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 29);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox3.Location = new System.Drawing.Point(319, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 29);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox2.Location = new System.Drawing.Point(94, 116);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 29);
            this.textBox2.TabIndex = 10;
            // 
            // lblG
            // 
            this.lblG.AutoSize = true;
            this.lblG.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblG.Location = new System.Drawing.Point(554, 119);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(22, 21);
            this.lblG.TabIndex = 9;
            this.lblG.Text = "g:";
            // 
            // lblK
            // 
            this.lblK.AutoSize = true;
            this.lblK.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblK.Location = new System.Drawing.Point(555, 71);
            this.lblK.Name = "lblK";
            this.lblK.Size = new System.Drawing.Size(21, 21);
            this.lblK.TabIndex = 8;
            this.lblK.Text = "k:";
            // 
            // lblM
            // 
            this.lblM.AutoSize = true;
            this.lblM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblM.Location = new System.Drawing.Point(292, 119);
            this.lblM.Name = "lblM";
            this.lblM.Size = new System.Drawing.Size(27, 21);
            this.lblM.TabIndex = 7;
            this.lblM.Text = "m:";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblC.Location = new System.Drawing.Point(297, 71);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(20, 21);
            this.lblC.TabIndex = 6;
            this.lblC.Text = "c:";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblA.Location = new System.Drawing.Point(72, 122);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(21, 21);
            this.lblA.TabIndex = 5;
            this.lblA.Text = "a:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox1.Location = new System.Drawing.Point(94, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 4;
            // 
            // lblX0
            // 
            this.lblX0.AutoSize = true;
            this.lblX0.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblX0.Location = new System.Drawing.Point(64, 71);
            this.lblX0.Name = "lblX0";
            this.lblX0.Size = new System.Drawing.Size(31, 21);
            this.lblX0.TabIndex = 2;
            this.lblX0.Text = "Xo:";
            // 
            // btnMultiplicativo
            // 
            this.btnMultiplicativo.AutoSize = true;
            this.btnMultiplicativo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMultiplicativo.Location = new System.Drawing.Point(458, 15);
            this.btnMultiplicativo.Name = "btnMultiplicativo";
            this.btnMultiplicativo.Size = new System.Drawing.Size(122, 25);
            this.btnMultiplicativo.TabIndex = 1;
            this.btnMultiplicativo.TabStop = true;
            this.btnMultiplicativo.Text = "Multiplicativo";
            this.btnMultiplicativo.UseVisualStyleBackColor = true;
            // 
            // btnMixto
            // 
            this.btnMixto.AutoSize = true;
            this.btnMixto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMixto.Location = new System.Drawing.Point(231, 15);
            this.btnMixto.Name = "btnMixto";
            this.btnMixto.Size = new System.Drawing.Size(67, 25);
            this.btnMixto.TabIndex = 0;
            this.btnMixto.TabStop = true;
            this.btnMixto.Text = "Mixto";
            this.btnMixto.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnProximo);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 267);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 342);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iteracion,
            this.numAleatorio});
            this.dataGridView1.Location = new System.Drawing.Point(44, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(468, 295);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Text = "dataGridView1";
            // 
            // iteracion
            // 
            this.iteracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iteracion.HeaderText = "Iteración (i)";
            this.iteracion.Name = "iteracion";
            this.iteracion.ReadOnly = true;
            this.iteracion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // numAleatorio
            // 
            this.numAleatorio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.numAleatorio.HeaderText = "N° Aleatorio (RND)";
            this.numAleatorio.Name = "numAleatorio";
            this.numAleatorio.ReadOnly = true;
            this.numAleatorio.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // btnProximo
            // 
            this.btnProximo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProximo.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnProximo.IconColor = System.Drawing.Color.Black;
            this.btnProximo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProximo.Location = new System.Drawing.Point(554, 140);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(133, 52);
            this.btnProximo.TabIndex = 1;
            this.btnProximo.Text = "Proximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProximo.UseVisualStyleBackColor = true;
            // 
            // frmNumAleatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 610);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ingresoDeNumeros);
            this.Controls.Add(this.titulo);
            this.Name = "frmNumAleatorio";
            this.Text = " Números Aleatorios";
            this.titulo.ResumeLayout(false);
            this.titulo.PerformLayout();
            this.ingresoDeNumeros.ResumeLayout(false);
            this.ingresoDeNumeros.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titulo;
        private System.Windows.Forms.Label titulo1;
        private System.Windows.Forms.Panel ingresoDeNumeros;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblK;
        private System.Windows.Forms.Label lblM;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblX0;
        private System.Windows.Forms.RadioButton btnMultiplicativo;
        private System.Windows.Forms.RadioButton btnMixto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iteracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn numAleatorio;
        private FontAwesome.Sharp.IconButton btnProximo;
    }
}

