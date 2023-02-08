
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
            this.button1 = new System.Windows.Forms.Button();
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
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.direccionTienda = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.vendedorInfo = new System.Windows.Forms.Label();
            this.nombreTienda = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(228, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cotizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Cotizar_Click);
            // 
            // checkMao
            // 
            this.checkMao.AutoSize = true;
            this.checkMao.Location = new System.Drawing.Point(87, 56);
            this.checkMao.Name = "checkMao";
            this.checkMao.Size = new System.Drawing.Size(79, 17);
            this.checkMao.TabIndex = 1;
            this.checkMao.Text = "Cuello Mao";
            this.checkMao.UseVisualStyleBackColor = true;
            this.checkMao.CheckedChanged += new System.EventHandler(this.checkMao_CheckedChanged);
            // 
            // botonCamisa
            // 
            this.botonCamisa.AutoSize = true;
            this.botonCamisa.Location = new System.Drawing.Point(6, 22);
            this.botonCamisa.Name = "botonCamisa";
            this.botonCamisa.Size = new System.Drawing.Size(59, 17);
            this.botonCamisa.TabIndex = 3;
            this.botonCamisa.Text = "Camisa";
            this.botonCamisa.UseVisualStyleBackColor = true;
            this.botonCamisa.CheckedChanged += new System.EventHandler(this.botonCamisa_CheckedChanged);
            // 
            // precioUnitarioInput
            // 
            this.precioUnitarioInput.Location = new System.Drawing.Point(25, 23);
            this.precioUnitarioInput.Name = "precioUnitarioInput";
            this.precioUnitarioInput.Size = new System.Drawing.Size(57, 20);
            this.precioUnitarioInput.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.botonCamisa);
            this.groupBox1.Controls.Add(this.botonPantalon);
            this.groupBox1.Controls.Add(this.checkChupin);
            this.groupBox1.Controls.Add(this.checkMao);
            this.groupBox1.Controls.Add(this.checkCorta);
            this.groupBox1.Location = new System.Drawing.Point(103, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Prenda:";
            // 
            // botonPantalon
            // 
            this.botonPantalon.AutoSize = true;
            this.botonPantalon.Location = new System.Drawing.Point(6, 102);
            this.botonPantalon.Name = "botonPantalon";
            this.botonPantalon.Size = new System.Drawing.Size(67, 17);
            this.botonPantalon.TabIndex = 11;
            this.botonPantalon.Text = "Pantalón";
            this.botonPantalon.UseVisualStyleBackColor = true;
            this.botonPantalon.CheckedChanged += new System.EventHandler(this.botonPantalon_CheckedChanged);
            // 
            // checkChupin
            // 
            this.checkChupin.AutoSize = true;
            this.checkChupin.Enabled = false;
            this.checkChupin.Location = new System.Drawing.Point(87, 102);
            this.checkChupin.Name = "checkChupin";
            this.checkChupin.Size = new System.Drawing.Size(61, 17);
            this.checkChupin.TabIndex = 8;
            this.checkChupin.Text = "Chupín";
            this.checkChupin.UseVisualStyleBackColor = true;
            this.checkChupin.CheckedChanged += new System.EventHandler(this.checkChupin_CheckedChanged);
            // 
            // checkCorta
            // 
            this.checkCorta.AutoSize = true;
            this.checkCorta.Location = new System.Drawing.Point(87, 22);
            this.checkCorta.Name = "checkCorta";
            this.checkCorta.Size = new System.Drawing.Size(86, 17);
            this.checkCorta.TabIndex = 7;
            this.checkCorta.Text = "Manga corta";
            this.checkCorta.UseVisualStyleBackColor = true;
            this.checkCorta.CheckedChanged += new System.EventHandler(this.checkCorta_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.botonStandard);
            this.groupBox2.Controls.Add(this.botonPremium);
            this.groupBox2.Location = new System.Drawing.Point(355, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 61);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calidad";
            // 
            // botonStandard
            // 
            this.botonStandard.AutoSize = true;
            this.botonStandard.Checked = true;
            this.botonStandard.Location = new System.Drawing.Point(6, 22);
            this.botonStandard.Name = "botonStandard";
            this.botonStandard.Size = new System.Drawing.Size(68, 17);
            this.botonStandard.TabIndex = 9;
            this.botonStandard.TabStop = true;
            this.botonStandard.Text = "Standard";
            this.botonStandard.UseVisualStyleBackColor = true;
            this.botonStandard.CheckedChanged += new System.EventHandler(this.botonStandard_CheckedChanged);
            // 
            // botonPremium
            // 
            this.botonPremium.AutoSize = true;
            this.botonPremium.Location = new System.Drawing.Point(109, 22);
            this.botonPremium.Name = "botonPremium";
            this.botonPremium.Size = new System.Drawing.Size(65, 17);
            this.botonPremium.TabIndex = 10;
            this.botonPremium.TabStop = true;
            this.botonPremium.Text = "Premium";
            this.botonPremium.UseVisualStyleBackColor = true;
            this.botonPremium.CheckedChanged += new System.EventHandler(this.botonPremium_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.precioUnitarioInput);
            this.groupBox3.Controls.Add(this.cantidadInput);
            this.groupBox3.Location = new System.Drawing.Point(355, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 55);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Precio unitario y cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cant:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "$";
            // 
            // cantidadInput
            // 
            this.cantidadInput.Location = new System.Drawing.Point(143, 23);
            this.cantidadInput.Name = "cantidadInput";
            this.cantidadInput.Size = new System.Drawing.Size(51, 20);
            this.cantidadInput.TabIndex = 18;
            // 
            // stockDisponible
            // 
            this.stockDisponible.Enabled = false;
            this.stockDisponible.Location = new System.Drawing.Point(512, 273);
            this.stockDisponible.Name = "stockDisponible";
            this.stockDisponible.Size = new System.Drawing.Size(43, 20);
            this.stockDisponible.TabIndex = 13;
            // 
            // resultadoCotizacion
            // 
            this.resultadoCotizacion.Location = new System.Drawing.Point(377, 322);
            this.resultadoCotizacion.Name = "resultadoCotizacion";
            this.resultadoCotizacion.Size = new System.Drawing.Size(100, 20);
            this.resultadoCotizacion.TabIndex = 15;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(525, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 18);
            this.button2.TabIndex = 16;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Historial_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(352, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Unidades de stock disponibles:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Historial de Cotizaciones:";
            // 
            // direccionTienda
            // 
            this.direccionTienda.AutoSize = true;
            this.direccionTienda.Location = new System.Drawing.Point(394, 63);
            this.direccionTienda.Name = "direccionTienda";
            this.direccionTienda.Size = new System.Drawing.Size(114, 13);
            this.direccionTienda.TabIndex = 21;
            this.direccionTienda.Text = "Dirección de la Tienda";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(358, 325);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Cotización al por Mayor";
            // 
            // vendedorInfo
            // 
            this.vendedorInfo.AutoSize = true;
            this.vendedorInfo.Location = new System.Drawing.Point(100, 94);
            this.vendedorInfo.Name = "vendedorInfo";
            this.vendedorInfo.Size = new System.Drawing.Size(199, 13);
            this.vendedorInfo.TabIndex = 27;
            this.vendedorInfo.Text = "Nombre y Apellido del Vendedor | Código";
            // 
            // nombreTienda
            // 
            this.nombreTienda.AutoSize = true;
            this.nombreTienda.Location = new System.Drawing.Point(100, 63);
            this.nombreTienda.Name = "nombreTienda";
            this.nombreTienda.Size = new System.Drawing.Size(106, 13);
            this.nombreTienda.TabIndex = 28;
            this.nombreTienda.Text = "Nombre de la Tienda";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.nombreTienda);
            this.Controls.Add(this.vendedorInfo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.direccionTienda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.resultadoCotizacion);
            this.Controls.Add(this.stockDisponible);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label direccionTienda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label vendedorInfo;
        private System.Windows.Forms.Label nombreTienda;
    }
}

