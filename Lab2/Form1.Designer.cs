namespace Lab2
{
    partial class FormularioEntrada
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
            this.botonCalcular = new System.Windows.Forms.Button();
            this.txtSalarioBruto = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lbSalarioBruto = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Label();
            this.lbSalidaSeguroSocial = new System.Windows.Forms.Label();
            this.lbSalidaSeguroEducativo = new System.Windows.Forms.Label();
            this.lbSalidaSalarioNeto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botonCalcular
            // 
            this.botonCalcular.BackColor = System.Drawing.Color.LightCoral;
            this.botonCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCalcular.Location = new System.Drawing.Point(531, 474);
            this.botonCalcular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.botonCalcular.Name = "botonCalcular";
            this.botonCalcular.Size = new System.Drawing.Size(224, 57);
            this.botonCalcular.TabIndex = 12;
            this.botonCalcular.Text = "Calcular";
            this.botonCalcular.UseVisualStyleBackColor = false;
            this.botonCalcular.Click += new System.EventHandler(this.botonCalcular_Click);
            // 
            // txtSalarioBruto
            // 
            this.txtSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalarioBruto.Location = new System.Drawing.Point(28, 395);
            this.txtSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSalarioBruto.MaxLength = 11;
            this.txtSalarioBruto.Name = "txtSalarioBruto";
            this.txtSalarioBruto.Size = new System.Drawing.Size(171, 26);
            this.txtSalarioBruto.TabIndex = 10;
            // 
            // txtCedula
            // 
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(28, 273);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.MaxLength = 16;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(239, 26);
            this.txtCedula.TabIndex = 8;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(24, 166);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.MaxLength = 150;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(537, 26);
            this.txtNombre.TabIndex = 6;
            // 
            // lbSalarioBruto
            // 
            this.lbSalarioBruto.AutoSize = true;
            this.lbSalarioBruto.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioBruto.Location = new System.Drawing.Point(24, 370);
            this.lbSalarioBruto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSalarioBruto.Name = "lbSalarioBruto";
            this.lbSalarioBruto.Size = new System.Drawing.Size(394, 23);
            this.lbSalarioBruto.TabIndex = 11;
            this.lbSalarioBruto.Text = "Ingrese su Salario Bruto Mensual";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Location = new System.Drawing.Point(24, 249);
            this.lbCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(334, 23);
            this.lbCedula.TabIndex = 9;
            this.lbCedula.Text = "Ingrese su Número de Cédula";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("OCR A Extended", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(24, 142);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(322, 23);
            this.lbNombre.TabIndex = 7;
            this.lbNombre.Text = "Ingrese su Nombre Completo";
            // 
            // Titulo
            // 
            this.Titulo.AutoSize = true;
            this.Titulo.BackColor = System.Drawing.Color.Gainsboro;
            this.Titulo.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Titulo.Location = new System.Drawing.Point(238, 28);
            this.Titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(323, 35);
            this.Titulo.TabIndex = 0;
            this.Titulo.Text = "Calculo de ISR";
            this.Titulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbSalidaSeguroSocial
            // 
            this.lbSalidaSeguroSocial.AutoSize = true;
            this.lbSalidaSeguroSocial.BackColor = System.Drawing.Color.MistyRose;
            this.lbSalidaSeguroSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalidaSeguroSocial.Location = new System.Drawing.Point(689, 252);
            this.lbSalidaSeguroSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSalidaSeguroSocial.Name = "lbSalidaSeguroSocial";
            this.lbSalidaSeguroSocial.Size = new System.Drawing.Size(0, 20);
            this.lbSalidaSeguroSocial.TabIndex = 39;
            // 
            // lbSalidaSeguroEducativo
            // 
            this.lbSalidaSeguroEducativo.AutoSize = true;
            this.lbSalidaSeguroEducativo.BackColor = System.Drawing.Color.MistyRose;
            this.lbSalidaSeguroEducativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalidaSeguroEducativo.Location = new System.Drawing.Point(657, 252);
            this.lbSalidaSeguroEducativo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSalidaSeguroEducativo.Name = "lbSalidaSeguroEducativo";
            this.lbSalidaSeguroEducativo.Size = new System.Drawing.Size(0, 20);
            this.lbSalidaSeguroEducativo.TabIndex = 40;
            // 
            // lbSalidaSalarioNeto
            // 
            this.lbSalidaSalarioNeto.AutoSize = true;
            this.lbSalidaSalarioNeto.BackColor = System.Drawing.Color.MistyRose;
            this.lbSalidaSalarioNeto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalidaSalarioNeto.Location = new System.Drawing.Point(689, 313);
            this.lbSalidaSalarioNeto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSalidaSalarioNeto.Name = "lbSalidaSalarioNeto";
            this.lbSalidaSalarioNeto.Size = new System.Drawing.Size(0, 20);
            this.lbSalidaSalarioNeto.TabIndex = 41;
            // 
            // FormularioEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(779, 567);
            this.Controls.Add(this.lbSalidaSalarioNeto);
            this.Controls.Add(this.lbSalidaSeguroEducativo);
            this.Controls.Add(this.lbSalidaSeguroSocial);
            this.Controls.Add(this.botonCalcular);
            this.Controls.Add(this.txtSalarioBruto);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbSalarioBruto);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.Titulo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormularioEntrada";
            this.Text = "Ingrese los datos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonCalcular;
        private System.Windows.Forms.TextBox txtSalarioBruto;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lbSalarioBruto;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label Titulo;
        private System.Windows.Forms.Label lbSalidaSeguroSocial;
        private System.Windows.Forms.Label lbSalidaSeguroEducativo;
        private System.Windows.Forms.Label lbSalidaSalarioNeto;
    }
}

