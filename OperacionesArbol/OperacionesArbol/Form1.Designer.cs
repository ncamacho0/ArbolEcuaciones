namespace OperacionesArbol
{
    partial class Operaciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.txtOperacion = new System.Windows.Forms.TextBox();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.txtPreOrden = new System.Windows.Forms.TextBox();
            this.btnPostOrden = new System.Windows.Forms.Button();
            this.txtPostOrden = new System.Windows.Forms.TextBox();
            this.txtPostOrdenResultado = new System.Windows.Forms.TextBox();
            this.txtPreOrdenResultado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introducir Operación";
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(3, 45);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(75, 23);
            this.btnProcesar.TabIndex = 1;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // txtOperacion
            // 
            this.txtOperacion.Location = new System.Drawing.Point(84, 48);
            this.txtOperacion.Name = "txtOperacion";
            this.txtOperacion.Size = new System.Drawing.Size(174, 20);
            this.txtOperacion.TabIndex = 2;
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(3, 95);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(75, 23);
            this.btnPreOrden.TabIndex = 3;
            this.btnPreOrden.Text = "PreOrden";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // txtPreOrden
            // 
            this.txtPreOrden.Location = new System.Drawing.Point(84, 74);
            this.txtPreOrden.Multiline = true;
            this.txtPreOrden.Name = "txtPreOrden";
            this.txtPreOrden.Size = new System.Drawing.Size(174, 44);
            this.txtPreOrden.TabIndex = 5;
            // 
            // btnPostOrden
            // 
            this.btnPostOrden.Location = new System.Drawing.Point(3, 182);
            this.btnPostOrden.Name = "btnPostOrden";
            this.btnPostOrden.Size = new System.Drawing.Size(75, 23);
            this.btnPostOrden.TabIndex = 6;
            this.btnPostOrden.Text = "PostOrden";
            this.btnPostOrden.UseVisualStyleBackColor = true;
            this.btnPostOrden.Click += new System.EventHandler(this.btnPostOrden_Click);
            // 
            // txtPostOrden
            // 
            this.txtPostOrden.Location = new System.Drawing.Point(84, 159);
            this.txtPostOrden.Multiline = true;
            this.txtPostOrden.Name = "txtPostOrden";
            this.txtPostOrden.Size = new System.Drawing.Size(174, 46);
            this.txtPostOrden.TabIndex = 7;
            // 
            // txtPostOrdenResultado
            // 
            this.txtPostOrdenResultado.Location = new System.Drawing.Point(84, 211);
            this.txtPostOrdenResultado.Name = "txtPostOrdenResultado";
            this.txtPostOrdenResultado.Size = new System.Drawing.Size(100, 20);
            this.txtPostOrdenResultado.TabIndex = 9;
            // 
            // txtPreOrdenResultado
            // 
            this.txtPreOrdenResultado.Location = new System.Drawing.Point(84, 124);
            this.txtPreOrdenResultado.Name = "txtPreOrdenResultado";
            this.txtPreOrdenResultado.Size = new System.Drawing.Size(100, 20);
            this.txtPreOrdenResultado.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Respuesta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Respuesta";
            // 
            // Operaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 269);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPreOrdenResultado);
            this.Controls.Add(this.txtPostOrdenResultado);
            this.Controls.Add(this.txtPostOrden);
            this.Controls.Add(this.btnPostOrden);
            this.Controls.Add(this.txtPreOrden);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.txtOperacion);
            this.Controls.Add(this.btnProcesar);
            this.Controls.Add(this.label1);
            this.Name = "Operaciones";
            this.Text = "Operaciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.TextBox txtOperacion;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.TextBox txtPreOrden;
        private System.Windows.Forms.Button btnPostOrden;
        private System.Windows.Forms.TextBox txtPostOrden;
        private System.Windows.Forms.TextBox txtPostOrdenResultado;
        private System.Windows.Forms.TextBox txtPreOrdenResultado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

