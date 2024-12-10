namespace MyWindowApp
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.endButton = new System.Windows.Forms.Button();
            this.unitPriceTestBox = new System.Windows.Forms.TextBox();
            this.volumeTextBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "金額を計算します。";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "単価";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "個数";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "金額";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(36, 240);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 6;
            this.calcButton.Text = "計算";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // endButton
            // 
            this.endButton.Location = new System.Drawing.Point(161, 240);
            this.endButton.Name = "endButton";
            this.endButton.Size = new System.Drawing.Size(75, 23);
            this.endButton.TabIndex = 7;
            this.endButton.Text = "終了";
            this.endButton.UseVisualStyleBackColor = true;
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // unitPriceTestBox
            // 
            this.unitPriceTestBox.Location = new System.Drawing.Point(136, 73);
            this.unitPriceTestBox.Name = "unitPriceTestBox";
            this.unitPriceTestBox.Size = new System.Drawing.Size(100, 26);
            this.unitPriceTestBox.TabIndex = 8;
            this.unitPriceTestBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.unitPriceTestBox.TextChanged += new System.EventHandler(this.unitPriceTestBox_TextChanged);
            // 
            // volumeTextBox
            // 
            this.volumeTextBox.Location = new System.Drawing.Point(136, 118);
            this.volumeTextBox.Name = "volumeTextBox";
            this.volumeTextBox.Size = new System.Drawing.Size(100, 26);
            this.volumeTextBox.TabIndex = 9;
            this.volumeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amountLabel
            // 
            this.amountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.amountLabel.Location = new System.Drawing.Point(136, 171);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(100, 23);
            this.amountLabel.TabIndex = 10;
            this.amountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 293);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.volumeTextBox);
            this.Controls.Add(this.unitPriceTestBox);
            this.Controls.Add(this.endButton);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "金額計算";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.Button endButton;
        private System.Windows.Forms.TextBox unitPriceTestBox;
        private System.Windows.Forms.TextBox volumeTextBox;
        private System.Windows.Forms.Label amountLabel;
    }
}

