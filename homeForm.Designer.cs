namespace Gestione_Conto_Corrente
{
    partial class homeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(homeForm));
            this.label1 = new System.Windows.Forms.Label();
            this.roundedPanel1 = new Gestione_Conto_Corrente.RoundedPanel();
            this.azzeraButton = new CustomControls.RJControls.RJButton();
            this.aggiugniButton = new CustomControls.RJControls.RJButton();
            this.indirizzoTextBox = new CustomControls.RJControls.RJTextBox();
            this.cognomeTextBox = new CustomControls.RJControls.RJTextBox();
            this.nomeTextBox = new CustomControls.RJControls.RJTextBox();
            this.indirizzoLabel = new System.Windows.Forms.Label();
            this.cognomeLabelò = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.roundedPanel2 = new Gestione_Conto_Corrente.RoundedPanel();
            this.saldoLabel = new System.Windows.Forms.Label();
            this.prelievoButton = new CustomControls.RJControls.RJButton();
            this.versamentoButton = new CustomControls.RJControls.RJButton();
            this.importoTextBox = new CustomControls.RJControls.RJTextBox();
            this.importoLabel = new System.Windows.Forms.Label();
            this.roundedPanel3 = new Gestione_Conto_Corrente.RoundedPanel();
            this.esciButton = new CustomControls.RJControls.RJButton();
            this.nuovoButton = new CustomControls.RJControls.RJButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.roundedPanel1.SuspendLayout();
            this.roundedPanel2.SuspendLayout();
            this.roundedPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(702, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestione Banca";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // roundedPanel1
            // 
            this.roundedPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.roundedPanel1.BorderColor = System.Drawing.Color.White;
            this.roundedPanel1.Controls.Add(this.azzeraButton);
            this.roundedPanel1.Controls.Add(this.aggiugniButton);
            this.roundedPanel1.Controls.Add(this.indirizzoTextBox);
            this.roundedPanel1.Controls.Add(this.cognomeTextBox);
            this.roundedPanel1.Controls.Add(this.nomeTextBox);
            this.roundedPanel1.Controls.Add(this.indirizzoLabel);
            this.roundedPanel1.Controls.Add(this.cognomeLabelò);
            this.roundedPanel1.Controls.Add(this.nomeLabel);
            this.roundedPanel1.Edge = 1;
            this.roundedPanel1.Location = new System.Drawing.Point(15, 64);
            this.roundedPanel1.Name = "roundedPanel1";
            this.roundedPanel1.Size = new System.Drawing.Size(330, 285);
            this.roundedPanel1.TabIndex = 1;
            // 
            // azzeraButton
            // 
            this.azzeraButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.azzeraButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.azzeraButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(173)))));
            this.azzeraButton.BorderRadius = 0;
            this.azzeraButton.BorderSize = 2;
            this.azzeraButton.FlatAppearance.BorderSize = 0;
            this.azzeraButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.azzeraButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.azzeraButton.ForeColor = System.Drawing.Color.White;
            this.azzeraButton.Location = new System.Drawing.Point(14, 223);
            this.azzeraButton.Name = "azzeraButton";
            this.azzeraButton.Size = new System.Drawing.Size(145, 50);
            this.azzeraButton.TabIndex = 8;
            this.azzeraButton.Text = "Azzera campi";
            this.azzeraButton.TextColor = System.Drawing.Color.White;
            this.azzeraButton.UseVisualStyleBackColor = false;
            this.azzeraButton.Click += new System.EventHandler(this.azzeraButton_Click);
            // 
            // aggiugniButton
            // 
            this.aggiugniButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(121)))));
            this.aggiugniButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(173)))), ((int)(((byte)(121)))));
            this.aggiugniButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(230)))), ((int)(((byte)(161)))));
            this.aggiugniButton.BorderRadius = 0;
            this.aggiugniButton.BorderSize = 2;
            this.aggiugniButton.FlatAppearance.BorderSize = 0;
            this.aggiugniButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aggiugniButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.aggiugniButton.ForeColor = System.Drawing.Color.White;
            this.aggiugniButton.Location = new System.Drawing.Point(171, 223);
            this.aggiugniButton.Name = "aggiugniButton";
            this.aggiugniButton.Size = new System.Drawing.Size(145, 50);
            this.aggiugniButton.TabIndex = 7;
            this.aggiugniButton.Text = "Aggiungi cliente";
            this.aggiugniButton.TextColor = System.Drawing.Color.White;
            this.aggiugniButton.UseVisualStyleBackColor = false;
            this.aggiugniButton.Click += new System.EventHandler(this.aggiugniButton_Click);
            // 
            // indirizzoTextBox
            // 
            this.indirizzoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.indirizzoTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(173)))));
            this.indirizzoTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.indirizzoTextBox.BorderRadius = 0;
            this.indirizzoTextBox.BorderSize = 2;
            this.indirizzoTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.indirizzoTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.indirizzoTextBox.Location = new System.Drawing.Point(134, 155);
            this.indirizzoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.indirizzoTextBox.Multiline = false;
            this.indirizzoTextBox.Name = "indirizzoTextBox";
            this.indirizzoTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.indirizzoTextBox.PasswordChar = false;
            this.indirizzoTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.indirizzoTextBox.PlaceholderText = "";
            this.indirizzoTextBox.Size = new System.Drawing.Size(182, 36);
            this.indirizzoTextBox.TabIndex = 5;
            this.indirizzoTextBox.Texts = "";
            this.indirizzoTextBox.UnderlinedStyle = false;
            this.indirizzoTextBox._TextChanged += new System.EventHandler(this.indirizzoTextBox__TextChanged);
            // 
            // cognomeTextBox
            // 
            this.cognomeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.cognomeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(173)))));
            this.cognomeTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.cognomeTextBox.BorderRadius = 0;
            this.cognomeTextBox.BorderSize = 2;
            this.cognomeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cognomeTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cognomeTextBox.Location = new System.Drawing.Point(134, 87);
            this.cognomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.cognomeTextBox.Multiline = false;
            this.cognomeTextBox.Name = "cognomeTextBox";
            this.cognomeTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.cognomeTextBox.PasswordChar = false;
            this.cognomeTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.cognomeTextBox.PlaceholderText = "";
            this.cognomeTextBox.Size = new System.Drawing.Size(182, 36);
            this.cognomeTextBox.TabIndex = 4;
            this.cognomeTextBox.Texts = "";
            this.cognomeTextBox.UnderlinedStyle = false;
            this.cognomeTextBox._TextChanged += new System.EventHandler(this.cognomeTextBox__TextChanged);
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.nomeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(173)))));
            this.nomeTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.nomeTextBox.BorderRadius = 0;
            this.nomeTextBox.BorderSize = 2;
            this.nomeTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nomeTextBox.Location = new System.Drawing.Point(134, 18);
            this.nomeTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeTextBox.Multiline = false;
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.nomeTextBox.PasswordChar = false;
            this.nomeTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.nomeTextBox.PlaceholderText = "";
            this.nomeTextBox.Size = new System.Drawing.Size(182, 36);
            this.nomeTextBox.TabIndex = 3;
            this.nomeTextBox.Texts = "";
            this.nomeTextBox.UnderlinedStyle = false;
            this.nomeTextBox._TextChanged += new System.EventHandler(this.nomeTextBox__TextChanged);
            // 
            // indirizzoLabel
            // 
            this.indirizzoLabel.AutoSize = true;
            this.indirizzoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.indirizzoLabel.ForeColor = System.Drawing.Color.White;
            this.indirizzoLabel.Location = new System.Drawing.Point(25, 162);
            this.indirizzoLabel.Name = "indirizzoLabel";
            this.indirizzoLabel.Size = new System.Drawing.Size(80, 22);
            this.indirizzoLabel.TabIndex = 2;
            this.indirizzoLabel.Text = "Indirizzo";
            // 
            // cognomeLabelò
            // 
            this.cognomeLabelò.AutoSize = true;
            this.cognomeLabelò.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cognomeLabelò.ForeColor = System.Drawing.Color.White;
            this.cognomeLabelò.Location = new System.Drawing.Point(14, 94);
            this.cognomeLabelò.Name = "cognomeLabelò";
            this.cognomeLabelò.Size = new System.Drawing.Size(103, 22);
            this.cognomeLabelò.TabIndex = 1;
            this.cognomeLabelò.Text = "Cognome";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nomeLabel.ForeColor = System.Drawing.Color.White;
            this.nomeLabel.Location = new System.Drawing.Point(33, 25);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(65, 22);
            this.nomeLabel.TabIndex = 0;
            this.nomeLabel.Text = "Nome";
            // 
            // roundedPanel2
            // 
            this.roundedPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.roundedPanel2.BorderColor = System.Drawing.Color.White;
            this.roundedPanel2.Controls.Add(this.saldoLabel);
            this.roundedPanel2.Controls.Add(this.prelievoButton);
            this.roundedPanel2.Controls.Add(this.versamentoButton);
            this.roundedPanel2.Controls.Add(this.importoTextBox);
            this.roundedPanel2.Controls.Add(this.importoLabel);
            this.roundedPanel2.Edge = 1;
            this.roundedPanel2.Location = new System.Drawing.Point(359, 64);
            this.roundedPanel2.Name = "roundedPanel2";
            this.roundedPanel2.Size = new System.Drawing.Size(330, 197);
            this.roundedPanel2.TabIndex = 6;
            // 
            // saldoLabel
            // 
            this.saldoLabel.AutoSize = true;
            this.saldoLabel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.saldoLabel.ForeColor = System.Drawing.Color.White;
            this.saldoLabel.Location = new System.Drawing.Point(25, 150);
            this.saldoLabel.Name = "saldoLabel";
            this.saldoLabel.Size = new System.Drawing.Size(135, 25);
            this.saldoLabel.TabIndex = 6;
            this.saldoLabel.Text = "Saldo: 0,00€";
            // 
            // prelievoButton
            // 
            this.prelievoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.prelievoButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.prelievoButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(173)))));
            this.prelievoButton.BorderRadius = 0;
            this.prelievoButton.BorderSize = 2;
            this.prelievoButton.Enabled = false;
            this.prelievoButton.FlatAppearance.BorderSize = 0;
            this.prelievoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prelievoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.prelievoButton.ForeColor = System.Drawing.Color.White;
            this.prelievoButton.Location = new System.Drawing.Point(172, 76);
            this.prelievoButton.Name = "prelievoButton";
            this.prelievoButton.Size = new System.Drawing.Size(145, 50);
            this.prelievoButton.TabIndex = 5;
            this.prelievoButton.Text = "Prelievo";
            this.prelievoButton.TextColor = System.Drawing.Color.White;
            this.prelievoButton.UseVisualStyleBackColor = false;
            this.prelievoButton.Click += new System.EventHandler(this.prelievoButton_Click);
            // 
            // versamentoButton
            // 
            this.versamentoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.versamentoButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.versamentoButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(173)))));
            this.versamentoButton.BorderRadius = 0;
            this.versamentoButton.BorderSize = 2;
            this.versamentoButton.Enabled = false;
            this.versamentoButton.FlatAppearance.BorderSize = 0;
            this.versamentoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.versamentoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.versamentoButton.ForeColor = System.Drawing.Color.White;
            this.versamentoButton.Location = new System.Drawing.Point(15, 76);
            this.versamentoButton.Name = "versamentoButton";
            this.versamentoButton.Size = new System.Drawing.Size(145, 50);
            this.versamentoButton.TabIndex = 4;
            this.versamentoButton.Text = "Versamento";
            this.versamentoButton.TextColor = System.Drawing.Color.White;
            this.versamentoButton.UseVisualStyleBackColor = false;
            this.versamentoButton.Click += new System.EventHandler(this.versamentoButton_Click);
            // 
            // importoTextBox
            // 
            this.importoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.importoTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(173)))));
            this.importoTextBox.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(115)))), ((int)(((byte)(158)))));
            this.importoTextBox.BorderRadius = 0;
            this.importoTextBox.BorderSize = 2;
            this.importoTextBox.Enabled = false;
            this.importoTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importoTextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.importoTextBox.Location = new System.Drawing.Point(135, 13);
            this.importoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.importoTextBox.Multiline = false;
            this.importoTextBox.Name = "importoTextBox";
            this.importoTextBox.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.importoTextBox.PasswordChar = false;
            this.importoTextBox.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.importoTextBox.PlaceholderText = "";
            this.importoTextBox.Size = new System.Drawing.Size(182, 36);
            this.importoTextBox.TabIndex = 3;
            this.importoTextBox.Texts = "";
            this.importoTextBox.UnderlinedStyle = false;
            this.importoTextBox._TextChanged += new System.EventHandler(this.importoTextBox__TextChanged);
            // 
            // importoLabel
            // 
            this.importoLabel.AutoSize = true;
            this.importoLabel.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.importoLabel.ForeColor = System.Drawing.Color.White;
            this.importoLabel.Location = new System.Drawing.Point(27, 20);
            this.importoLabel.Name = "importoLabel";
            this.importoLabel.Size = new System.Drawing.Size(82, 22);
            this.importoLabel.TabIndex = 0;
            this.importoLabel.Text = "Importo";
            // 
            // roundedPanel3
            // 
            this.roundedPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.roundedPanel3.BorderColor = System.Drawing.Color.White;
            this.roundedPanel3.Controls.Add(this.esciButton);
            this.roundedPanel3.Controls.Add(this.nuovoButton);
            this.roundedPanel3.Edge = 1;
            this.roundedPanel3.Location = new System.Drawing.Point(359, 275);
            this.roundedPanel3.Name = "roundedPanel3";
            this.roundedPanel3.Size = new System.Drawing.Size(330, 74);
            this.roundedPanel3.TabIndex = 7;
            // 
            // esciButton
            // 
            this.esciButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.esciButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.esciButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.esciButton.BorderRadius = 0;
            this.esciButton.BorderSize = 2;
            this.esciButton.FlatAppearance.BorderSize = 0;
            this.esciButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.esciButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.esciButton.ForeColor = System.Drawing.Color.White;
            this.esciButton.Location = new System.Drawing.Point(172, 12);
            this.esciButton.Name = "esciButton";
            this.esciButton.Size = new System.Drawing.Size(145, 50);
            this.esciButton.TabIndex = 8;
            this.esciButton.Text = "Esci";
            this.esciButton.TextColor = System.Drawing.Color.White;
            this.esciButton.UseVisualStyleBackColor = false;
            this.esciButton.Click += new System.EventHandler(this.esciButton_Click);
            // 
            // nuovoButton
            // 
            this.nuovoButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.nuovoButton.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(79)))), ((int)(((byte)(140)))));
            this.nuovoButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(97)))), ((int)(((byte)(173)))));
            this.nuovoButton.BorderRadius = 0;
            this.nuovoButton.BorderSize = 2;
            this.nuovoButton.FlatAppearance.BorderSize = 0;
            this.nuovoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nuovoButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nuovoButton.ForeColor = System.Drawing.Color.White;
            this.nuovoButton.Location = new System.Drawing.Point(15, 12);
            this.nuovoButton.Name = "nuovoButton";
            this.nuovoButton.Size = new System.Drawing.Size(145, 50);
            this.nuovoButton.TabIndex = 7;
            this.nuovoButton.Text = "Nuovo cliente";
            this.nuovoButton.TextColor = System.Drawing.Color.White;
            this.nuovoButton.UseVisualStyleBackColor = false;
            this.nuovoButton.Click += new System.EventHandler(this.nuovoButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(60)))), ((int)(((byte)(117)))));
            this.pictureBox1.Image = global::Gestione_Conto_Corrente.Properties.Resources.bank;
            this.pictureBox1.Location = new System.Drawing.Point(649, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // homeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(702, 360);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.roundedPanel3);
            this.Controls.Add(this.roundedPanel2);
            this.Controls.Add(this.roundedPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "homeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.roundedPanel1.ResumeLayout(false);
            this.roundedPanel1.PerformLayout();
            this.roundedPanel2.ResumeLayout(false);
            this.roundedPanel2.PerformLayout();
            this.roundedPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private RoundedPanel roundedPanel1;
        private CustomControls.RJControls.RJTextBox indirizzoTextBox;
        private CustomControls.RJControls.RJTextBox cognomeTextBox;
        private CustomControls.RJControls.RJTextBox nomeTextBox;
        private Label indirizzoLabel;
        private Label cognomeLabelò;
        private Label nomeLabel;
        private RoundedPanel roundedPanel2;
        private CustomControls.RJControls.RJTextBox importoTextBox;
        private Label importoLabel;
        private CustomControls.RJControls.RJButton azzeraButton;
        private CustomControls.RJControls.RJButton aggiugniButton;
        private Label saldoLabel;
        private CustomControls.RJControls.RJButton prelievoButton;
        private CustomControls.RJControls.RJButton versamentoButton;
        private RoundedPanel roundedPanel3;
        private CustomControls.RJControls.RJButton esciButton;
        private CustomControls.RJControls.RJButton nuovoButton;
        private PictureBox pictureBox1;
    }
}