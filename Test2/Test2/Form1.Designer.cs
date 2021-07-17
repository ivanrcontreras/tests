
namespace Test2
{
    partial class Form1
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
            this.rtbxtexto_ingresado = new System.Windows.Forms.RichTextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // rtbxtexto_ingresado
            // 
            this.rtbxtexto_ingresado.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbxtexto_ingresado.Location = new System.Drawing.Point(12, 50);
            this.rtbxtexto_ingresado.Name = "rtbxtexto_ingresado";
            this.rtbxtexto_ingresado.Size = new System.Drawing.Size(525, 241);
            this.rtbxtexto_ingresado.TabIndex = 0;
            this.rtbxtexto_ingresado.Text = "Ingrese su texto aquí";
            this.rtbxtexto_ingresado.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnguardar
            // 
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnguardar.Image = global::Test2.Properties.Resources.save;
            this.btnguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnguardar.Location = new System.Drawing.Point(181, 326);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(150, 47);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar Texto";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.rtbxtexto_ingresado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbxtexto_ingresado;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

