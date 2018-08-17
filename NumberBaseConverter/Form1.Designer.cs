namespace NumberBaseConverter
{
    partial class frmSolver
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
            this.nudNumBase = new System.Windows.Forms.NumericUpDown();
            this.nudAnswerBase = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Number = new System.Windows.Forms.Label();
            this.btnSolve = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnswerBase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // nudNumBase
            // 
            this.nudNumBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumBase.Location = new System.Drawing.Point(33, 55);
            this.nudNumBase.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.nudNumBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumBase.Name = "nudNumBase";
            this.nudNumBase.Size = new System.Drawing.Size(156, 38);
            this.nudNumBase.TabIndex = 0;
            this.nudNumBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nudAnswerBase
            // 
            this.nudAnswerBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAnswerBase.Location = new System.Drawing.Point(226, 55);
            this.nudAnswerBase.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.nudAnswerBase.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudAnswerBase.Name = "nudAnswerBase";
            this.nudAnswerBase.Size = new System.Drawing.Size(156, 38);
            this.nudAnswerBase.TabIndex = 1;
            this.nudAnswerBase.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Number Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Answer Base";
            // 
            // Number
            // 
            this.Number.AutoSize = true;
            this.Number.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Number.Location = new System.Drawing.Point(28, 137);
            this.Number.Name = "Number";
            this.Number.Size = new System.Drawing.Size(100, 29);
            this.Number.TabIndex = 6;
            this.Number.Text = "Number";
            // 
            // btnSolve
            // 
            this.btnSolve.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolve.Location = new System.Drawing.Point(33, 233);
            this.btnSolve.Name = "btnSolve";
            this.btnSolve.Size = new System.Drawing.Size(349, 72);
            this.btnSolve.TabIndex = 7;
            this.btnSolve.Text = "Solve";
            this.btnSolve.UseVisualStyleBackColor = true;
            this.btnSolve.Click += new System.EventHandler(this.btnSolve_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumber.Location = new System.Drawing.Point(28, 354);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(0, 29);
            this.lblNumber.TabIndex = 8;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnswer.Location = new System.Drawing.Point(28, 423);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(0, 29);
            this.lblAnswer.TabIndex = 9;
            // 
            // nudNumber
            // 
            this.nudNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumber.Location = new System.Drawing.Point(33, 169);
            this.nudNumber.Maximum = new decimal(new int[] {
            -559939584,
            902409669,
            54,
            0});
            this.nudNumber.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(349, 38);
            this.nudNumber.TabIndex = 10;
            this.nudNumber.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // frmSolver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 524);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnSolve);
            this.Controls.Add(this.Number);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAnswerBase);
            this.Controls.Add(this.nudNumBase);
            this.Name = "frmSolver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Base Solver";
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnswerBase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudNumBase;
        private System.Windows.Forms.NumericUpDown nudAnswerBase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Number;
        private System.Windows.Forms.Button btnSolve;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.NumericUpDown nudNumber;
    }
}

