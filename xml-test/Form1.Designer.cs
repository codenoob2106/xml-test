namespace xml_test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.CmdEingabe = new System.Windows.Forms.Button();
            this.LblAusgabe = new System.Windows.Forms.Label();
            this.TxtEingabe = new System.Windows.Forms.TextBox();
            this.CmdAusgabe = new System.Windows.Forms.Button();
            this.CmdClear = new System.Windows.Forms.Button();
            this.CmdXmlSchreiben = new System.Windows.Forms.Button();
            this.CmdXmlLesen = new System.Windows.Forms.Button();
            this.CmdTeilnehmer = new System.Windows.Forms.Button();
            this.LstAusgabe = new System.Windows.Forms.ListBox();
            this.CmdPunkteNeu = new System.Windows.Forms.Button();
            this.TxtPunkteNeu = new System.Windows.Forms.TextBox();
            this.LblAuswahlListe = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CmdEingabe
            // 
            this.CmdEingabe.Location = new System.Drawing.Point(25, 27);
            this.CmdEingabe.Name = "CmdEingabe";
            this.CmdEingabe.Size = new System.Drawing.Size(75, 23);
            this.CmdEingabe.TabIndex = 0;
            this.CmdEingabe.Text = "Enter";
            this.CmdEingabe.UseVisualStyleBackColor = true;
            this.CmdEingabe.Click += new System.EventHandler(this.CmdEingabe_Click);
            // 
            // LblAusgabe
            // 
            this.LblAusgabe.AutoSize = true;
            this.LblAusgabe.BackColor = System.Drawing.Color.MistyRose;
            this.LblAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAusgabe.Location = new System.Drawing.Point(320, 29);
            this.LblAusgabe.MinimumSize = new System.Drawing.Size(100, 100);
            this.LblAusgabe.Name = "LblAusgabe";
            this.LblAusgabe.Size = new System.Drawing.Size(100, 100);
            this.LblAusgabe.TabIndex = 1;
            // 
            // TxtEingabe
            // 
            this.TxtEingabe.Location = new System.Drawing.Point(120, 29);
            this.TxtEingabe.Name = "TxtEingabe";
            this.TxtEingabe.Size = new System.Drawing.Size(161, 20);
            this.TxtEingabe.TabIndex = 2;
            // 
            // CmdAusgabe
            // 
            this.CmdAusgabe.Location = new System.Drawing.Point(25, 145);
            this.CmdAusgabe.Name = "CmdAusgabe";
            this.CmdAusgabe.Size = new System.Drawing.Size(75, 23);
            this.CmdAusgabe.TabIndex = 3;
            this.CmdAusgabe.Text = "Ausgabe";
            this.CmdAusgabe.UseVisualStyleBackColor = true;
            this.CmdAusgabe.Click += new System.EventHandler(this.CmdAusgabe_Click);
            // 
            // CmdClear
            // 
            this.CmdClear.Location = new System.Drawing.Point(25, 116);
            this.CmdClear.Name = "CmdClear";
            this.CmdClear.Size = new System.Drawing.Size(116, 23);
            this.CmdClear.TabIndex = 4;
            this.CmdClear.Text = "Label löschen";
            this.CmdClear.UseVisualStyleBackColor = true;
            this.CmdClear.Click += new System.EventHandler(this.CmdClear_Click);
            // 
            // CmdXmlSchreiben
            // 
            this.CmdXmlSchreiben.Location = new System.Drawing.Point(25, 193);
            this.CmdXmlSchreiben.Name = "CmdXmlSchreiben";
            this.CmdXmlSchreiben.Size = new System.Drawing.Size(116, 23);
            this.CmdXmlSchreiben.TabIndex = 5;
            this.CmdXmlSchreiben.Text = "In XML schreiben";
            this.CmdXmlSchreiben.UseVisualStyleBackColor = true;
            this.CmdXmlSchreiben.Click += new System.EventHandler(this.CmdXmlSchreiben_Click);
            // 
            // CmdXmlLesen
            // 
            this.CmdXmlLesen.Location = new System.Drawing.Point(25, 222);
            this.CmdXmlLesen.Name = "CmdXmlLesen";
            this.CmdXmlLesen.Size = new System.Drawing.Size(116, 23);
            this.CmdXmlLesen.TabIndex = 6;
            this.CmdXmlLesen.Text = "Aus XML lesen";
            this.CmdXmlLesen.UseVisualStyleBackColor = true;
            this.CmdXmlLesen.Click += new System.EventHandler(this.CmdXmlLesen_Click);
            // 
            // CmdTeilnehmer
            // 
            this.CmdTeilnehmer.Location = new System.Drawing.Point(25, 275);
            this.CmdTeilnehmer.Name = "CmdTeilnehmer";
            this.CmdTeilnehmer.Size = new System.Drawing.Size(116, 23);
            this.CmdTeilnehmer.TabIndex = 7;
            this.CmdTeilnehmer.Text = "Welcher Teilnehmer?";
            this.CmdTeilnehmer.UseVisualStyleBackColor = true;
            this.CmdTeilnehmer.Click += new System.EventHandler(this.CmdTeilnehmer_Click);
            // 
            // LstAusgabe
            // 
            this.LstAusgabe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstAusgabe.FormattingEnabled = true;
            this.LstAusgabe.IntegralHeight = false;
            this.LstAusgabe.ItemHeight = 24;
            this.LstAusgabe.Location = new System.Drawing.Point(584, 27);
            this.LstAusgabe.MultiColumn = true;
            this.LstAusgabe.Name = "LstAusgabe";
            this.LstAusgabe.Size = new System.Drawing.Size(365, 794);
            this.LstAusgabe.TabIndex = 9;
            // 
            // CmdPunkteNeu
            // 
            this.CmdPunkteNeu.Location = new System.Drawing.Point(25, 399);
            this.CmdPunkteNeu.Name = "CmdPunkteNeu";
            this.CmdPunkteNeu.Size = new System.Drawing.Size(116, 23);
            this.CmdPunkteNeu.TabIndex = 10;
            this.CmdPunkteNeu.Text = "Punkte neu?";
            this.CmdPunkteNeu.UseVisualStyleBackColor = true;
            this.CmdPunkteNeu.Click += new System.EventHandler(this.CmdPunkteNeu_Click);
            // 
            // TxtPunkteNeu
            // 
            this.TxtPunkteNeu.Location = new System.Drawing.Point(25, 428);
            this.TxtPunkteNeu.Name = "TxtPunkteNeu";
            this.TxtPunkteNeu.Size = new System.Drawing.Size(116, 20);
            this.TxtPunkteNeu.TabIndex = 11;
            // 
            // LblAuswahlListe
            // 
            this.LblAuswahlListe.AutoSize = true;
            this.LblAuswahlListe.BackColor = System.Drawing.Color.SeaShell;
            this.LblAuswahlListe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuswahlListe.Location = new System.Drawing.Point(30, 301);
            this.LblAuswahlListe.Name = "LblAuswahlListe";
            this.LblAuswahlListe.Size = new System.Drawing.Size(0, 16);
            this.LblAuswahlListe.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 833);
            this.Controls.Add(this.LblAuswahlListe);
            this.Controls.Add(this.TxtPunkteNeu);
            this.Controls.Add(this.CmdPunkteNeu);
            this.Controls.Add(this.LstAusgabe);
            this.Controls.Add(this.CmdTeilnehmer);
            this.Controls.Add(this.CmdXmlLesen);
            this.Controls.Add(this.CmdXmlSchreiben);
            this.Controls.Add(this.CmdClear);
            this.Controls.Add(this.CmdAusgabe);
            this.Controls.Add(this.TxtEingabe);
            this.Controls.Add(this.LblAusgabe);
            this.Controls.Add(this.CmdEingabe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CmdEingabe;
        private System.Windows.Forms.Label LblAusgabe;
        private System.Windows.Forms.TextBox TxtEingabe;
        private System.Windows.Forms.Button CmdAusgabe;
        private System.Windows.Forms.Button CmdClear;
        private System.Windows.Forms.Button CmdXmlSchreiben;
        private System.Windows.Forms.Button CmdXmlLesen;
        private System.Windows.Forms.Button CmdTeilnehmer;
        private System.Windows.Forms.ListBox LstAusgabe;
        private System.Windows.Forms.Button CmdPunkteNeu;
        private System.Windows.Forms.TextBox TxtPunkteNeu;
        private System.Windows.Forms.Label LblAuswahlListe;
    }
}

