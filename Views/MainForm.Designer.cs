namespace PlantillaMaterialForm
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.materialListView1 = new MaterialSkin.Controls.MaterialListView();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Edad = new System.Windows.Forms.ColumnHeader();
            this.FechaRegistro = new System.Windows.Forms.ColumnHeader();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.combobox_color_esquema = new MaterialSkin.Controls.MaterialComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.switch_modo_oscuro = new MaterialSkin.Controls.MaterialSwitch();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.materialCard2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ImageList = this.imageList1;
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(794, 383);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.materialCard1);
            this.tabPage1.ImageKey = "house_FILL0_wght400_GRAD0_opsz48.png";
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(786, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Inicio";
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 17);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(200, 100);
            this.materialCard1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.materialListView1);
            this.tabPage2.ImageKey = "emoji_people_FILL0_wght400_GRAD0_opsz48.png";
            this.tabPage2.Location = new System.Drawing.Point(4, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(786, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacientes";
            // 
            // materialListView1
            // 
            this.materialListView1.AutoSizeTable = false;
            this.materialListView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialListView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Edad,
            this.FechaRegistro});
            this.materialListView1.Depth = 0;
            this.materialListView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialListView1.FullRowSelect = true;
            this.materialListView1.Location = new System.Drawing.Point(3, 3);
            this.materialListView1.MinimumSize = new System.Drawing.Size(200, 100);
            this.materialListView1.MouseLocation = new System.Drawing.Point(-1, -1);
            this.materialListView1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialListView1.Name = "materialListView1";
            this.materialListView1.OwnerDraw = true;
            this.materialListView1.Size = new System.Drawing.Size(780, 334);
            this.materialListView1.TabIndex = 0;
            this.materialListView1.UseCompatibleStateImageBehavior = false;
            this.materialListView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre Completo";
            this.Nombre.Width = 200;
            // 
            // Edad
            // 
            this.Edad.Text = "Edad";
            this.Edad.Width = 100;
            // 
            // FechaRegistro
            // 
            this.FechaRegistro.Text = "Fecha de registro";
            this.FechaRegistro.Width = 200;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.materialCard2);
            this.tabPage3.ImageKey = "settings_FILL0_wght400_GRAD0_opsz48.png";
            this.tabPage3.Location = new System.Drawing.Point(4, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(786, 340);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Configuración";
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.combobox_color_esquema);
            this.materialCard2.Controls.Add(this.materialLabel1);
            this.materialCard2.Controls.Add(this.switch_modo_oscuro);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(10, 14);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(762, 100);
            this.materialCard2.TabIndex = 3;
            // 
            // combobox_color_esquema
            // 
            this.combobox_color_esquema.AutoResize = false;
            this.combobox_color_esquema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.combobox_color_esquema.Depth = 0;
            this.combobox_color_esquema.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.combobox_color_esquema.DropDownHeight = 174;
            this.combobox_color_esquema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobox_color_esquema.DropDownWidth = 121;
            this.combobox_color_esquema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.combobox_color_esquema.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.combobox_color_esquema.FormattingEnabled = true;
            this.combobox_color_esquema.IntegralHeight = false;
            this.combobox_color_esquema.ItemHeight = 43;
            this.combobox_color_esquema.Items.AddRange(new object[] {
            "Gris",
            "Índigo",
            "Verde"});
            this.combobox_color_esquema.Location = new System.Drawing.Point(499, 34);
            this.combobox_color_esquema.MaxDropDownItems = 4;
            this.combobox_color_esquema.MouseState = MaterialSkin.MouseState.OUT;
            this.combobox_color_esquema.Name = "combobox_color_esquema";
            this.combobox_color_esquema.Size = new System.Drawing.Size(198, 49);
            this.combobox_color_esquema.StartIndex = 0;
            this.combobox_color_esquema.TabIndex = 4;
            this.combobox_color_esquema.SelectedIndexChanged += new System.EventHandler(this.CambiarColoresEsquema);
            // 
            // materialLabel1
            // 
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(17, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(100, 23);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "Apariencia";
            // 
            // switch_modo_oscuro
            // 
            this.switch_modo_oscuro.AutoSize = true;
            this.switch_modo_oscuro.Depth = 0;
            this.switch_modo_oscuro.Location = new System.Drawing.Point(14, 37);
            this.switch_modo_oscuro.Margin = new System.Windows.Forms.Padding(0);
            this.switch_modo_oscuro.MouseLocation = new System.Drawing.Point(-1, -1);
            this.switch_modo_oscuro.MouseState = MaterialSkin.MouseState.HOVER;
            this.switch_modo_oscuro.Name = "switch_modo_oscuro";
            this.switch_modo_oscuro.Ripple = true;
            this.switch_modo_oscuro.Size = new System.Drawing.Size(153, 37);
            this.switch_modo_oscuro.TabIndex = 2;
            this.switch_modo_oscuro.Text = "Modo Oscuro";
            this.switch_modo_oscuro.UseVisualStyleBackColor = true;
            this.switch_modo_oscuro.CheckedChanged += new System.EventHandler(this.EstablecerModoOscuro);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "emoji_people_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(1, "house_FILL0_wght400_GRAD0_opsz48.png");
            this.imageList1.Images.SetKeyName(2, "settings_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "MainForm";
            this.Text = "Demo Material Design";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        public TabPage tabPage1;
        public TabPage tabPage2;
        public TabPage tabPage3;
        public ImageList imageList1;
        public MaterialSkin.Controls.MaterialCard materialCard1;
        public MaterialSkin.Controls.MaterialLabel materialLabel1;
        public MaterialSkin.Controls.MaterialCard materialCard2;
        public MaterialSkin.Controls.MaterialListView materialListView1;
        public ColumnHeader Nombre;
        public ColumnHeader Edad;
        public ColumnHeader FechaRegistro;
        public MaterialSkin.Controls.MaterialSwitch switch_modo_oscuro;
        private MaterialSkin.Controls.MaterialComboBox combobox_color_esquema;
    }
}