
namespace Array
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblArrayCount = new System.Windows.Forms.Label();
            this.colDay1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDay7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "매장 방문 수";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDay1,
            this.colDay2,
            this.colDay3,
            this.colDay4,
            this.colDay5,
            this.colDay6,
            this.colDay7});
            this.dataGridView1.Location = new System.Drawing.Point(12, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1062, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "일주일간";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(107, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 32);
            this.button2.TabIndex = 2;
            this.button2.Text = "이주일간";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lblArrayCount
            // 
            this.lblArrayCount.AutoSize = true;
            this.lblArrayCount.Location = new System.Drawing.Point(200, 243);
            this.lblArrayCount.Name = "lblArrayCount";
            this.lblArrayCount.Size = new System.Drawing.Size(105, 15);
            this.lblArrayCount.TabIndex = 0;
            this.lblArrayCount.Text = "전체 자료 수:0";
            // 
            // colDay1
            // 
            this.colDay1.HeaderText = "월";
            this.colDay1.MinimumWidth = 6;
            this.colDay1.Name = "colDay1";
            this.colDay1.Width = 125;
            // 
            // colDay2
            // 
            this.colDay2.HeaderText = "화";
            this.colDay2.MinimumWidth = 6;
            this.colDay2.Name = "colDay2";
            this.colDay2.Width = 125;
            // 
            // colDay3
            // 
            this.colDay3.HeaderText = "수";
            this.colDay3.MinimumWidth = 6;
            this.colDay3.Name = "colDay3";
            this.colDay3.Width = 125;
            // 
            // colDay4
            // 
            this.colDay4.HeaderText = "목";
            this.colDay4.MinimumWidth = 6;
            this.colDay4.Name = "colDay4";
            this.colDay4.Width = 125;
            // 
            // colDay5
            // 
            this.colDay5.HeaderText = "금";
            this.colDay5.MinimumWidth = 6;
            this.colDay5.Name = "colDay5";
            this.colDay5.Width = 125;
            // 
            // colDay6
            // 
            this.colDay6.HeaderText = "토";
            this.colDay6.MinimumWidth = 6;
            this.colDay6.Name = "colDay6";
            this.colDay6.Width = 125;
            // 
            // colDay7
            // 
            this.colDay7.HeaderText = "일";
            this.colDay7.MinimumWidth = 6;
            this.colDay7.Name = "colDay7";
            this.colDay7.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblArrayCount);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay3;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay6;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDay7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblArrayCount;
    }
}

