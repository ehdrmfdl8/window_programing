namespace 다중폼_MDI_
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.윈도우1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.윈도우2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폼4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.윈도우1ToolStripMenuItem,
            this.윈도우2ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.윈도우1ToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 윈도우1ToolStripMenuItem
            // 
            this.윈도우1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼1ToolStripMenuItem,
            this.폼2ToolStripMenuItem});
            this.윈도우1ToolStripMenuItem.Name = "윈도우1ToolStripMenuItem";
            this.윈도우1ToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.윈도우1ToolStripMenuItem.Text = "윈도우1";
            // 
            // 윈도우2ToolStripMenuItem
            // 
            this.윈도우2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폼3ToolStripMenuItem,
            this.폼4ToolStripMenuItem});
            this.윈도우2ToolStripMenuItem.Name = "윈도우2ToolStripMenuItem";
            this.윈도우2ToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.윈도우2ToolStripMenuItem.Text = "윈도우2";
            // 
            // 폼1ToolStripMenuItem
            // 
            this.폼1ToolStripMenuItem.Name = "폼1ToolStripMenuItem";
            this.폼1ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.폼1ToolStripMenuItem.Text = "폼1";
            this.폼1ToolStripMenuItem.Click += new System.EventHandler(this.폼1ToolStripMenuItem_Click);
            // 
            // 폼2ToolStripMenuItem
            // 
            this.폼2ToolStripMenuItem.Name = "폼2ToolStripMenuItem";
            this.폼2ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.폼2ToolStripMenuItem.Text = "폼2";
            this.폼2ToolStripMenuItem.Click += new System.EventHandler(this.폼2ToolStripMenuItem_Click);
            // 
            // 폼3ToolStripMenuItem
            // 
            this.폼3ToolStripMenuItem.Name = "폼3ToolStripMenuItem";
            this.폼3ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.폼3ToolStripMenuItem.Text = "폼3";
            this.폼3ToolStripMenuItem.Click += new System.EventHandler(this.폼3ToolStripMenuItem_Click);
            // 
            // 폼4ToolStripMenuItem
            // 
            this.폼4ToolStripMenuItem.Name = "폼4ToolStripMenuItem";
            this.폼4ToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.폼4ToolStripMenuItem.Text = "폼4";
            this.폼4ToolStripMenuItem.Click += new System.EventHandler(this.폼4ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 윈도우1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 윈도우2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폼4ToolStripMenuItem;
    }
}

