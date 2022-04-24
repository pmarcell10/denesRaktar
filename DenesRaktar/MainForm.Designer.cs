
namespace DenesRaktar
{
    partial class MainForm
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
            this.btn_AddItem = new System.Windows.Forms.Button();
            this.tb_AktivSzamla = new System.Windows.Forms.TextBox();
            this.lbl_AktivSzamla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_AddItem
            // 
            this.btn_AddItem.Location = new System.Drawing.Point(1009, 51);
            this.btn_AddItem.Name = "btn_AddItem";
            this.btn_AddItem.Size = new System.Drawing.Size(105, 26);
            this.btn_AddItem.TabIndex = 0;
            this.btn_AddItem.Text = "Elem hozzáadása";
            this.btn_AddItem.UseVisualStyleBackColor = true;
            this.btn_AddItem.Click += new System.EventHandler(this.btn_AddItem_Click);
            // 
            // tb_AktivSzamla
            // 
            this.tb_AktivSzamla.Location = new System.Drawing.Point(87, 12);
            this.tb_AktivSzamla.Name = "tb_AktivSzamla";
            this.tb_AktivSzamla.Size = new System.Drawing.Size(100, 20);
            this.tb_AktivSzamla.TabIndex = 1;
            // 
            // lbl_AktivSzamla
            // 
            this.lbl_AktivSzamla.AutoSize = true;
            this.lbl_AktivSzamla.Location = new System.Drawing.Point(10, 15);
            this.lbl_AktivSzamla.Name = "lbl_AktivSzamla";
            this.lbl_AktivSzamla.Size = new System.Drawing.Size(71, 13);
            this.lbl_AktivSzamla.TabIndex = 2;
            this.lbl_AktivSzamla.Text = "Aktív számla:";
            this.lbl_AktivSzamla.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 686);
            this.Controls.Add(this.lbl_AktivSzamla);
            this.Controls.Add(this.tb_AktivSzamla);
            this.Controls.Add(this.btn_AddItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Raktár";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddItem;
        private System.Windows.Forms.TextBox tb_AktivSzamla;
        private System.Windows.Forms.Label lbl_AktivSzamla;
    }
}

