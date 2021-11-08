
namespace _02_DecimalBinaryCalculater
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
            this.rdoBinaryToDecimal = new System.Windows.Forms.RadioButton();
            this.rdoDecimalToBinary = new System.Windows.Forms.RadioButton();
            this.tboxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxResult = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoBinaryToDecimal
            // 
            this.rdoBinaryToDecimal.AutoSize = true;
            this.rdoBinaryToDecimal.Location = new System.Drawing.Point(20, 54);
            this.rdoBinaryToDecimal.Name = "rdoBinaryToDecimal";
            this.rdoBinaryToDecimal.Size = new System.Drawing.Size(123, 16);
            this.rdoBinaryToDecimal.TabIndex = 2;
            this.rdoBinaryToDecimal.TabStop = true;
            this.rdoBinaryToDecimal.Text = "Binary to Decimal";
            this.rdoBinaryToDecimal.UseVisualStyleBackColor = true;
            // 
            // rdoDecimalToBinary
            // 
            this.rdoDecimalToBinary.AutoSize = true;
            this.rdoDecimalToBinary.Location = new System.Drawing.Point(20, 32);
            this.rdoDecimalToBinary.Name = "rdoDecimalToBinary";
            this.rdoDecimalToBinary.Size = new System.Drawing.Size(123, 16);
            this.rdoDecimalToBinary.TabIndex = 3;
            this.rdoDecimalToBinary.TabStop = true;
            this.rdoDecimalToBinary.Text = "Decimal to Binary";
            this.rdoDecimalToBinary.UseVisualStyleBackColor = true;
            // 
            // tboxInput
            // 
            this.tboxInput.Location = new System.Drawing.Point(20, 85);
            this.tboxInput.Name = "tboxInput";
            this.tboxInput.Size = new System.Drawing.Size(138, 21);
            this.tboxInput.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "Input -127 ~ 127";
            // 
            // tboxResult
            // 
            this.tboxResult.Enabled = false;
            this.tboxResult.Location = new System.Drawing.Point(202, 85);
            this.tboxResult.Name = "tboxResult";
            this.tboxResult.Size = new System.Drawing.Size(145, 21);
            this.tboxResult.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(200, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Result";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tboxResult);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tboxInput);
            this.groupBox1.Controls.Add(this.rdoDecimalToBinary);
            this.groupBox1.Controls.Add(this.rdoBinaryToDecimal);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 144);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculater";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(202, 32);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(145, 38);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "Calculate";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 172);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rdoBinaryToDecimal;
        private System.Windows.Forms.RadioButton rdoDecimalToBinary;
        private System.Windows.Forms.TextBox tboxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalc;
    }
}

