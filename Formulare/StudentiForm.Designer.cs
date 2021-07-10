using System.ComponentModel;
using System.Windows.Forms;

namespace PAW_Proiect.Formulare
{
    partial class StudentiForm
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
            this.sfdScriereText = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlExp = new System.Windows.Forms.ToolStripMenuItem();
            this.binarExp = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlImp = new System.Windows.Forms.ToolStripMenuItem();
            this.desenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dreptunghiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printStudentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tvStudenti = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.exportToolStripMenuItem, this.importToolStripMenuItem, this.desenToolStripMenuItem, this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.xmlExp, this.binarExp});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // xmlExp
            // 
            this.xmlExp.Name = "xmlExp";
            this.xmlExp.Size = new System.Drawing.Size(112, 24);
            this.xmlExp.Text = "XML";
            this.xmlExp.Click += new System.EventHandler(this.menuXmlExp_Click);
            // 
            // binarExp
            // 
            this.binarExp.Name = "binarExp";
            this.binarExp.Size = new System.Drawing.Size(112, 24);
            this.binarExp.Text = "Binar";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.xmlImp});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // xmlImp
            // 
            this.xmlImp.Name = "xmlImp";
            this.xmlImp.Size = new System.Drawing.Size(107, 24);
            this.xmlImp.Text = "XML";
            this.xmlImp.Click += new System.EventHandler(this.xMLToolStripMenuItem1_Click);
            // 
            // desenToolStripMenuItem
            // 
            this.desenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.dreptunghiToolStripMenuItem});
            this.desenToolStripMenuItem.Name = "desenToolStripMenuItem";
            this.desenToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.desenToolStripMenuItem.Text = "Desen";
            // 
            // dreptunghiToolStripMenuItem
            // 
            this.dreptunghiToolStripMenuItem.Name = "dreptunghiToolStripMenuItem";
            this.dreptunghiToolStripMenuItem.Size = new System.Drawing.Size(153, 24);
            this.dreptunghiToolStripMenuItem.Text = "Dreptunghi";
            this.dreptunghiToolStripMenuItem.Click += new System.EventHandler(this.dreptunghiToolStripMenuItem_Click);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.printStudentiToolStripMenuItem});
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.printToolStripMenuItem.Text = "Print";
            // 
            // printStudentiToolStripMenuItem
            // 
            this.printStudentiToolStripMenuItem.Name = "printStudentiToolStripMenuItem";
            this.printStudentiToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.printStudentiToolStripMenuItem.Text = "Print Studenti";
            this.printStudentiToolStripMenuItem.Click += new System.EventHandler(this.printStudentiToolStripMenuItem_Click);
            // 
            // tvStudenti
            // 
            this.tvStudenti.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (208)))), ((int) (((byte) (193)))));
            this.tvStudenti.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvStudenti.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (64)))), ((int) (((byte) (0)))));
            this.tvStudenti.Location = new System.Drawing.Point(0, 28);
            this.tvStudenti.Name = "tvStudenti";
            this.tvStudenti.Size = new System.Drawing.Size(237, 422);
            this.tvStudenti.TabIndex = 8;
            // 
            // StudentiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (216)))), ((int) (((byte) (208)))), ((int) (((byte) (193)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tvStudenti);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (64)))), ((int) (((byte) (0)))));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentiForm";
            this.Text = "StudentiForm";
            this.Load += new System.EventHandler(this.ListaStudenti_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.StudentiForm_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem printStudentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem desenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dreptunghiToolStripMenuItem;

        private System.Windows.Forms.TreeView tvStudenti;

        private System.Windows.Forms.ToolStripMenuItem binarExp;

        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xmlExp;
        private System.Windows.Forms.ToolStripMenuItem xmlImp;

        private System.Windows.Forms.SaveFileDialog sfdScriereText;

        #endregion
    }
}