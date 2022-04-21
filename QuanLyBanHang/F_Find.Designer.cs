
namespace QuanLyBanHang
{
    partial class F_Find
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
            this.txtPrimaryKeyFromTable = new System.Windows.Forms.TextBox();
            this.lb_PrimaryKeyFromTable = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrimaryKeyFromTable
            // 
            this.txtPrimaryKeyFromTable.Location = new System.Drawing.Point(164, 144);
            this.txtPrimaryKeyFromTable.Name = "txtPrimaryKeyFromTable";
            this.txtPrimaryKeyFromTable.Size = new System.Drawing.Size(150, 31);
            this.txtPrimaryKeyFromTable.TabIndex = 0;
            // 
            // lb_PrimaryKeyFromTable
            // 
            this.lb_PrimaryKeyFromTable.AutoSize = true;
            this.lb_PrimaryKeyFromTable.Location = new System.Drawing.Point(64, 150);
            this.lb_PrimaryKeyFromTable.Name = "lb_PrimaryKeyFromTable";
            this.lb_PrimaryKeyFromTable.Size = new System.Drawing.Size(40, 25);
            this.lb_PrimaryKeyFromTable.TabIndex = 1;
            this.lb_PrimaryKeyFromTable.Text = ".......";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(64, 280);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(112, 34);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "Tìm kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // F_Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 392);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lb_PrimaryKeyFromTable);
            this.Controls.Add(this.txtPrimaryKeyFromTable);
            this.Name = "F_Find";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrimaryKeyFromTable;
        private System.Windows.Forms.Label lb_PrimaryKeyFromTable;
        private System.Windows.Forms.Button btnFind;
    }
}