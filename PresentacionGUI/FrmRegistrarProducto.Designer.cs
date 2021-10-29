
namespace PresentacionGUI
{
    partial class FrmRegistrarProducto
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
            this.label1 = new System.Windows.Forms.Label();
            this.TxtReferenciaProducto = new System.Windows.Forms.TextBox();
            this.TxtNombreProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbExistProducto = new System.Windows.Forms.ComboBox();
            this.TxtPrecioProducto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CmbEstadoProducto = new System.Windows.Forms.ComboBox();
            this.BtnRegistrar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.TxtCantidad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Referencia del producto";
            // 
            // TxtReferenciaProducto
            // 
            this.TxtReferenciaProducto.Location = new System.Drawing.Point(239, 87);
            this.TxtReferenciaProducto.Name = "TxtReferenciaProducto";
            this.TxtReferenciaProducto.Size = new System.Drawing.Size(157, 27);
            this.TxtReferenciaProducto.TabIndex = 1;
            // 
            // TxtNombreProducto
            // 
            this.TxtNombreProducto.Location = new System.Drawing.Point(239, 135);
            this.TxtNombreProducto.Name = "TxtNombreProducto";
            this.TxtNombreProducto.Size = new System.Drawing.Size(157, 27);
            this.TxtNombreProducto.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del producto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Existencia del producto";
            // 
            // CmbExistProducto
            // 
            this.CmbExistProducto.FormattingEnabled = true;
            this.CmbExistProducto.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.CmbExistProducto.Location = new System.Drawing.Point(239, 185);
            this.CmbExistProducto.Name = "CmbExistProducto";
            this.CmbExistProducto.Size = new System.Drawing.Size(157, 28);
            this.CmbExistProducto.TabIndex = 5;
            // 
            // TxtPrecioProducto
            // 
            this.TxtPrecioProducto.Location = new System.Drawing.Point(239, 234);
            this.TxtPrecioProducto.Name = "TxtPrecioProducto";
            this.TxtPrecioProducto.Size = new System.Drawing.Size(157, 27);
            this.TxtPrecioProducto.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Precio Unitario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 279);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Estado";
            // 
            // CmbEstadoProducto
            // 
            this.CmbEstadoProducto.FormattingEnabled = true;
            this.CmbEstadoProducto.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.CmbEstadoProducto.Location = new System.Drawing.Point(239, 279);
            this.CmbEstadoProducto.Name = "CmbEstadoProducto";
            this.CmbEstadoProducto.Size = new System.Drawing.Size(157, 28);
            this.CmbEstadoProducto.TabIndex = 9;
            // 
            // BtnRegistrar
            // 
            this.BtnRegistrar.Location = new System.Drawing.Point(80, 399);
            this.BtnRegistrar.Name = "BtnRegistrar";
            this.BtnRegistrar.Size = new System.Drawing.Size(156, 49);
            this.BtnRegistrar.TabIndex = 10;
            this.BtnRegistrar.Text = "Registrar";
            this.BtnRegistrar.UseVisualStyleBackColor = true;
            this.BtnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(271, 399);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(156, 49);
            this.BtnCerrar.TabIndex = 11;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Location = new System.Drawing.Point(239, 325);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(157, 27);
            this.TxtCantidad.TabIndex = 13;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged);
            this.TxtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidad_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Cantidad";
            // 
            // FrmRegistrarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 547);
            this.Controls.Add(this.TxtCantidad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnRegistrar);
            this.Controls.Add(this.CmbEstadoProducto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TxtPrecioProducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CmbExistProducto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtReferenciaProducto);
            this.Controls.Add(this.label1);
            this.Name = "FrmRegistrarProducto";
            this.Text = "Registrar Producto";
            this.Load += new System.EventHandler(this.FrmRegistrarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtReferenciaProducto;
        private System.Windows.Forms.TextBox TxtNombreProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbExistProducto;
        private System.Windows.Forms.TextBox TxtPrecioProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CmbEstadoProducto;
        private System.Windows.Forms.Button BtnRegistrar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.TextBox TxtCantidad;
        private System.Windows.Forms.Label label6;
    }
}