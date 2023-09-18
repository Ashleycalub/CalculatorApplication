namespace CalculatorApplication
{
    partial class FrmCalculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1=new Label();
            label2=new Label();
            label3=new Label();
            txtBoxInput1=new TextBox();
            txtBoxInput2=new TextBox();
            cbOperator=new ComboBox();
            backgroundWorker1=new System.ComponentModel.BackgroundWorker();
            lblDisplayTotal=new Label();
            btnEqual=new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location=new Point(31, 36);
            label1.Name="label1";
            label1.Size=new Size(145, 21);
            label1.TabIndex=0;
            label1.Text="Enter First Number:";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location=new Point(10, 117);
            label2.Name="label2";
            label2.Size=new Size(166, 21);
            label2.TabIndex=1;
            label2.Text="Enter Second Number:";
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location=new Point(111, 156);
            label3.Name="label3";
            label3.Size=new Size(65, 21);
            label3.TabIndex=2;
            label3.Text="Answer:";
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput1.Location=new Point(182, 28);
            txtBoxInput1.Name="txtBoxInput1";
            txtBoxInput1.Size=new Size(160, 29);
            txtBoxInput1.TabIndex=3;
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput2.Location=new Point(182, 109);
            txtBoxInput2.Name="txtBoxInput2";
            txtBoxInput2.Size=new Size(160, 29);
            txtBoxInput2.TabIndex=4;
            // 
            // cbOperator
            // 
            cbOperator.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbOperator.FormattingEnabled=true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location=new Point(235, 68);
            cbOperator.Name="cbOperator";
            cbOperator.Size=new Size(44, 29);
            cbOperator.TabIndex=5;
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize=true;
            lblDisplayTotal.Font=new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTotal.Location=new Point(182, 156);
            lblDisplayTotal.Name="lblDisplayTotal";
            lblDisplayTotal.Size=new Size(0, 21);
            lblDisplayTotal.TabIndex=6;
            // 
            // btnEqual
            // 
            btnEqual.Font=new Font("Consolas", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnEqual.Location=new Point(203, 186);
            btnEqual.Name="btnEqual";
            btnEqual.Size=new Size(114, 27);
            btnEqual.TabIndex=7;
            btnEqual.Text="Calculate";
            btnEqual.UseVisualStyleBackColor=true;
            btnEqual.Click+=btnEqual_Click;
            // 
            // FrmCalculator
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            ClientSize=new Size(389, 235);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(cbOperator);
            Controls.Add(txtBoxInput2);
            Controls.Add(txtBoxInput1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name="FrmCalculator";
            Text="FrmCalculator";
            Load+=FrmCalculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtBoxInput1;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}