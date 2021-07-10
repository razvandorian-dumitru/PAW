using System.ComponentModel;

namespace PAW_Proiect.Formulare
{
    partial class AddAnUniversitar
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbAn = new System.Windows.Forms.ComboBox();
            this.btAddAn = new System.Windows.Forms.Button();
            this.errAn = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize) (this.errAn)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 68);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(659, 143);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "An Universitar";
            // 
            // cbAn
            // 
            this.cbAn.FormattingEnabled = true;
            this.cbAn.Items.AddRange(new object[] {"1", "2", "3"});
            this.cbAn.Location = new System.Drawing.Point(126, 20);
            this.cbAn.Name = "cbAn";
            this.cbAn.Size = new System.Drawing.Size(84, 24);
            this.cbAn.TabIndex = 2;
            // 
            // btAddAn
            // 
            this.btAddAn.AutoSize = true;
            this.btAddAn.Location = new System.Drawing.Point(528, 20);
            this.btAddAn.Name = "btAddAn";
            this.btAddAn.Size = new System.Drawing.Size(119, 26);
            this.btAddAn.TabIndex = 3;
            this.btAddAn.Text = "Creare An";
            this.btAddAn.UseVisualStyleBackColor = true;
            this.btAddAn.Click += new System.EventHandler(this.btAddAn_Click);
            // 
            // errAn
            // 
            this.errAn.ContainerControl = this;
            // 
            // AddAnUniversitar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 211);
            this.Controls.Add(this.btAddAn);
            this.Controls.Add(this.cbAn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddAnUniversitar";
            this.Text = "AddAnUniversitar";
            ((System.ComponentModel.ISupportInitialize) (this.errAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ErrorProvider errAn;

        private System.Windows.Forms.Button btAddAn;

        private System.Windows.Forms.ComboBox cbAn;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox textBox1;

        #endregion
    }
}