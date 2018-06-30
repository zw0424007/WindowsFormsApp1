namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tvPath = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.imgListFlies = new System.Windows.Forms.ImageList(this.components);
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.SuspendLayout();
            // 
            // tvPath
            // 
            this.tvPath.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvPath.ImageIndex = 0;
            this.tvPath.ImageList = this.imgListFlies;
            this.tvPath.Location = new System.Drawing.Point(0, 0);
            this.tvPath.Name = "tvPath";
            this.tvPath.SelectedImageIndex = 0;
            this.tvPath.Size = new System.Drawing.Size(270, 368);
            this.tvPath.TabIndex = 0;
            this.tvPath.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvPath_BeforeExpand);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(309, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // imgListFlies
            // 
            this.imgListFlies.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imgListFlies.ImageSize = new System.Drawing.Size(16, 16);
            this.imgListFlies.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(270, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 368);
            this.splitter1.TabIndex = 3;
            this.splitter1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 368);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tvPath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvPath;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ImageList imgListFlies;
        private System.Windows.Forms.Splitter splitter1;
    }
}

