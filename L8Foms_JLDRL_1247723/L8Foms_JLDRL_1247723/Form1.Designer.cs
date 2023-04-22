
namespace L8Foms_JLDRL_1247723
{
    partial class laboratorio_8
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.titulo = new System.Windows.Forms.Label();
            this.seleccion = new System.Windows.Forms.GroupBox();
            this.cmb_seleccion = new System.Windows.Forms.ComboBox();
            this.btn_ejecutar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_sumatoria = new System.Windows.Forms.TabPage();
            this.lbl_datossum = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.tab_tablas = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tab_perfecto = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ressum = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.seleccion.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tab_sumatoria.SuspendLayout();
            this.tab_tablas.SuspendLayout();
            this.tab_perfecto.SuspendLayout();
            this.SuspendLayout();
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo.Location = new System.Drawing.Point(115, 9);
            this.titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(533, 96);
            this.titulo.TabIndex = 0;
            this.titulo.Text = "LABORATORIO 8";
            // 
            // seleccion
            // 
            this.seleccion.Controls.Add(this.cmb_seleccion);
            this.seleccion.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccion.Location = new System.Drawing.Point(71, 118);
            this.seleccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.seleccion.Name = "seleccion";
            this.seleccion.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.seleccion.Size = new System.Drawing.Size(166, 139);
            this.seleccion.TabIndex = 1;
            this.seleccion.TabStop = false;
            this.seleccion.Text = "Seleccionar";
            this.seleccion.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cmb_seleccion
            // 
            this.cmb_seleccion.FormattingEnabled = true;
            this.cmb_seleccion.Items.AddRange(new object[] {
            "SUMATORIA",
            "TABLAS DE MULTIPLICAR",
            "NÚMERO PERFECTO"});
            this.cmb_seleccion.Location = new System.Drawing.Point(4, 56);
            this.cmb_seleccion.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cmb_seleccion.Name = "cmb_seleccion";
            this.cmb_seleccion.Size = new System.Drawing.Size(156, 24);
            this.cmb_seleccion.TabIndex = 2;
            this.cmb_seleccion.SelectedIndexChanged += new System.EventHandler(this.Cmbseleccion_SelectedIndexChanged);
            // 
            // btn_ejecutar
            // 
            this.btn_ejecutar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_ejecutar.Font = new System.Drawing.Font("Bahnschrift", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ejecutar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_ejecutar.Location = new System.Drawing.Point(120, 281);
            this.btn_ejecutar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_ejecutar.Name = "btn_ejecutar";
            this.btn_ejecutar.Size = new System.Drawing.Size(94, 28);
            this.btn_ejecutar.TabIndex = 3;
            this.btn_ejecutar.Text = "Ejecutar";
            this.btn_ejecutar.UseVisualStyleBackColor = false;
            this.btn_ejecutar.Click += new System.EventHandler(this.Btn_ejecutar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_sumatoria);
            this.tabControl1.Controls.Add(this.tab_tablas);
            this.tabControl1.Controls.Add(this.tab_perfecto);
            this.tabControl1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(300, 118);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(376, 191);
            this.tabControl1.TabIndex = 4;
            // 
            // tab_sumatoria
            // 
            this.tab_sumatoria.Controls.Add(this.lbl_ressum);
            this.tab_sumatoria.Controls.Add(this.lbl_datossum);
            this.tab_sumatoria.Controls.Add(this.txt_numero);
            this.tab_sumatoria.Controls.Add(this.lbl_resultado);
            this.tab_sumatoria.Location = new System.Drawing.Point(4, 25);
            this.tab_sumatoria.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tab_sumatoria.Name = "tab_sumatoria";
            this.tab_sumatoria.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tab_sumatoria.Size = new System.Drawing.Size(368, 162);
            this.tab_sumatoria.TabIndex = 0;
            this.tab_sumatoria.Text = "SUMATORIA";
            this.tab_sumatoria.UseVisualStyleBackColor = true;
            this.tab_sumatoria.Click += new System.EventHandler(this.tab_sumatoria_Click);
            // 
            // lbl_datossum
            // 
            this.lbl_datossum.AutoSize = true;
            this.lbl_datossum.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datossum.Location = new System.Drawing.Point(16, 34);
            this.lbl_datossum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_datossum.Name = "lbl_datossum";
            this.lbl_datossum.Size = new System.Drawing.Size(95, 17);
            this.lbl_datossum.TabIndex = 2;
            this.lbl_datossum.Text = "Ingrese un dato:";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(112, 32);
            this.txt_numero.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(182, 23);
            this.txt_numero.TabIndex = 1;
            this.txt_numero.TextChanged += new System.EventHandler(this.txt_numero_TextChanged);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resultado.Location = new System.Drawing.Point(16, 81);
            this.lbl_resultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(66, 17);
            this.lbl_resultado.TabIndex = 0;
            this.lbl_resultado.Text = "Resultado:";
            // 
            // tab_tablas
            // 
            this.tab_tablas.Controls.Add(this.label1);
            this.tab_tablas.Controls.Add(this.textBox1);
            this.tab_tablas.Location = new System.Drawing.Point(4, 25);
            this.tab_tablas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tab_tablas.Name = "tab_tablas";
            this.tab_tablas.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tab_tablas.Size = new System.Drawing.Size(368, 162);
            this.tab_tablas.TabIndex = 1;
            this.tab_tablas.Text = "TABLAS DE MULTIPLICAR";
            this.tab_tablas.UseVisualStyleBackColor = true;
            this.tab_tablas.Click += new System.EventHandler(this.tab_tablas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese un dato:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(106, 31);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 23);
            this.textBox1.TabIndex = 4;
            // 
            // tab_perfecto
            // 
            this.tab_perfecto.Controls.Add(this.label2);
            this.tab_perfecto.Controls.Add(this.label3);
            this.tab_perfecto.Controls.Add(this.textBox2);
            this.tab_perfecto.Controls.Add(this.label4);
            this.tab_perfecto.Location = new System.Drawing.Point(4, 25);
            this.tab_perfecto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tab_perfecto.Name = "tab_perfecto";
            this.tab_perfecto.Size = new System.Drawing.Size(368, 162);
            this.tab_perfecto.TabIndex = 2;
            this.tab_perfecto.Text = "NÚMERO PERFECTO";
            this.tab_perfecto.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese un dato:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(106, 48);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(182, 23);
            this.textBox2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 97);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Resultado:";
            // 
            // lbl_ressum
            // 
            this.lbl_ressum.AutoSize = true;
            this.lbl_ressum.Location = new System.Drawing.Point(112, 81);
            this.lbl_ressum.Name = "lbl_ressum";
            this.lbl_ressum.Size = new System.Drawing.Size(0, 17);
            this.lbl_ressum.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 17);
            this.label2.TabIndex = 6;
            // 
            // laboratorio_8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_ejecutar);
            this.Controls.Add(this.seleccion);
            this.Controls.Add(this.titulo);
            this.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "laboratorio_8";
            this.Text = "Laboratorio 8";
            this.Load += new System.EventHandler(this.laboratorio_8_Load);
            this.seleccion.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tab_sumatoria.ResumeLayout(false);
            this.tab_sumatoria.PerformLayout();
            this.tab_tablas.ResumeLayout(false);
            this.tab_tablas.PerformLayout();
            this.tab_perfecto.ResumeLayout(false);
            this.tab_perfecto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.GroupBox seleccion;
        private System.Windows.Forms.ComboBox cmb_seleccion;
        private System.Windows.Forms.Button btn_ejecutar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_sumatoria;
        private System.Windows.Forms.TabPage tab_tablas;
        private System.Windows.Forms.TabPage tab_perfecto;
        private System.Windows.Forms.Label lbl_datossum;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ressum;
        private System.Windows.Forms.Label label2;
    }
}

