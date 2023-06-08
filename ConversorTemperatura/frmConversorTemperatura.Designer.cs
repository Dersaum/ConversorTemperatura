namespace ConversorTemperatura
{
    partial class frmConversorTemperatura
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboUnidadeInicial = new MaterialSkin.Controls.MaterialComboBox();
            this.cboUnidadeConvertida = new MaterialSkin.Controls.MaterialComboBox();
            this.btnConverter = new MaterialSkin.Controls.MaterialButton();
            this.txtUnidadeInicial = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtUnidadeConvertida = new MaterialSkin.Controls.MaterialTextBox2();
            this.SuspendLayout();
            // 
            // cboUnidadeInicial
            // 
            this.cboUnidadeInicial.AutoResize = false;
            this.cboUnidadeInicial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboUnidadeInicial.Depth = 0;
            this.cboUnidadeInicial.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboUnidadeInicial.DropDownHeight = 174;
            this.cboUnidadeInicial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadeInicial.DropDownWidth = 121;
            this.cboUnidadeInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadeInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboUnidadeInicial.FormattingEnabled = true;
            this.cboUnidadeInicial.IntegralHeight = false;
            this.cboUnidadeInicial.ItemHeight = 43;
            this.cboUnidadeInicial.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cboUnidadeInicial.Location = new System.Drawing.Point(34, 82);
            this.cboUnidadeInicial.MaxDropDownItems = 4;
            this.cboUnidadeInicial.MouseState = MaterialSkin.MouseState.OUT;
            this.cboUnidadeInicial.Name = "cboUnidadeInicial";
            this.cboUnidadeInicial.Size = new System.Drawing.Size(120, 49);
            this.cboUnidadeInicial.StartIndex = 0;
            this.cboUnidadeInicial.TabIndex = 4;
            // 
            // cboUnidadeConvertida
            // 
            this.cboUnidadeConvertida.AutoResize = false;
            this.cboUnidadeConvertida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cboUnidadeConvertida.Depth = 0;
            this.cboUnidadeConvertida.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cboUnidadeConvertida.DropDownHeight = 174;
            this.cboUnidadeConvertida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidadeConvertida.DropDownWidth = 121;
            this.cboUnidadeConvertida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboUnidadeConvertida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cboUnidadeConvertida.FormattingEnabled = true;
            this.cboUnidadeConvertida.IntegralHeight = false;
            this.cboUnidadeConvertida.ItemHeight = 43;
            this.cboUnidadeConvertida.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cboUnidadeConvertida.Location = new System.Drawing.Point(185, 82);
            this.cboUnidadeConvertida.MaxDropDownItems = 4;
            this.cboUnidadeConvertida.MouseState = MaterialSkin.MouseState.OUT;
            this.cboUnidadeConvertida.Name = "cboUnidadeConvertida";
            this.cboUnidadeConvertida.Size = new System.Drawing.Size(120, 49);
            this.cboUnidadeConvertida.StartIndex = 0;
            this.cboUnidadeConvertida.TabIndex = 4;
            // 
            // btnConverter
            // 
            this.btnConverter.AutoSize = false;
            this.btnConverter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConverter.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnConverter.Depth = 0;
            this.btnConverter.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConverter.HighEmphasis = true;
            this.btnConverter.Icon = null;
            this.btnConverter.Location = new System.Drawing.Point(78, 194);
            this.btnConverter.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.btnConverter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConverter.Name = "btnConverter";
            this.btnConverter.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnConverter.Size = new System.Drawing.Size(185, 55);
            this.btnConverter.TabIndex = 6;
            this.btnConverter.Text = "Converter";
            this.btnConverter.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnConverter.UseAccentColor = false;
            this.btnConverter.UseVisualStyleBackColor = true;
            this.btnConverter.Click += new System.EventHandler(this.btnConverter_Click);
            // 
            // txtUnidadeInicial
            // 
            this.txtUnidadeInicial.AnimateReadOnly = false;
            this.txtUnidadeInicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUnidadeInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUnidadeInicial.Depth = 0;
            this.txtUnidadeInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txtUnidadeInicial.HideSelection = true;
            this.txtUnidadeInicial.LeadingIcon = null;
            this.txtUnidadeInicial.Location = new System.Drawing.Point(34, 137);
            this.txtUnidadeInicial.MaxLength = 32767;
            this.txtUnidadeInicial.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUnidadeInicial.Name = "txtUnidadeInicial";
            this.txtUnidadeInicial.PasswordChar = '\0';
            this.txtUnidadeInicial.PrefixSuffixText = null;
            this.txtUnidadeInicial.ReadOnly = false;
            this.txtUnidadeInicial.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUnidadeInicial.SelectedText = "";
            this.txtUnidadeInicial.SelectionLength = 0;
            this.txtUnidadeInicial.SelectionStart = 0;
            this.txtUnidadeInicial.ShortcutsEnabled = true;
            this.txtUnidadeInicial.Size = new System.Drawing.Size(120, 48);
            this.txtUnidadeInicial.TabIndex = 7;
            this.txtUnidadeInicial.TabStop = false;
            this.txtUnidadeInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnidadeInicial.TrailingIcon = null;
            this.txtUnidadeInicial.UseSystemPasswordChar = false;
            // 
            // txtUnidadeConvertida
            // 
            this.txtUnidadeConvertida.AnimateReadOnly = false;
            this.txtUnidadeConvertida.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUnidadeConvertida.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUnidadeConvertida.Depth = 0;
            this.txtUnidadeConvertida.Enabled = false;
            this.txtUnidadeConvertida.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.txtUnidadeConvertida.HideSelection = true;
            this.txtUnidadeConvertida.LeadingIcon = null;
            this.txtUnidadeConvertida.Location = new System.Drawing.Point(185, 137);
            this.txtUnidadeConvertida.MaxLength = 32767;
            this.txtUnidadeConvertida.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUnidadeConvertida.Name = "txtUnidadeConvertida";
            this.txtUnidadeConvertida.PasswordChar = '\0';
            this.txtUnidadeConvertida.PrefixSuffixText = null;
            this.txtUnidadeConvertida.ReadOnly = true;
            this.txtUnidadeConvertida.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUnidadeConvertida.SelectedText = "";
            this.txtUnidadeConvertida.SelectionLength = 0;
            this.txtUnidadeConvertida.SelectionStart = 0;
            this.txtUnidadeConvertida.ShortcutsEnabled = true;
            this.txtUnidadeConvertida.Size = new System.Drawing.Size(120, 48);
            this.txtUnidadeConvertida.TabIndex = 7;
            this.txtUnidadeConvertida.TabStop = false;
            this.txtUnidadeConvertida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnidadeConvertida.TrailingIcon = null;
            this.txtUnidadeConvertida.UseSystemPasswordChar = false;
            // 
            // frmConversorTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(318, 271);
            this.Controls.Add(this.txtUnidadeConvertida);
            this.Controls.Add(this.txtUnidadeInicial);
            this.Controls.Add(this.btnConverter);
            this.Controls.Add(this.cboUnidadeConvertida);
            this.Controls.Add(this.cboUnidadeInicial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConversorTemperatura";
            this.Padding = new System.Windows.Forms.Padding(3, 65, 3, 3);
            this.ShowIcon = false;
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor de Temperatura";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private MaterialSkin.Controls.MaterialComboBox cboUnidadeInicial;
        private MaterialSkin.Controls.MaterialComboBox cboUnidadeConvertida;
        private MaterialSkin.Controls.MaterialButton btnConverter;
        private MaterialSkin.Controls.MaterialTextBox2 txtUnidadeInicial;
        private MaterialSkin.Controls.MaterialTextBox2 txtUnidadeConvertida;
    }
}

