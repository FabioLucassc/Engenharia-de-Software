
namespace Prototipacao
{
    partial class Form_Paciente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Paciente));
            this.dtVencimento = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtNomeCliente = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.dtCadastro = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.tggPago = new MetroFramework.Controls.MetroToggle();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // dtVencimento
            // 
            this.dtVencimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVencimento.Location = new System.Drawing.Point(229, 406);
            this.dtVencimento.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtVencimento.Name = "dtVencimento";
            this.dtVencimento.ShowCheckBox = true;
            this.dtVencimento.Size = new System.Drawing.Size(144, 29);
            this.dtVencimento.Style = MetroFramework.MetroColorStyle.Green;
            this.dtVencimento.TabIndex = 35;
            this.dtVencimento.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.dtVencimento.ValueChanged += new System.EventHandler(this.dtVencimento_ValueChanged);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(229, 384);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(144, 19);
            this.metroLabel6.TabIndex = 36;
            this.metroLabel6.Text = "Data Primeira Consulta";
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txtNomeCliente
            // 
            // 
            // 
            // 
            this.txtNomeCliente.CustomButton.Image = null;
            this.txtNomeCliente.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.txtNomeCliente.CustomButton.Name = "";
            this.txtNomeCliente.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNomeCliente.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNomeCliente.CustomButton.TabIndex = 1;
            this.txtNomeCliente.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNomeCliente.CustomButton.UseSelectable = true;
            this.txtNomeCliente.CustomButton.Visible = false;
            this.txtNomeCliente.Lines = new string[0];
            this.txtNomeCliente.Location = new System.Drawing.Point(30, 123);
            this.txtNomeCliente.MaxLength = 32767;
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.PasswordChar = '\0';
            this.txtNomeCliente.PromptText = "Nome do paciente";
            this.txtNomeCliente.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNomeCliente.SelectedText = "";
            this.txtNomeCliente.SelectionLength = 0;
            this.txtNomeCliente.SelectionStart = 0;
            this.txtNomeCliente.ShortcutsEnabled = true;
            this.txtNomeCliente.ShowClearButton = true;
            this.txtNomeCliente.Size = new System.Drawing.Size(490, 23);
            this.txtNomeCliente.Style = MetroFramework.MetroColorStyle.Green;
            this.txtNomeCliente.TabIndex = 33;
            this.txtNomeCliente.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.txtNomeCliente.UseSelectable = true;
            this.txtNomeCliente.WaterMark = "Nome do paciente";
            this.txtNomeCliente.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNomeCliente.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(30, 101);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(119, 19);
            this.metroLabel8.TabIndex = 34;
            this.metroLabel8.Text = "Nome Do Paciente";
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dtCadastro
            // 
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCadastro.Location = new System.Drawing.Point(30, 406);
            this.dtCadastro.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.ShowCheckBox = true;
            this.dtCadastro.Size = new System.Drawing.Size(129, 29);
            this.dtCadastro.Style = MetroFramework.MetroColorStyle.Green;
            this.dtCadastro.TabIndex = 31;
            this.dtCadastro.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(30, 384);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(129, 19);
            this.metroLabel3.TabIndex = 32;
            this.metroLabel3.Text = "Data De Nascimento";
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(30, 192);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Endereço do paciente";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.ShowClearButton = true;
            this.metroTextBox1.Size = new System.Drawing.Size(490, 23);
            this.metroTextBox1.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox1.TabIndex = 37;
            this.metroTextBox1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Endereço do paciente";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(30, 170);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(64, 19);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Endereço";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[0];
            this.metroTextBox2.Location = new System.Drawing.Point(30, 265);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.PromptText = "Telefone do paciente";
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.ShowClearButton = true;
            this.metroTextBox2.Size = new System.Drawing.Size(490, 23);
            this.metroTextBox2.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox2.TabIndex = 39;
            this.metroTextBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMark = "Telefone do paciente";
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(30, 243);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(124, 19);
            this.metroLabel2.TabIndex = 40;
            this.metroLabel2.Text = "Telefone de contato";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[0];
            this.metroTextBox3.Location = new System.Drawing.Point(30, 336);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.PromptText = "Email do paciente";
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.ShowClearButton = true;
            this.metroTextBox3.Size = new System.Drawing.Size(490, 23);
            this.metroTextBox3.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox3.TabIndex = 41;
            this.metroTextBox3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMark = "Email do paciente";
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(30, 314);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(41, 19);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Email";
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(434, 384);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(86, 19);
            this.metroLabel5.TabIndex = 44;
            this.metroLabel5.Text = "É particular ?";
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tggPago
            // 
            this.tggPago.AutoSize = true;
            this.tggPago.DisplayStatus = false;
            this.tggPago.Location = new System.Drawing.Point(449, 416);
            this.tggPago.Name = "tggPago";
            this.tggPago.Size = new System.Drawing.Size(50, 19);
            this.tggPago.Style = MetroFramework.MetroColorStyle.Green;
            this.tggPago.TabIndex = 43;
            this.tggPago.Text = "Off";
            this.tggPago.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tggPago.UseSelectable = true;
            this.tggPago.CheckedChanged += new System.EventHandler(this.tggPago_CheckedChanged);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(30, 452);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(229, 19);
            this.metroLabel7.TabIndex = 47;
            this.metroLabel7.Text = "Número de consultas (Não Particular)";
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.Click += new System.EventHandler(this.metroLabel7_Click);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(468, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[0];
            this.metroTextBox4.Location = new System.Drawing.Point(30, 474);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.PromptText = "Nº De Consultas";
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.ShowClearButton = true;
            this.metroTextBox4.Size = new System.Drawing.Size(490, 23);
            this.metroTextBox4.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTextBox4.TabIndex = 48;
            this.metroTextBox4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMark = "Nº De Consultas";
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton1.BackgroundImage")));
            this.metroButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton1.Location = new System.Drawing.Point(378, 521);
            this.metroButton1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(142, 23);
            this.metroButton1.TabIndex = 45;
            this.metroButton1.Text = "Cadastrar";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseSelectable = true;
            // 
            // metroButton4
            // 
            this.metroButton4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButton4.BackgroundImage")));
            this.metroButton4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.metroButton4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metroButton4.Location = new System.Drawing.Point(30, 521);
            this.metroButton4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(144, 23);
            this.metroButton4.TabIndex = 4;
            this.metroButton4.Text = "Voltar";
            this.metroButton4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // Form_Paciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.ClientSize = new System.Drawing.Size(558, 582);
            this.Controls.Add(this.metroTextBox4);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.tggPago);
            this.Controls.Add(this.metroTextBox3);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroTextBox2);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dtVencimento);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.txtNomeCliente);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.dtCadastro);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroButton4);
            this.Font = new System.Drawing.Font("Impact", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form_Paciente";
            this.Padding = new System.Windows.Forms.Padding(17, 69, 17, 23);
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Cadastrar Pacientes";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.Form_Paciente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroDateTime dtVencimento;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtNomeCliente;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroDateTime dtCadastro;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroToggle tggPago;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
    }
}