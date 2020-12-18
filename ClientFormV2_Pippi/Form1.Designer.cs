namespace ClientFormV2_Pippi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_serverPort = new System.Windows.Forms.TextBox();
            this.txt_messaggio = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.Errore = new System.Windows.Forms.Label();
            this.txt_serverIp = new System.Windows.Forms.TextBox();
            this.btn_disconetti = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_serverPort
            // 
            this.txt_serverPort.Location = new System.Drawing.Point(140, 94);
            this.txt_serverPort.Name = "txt_serverPort";
            this.txt_serverPort.Size = new System.Drawing.Size(100, 22);
            this.txt_serverPort.TabIndex = 1;
            this.txt_serverPort.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txt_messaggio
            // 
            this.txt_messaggio.Location = new System.Drawing.Point(140, 202);
            this.txt_messaggio.Name = "txt_messaggio";
            this.txt_messaggio.Size = new System.Drawing.Size(100, 22);
            this.txt_messaggio.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(585, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(574, 202);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Invio";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 153);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(393, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "-----------------------------------------------------------------------------";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Server IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Server Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 25;
            this.label4.Text = "Messaggio";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(140, 253);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(338, 148);
            this.listBox1.TabIndex = 26;
            // 
            // Errore
            // 
            this.Errore.AutoSize = true;
            this.Errore.Location = new System.Drawing.Point(574, 297);
            this.Errore.Name = "Errore";
            this.Errore.Size = new System.Drawing.Size(52, 17);
            this.Errore.TabIndex = 27;
            this.Errore.Text = "Errore:";
            this.Errore.Click += new System.EventHandler(this.label5_Click);
            // 
            // txt_serverIp
            // 
            this.txt_serverIp.Location = new System.Drawing.Point(140, 46);
            this.txt_serverIp.Name = "txt_serverIp";
            this.txt_serverIp.Size = new System.Drawing.Size(100, 22);
            this.txt_serverIp.TabIndex = 0;
            // 
            // btn_disconetti
            // 
            this.btn_disconetti.Location = new System.Drawing.Point(563, 350);
            this.btn_disconetti.Name = "btn_disconetti";
            this.btn_disconetti.Size = new System.Drawing.Size(86, 36);
            this.btn_disconetti.TabIndex = 28;
            this.btn_disconetti.Text = "Disconetti";
            this.btn_disconetti.UseVisualStyleBackColor = true;
            this.btn_disconetti.Click += new System.EventHandler(this.btn_disconetti_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_disconetti);
            this.Controls.Add(this.Errore);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_messaggio);
            this.Controls.Add(this.txt_serverPort);
            this.Controls.Add(this.txt_serverIp);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_serverPort;
        private System.Windows.Forms.TextBox txt_messaggio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label Errore;
        private System.Windows.Forms.TextBox txt_serverIp;
        private System.Windows.Forms.Button btn_disconetti;
    }
}

