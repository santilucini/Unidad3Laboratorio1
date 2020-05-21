namespace U3L1
{
    partial class formLogin
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
            this.lb_Nombre = new System.Windows.Forms.Label();
            this.lb_Contr = new System.Windows.Forms.Label();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Contr = new System.Windows.Forms.TextBox();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.lblk_OlvideContr = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lb_Nombre
            // 
            this.lb_Nombre.AutoSize = true;
            this.lb_Nombre.Location = new System.Drawing.Point(181, 147);
            this.lb_Nombre.Name = "lb_Nombre";
            this.lb_Nombre.Size = new System.Drawing.Size(135, 17);
            this.lb_Nombre.TabIndex = 0;
            this.lb_Nombre.Text = "Nombre de Usuario:";
            // 
            // lb_Contr
            // 
            this.lb_Contr.AutoSize = true;
            this.lb_Contr.Location = new System.Drawing.Point(181, 192);
            this.lb_Contr.Name = "lb_Contr";
            this.lb_Contr.Size = new System.Drawing.Size(85, 17);
            this.lb_Contr.TabIndex = 1;
            this.lb_Contr.Text = "Contraseña:";
            this.lb_Contr.Click += new System.EventHandler(this.lb_Contr_Click);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(330, 141);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(100, 22);
            this.txt_Nombre.TabIndex = 2;
            // 
            // txt_Contr
            // 
            this.txt_Contr.Location = new System.Drawing.Point(330, 189);
            this.txt_Contr.Name = "txt_Contr";
            this.txt_Contr.Size = new System.Drawing.Size(100, 22);
            this.txt_Contr.TabIndex = 3;
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.Location = new System.Drawing.Point(218, 91);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(182, 34);
            this.lb_Titulo.TabIndex = 4;
            this.lb_Titulo.Text = "   ¡Bienvenido al Sistema! \r\nPor favor ingrese sus datos";
            this.lb_Titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(330, 242);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 5;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // lblk_OlvideContr
            // 
            this.lblk_OlvideContr.AutoSize = true;
            this.lblk_OlvideContr.Location = new System.Drawing.Point(13, 421);
            this.lblk_OlvideContr.Name = "lblk_OlvideContr";
            this.lblk_OlvideContr.Size = new System.Drawing.Size(143, 17);
            this.lblk_OlvideContr.TabIndex = 6;
            this.lblk_OlvideContr.TabStop = true;
            this.lblk_OlvideContr.Text = "Olvide mi Contraseña";
            this.lblk_OlvideContr.Click += new System.EventHandler(this.lblk_OlvideContr_Click);
            // 
            // fromLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblk_OlvideContr);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.txt_Contr);
            this.Controls.Add(this.txt_Nombre);
            this.Controls.Add(this.lb_Contr);
            this.Controls.Add(this.lb_Nombre);
            this.Name = "fromLogin";
            this.Text = "Ingreso";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_Nombre;
        private System.Windows.Forms.Label lb_Contr;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Contr;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.LinkLabel lblk_OlvideContr;
    }
}

