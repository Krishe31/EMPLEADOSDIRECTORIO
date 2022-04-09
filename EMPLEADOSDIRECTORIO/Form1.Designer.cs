namespace EMPLEADOSDIRECTORIO
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
            this.components = new System.ComponentModel.Container();
            this.label0 = new System.Windows.Forms.Label();
            this.LBLDNI = new System.Windows.Forms.Label();
            this.LBLNOMBRES = new System.Windows.Forms.Label();
            this.LBLAPELLIDOS = new System.Windows.Forms.Label();
            this.LBLFECHA = new System.Windows.Forms.Label();
            this.TXTFECHA = new System.Windows.Forms.DateTimePicker();
            this.TXTNOMBRES = new System.Windows.Forms.TextBox();
            this.TXTDNI = new System.Windows.Forms.TextBox();
            this.TXTAPELLIDOS = new System.Windows.Forms.TextBox();
            this.BTNGUARDAR = new System.Windows.Forms.Button();
            this.DTGLISTAR = new System.Windows.Forms.DataGridView();
            this.LBLHORA = new System.Windows.Forms.Label();
            this.LBLHORITA = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLISTAR)).BeginInit();
            this.SuspendLayout();
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(337, 23);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(146, 15);
            this.label0.TabIndex = 0;
            this.label0.Text = "REGISTRO DE EMPLEADOS";
            this.label0.Click += new System.EventHandler(this.label1_Click);
            // 
            // LBLDNI
            // 
            this.LBLDNI.AutoSize = true;
            this.LBLDNI.Location = new System.Drawing.Point(25, 72);
            this.LBLDNI.Name = "LBLDNI";
            this.LBLDNI.Size = new System.Drawing.Size(30, 15);
            this.LBLDNI.TabIndex = 1;
            this.LBLDNI.Text = "DNI:";
            this.LBLDNI.Click += new System.EventHandler(this.LBLDNI_Click);
            // 
            // LBLNOMBRES
            // 
            this.LBLNOMBRES.AutoSize = true;
            this.LBLNOMBRES.Location = new System.Drawing.Point(25, 106);
            this.LBLNOMBRES.Name = "LBLNOMBRES";
            this.LBLNOMBRES.Size = new System.Drawing.Size(65, 15);
            this.LBLNOMBRES.TabIndex = 2;
            this.LBLNOMBRES.Text = "NOMBRES:";
            // 
            // LBLAPELLIDOS
            // 
            this.LBLAPELLIDOS.AutoSize = true;
            this.LBLAPELLIDOS.Location = new System.Drawing.Point(25, 141);
            this.LBLAPELLIDOS.Name = "LBLAPELLIDOS";
            this.LBLAPELLIDOS.Size = new System.Drawing.Size(69, 15);
            this.LBLAPELLIDOS.TabIndex = 3;
            this.LBLAPELLIDOS.Text = "APELLIDOS:";
            // 
            // LBLFECHA
            // 
            this.LBLFECHA.AutoSize = true;
            this.LBLFECHA.Location = new System.Drawing.Point(25, 172);
            this.LBLFECHA.Name = "LBLFECHA";
            this.LBLFECHA.Size = new System.Drawing.Size(47, 15);
            this.LBLFECHA.TabIndex = 4;
            this.LBLFECHA.Text = "FECHA:";
            this.LBLFECHA.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TXTFECHA
            // 
            this.TXTFECHA.Location = new System.Drawing.Point(99, 166);
            this.TXTFECHA.Name = "TXTFECHA";
            this.TXTFECHA.Size = new System.Drawing.Size(201, 23);
            this.TXTFECHA.TabIndex = 5;
            // 
            // TXTNOMBRES
            // 
            this.TXTNOMBRES.Location = new System.Drawing.Point(99, 103);
            this.TXTNOMBRES.Name = "TXTNOMBRES";
            this.TXTNOMBRES.Size = new System.Drawing.Size(201, 23);
            this.TXTNOMBRES.TabIndex = 6;
            // 
            // TXTDNI
            // 
            this.TXTDNI.Location = new System.Drawing.Point(99, 69);
            this.TXTDNI.Name = "TXTDNI";
            this.TXTDNI.Size = new System.Drawing.Size(201, 23);
            this.TXTDNI.TabIndex = 7;
            // 
            // TXTAPELLIDOS
            // 
            this.TXTAPELLIDOS.Location = new System.Drawing.Point(99, 133);
            this.TXTAPELLIDOS.Name = "TXTAPELLIDOS";
            this.TXTAPELLIDOS.Size = new System.Drawing.Size(201, 23);
            this.TXTAPELLIDOS.TabIndex = 8;
            // 
            // BTNGUARDAR
            // 
            this.BTNGUARDAR.Location = new System.Drawing.Point(496, 198);
            this.BTNGUARDAR.Name = "BTNGUARDAR";
            this.BTNGUARDAR.Size = new System.Drawing.Size(75, 23);
            this.BTNGUARDAR.TabIndex = 9;
            this.BTNGUARDAR.Text = "GUARDAR";
            this.BTNGUARDAR.UseVisualStyleBackColor = true;
            this.BTNGUARDAR.Click += new System.EventHandler(this.BTNGUARDAR_Click);
            // 
            // DTGLISTAR
            // 
            this.DTGLISTAR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTGLISTAR.Location = new System.Drawing.Point(319, 69);
            this.DTGLISTAR.Name = "DTGLISTAR";
            this.DTGLISTAR.RowTemplate.Height = 25;
            this.DTGLISTAR.Size = new System.Drawing.Size(406, 120);
            this.DTGLISTAR.TabIndex = 12;
            this.DTGLISTAR.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DTGLISTAR_CellContentClick);
            // 
            // LBLHORA
            // 
            this.LBLHORA.AutoSize = true;
            this.LBLHORA.Location = new System.Drawing.Point(25, 202);
            this.LBLHORA.Name = "LBLHORA";
            this.LBLHORA.Size = new System.Drawing.Size(43, 15);
            this.LBLHORA.TabIndex = 13;
            this.LBLHORA.Text = "HORA:";
            this.LBLHORA.Click += new System.EventHandler(this.LBLHORA_Click);
            // 
            // LBLHORITA
            // 
            this.LBLHORITA.AutoSize = true;
            this.LBLHORITA.Location = new System.Drawing.Point(170, 202);
            this.LBLHORITA.Name = "LBLHORITA";
            this.LBLHORITA.Size = new System.Drawing.Size(40, 15);
            this.LBLHORITA.TabIndex = 14;
            this.LBLHORITA.Text = "TIMER";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 234);
            this.Controls.Add(this.LBLHORITA);
            this.Controls.Add(this.LBLHORA);
            this.Controls.Add(this.DTGLISTAR);
            this.Controls.Add(this.BTNGUARDAR);
            this.Controls.Add(this.TXTAPELLIDOS);
            this.Controls.Add(this.TXTDNI);
            this.Controls.Add(this.TXTNOMBRES);
            this.Controls.Add(this.TXTFECHA);
            this.Controls.Add(this.LBLFECHA);
            this.Controls.Add(this.LBLAPELLIDOS);
            this.Controls.Add(this.LBLNOMBRES);
            this.Controls.Add(this.LBLDNI);
            this.Controls.Add(this.label0);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DTGLISTAR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label0;
        private Label LBLDNI;
        private Label LBLNOMBRES;
        private Label LBLAPELLIDOS;
        private Label LBLFECHA;
        private DateTimePicker TXTFECHA;
        private TextBox TXTNOMBRES;
        private TextBox TXTDNI;
        private TextBox TXTAPELLIDOS;
        private Button BTNGUARDAR;
        private DataGridView DTGLISTAR;
        private Label LBLHORA;
        private Label LBLHORITA;
        private System.Windows.Forms.Timer timer1;
    }
}