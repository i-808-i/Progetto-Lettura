namespace ProgettoLetturaProprieta
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
            this.btn_scegliFile = new System.Windows.Forms.Button();
            this.btn_Salva = new System.Windows.Forms.Button();
            this.lbl_NomeFile = new System.Windows.Forms.Label();
            this.grid_Proprieta = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_tipo = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_dim = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_datacreaz = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl_ultimamod = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbl_versione = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbl_nomeorig = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_path = new System.Windows.Forms.Label();
            this.grid_Proprieta.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_scegliFile
            // 
            this.btn_scegliFile.Location = new System.Drawing.Point(12, 12);
            this.btn_scegliFile.Name = "btn_scegliFile";
            this.btn_scegliFile.Size = new System.Drawing.Size(81, 35);
            this.btn_scegliFile.TabIndex = 0;
            this.btn_scegliFile.Text = "File";
            this.btn_scegliFile.UseVisualStyleBackColor = true;
            this.btn_scegliFile.Click += new System.EventHandler(this.btn_scegliFile_Click);
            // 
            // btn_Salva
            // 
            this.btn_Salva.Location = new System.Drawing.Point(12, 591);
            this.btn_Salva.Name = "btn_Salva";
            this.btn_Salva.Size = new System.Drawing.Size(81, 35);
            this.btn_Salva.TabIndex = 1;
            this.btn_Salva.Text = "Salva";
            this.btn_Salva.UseVisualStyleBackColor = true;
            this.btn_Salva.Click += new System.EventHandler(this.btn_Salva_Click);
            // 
            // lbl_NomeFile
            // 
            this.lbl_NomeFile.AutoSize = true;
            this.lbl_NomeFile.Location = new System.Drawing.Point(12, 106);
            this.lbl_NomeFile.Name = "lbl_NomeFile";
            this.lbl_NomeFile.Size = new System.Drawing.Size(73, 20);
            this.lbl_NomeFile.TabIndex = 0;
            this.lbl_NomeFile.Text = "⠀⠀⠀⠀⠀⠀⠀⠀";
            // 
            // grid_Proprieta
            // 
            this.grid_Proprieta.ColumnCount = 2;
            this.grid_Proprieta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.grid_Proprieta.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.grid_Proprieta.Controls.Add(this.label1, 0, 0);
            this.grid_Proprieta.Controls.Add(this.label2, 1, 0);
            this.grid_Proprieta.Controls.Add(this.label19, 0, 8);
            this.grid_Proprieta.Controls.Add(this.label15, 0, 7);
            this.grid_Proprieta.Controls.Add(this.label13, 0, 6);
            this.grid_Proprieta.Controls.Add(this.label11, 0, 5);
            this.grid_Proprieta.Controls.Add(this.label7, 0, 4);
            this.grid_Proprieta.Controls.Add(this.label5, 0, 3);
            this.grid_Proprieta.Controls.Add(this.label3, 0, 2);
            this.grid_Proprieta.Controls.Add(this.lbl_nomeorig, 1, 8);
            this.grid_Proprieta.Controls.Add(this.lbl_versione, 1, 7);
            this.grid_Proprieta.Controls.Add(this.lbl_ultimamod, 1, 6);
            this.grid_Proprieta.Controls.Add(this.lbl_datacreaz, 1, 5);
            this.grid_Proprieta.Controls.Add(this.lbl_dim, 1, 4);
            this.grid_Proprieta.Controls.Add(this.lbl_desc, 1, 3);
            this.grid_Proprieta.Controls.Add(this.lbl_tipo, 1, 2);
            this.grid_Proprieta.Controls.Add(this.label4, 0, 1);
            this.grid_Proprieta.Controls.Add(this.lbl_path, 1, 1);
            this.grid_Proprieta.Location = new System.Drawing.Point(12, 148);
            this.grid_Proprieta.Name = "grid_Proprieta";
            this.grid_Proprieta.RowCount = 9;
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.grid_Proprieta.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.grid_Proprieta.Size = new System.Drawing.Size(814, 353);
            this.grid_Proprieta.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "PROPRIETÀ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(471, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "VALORE";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo File";
            // 
            // lbl_tipo
            // 
            this.lbl_tipo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_tipo.AutoSize = true;
            this.lbl_tipo.Location = new System.Drawing.Point(472, 87);
            this.lbl_tipo.Name = "lbl_tipo";
            this.lbl_tipo.Size = new System.Drawing.Size(73, 20);
            this.lbl_tipo.TabIndex = 3;
            this.lbl_tipo.Text = "⠀⠀⠀⠀⠀⠀⠀⠀";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descrizione";
            // 
            // lbl_desc
            // 
            this.lbl_desc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(472, 126);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(73, 20);
            this.lbl_desc.TabIndex = 5;
            this.lbl_desc.Text = "⠀⠀⠀⠀⠀⠀⠀⠀";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Dimensioni";
            // 
            // lbl_dim
            // 
            this.lbl_dim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_dim.AutoSize = true;
            this.lbl_dim.Location = new System.Drawing.Point(472, 165);
            this.lbl_dim.Name = "lbl_dim";
            this.lbl_dim.Size = new System.Drawing.Size(73, 20);
            this.lbl_dim.TabIndex = 7;
            this.lbl_dim.Text = "⠀⠀⠀⠀⠀⠀⠀⠀";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(120, 20);
            this.label11.TabIndex = 10;
            this.label11.Text = "Data Creazione";
            // 
            // lbl_datacreaz
            // 
            this.lbl_datacreaz.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_datacreaz.AutoSize = true;
            this.lbl_datacreaz.Location = new System.Drawing.Point(472, 204);
            this.lbl_datacreaz.Name = "lbl_datacreaz";
            this.lbl_datacreaz.Size = new System.Drawing.Size(73, 20);
            this.lbl_datacreaz.TabIndex = 11;
            this.lbl_datacreaz.Text = "⠀⠀⠀⠀⠀⠀⠀⠀";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(117, 20);
            this.label13.TabIndex = 12;
            this.label13.Text = "Ultima Modifica";
            // 
            // lbl_ultimamod
            // 
            this.lbl_ultimamod.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ultimamod.AutoSize = true;
            this.lbl_ultimamod.Location = new System.Drawing.Point(472, 243);
            this.lbl_ultimamod.Name = "lbl_ultimamod";
            this.lbl_ultimamod.Size = new System.Drawing.Size(73, 20);
            this.lbl_ultimamod.TabIndex = 13;
            this.lbl_ultimamod.Text = "⠀⠀⠀⠀⠀⠀⠀⠀";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(65, 282);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Versione";
            // 
            // lbl_versione
            // 
            this.lbl_versione.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_versione.AutoSize = true;
            this.lbl_versione.Location = new System.Drawing.Point(472, 282);
            this.lbl_versione.Name = "lbl_versione";
            this.lbl_versione.Size = new System.Drawing.Size(73, 20);
            this.lbl_versione.TabIndex = 15;
            this.lbl_versione.Text = "⠀⠀⠀⠀⠀⠀⠀⠀";
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 322);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(146, 20);
            this.label19.TabIndex = 18;
            this.label19.Text = "Nome File Originale";
            // 
            // lbl_nomeorig
            // 
            this.lbl_nomeorig.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_nomeorig.AutoSize = true;
            this.lbl_nomeorig.Location = new System.Drawing.Point(472, 322);
            this.lbl_nomeorig.Name = "lbl_nomeorig";
            this.lbl_nomeorig.Size = new System.Drawing.Size(73, 20);
            this.lbl_nomeorig.TabIndex = 19;
            this.lbl_nomeorig.Text = "⠀⠀⠀⠀⠀⠀⠀⠀";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Percorso";
            // 
            // lbl_path
            // 
            this.lbl_path.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_path.AutoSize = true;
            this.lbl_path.Location = new System.Drawing.Point(472, 48);
            this.lbl_path.Name = "lbl_path";
            this.lbl_path.Size = new System.Drawing.Size(73, 20);
            this.lbl_path.TabIndex = 21;
            this.lbl_path.Text = "⠀⠀⠀⠀⠀⠀⠀⠀";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 638);
            this.Controls.Add(this.grid_Proprieta);
            this.Controls.Add(this.lbl_NomeFile);
            this.Controls.Add(this.btn_Salva);
            this.Controls.Add(this.btn_scegliFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grid_Proprieta.ResumeLayout(false);
            this.grid_Proprieta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_scegliFile;
        private System.Windows.Forms.Button btn_Salva;
        private System.Windows.Forms.Label lbl_NomeFile;
        private System.Windows.Forms.TableLayoutPanel grid_Proprieta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_tipo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_dim;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_datacreaz;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl_ultimamod;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbl_versione;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbl_nomeorig;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_path;
    }
}

