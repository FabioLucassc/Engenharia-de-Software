
namespace Prototipacao
{
    partial class Form_Centro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Centro));
            this.cmbMetodoPag = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.dtCadastro = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtValor = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroDateTime2 = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // cmbMetodoPag
            // 
            this.cmbMetodoPag.FormattingEnabled = true;
            this.cmbMetodoPag.ItemHeight = 23;
            this.cmbMetodoPag.Items.AddRange(new object[] {
            "Dinheiro",
            "Cartão"});
            this.cmbMetodoPag.Location = new System.Drawing.Point(29, 101);
            this.cmbMetodoPag.Name = "cmbMetodoPag";
            this.cmbMetodoPag.Size = new System.Drawing.Size(268, 29);
            this.cmbMetodoPag.TabIndex = 47;
            this.cmbMetodoPag.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cmbMetodoPag.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 79);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(57, 19);
            this.metroLabel2.TabIndex = 48;
            this.metroLabel2.Text = "Paciente";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtCadastro
            // 
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCadastro.Location = new System.Drawing.Point(29, 191);
            this.dtCadastro.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.ShowCheckBox = true;
            this.dtCadastro.Size = new System.Drawing.Size(121, 29);
            this.dtCadastro.Style = MetroFramework.MetroColorStyle.Green;
            this.dtCadastro.TabIndex = 49;
            this.dtCadastro.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(29, 157);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(90, 19);
            this.metroLabel3.TabIndex = 50;
            this.metroLabel3.Text = "Data Consulta";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // txtValor
            // 
            // 
            // 
            // 
            this.txtValor.CustomButton.Image = null;
            this.txtValor.CustomButton.Location = new System.Drawing.Point(120, 1);
            this.txtValor.CustomButton.Name = "";
            this.txtValor.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtValor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtValor.CustomButton.TabIndex = 1;
            this.txtValor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtValor.CustomButton.UseSelectable = true;
            this.txtValor.CustomButton.Visible = false;
            this.txtValor.Lines = new string[0];
            this.txtValor.Location = new System.Drawing.Point(350, 107);
            this.txtValor.MaxLength = 32767;
            this.txtValor.Name = "txtValor";
            this.txtValor.PasswordChar = '\0';
            this.txtValor.PromptText = "Valor";
            this.txtValor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtValor.SelectedText = "";
            this.txtValor.SelectionLength = 0;
            this.txtValor.SelectionStart = 0;
            this.txtValor.ShortcutsEnabled = true;
            this.txtValor.ShowClearButton = true;
            this.txtValor.Size = new System.Drawing.Size(142, 23);
            this.txtValor.Style = MetroFramework.MetroColorStyle.Green;
            this.txtValor.TabIndex = 51;
            this.txtValor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtValor.UseSelectable = true;
            this.txtValor.WaterMark = "Valor";
            this.txtValor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtValor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(350, 79);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(108, 19);
            this.metroLabel5.TabIndex = 52;
            this.metroLabel5.Text = "Valor da consulta";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.metroDateTime1.Location = new System.Drawing.Point(204, 191);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.ShowCheckBox = true;
            this.metroDateTime1.Size = new System.Drawing.Size(121, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroDateTime1.TabIndex = 53;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroDateTime1.Value = new System.DateTime(2021, 5, 26, 10, 30, 0, 0);
            this.metroDateTime1.ValueChanged += new System.EventHandler(this.metroDateTime1_ValueChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(220, 157);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(54, 19);
            this.metroLabel1.TabIndex = 54;
            this.metroLabel1.Text = "Horário";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroDateTime2
            // 
            this.metroDateTime2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.metroDateTime2.Location = new System.Drawing.Point(371, 191);
            this.metroDateTime2.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime2.Name = "metroDateTime2";
            this.metroDateTime2.ShowCheckBox = true;
            this.metroDateTime2.Size = new System.Drawing.Size(121, 29);
            this.metroDateTime2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroDateTime2.TabIndex = 55;
            this.metroDateTime2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(384, 157);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 19);
            this.metroLabel4.TabIndex = 56;
            this.metroLabel4.Text = "Data Cadastro";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton4.BackgroundImage")));
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton4.Location = new System.Drawing.Point(29, 267);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(144, 23);
            this.metroButton4.TabIndex = 8;
            this.metroButton4.Text = "Voltar";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click_1);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton1.Location = new System.Drawing.Point(350, 267);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(142, 23);
            this.metroButton1.TabIndex = 57;
            this.metroButton1.Text = "Agendar";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            // 
            // Form_Centro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(528, 309);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroDateTime2);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dtCadastro);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.cmbMetodoPag);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroButton4);
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form_Centro";
            this.Padding = new System.Windows.Forms.Padding(17, 69, 17, 23);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Consultório Centro - 9h às 18h";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form_consultorios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroComboBox cmbMetodoPag;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroDateTime dtCadastro;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtValor;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime metroDateTime2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}