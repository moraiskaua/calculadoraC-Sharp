namespace WinFormsApp2
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblOperacao = new System.Windows.Forms.Label();
            this.btnNumeroNegativo = new System.Windows.Forms.Button();
            this.btnApaga = new System.Windows.Forms.Button();
            this.btnNumeroVirgula = new System.Windows.Forms.Button();
            this.btnNumero0 = new System.Windows.Forms.Button();
            this.btnSubtrai = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnMultiplica = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.btnNumero9 = new System.Windows.Forms.Button();
            this.btnNumero8 = new System.Windows.Forms.Button();
            this.btnNumero7 = new System.Windows.Forms.Button();
            this.btnNumero6 = new System.Windows.Forms.Button();
            this.btnNumero5 = new System.Windows.Forms.Button();
            this.btnNumero4 = new System.Windows.Forms.Button();
            this.btnNumero3 = new System.Windows.Forms.Button();
            this.btnNumero2 = new System.Windows.Forms.Button();
            this.btnNumero1 = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblOperacao);
            this.groupBox1.Controls.Add(this.btnNumeroNegativo);
            this.groupBox1.Controls.Add(this.btnApaga);
            this.groupBox1.Controls.Add(this.btnNumeroVirgula);
            this.groupBox1.Controls.Add(this.btnNumero0);
            this.groupBox1.Controls.Add(this.btnSubtrai);
            this.groupBox1.Controls.Add(this.btnSoma);
            this.groupBox1.Controls.Add(this.btnIgual);
            this.groupBox1.Controls.Add(this.btnMultiplica);
            this.groupBox1.Controls.Add(this.btnDivide);
            this.groupBox1.Controls.Add(this.btnLimpa);
            this.groupBox1.Controls.Add(this.btnNumero9);
            this.groupBox1.Controls.Add(this.btnNumero8);
            this.groupBox1.Controls.Add(this.btnNumero7);
            this.groupBox1.Controls.Add(this.btnNumero6);
            this.groupBox1.Controls.Add(this.btnNumero5);
            this.groupBox1.Controls.Add(this.btnNumero4);
            this.groupBox1.Controls.Add(this.btnNumero3);
            this.groupBox1.Controls.Add(this.btnNumero2);
            this.groupBox1.Controls.Add(this.btnNumero1);
            this.groupBox1.Controls.Add(this.txtResultado);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 476);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculadora";
            // 
            // lblOperacao
            // 
            this.lblOperacao.AutoSize = true;
            this.lblOperacao.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOperacao.Location = new System.Drawing.Point(15, 44);
            this.lblOperacao.Name = "lblOperacao";
            this.lblOperacao.Size = new System.Drawing.Size(22, 21);
            this.lblOperacao.TabIndex = 20;
            this.lblOperacao.Text = "   ";
            // 
            // btnNumeroNegativo
            // 
            this.btnNumeroNegativo.Location = new System.Drawing.Point(6, 397);
            this.btnNumeroNegativo.Name = "btnNumeroNegativo";
            this.btnNumeroNegativo.Size = new System.Drawing.Size(76, 69);
            this.btnNumeroNegativo.TabIndex = 19;
            this.btnNumeroNegativo.Text = "+/-";
            this.btnNumeroNegativo.UseVisualStyleBackColor = true;
            this.btnNumeroNegativo.Click += new System.EventHandler(this.btnNumeroNegativo_Click);
            // 
            // btnApaga
            // 
            this.btnApaga.Image = ((System.Drawing.Image)(resources.GetObject("btnApaga.Image")));
            this.btnApaga.Location = new System.Drawing.Point(251, 97);
            this.btnApaga.Name = "btnApaga";
            this.btnApaga.Size = new System.Drawing.Size(76, 69);
            this.btnApaga.TabIndex = 18;
            this.btnApaga.UseVisualStyleBackColor = true;
            this.btnApaga.Click += new System.EventHandler(this.btnApaga_Click);
            // 
            // btnNumeroVirgula
            // 
            this.btnNumeroVirgula.Location = new System.Drawing.Point(169, 397);
            this.btnNumeroVirgula.Name = "btnNumeroVirgula";
            this.btnNumeroVirgula.Size = new System.Drawing.Size(76, 69);
            this.btnNumeroVirgula.TabIndex = 17;
            this.btnNumeroVirgula.Text = ".";
            this.btnNumeroVirgula.UseVisualStyleBackColor = true;
            this.btnNumeroVirgula.Click += new System.EventHandler(this.btnNumeroVirgula_Click);
            // 
            // btnNumero0
            // 
            this.btnNumero0.Location = new System.Drawing.Point(87, 397);
            this.btnNumero0.Name = "btnNumero0";
            this.btnNumero0.Size = new System.Drawing.Size(76, 69);
            this.btnNumero0.TabIndex = 16;
            this.btnNumero0.Text = "0";
            this.btnNumero0.UseVisualStyleBackColor = true;
            this.btnNumero0.Click += new System.EventHandler(this.btnNumero0_Click);
            // 
            // btnSubtrai
            // 
            this.btnSubtrai.Location = new System.Drawing.Point(251, 172);
            this.btnSubtrai.Name = "btnSubtrai";
            this.btnSubtrai.Size = new System.Drawing.Size(76, 69);
            this.btnSubtrai.TabIndex = 15;
            this.btnSubtrai.Text = "-";
            this.btnSubtrai.UseVisualStyleBackColor = true;
            this.btnSubtrai.Click += new System.EventHandler(this.btnSubtrai_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(251, 247);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(76, 69);
            this.btnSoma.TabIndex = 14;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(251, 322);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(76, 144);
            this.btnIgual.TabIndex = 13;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnMultiplica
            // 
            this.btnMultiplica.Location = new System.Drawing.Point(169, 97);
            this.btnMultiplica.Name = "btnMultiplica";
            this.btnMultiplica.Size = new System.Drawing.Size(76, 69);
            this.btnMultiplica.TabIndex = 12;
            this.btnMultiplica.Text = "x";
            this.btnMultiplica.UseVisualStyleBackColor = true;
            this.btnMultiplica.Click += new System.EventHandler(this.btnMultiplica_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(87, 97);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(76, 69);
            this.btnDivide.TabIndex = 11;
            this.btnDivide.Text = "÷";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(5, 97);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(76, 69);
            this.btnLimpa.TabIndex = 10;
            this.btnLimpa.Text = "C";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // btnNumero9
            // 
            this.btnNumero9.Location = new System.Drawing.Point(169, 172);
            this.btnNumero9.Name = "btnNumero9";
            this.btnNumero9.Size = new System.Drawing.Size(76, 69);
            this.btnNumero9.TabIndex = 9;
            this.btnNumero9.Text = "9";
            this.btnNumero9.UseVisualStyleBackColor = true;
            this.btnNumero9.Click += new System.EventHandler(this.btnNumero9_Click);
            // 
            // btnNumero8
            // 
            this.btnNumero8.Location = new System.Drawing.Point(87, 172);
            this.btnNumero8.Name = "btnNumero8";
            this.btnNumero8.Size = new System.Drawing.Size(76, 69);
            this.btnNumero8.TabIndex = 8;
            this.btnNumero8.Text = "8";
            this.btnNumero8.UseVisualStyleBackColor = true;
            this.btnNumero8.Click += new System.EventHandler(this.btnNumero8_Click);
            // 
            // btnNumero7
            // 
            this.btnNumero7.Location = new System.Drawing.Point(5, 172);
            this.btnNumero7.Name = "btnNumero7";
            this.btnNumero7.Size = new System.Drawing.Size(76, 69);
            this.btnNumero7.TabIndex = 7;
            this.btnNumero7.Text = "7";
            this.btnNumero7.UseVisualStyleBackColor = true;
            this.btnNumero7.Click += new System.EventHandler(this.btnNumero7_Click);
            // 
            // btnNumero6
            // 
            this.btnNumero6.Location = new System.Drawing.Point(169, 247);
            this.btnNumero6.Name = "btnNumero6";
            this.btnNumero6.Size = new System.Drawing.Size(76, 69);
            this.btnNumero6.TabIndex = 6;
            this.btnNumero6.Text = "6";
            this.btnNumero6.UseVisualStyleBackColor = true;
            this.btnNumero6.Click += new System.EventHandler(this.btnNumero6_Click);
            // 
            // btnNumero5
            // 
            this.btnNumero5.Location = new System.Drawing.Point(87, 247);
            this.btnNumero5.Name = "btnNumero5";
            this.btnNumero5.Size = new System.Drawing.Size(76, 69);
            this.btnNumero5.TabIndex = 5;
            this.btnNumero5.Text = "5";
            this.btnNumero5.UseVisualStyleBackColor = true;
            this.btnNumero5.Click += new System.EventHandler(this.btnNumero5_Click);
            // 
            // btnNumero4
            // 
            this.btnNumero4.Location = new System.Drawing.Point(5, 247);
            this.btnNumero4.Name = "btnNumero4";
            this.btnNumero4.Size = new System.Drawing.Size(76, 69);
            this.btnNumero4.TabIndex = 4;
            this.btnNumero4.Text = "4";
            this.btnNumero4.UseVisualStyleBackColor = true;
            this.btnNumero4.Click += new System.EventHandler(this.btnNumero4_Click);
            // 
            // btnNumero3
            // 
            this.btnNumero3.Location = new System.Drawing.Point(169, 322);
            this.btnNumero3.Name = "btnNumero3";
            this.btnNumero3.Size = new System.Drawing.Size(76, 69);
            this.btnNumero3.TabIndex = 3;
            this.btnNumero3.Text = "3";
            this.btnNumero3.UseVisualStyleBackColor = true;
            this.btnNumero3.Click += new System.EventHandler(this.btnNumero3_Click);
            // 
            // btnNumero2
            // 
            this.btnNumero2.Location = new System.Drawing.Point(87, 322);
            this.btnNumero2.Name = "btnNumero2";
            this.btnNumero2.Size = new System.Drawing.Size(76, 69);
            this.btnNumero2.TabIndex = 2;
            this.btnNumero2.Text = "2";
            this.btnNumero2.UseVisualStyleBackColor = true;
            this.btnNumero2.Click += new System.EventHandler(this.btnNumero2_Click);
            // 
            // btnNumero1
            // 
            this.btnNumero1.Location = new System.Drawing.Point(5, 322);
            this.btnNumero1.Name = "btnNumero1";
            this.btnNumero1.Size = new System.Drawing.Size(76, 69);
            this.btnNumero1.TabIndex = 1;
            this.btnNumero1.Text = "1";
            this.btnNumero1.UseVisualStyleBackColor = true;
            this.btnNumero1.Click += new System.EventHandler(this.btnNumero1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(6, 28);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(321, 50);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 500);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculadora";
            this.Text = "Calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnNumeroNegativo;
        private Button btnApaga;
        private Button btnNumeroVirgula;
        private Button btnNumero0;
        private Button btnSubtrai;
        private Button btnSoma;
        private Button btnIgual;
        private Button btnMultiplica;
        private Button btnDivide;
        private Button btnLimpa;
        private Button btnNumero9;
        private Button btnNumero8;
        private Button btnNumero7;
        private Button btnNumero6;
        private Button btnNumero5;
        private Button btnNumero4;
        private Button btnNumero3;
        private Button btnNumero2;
        private Button btnNumero1;
        private TextBox txtResultado;
        private Label lblOperacao;
    }
}