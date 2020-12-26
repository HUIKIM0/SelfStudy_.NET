
namespace SelfStudy_.NET
{
    partial class DataType
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
            this.tboxNumber = new System.Windows.Forms.TextBox();
            this.btnShort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblException = new System.Windows.Forms.Label();
            this.lblDouble = new System.Windows.Forms.Label();
            this.lblInt = new System.Windows.Forms.Label();
            this.lblShort = new System.Windows.Forms.Label();
            this.btnEx = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tboxNumber
            // 
            this.tboxNumber.Location = new System.Drawing.Point(12, 28);
            this.tboxNumber.Name = "tboxNumber";
            this.tboxNumber.Size = new System.Drawing.Size(649, 25);
            this.tboxNumber.TabIndex = 0;
            // 
            // btnShort
            // 
            this.btnShort.Location = new System.Drawing.Point(254, 92);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(100, 23);
            this.btnShort.TabIndex = 1;
            this.btnShort.Text = "Short 변환";
            this.btnShort.UseVisualStyleBackColor = true;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Short";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Int";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Double";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Exception";
            // 
            // lblException
            // 
            this.lblException.AutoSize = true;
            this.lblException.Location = new System.Drawing.Point(108, 273);
            this.lblException.Name = "lblException";
            this.lblException.Size = new System.Drawing.Size(15, 15);
            this.lblException.TabIndex = 2;
            this.lblException.Text = "-";
            // 
            // lblDouble
            // 
            this.lblDouble.AutoSize = true;
            this.lblDouble.Location = new System.Drawing.Point(108, 217);
            this.lblDouble.Name = "lblDouble";
            this.lblDouble.Size = new System.Drawing.Size(15, 15);
            this.lblDouble.TabIndex = 2;
            this.lblDouble.Text = "0";
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(108, 154);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(15, 15);
            this.lblInt.TabIndex = 2;
            this.lblInt.Text = "0";
            // 
            // lblShort
            // 
            this.lblShort.AutoSize = true;
            this.lblShort.Location = new System.Drawing.Point(108, 96);
            this.lblShort.Name = "lblShort";
            this.lblShort.Size = new System.Drawing.Size(15, 15);
            this.lblShort.TabIndex = 2;
            this.lblShort.Text = "0";
            // 
            // btnEx
            // 
            this.btnEx.Location = new System.Drawing.Point(667, 27);
            this.btnEx.Name = "btnEx";
            this.btnEx.Size = new System.Drawing.Size(112, 26);
            this.btnEx.TabIndex = 1;
            this.btnEx.Text = "알아서 변환";
            this.btnEx.UseVisualStyleBackColor = true;
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(254, 150);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(100, 23);
            this.btnInt.TabIndex = 1;
            this.btnInt.Text = "Int 변환";
            this.btnInt.UseVisualStyleBackColor = true;
            // 
            // btnDouble
            // 
            this.btnDouble.Location = new System.Drawing.Point(254, 213);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(100, 23);
            this.btnDouble.TabIndex = 1;
            this.btnDouble.Text = "Double 변환";
            this.btnDouble.UseVisualStyleBackColor = true;
            // 
            // DataType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblShort);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.lblDouble);
            this.Controls.Add(this.lblException);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEx);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.btnInt);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.tboxNumber);
            this.Name = "DataType";
            this.Text = "DataType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNumber;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblException;
        private System.Windows.Forms.Label lblDouble;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.Label lblShort;
        private System.Windows.Forms.Button btnEx;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnDouble;
    }
}