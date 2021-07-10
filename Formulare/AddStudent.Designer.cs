using System.ComponentModel;

namespace PAW_Proiect.Formulare
{
    partial class AddStudent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.numericVarsta = new System.Windows.Forms.NumericUpDown();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.tbCod = new System.Windows.Forms.TextBox();
            this.tvVarsta = new System.Windows.Forms.Label();
            this.tvCod = new System.Windows.Forms.Label();
            this.Nume = new System.Windows.Forms.Label();
            this.btSaveStud = new System.Windows.Forms.Button();
            this.GbMaterie = new System.Windows.Forms.GroupBox();
            this.lvMaterii = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.stergeMateriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Materie = new System.Windows.Forms.Label();
            this.btAddMaterie = new System.Windows.Forms.Button();
            this.numNota = new System.Windows.Forms.NumericUpDown();
            this.numCredite = new System.Windows.Forms.NumericUpDown();
            this.tbDenumire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tvNrCred = new System.Windows.Forms.Label();
            this.tvDenumire = new System.Windows.Forms.Label();
            this.gbAn = new System.Windows.Forms.GroupBox();
            this.rbAn4 = new System.Windows.Forms.RadioButton();
            this.rbAn3 = new System.Windows.Forms.RadioButton();
            this.rbAn2 = new System.Windows.Forms.RadioButton();
            this.rbAn1 = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btLista = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.modificareAspectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fundalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fOndToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gunoi = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize) (this.numericVarsta)).BeginInit();
            this.GbMaterie.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.numNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.numCredite)).BeginInit();
            this.gbAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.gunoi)).BeginInit();
            this.SuspendLayout();
            // 
            // numericVarsta
            // 
            this.numericVarsta.Location = new System.Drawing.Point(74, 120);
            this.numericVarsta.Name = "numericVarsta";
            this.numericVarsta.Size = new System.Drawing.Size(91, 22);
            this.numericVarsta.TabIndex = 25;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(74, 88);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(120, 22);
            this.tbNume.TabIndex = 23;
            this.tbNume.KeyDown += new System.Windows.Forms.KeyEventHandler(this.etNume_KeyDown);
            this.tbNume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.etNume_KeyPress);
            // 
            // tbCod
            // 
            this.tbCod.Location = new System.Drawing.Point(74, 52);
            this.tbCod.Name = "tbCod";
            this.tbCod.Size = new System.Drawing.Size(120, 22);
            this.tbCod.TabIndex = 21;
            this.tbCod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.etCod_KeyDown);
            this.tbCod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.etCod_KeyPress);
            // 
            // tvVarsta
            // 
            this.tvVarsta.Location = new System.Drawing.Point(18, 127);
            this.tvVarsta.Name = "tvVarsta";
            this.tvVarsta.Size = new System.Drawing.Size(50, 15);
            this.tvVarsta.TabIndex = 28;
            this.tvVarsta.Text = "Varsta";
            // 
            // tvCod
            // 
            this.tvCod.Location = new System.Drawing.Point(18, 59);
            this.tvCod.Name = "tvCod";
            this.tvCod.Size = new System.Drawing.Size(50, 15);
            this.tvCod.TabIndex = 24;
            this.tvCod.Text = "Cod";
            // 
            // Nume
            // 
            this.Nume.Location = new System.Drawing.Point(18, 91);
            this.Nume.Name = "Nume";
            this.Nume.Size = new System.Drawing.Size(50, 15);
            this.Nume.TabIndex = 22;
            this.Nume.Text = "Nume";
            // 
            // btSaveStud
            // 
            this.btSaveStud.Location = new System.Drawing.Point(432, 430);
            this.btSaveStud.Name = "btSaveStud";
            this.btSaveStud.Size = new System.Drawing.Size(92, 29);
            this.btSaveStud.TabIndex = 31;
            this.btSaveStud.Text = "Save";
            this.btSaveStud.UseVisualStyleBackColor = true;
            this.btSaveStud.Click += new System.EventHandler(this.btNew_Click);
            // 
            // GbMaterie
            // 
            this.GbMaterie.Controls.Add(this.lvMaterii);
            this.GbMaterie.Controls.Add(this.Materie);
            this.GbMaterie.Controls.Add(this.btAddMaterie);
            this.GbMaterie.Controls.Add(this.numNota);
            this.GbMaterie.Controls.Add(this.numCredite);
            this.GbMaterie.Controls.Add(this.tbDenumire);
            this.GbMaterie.Controls.Add(this.label2);
            this.GbMaterie.Controls.Add(this.tvNrCred);
            this.GbMaterie.Controls.Add(this.tvDenumire);
            this.GbMaterie.Location = new System.Drawing.Point(224, 36);
            this.GbMaterie.Name = "GbMaterie";
            this.GbMaterie.Size = new System.Drawing.Size(300, 374);
            this.GbMaterie.TabIndex = 32;
            this.GbMaterie.TabStop = false;
            this.GbMaterie.Text = "Materie";
            // 
            // lvMaterii
            // 
            this.lvMaterii.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (208)))), ((int) (((byte) (193)))));
            this.lvMaterii.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvMaterii.CheckBoxes = true;
            this.lvMaterii.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {this.columnHeader1, this.columnHeader2, this.columnHeader3, this.columnHeader4});
            this.lvMaterii.ContextMenuStrip = this.contextMenuStrip1;
            this.lvMaterii.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lvMaterii.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (64)))), ((int) (((byte) (0)))));
            this.lvMaterii.FullRowSelect = true;
            this.lvMaterii.GridLines = true;
            this.lvMaterii.Location = new System.Drawing.Point(3, 188);
            this.lvMaterii.Name = "lvMaterii";
            this.lvMaterii.Size = new System.Drawing.Size(294, 183);
            this.lvMaterii.TabIndex = 17;
            this.lvMaterii.UseCompatibleStateImageBehavior = false;
            this.lvMaterii.View = System.Windows.Forms.View.Details;
            this.lvMaterii.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.lvMaterii_ItemDrag);
            this.lvMaterii.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lvMaterii_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Denumire";
            this.columnHeader1.Width = 74;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nr. Credite";
            this.columnHeader2.Width = 79;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nota";
            this.columnHeader3.Width = 42;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Tip Examen";
            this.columnHeader4.Width = 97;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.stergeMateriaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(177, 50);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // stergeMateriaToolStripMenuItem
            // 
            this.stergeMateriaToolStripMenuItem.Name = "stergeMateriaToolStripMenuItem";
            this.stergeMateriaToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.stergeMateriaToolStripMenuItem.Text = "Sterge Materia";
            this.stergeMateriaToolStripMenuItem.Click += new System.EventHandler(this.stergeMateriaToolStripMenuItem_Click);
            // 
            // Materie
            // 
            this.Materie.AutoSize = true;
            this.Materie.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Materie.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (64)))), ((int) (((byte) (0)))));
            this.Materie.Location = new System.Drawing.Point(53, 36);
            this.Materie.Name = "Materie";
            this.Materie.Size = new System.Drawing.Size(211, 28);
            this.Materie.TabIndex = 16;
            this.Materie.Text = "ADAUGARE MATERIE";
            // 
            // btAddMaterie
            // 
            this.btAddMaterie.BackColor = System.Drawing.SystemColors.Control;
            this.btAddMaterie.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btAddMaterie.Location = new System.Drawing.Point(189, 125);
            this.btAddMaterie.Name = "btAddMaterie";
            this.btAddMaterie.Size = new System.Drawing.Size(75, 45);
            this.btAddMaterie.TabIndex = 15;
            this.btAddMaterie.Text = "Creare Materie";
            this.btAddMaterie.UseVisualStyleBackColor = false;
            this.btAddMaterie.Click += new System.EventHandler(this.btAddMaterie_Click);
            // 
            // numNota
            // 
            this.numNota.Location = new System.Drawing.Point(125, 148);
            this.numNota.Maximum = new decimal(new int[] {10, 0, 0, 0});
            this.numNota.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numNota.Name = "numNota";
            this.numNota.Size = new System.Drawing.Size(46, 22);
            this.numNota.TabIndex = 14;
            this.numNota.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // numCredite
            // 
            this.numCredite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numCredite.Location = new System.Drawing.Point(125, 113);
            this.numCredite.Maximum = new decimal(new int[] {6, 0, 0, 0});
            this.numCredite.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.numCredite.Name = "numCredite";
            this.numCredite.Size = new System.Drawing.Size(46, 22);
            this.numCredite.TabIndex = 13;
            this.numCredite.Value = new decimal(new int[] {1, 0, 0, 0});
            // 
            // tbDenumire
            // 
            this.tbDenumire.Location = new System.Drawing.Point(125, 74);
            this.tbDenumire.Name = "tbDenumire";
            this.tbDenumire.Size = new System.Drawing.Size(139, 22);
            this.tbDenumire.TabIndex = 12;
            this.tbDenumire.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.etDenumire_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 150);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Nota";
            // 
            // tvNrCred
            // 
            this.tvNrCred.AutoSize = true;
            this.tvNrCred.Location = new System.Drawing.Point(24, 113);
            this.tvNrCred.Name = "tvNrCred";
            this.tvNrCred.Size = new System.Drawing.Size(70, 16);
            this.tvNrCred.TabIndex = 10;
            this.tvNrCred.Text = "Nr. Credite";
            // 
            // tvDenumire
            // 
            this.tvDenumire.AutoSize = true;
            this.tvDenumire.Location = new System.Drawing.Point(24, 74);
            this.tvDenumire.Margin = new System.Windows.Forms.Padding(3);
            this.tvDenumire.Name = "tvDenumire";
            this.tvDenumire.Size = new System.Drawing.Size(65, 16);
            this.tvDenumire.TabIndex = 9;
            this.tvDenumire.Text = "Denumire";
            // 
            // gbAn
            // 
            this.gbAn.Controls.Add(this.rbAn4);
            this.gbAn.Controls.Add(this.rbAn3);
            this.gbAn.Controls.Add(this.rbAn2);
            this.gbAn.Controls.Add(this.rbAn1);
            this.gbAn.Location = new System.Drawing.Point(18, 235);
            this.gbAn.Name = "gbAn";
            this.gbAn.Size = new System.Drawing.Size(176, 145);
            this.gbAn.TabIndex = 33;
            this.gbAn.TabStop = false;
            this.gbAn.Text = "An";
            // 
            // rbAn4
            // 
            this.rbAn4.AutoSize = true;
            this.rbAn4.Location = new System.Drawing.Point(34, 112);
            this.rbAn4.Name = "rbAn4";
            this.rbAn4.Size = new System.Drawing.Size(116, 20);
            this.rbAn4.TabIndex = 3;
            this.rbAn4.TabStop = true;
            this.rbAn4.Text = "An suplimentar";
            this.rbAn4.UseVisualStyleBackColor = true;
            // 
            // rbAn3
            // 
            this.rbAn3.Location = new System.Drawing.Point(34, 82);
            this.rbAn3.Name = "rbAn3";
            this.rbAn3.Size = new System.Drawing.Size(104, 24);
            this.rbAn3.TabIndex = 2;
            this.rbAn3.TabStop = true;
            this.rbAn3.Text = "An III";
            this.rbAn3.UseVisualStyleBackColor = true;
            // 
            // rbAn2
            // 
            this.rbAn2.Location = new System.Drawing.Point(34, 52);
            this.rbAn2.Name = "rbAn2";
            this.rbAn2.Size = new System.Drawing.Size(104, 24);
            this.rbAn2.TabIndex = 1;
            this.rbAn2.TabStop = true;
            this.rbAn2.Text = "An II";
            this.rbAn2.UseVisualStyleBackColor = true;
            // 
            // rbAn1
            // 
            this.rbAn1.Location = new System.Drawing.Point(34, 22);
            this.rbAn1.Name = "rbAn1";
            this.rbAn1.Size = new System.Drawing.Size(104, 24);
            this.rbAn1.TabIndex = 0;
            this.rbAn1.TabStop = true;
            this.rbAn1.Text = "An I";
            this.rbAn1.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {"M", "F"});
            this.cbSex.Location = new System.Drawing.Point(74, 149);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(63, 24);
            this.cbSex.TabIndex = 34;
            this.cbSex.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbSex_KeyDown);
            this.cbSex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbSex_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 16);
            this.label1.TabIndex = 35;
            this.label1.Text = "Sex";
            // 
            // btLista
            // 
            this.btLista.AutoSize = true;
            this.btLista.Location = new System.Drawing.Point(18, 430);
            this.btLista.Name = "btLista";
            this.btLista.Size = new System.Drawing.Size(90, 26);
            this.btLista.TabIndex = 36;
            this.btLista.Text = "Afisare Lista";
            this.btLista.UseVisualStyleBackColor = true;
            this.btLista.Click += new System.EventHandler(this.btLista_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.modificareAspectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(746, 28);
            this.menuStrip1.TabIndex = 37;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // modificareAspectToolStripMenuItem
            // 
            this.modificareAspectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fundalToolStripMenuItem, this.fOndToolStripMenuItem});
            this.modificareAspectToolStripMenuItem.Name = "modificareAspectToolStripMenuItem";
            this.modificareAspectToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.modificareAspectToolStripMenuItem.Text = "Modificare Aspect";
            // 
            // fundalToolStripMenuItem
            // 
            this.fundalToolStripMenuItem.Name = "fundalToolStripMenuItem";
            this.fundalToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.fundalToolStripMenuItem.Text = "Fundal";
            this.fundalToolStripMenuItem.Click += new System.EventHandler(this.fundalToolStripMenuItem_Click);
            // 
            // fOndToolStripMenuItem
            // 
            this.fOndToolStripMenuItem.Name = "fOndToolStripMenuItem";
            this.fOndToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.fOndToolStripMenuItem.Text = "Fond";
            this.fOndToolStripMenuItem.Click += new System.EventHandler(this.fOndToolStripMenuItem_Click);
            // 
            // gunoi
            // 
            this.gunoi.Image = ((System.Drawing.Image) (resources.GetObject("gunoi.Image")));
            this.gunoi.Location = new System.Drawing.Point(542, 300);
            this.gunoi.Name = "gunoi";
            this.gunoi.Size = new System.Drawing.Size(89, 110);
            this.gunoi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunoi.TabIndex = 39;
            this.gunoi.TabStop = false;
            this.gunoi.DragDrop += new System.Windows.Forms.DragEventHandler(this.gunoi_DragDrop);
            this.gunoi.DragEnter += new System.Windows.Forms.DragEventHandler(this.gunoi_DragEnter);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (208)))), ((int) (((byte) (193)))));
            this.ClientSize = new System.Drawing.Size(746, 471);
            this.Controls.Add(this.gunoi);
            this.Controls.Add(this.btLista);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.gbAn);
            this.Controls.Add(this.GbMaterie);
            this.Controls.Add(this.numericVarsta);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbCod);
            this.Controls.Add(this.tvVarsta);
            this.Controls.Add(this.tvCod);
            this.Controls.Add(this.Nume);
            this.Controls.Add(this.btSaveStud);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AddStudent";
            this.Text = "AddStudent";
            this.Click += new System.EventHandler(this.AddStudent_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AddStudent_KeyDown);
            ((System.ComponentModel.ISupportInitialize) (this.numericVarsta)).EndInit();
            this.GbMaterie.ResumeLayout(false);
            this.GbMaterie.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.numNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.numCredite)).EndInit();
            this.gbAn.ResumeLayout(false);
            this.gbAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.errorProvider1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.gunoi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.PictureBox gunoi;

        private System.Windows.Forms.ToolStripMenuItem stergeMateriaToolStripMenuItem;

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;

        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;

        private System.Windows.Forms.ColumnHeader columnHeader1;

        private System.Windows.Forms.ListView lvMaterii;

        private System.Windows.Forms.ToolStripMenuItem fOndToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fundalToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem modificareAspectToolStripMenuItem;

        private System.Windows.Forms.Button btLista;

        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.RadioButton rbAn1;
        private System.Windows.Forms.RadioButton rbAn2;
        private System.Windows.Forms.RadioButton rbAn3;
        private System.Windows.Forms.RadioButton rbAn4;

        private System.Windows.Forms.ErrorProvider errorProvider1;

        private System.Windows.Forms.Button btAddMaterie;
        private System.Windows.Forms.TextBox tbDenumire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Materie;
        private System.Windows.Forms.NumericUpDown numCredite;
        private System.Windows.Forms.NumericUpDown numNota;
        private System.Windows.Forms.Label tvDenumire;
        private System.Windows.Forms.Label tvNrCred;
        private System.Windows.Forms.GroupBox gbAn;
        private System.Windows.Forms.GroupBox GbMaterie;
        private System.Windows.Forms.Button btSaveStud;
        private System.Windows.Forms.TextBox tbCod;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label Nume;
        private System.Windows.Forms.NumericUpDown numericVarsta;
        private System.Windows.Forms.Label tvCod;
        private System.Windows.Forms.Label tvVarsta;

        #endregion
    }
}