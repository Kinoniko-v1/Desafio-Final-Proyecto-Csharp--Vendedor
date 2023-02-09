
namespace Vista
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
            this.checkMao = new System.Windows.Forms.CheckBox();
            this.botonCamisa = new System.Windows.Forms.RadioButton();
            this.precioUnitarioInput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.botonPantalon = new System.Windows.Forms.RadioButton();
            this.checkChupin = new System.Windows.Forms.CheckBox();
            this.checkCorta = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.botonStandard = new System.Windows.Forms.RadioButton();
            this.botonPremium = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cantidadInput = new System.Windows.Forms.TextBox();
            this.stockDisponible = new System.Windows.Forms.TextBox();
            this.resultadoCotizacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.nombreTienda = new System.Windows.Forms.Label();
            this.vendedorInfo = new System.Windows.Forms.Label();
            this.direccionTienda = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkMao
            // 
            this.checkMao.AutoSize = true;
            this.checkMao.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMao.Location = new System.Drawing.Point(217, 56);
            this.checkMao.Name = "checkMao";
            this.checkMao.Size = new System.Drawing.Size(102, 21);
            this.checkMao.TabIndex = 1;
            this.checkMao.Text = "Cuello Mao";
            this.checkMao.UseVisualStyleBackColor = true;
            this.checkMao.CheckedChanged += new System.EventHandler(this.checkMao_CheckedChanged);
            // 
            // botonCamisa
            // 
            this.botonCamisa.AutoSize = true;
            this.botonCamisa.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCamisa.Location = new System.Drawing.Point(51, 22);
            this.botonCamisa.Name = "botonCamisa";
            this.botonCamisa.Size = new System.Drawing.Size(76, 21);
            this.botonCamisa.TabIndex = 3;
            this.botonCamisa.Text = "Camisa";
            this.botonCamisa.UseVisualStyleBackColor = true;
            this.botonCamisa.CheckedChanged += new System.EventHandler(this.botonCamisa_CheckedChanged);
            // 
            // precioUnitarioInput
            // 
            this.precioUnitarioInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.precioUnitarioInput.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioUnitarioInput.Location = new System.Drawing.Point(45, 23);
            this.precioUnitarioInput.Name = "precioUnitarioInput";
            this.precioUnitarioInput.Size = new System.Drawing.Size(57, 24);
            this.precioUnitarioInput.TabIndex = 18;
            this.precioUnitarioInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Snow;
            this.groupBox1.Controls.Add(this.botonCamisa);
            this.groupBox1.Controls.Add(this.botonPantalon);
            this.groupBox1.Controls.Add(this.checkChupin);
            this.groupBox1.Controls.Add(this.checkMao);
            this.groupBox1.Controls.Add(this.checkCorta);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 202);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda:";
            // 
            // botonPantalon
            // 
            this.botonPantalon.AutoSize = true;
            this.botonPantalon.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPantalon.Location = new System.Drawing.Point(51, 102);
            this.botonPantalon.Name = "botonPantalon";
            this.botonPantalon.Size = new System.Drawing.Size(86, 21);
            this.botonPantalon.TabIndex = 11;
            this.botonPantalon.Text = "Pantalón";
            this.botonPantalon.UseVisualStyleBackColor = true;
            this.botonPantalon.CheckedChanged += new System.EventHandler(this.botonPantalon_CheckedChanged);
            // 
            // checkChupin
            // 
            this.checkChupin.AutoSize = true;
            this.checkChupin.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkChupin.Location = new System.Drawing.Point(217, 102);
            this.checkChupin.Name = "checkChupin";
            this.checkChupin.Size = new System.Drawing.Size(76, 21);
            this.checkChupin.TabIndex = 8;
            this.checkChupin.Text = "Chupín";
            this.checkChupin.UseVisualStyleBackColor = false;
            this.checkChupin.CheckedChanged += new System.EventHandler(this.checkChupin_CheckedChanged);
            // 
            // checkCorta
            // 
            this.checkCorta.AutoSize = true;
            this.checkCorta.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkCorta.Location = new System.Drawing.Point(217, 22);
            this.checkCorta.Name = "checkCorta";
            this.checkCorta.Size = new System.Drawing.Size(113, 21);
            this.checkCorta.TabIndex = 7;
            this.checkCorta.Text = "Manga corta";
            this.checkCorta.UseVisualStyleBackColor = true;
            this.checkCorta.CheckedChanged += new System.EventHandler(this.checkCorta_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Snow;
            this.groupBox2.Controls.Add(this.botonStandard);
            this.groupBox2.Controls.Add(this.botonPremium);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(426, 202);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 58);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad";
            // 
            // botonStandard
            // 
            this.botonStandard.AutoSize = true;
            this.botonStandard.Checked = true;
            this.botonStandard.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonStandard.Location = new System.Drawing.Point(25, 22);
            this.botonStandard.Name = "botonStandard";
            this.botonStandard.Size = new System.Drawing.Size(91, 21);
            this.botonStandard.TabIndex = 9;
            this.botonStandard.TabStop = true;
            this.botonStandard.Text = "Standard";
            this.botonStandard.UseVisualStyleBackColor = true;
            this.botonStandard.CheckedChanged += new System.EventHandler(this.botonStandard_CheckedChanged);
            // 
            // botonPremium
            // 
            this.botonPremium.AutoSize = true;
            this.botonPremium.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonPremium.Location = new System.Drawing.Point(180, 22);
            this.botonPremium.Name = "botonPremium";
            this.botonPremium.Size = new System.Drawing.Size(86, 21);
            this.botonPremium.TabIndex = 10;
            this.botonPremium.TabStop = true;
            this.botonPremium.Text = "Premium";
            this.botonPremium.UseVisualStyleBackColor = true;
            this.botonPremium.CheckedChanged += new System.EventHandler(this.botonPremium_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Snow;
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.precioUnitarioInput);
            this.groupBox3.Controls.Add(this.cantidadInput);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(426, 258);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(346, 55);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio unitario y cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "$";
            // 
            // cantidadInput
            // 
            this.cantidadInput.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cantidadInput.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadInput.Location = new System.Drawing.Point(224, 23);
            this.cantidadInput.Name = "cantidadInput";
            this.cantidadInput.Size = new System.Drawing.Size(39, 24);
            this.cantidadInput.TabIndex = 18;
            this.cantidadInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // stockDisponible
            // 
            this.stockDisponible.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stockDisponible.Enabled = false;
            this.stockDisponible.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockDisponible.Location = new System.Drawing.Point(650, 327);
            this.stockDisponible.Name = "stockDisponible";
            this.stockDisponible.Size = new System.Drawing.Size(39, 24);
            this.stockDisponible.TabIndex = 13;
            this.stockDisponible.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // resultadoCotizacion
            // 
            this.resultadoCotizacion.Enabled = false;
            this.resultadoCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoCotizacion.Location = new System.Drawing.Point(439, 38);
            this.resultadoCotizacion.Name = "resultadoCotizacion";
            this.resultadoCotizacion.Size = new System.Drawing.Size(77, 23);
            this.resultadoCotizacion.TabIndex = 15;
            this.resultadoCotizacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(429, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(203, 14);
            this.label4.TabIndex = 19;
            this.label4.Text = "Unidades de stock disponibles:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(411, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "$";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Yellow;
            this.panel1.BackgroundImage = global::Vista.Properties.Resources.icons8_jake_48;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.nombreTienda);
            this.panel1.Controls.Add(this.vendedorInfo);
            this.panel1.Controls.Add(this.direccionTienda);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 161);
            this.panel1.TabIndex = 50;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(198, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(393, 38);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cotización al por Mayor";
            // 
            // nombreTienda
            // 
            this.nombreTienda.AutoSize = true;
            this.nombreTienda.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTienda.ForeColor = System.Drawing.Color.Gray;
            this.nombreTienda.Location = new System.Drawing.Point(48, 80);
            this.nombreTienda.Name = "nombreTienda";
            this.nombreTienda.Size = new System.Drawing.Size(161, 18);
            this.nombreTienda.TabIndex = 28;
            this.nombreTienda.Text = "Nombre de la Tienda";
            // 
            // vendedorInfo
            // 
            this.vendedorInfo.AutoSize = true;
            this.vendedorInfo.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vendedorInfo.ForeColor = System.Drawing.Color.Gray;
            this.vendedorInfo.Location = new System.Drawing.Point(48, 122);
            this.vendedorInfo.Name = "vendedorInfo";
            this.vendedorInfo.Size = new System.Drawing.Size(313, 18);
            this.vendedorInfo.TabIndex = 27;
            this.vendedorInfo.Text = "Nombre y Apellido del Vendedor | Código";
            // 
            // direccionTienda
            // 
            this.direccionTienda.AutoSize = true;
            this.direccionTienda.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTienda.ForeColor = System.Drawing.Color.Gray;
            this.direccionTienda.Location = new System.Drawing.Point(512, 80);
            this.direccionTienda.Name = "direccionTienda";
            this.direccionTienda.Size = new System.Drawing.Size(168, 18);
            this.direccionTienda.TabIndex = 21;
            this.direccionTienda.Text = "Dirección de la Tienda";
            this.direccionTienda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(524, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 30);
            this.button2.TabIndex = 16;
            this.button2.Text = "Historial de Cotizaciones";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Historial_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Image = global::Vista.Properties.Resources.icons8_transacción_material_sharp_16;
            this.button1.Location = new System.Drawing.Point(217, 27);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(89, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cotizar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Cotizar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Snow;
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.resultadoCotizacion);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(12, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(760, 100);
            this.panel2.TabIndex = 51;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.stockDisponible);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkMao;
        private System.Windows.Forms.RadioButton botonCamisa;
        private System.Windows.Forms.TextBox precioUnitarioInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox checkCorta;
        private System.Windows.Forms.CheckBox checkChupin;
        private System.Windows.Forms.RadioButton botonStandard;
        private System.Windows.Forms.RadioButton botonPremium;
        private System.Windows.Forms.RadioButton botonPantalon;
        private System.Windows.Forms.TextBox cantidadInput;
        private System.Windows.Forms.TextBox stockDisponible;
        private System.Windows.Forms.TextBox resultadoCotizacion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label direccionTienda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label vendedorInfo;
        private System.Windows.Forms.Label nombreTienda;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

