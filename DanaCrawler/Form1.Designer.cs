namespace DanaCrawler
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textPW = new System.Windows.Forms.TextBox();
            this.textID = new System.Windows.Forms.TextBox();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listCount = new System.Windows.Forms.Label();
            this.loadedImg = new System.Windows.Forms.TextBox();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.textImg = new System.Windows.Forms.TextBox();
            this.imgBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.loginBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textPW);
            this.groupBox1.Controls.Add(this.textID);
            this.groupBox1.Location = new System.Drawing.Point(26, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(530, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "로그인";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(301, 71);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(175, 82);
            this.loginBtn.TabIndex = 1;
            this.loginBtn.Text = "로그인";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "PW : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textPW
            // 
            this.textPW.Location = new System.Drawing.Point(99, 121);
            this.textPW.Name = "textPW";
            this.textPW.Size = new System.Drawing.Size(156, 32);
            this.textPW.TabIndex = 1;
            // 
            // textID
            // 
            this.textID.Location = new System.Drawing.Point(99, 71);
            this.textID.Name = "textID";
            this.textID.Size = new System.Drawing.Size(156, 32);
            this.textID.TabIndex = 0;
            this.textID.TextChanged += new System.EventHandler(this.textID_TextChanged);
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(562, 39);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(514, 663);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No.";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "로그 내용";
            this.columnHeader2.Width = 400;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imgBtn);
            this.groupBox2.Controls.Add(this.textImg);
            this.groupBox2.Controls.Add(this.listCount);
            this.groupBox2.Controls.Add(this.loadedImg);
            this.groupBox2.Controls.Add(this.pictureBox);
            this.groupBox2.Location = new System.Drawing.Point(26, 264);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(530, 438);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "이미지";
            // 
            // listCount
            // 
            this.listCount.AutoSize = true;
            this.listCount.Location = new System.Drawing.Point(226, 386);
            this.listCount.Name = "listCount";
            this.listCount.Size = new System.Drawing.Size(37, 21);
            this.listCount.TabIndex = 2;
            this.listCount.Text = "/ 0";
            // 
            // loadedImg
            // 
            this.loadedImg.Location = new System.Drawing.Point(168, 383);
            this.loadedImg.Name = "loadedImg";
            this.loadedImg.Size = new System.Drawing.Size(52, 32);
            this.loadedImg.TabIndex = 1;
            this.loadedImg.Text = "0";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(16, 67);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(496, 310);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // textImg
            // 
            this.textImg.Location = new System.Drawing.Point(144, 29);
            this.textImg.Name = "textImg";
            this.textImg.Size = new System.Drawing.Size(198, 32);
            this.textImg.TabIndex = 3;
            // 
            // imgBtn
            // 
            this.imgBtn.Location = new System.Drawing.Point(368, 26);
            this.imgBtn.Name = "imgBtn";
            this.imgBtn.Size = new System.Drawing.Size(122, 32);
            this.imgBtn.TabIndex = 4;
            this.imgBtn.Text = "검색하기";
            this.imgBtn.UseVisualStyleBackColor = true;
            this.imgBtn.Click += new System.EventHandler(this.imgBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 714);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textPW;
        private System.Windows.Forms.TextBox textID;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label listCount;
        private System.Windows.Forms.TextBox loadedImg;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button imgBtn;
        private System.Windows.Forms.TextBox textImg;
    }
}

