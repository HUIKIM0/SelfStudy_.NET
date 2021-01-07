
namespace Lotto_while
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
            this.lblrottoResult = new System.Windows.Forms.Label();
            this.btnrottoResult = new System.Windows.Forms.Button();
            this.lboxrottoResult = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.btnchoiceResult = new System.Windows.Forms.Button();
            this.lblfindResult = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblrottoResult
            // 
            this.lblrottoResult.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblrottoResult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblrottoResult.Location = new System.Drawing.Point(12, 21);
            this.lblrottoResult.Name = "lblrottoResult";
            this.lblrottoResult.Size = new System.Drawing.Size(281, 31);
            this.lblrottoResult.TabIndex = 0;
            this.lblrottoResult.Text = "0. 0. 0. 0. 0. 0.";
            this.lblrottoResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnrottoResult
            // 
            this.btnrottoResult.Location = new System.Drawing.Point(309, 21);
            this.btnrottoResult.Name = "btnrottoResult";
            this.btnrottoResult.Size = new System.Drawing.Size(98, 31);
            this.btnrottoResult.TabIndex = 1;
            this.btnrottoResult.Text = "로또번호";
            this.btnrottoResult.UseVisualStyleBackColor = true;
            this.btnrottoResult.Click += new System.EventHandler(this.btnrottoResult_Click);
            // 
            // lboxrottoResult
            // 
            this.lboxrottoResult.FormattingEnabled = true;
            this.lboxrottoResult.ItemHeight = 15;
            this.lboxrottoResult.Location = new System.Drawing.Point(12, 68);
            this.lboxrottoResult.Name = "lboxrottoResult";
            this.lboxrottoResult.Size = new System.Drawing.Size(281, 214);
            this.lboxrottoResult.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "1~100사이의 숫자 중에서 선택하세요";
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(12, 347);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(100, 25);
            this.tboxNumber.TabIndex = 4;
            // 
            // btnchoiceResult
            // 
            this.btnchoiceResult.Location = new System.Drawing.Point(128, 347);
            this.btnchoiceResult.Name = "btnchoiceResult";
            this.btnchoiceResult.Size = new System.Drawing.Size(144, 25);
            this.btnchoiceResult.TabIndex = 5;
            this.btnchoiceResult.Text = "선택 번호 뽑기";
            this.btnchoiceResult.UseVisualStyleBackColor = true;
            this.btnchoiceResult.Click += new System.EventHandler(this.btnchoiceResult_Click);
            // 
            // lblfindResult
            // 
            this.lblfindResult.AutoSize = true;
            this.lblfindResult.Location = new System.Drawing.Point(12, 400);
            this.lblfindResult.Name = "lblfindResult";
            this.lblfindResult.Size = new System.Drawing.Size(15, 15);
            this.lblfindResult.TabIndex = 6;
            this.lblfindResult.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Location = new System.Drawing.Point(12, 295);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 3);
            this.panel1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 442);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblfindResult);
            this.Controls.Add(this.btnchoiceResult);
            this.Controls.Add(this.tboxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lboxrottoResult);
            this.Controls.Add(this.btnrottoResult);
            this.Controls.Add(this.lblrottoResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblrottoResult;
        private System.Windows.Forms.Button btnrottoResult;
        private System.Windows.Forms.ListBox lboxrottoResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Button btnchoiceResult;
        private System.Windows.Forms.Label lblfindResult;
        private System.Windows.Forms.Panel panel1;
    }
}

