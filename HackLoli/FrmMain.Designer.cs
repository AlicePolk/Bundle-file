namespace HackLoli
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.btnOk = new System.Windows.Forms.Button();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.txtAFile = new System.Windows.Forms.TextBox();
            this.lblAFile = new System.Windows.Forms.Label();
            this.txtBFile = new System.Windows.Forms.TextBox();
            this.lblBFile = new System.Windows.Forms.Label();
            this.txtCSave = new System.Windows.Forms.TextBox();
            this.lblCSave = new System.Windows.Forms.Label();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(203, 203);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "确定";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsg.BackColor = System.Drawing.Color.White;
            this.txtMsg.Location = new System.Drawing.Point(18, 101);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ReadOnly = true;
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMsg.Size = new System.Drawing.Size(260, 96);
            this.txtMsg.TabIndex = 3;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // txtAFile
            // 
            this.txtAFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAFile.BackColor = System.Drawing.Color.White;
            this.txtAFile.Location = new System.Drawing.Point(77, 9);
            this.txtAFile.Name = "txtAFile";
            this.txtAFile.ReadOnly = true;
            this.txtAFile.Size = new System.Drawing.Size(201, 21);
            this.txtAFile.TabIndex = 0;
            this.txtAFile.Text = " ";
            this.txtAFile.Click += new System.EventHandler(this.txtFile_Click);
            // 
            // lblAFile
            // 
            this.lblAFile.AutoSize = true;
            this.lblAFile.Location = new System.Drawing.Point(18, 12);
            this.lblAFile.Name = "lblAFile";
            this.lblAFile.Size = new System.Drawing.Size(53, 12);
            this.lblAFile.TabIndex = 3;
            this.lblAFile.Text = "主文件：";
            // 
            // txtBFile
            // 
            this.txtBFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBFile.BackColor = System.Drawing.Color.White;
            this.txtBFile.Location = new System.Drawing.Point(77, 37);
            this.txtBFile.Name = "txtBFile";
            this.txtBFile.ReadOnly = true;
            this.txtBFile.Size = new System.Drawing.Size(201, 21);
            this.txtBFile.TabIndex = 1;
            this.txtBFile.Click += new System.EventHandler(this.txtFile_Click);
            // 
            // lblBFile
            // 
            this.lblBFile.AutoSize = true;
            this.lblBFile.Location = new System.Drawing.Point(18, 40);
            this.lblBFile.Name = "lblBFile";
            this.lblBFile.Size = new System.Drawing.Size(53, 12);
            this.lblBFile.TabIndex = 3;
            this.lblBFile.Text = "副文件：";
            // 
            // txtCSave
            // 
            this.txtCSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCSave.BackColor = System.Drawing.Color.White;
            this.txtCSave.Location = new System.Drawing.Point(77, 68);
            this.txtCSave.Name = "txtCSave";
            this.txtCSave.ReadOnly = true;
            this.txtCSave.Size = new System.Drawing.Size(201, 21);
            this.txtCSave.TabIndex = 2;
            this.txtCSave.Click += new System.EventHandler(this.txtCSave_Click);
            // 
            // lblCSave
            // 
            this.lblCSave.AutoSize = true;
            this.lblCSave.Location = new System.Drawing.Point(6, 71);
            this.lblCSave.Name = "lblCSave";
            this.lblCSave.Size = new System.Drawing.Size(65, 12);
            this.lblCSave.TabIndex = 3;
            this.lblCSave.Text = "存储路径：";
            // 
            // FrmMain
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 237);
            this.Controls.Add(this.lblCSave);
            this.Controls.Add(this.lblBFile);
            this.Controls.Add(this.lblAFile);
            this.Controls.Add(this.txtCSave);
            this.Controls.Add(this.txtBFile);
            this.Controls.Add(this.txtAFile);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnOk);
            this.MinimumSize = new System.Drawing.Size(300, 275);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "文件捆绑";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox txtAFile;
        private System.Windows.Forms.Label lblAFile;
        private System.Windows.Forms.TextBox txtBFile;
        private System.Windows.Forms.Label lblBFile;
        private System.Windows.Forms.TextBox txtCSave;
        private System.Windows.Forms.Label lblCSave;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

