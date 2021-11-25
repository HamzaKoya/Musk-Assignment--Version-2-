
namespace Musk_Assisgnment
{
    partial class List_of_Inspection
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvSAF = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAF)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(413, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(411, 55);
            this.label1.TabIndex = 6;
            this.label1.Text = "List Of Inspection";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvSAF
            // 
            this.dgvSAF.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSAF.Location = new System.Drawing.Point(12, 67);
            this.dgvSAF.Name = "dgvSAF";
            this.dgvSAF.Size = new System.Drawing.Size(1243, 491);
            this.dgvSAF.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 564);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(336, 51);
            this.button2.TabIndex = 8;
            this.button2.Text = "Load Data";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // List_of_Inspection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(53)))), ((int)(((byte)(71)))));
            this.ClientSize = new System.Drawing.Size(1267, 644);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvSAF);
            this.Controls.Add(this.label1);
            this.Name = "List_of_Inspection";
            this.Text = "List_of_Inspection";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSAF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvSAF;
        private System.Windows.Forms.Button button2;
    }
}