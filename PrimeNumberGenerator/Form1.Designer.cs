namespace PrimeNumberGenerator
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnSeq = new System.Windows.Forms.Button();
            this.btnParallel = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblPrimeCount = new System.Windows.Forms.Label();
            this.lbPrimeNumbers = new System.Windows.Forms.ListBox();
            this.numUDStart = new System.Windows.Forms.NumericUpDown();
            this.numUDEnd = new System.Windows.Forms.NumericUpDown();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numUDStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEnd)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeq
            // 
            this.btnSeq.Location = new System.Drawing.Point(12, 12);
            this.btnSeq.Name = "btnSeq";
            this.btnSeq.Size = new System.Drawing.Size(250, 40);
            this.btnSeq.TabIndex = 0;
            this.btnSeq.Text = "Sequential";
            this.btnSeq.UseVisualStyleBackColor = true;
            this.btnSeq.Click += new System.EventHandler(this.btnSeq_Click);
            // 
            // btnParallel
            // 
            this.btnParallel.Location = new System.Drawing.Point(318, 12);
            this.btnParallel.Name = "btnParallel";
            this.btnParallel.Size = new System.Drawing.Size(250, 40);
            this.btnParallel.TabIndex = 1;
            this.btnParallel.Text = "Parallel";
            this.btnParallel.UseVisualStyleBackColor = true;
            this.btnParallel.Click += new System.EventHandler(this.btnParallel_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(343, 57);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(0, 17);
            this.lblTime.TabIndex = 2;
            // 
            // lblPrimeCount
            // 
            this.lblPrimeCount.AutoSize = true;
            this.lblPrimeCount.Location = new System.Drawing.Point(343, 86);
            this.lblPrimeCount.Name = "lblPrimeCount";
            this.lblPrimeCount.Size = new System.Drawing.Size(0, 17);
            this.lblPrimeCount.TabIndex = 3;
            // 
            // lbPrimeNumbers
            // 
            this.lbPrimeNumbers.FormattingEnabled = true;
            this.lbPrimeNumbers.ItemHeight = 16;
            this.lbPrimeNumbers.Location = new System.Drawing.Point(12, 124);
            this.lbPrimeNumbers.Name = "lbPrimeNumbers";
            this.lbPrimeNumbers.Size = new System.Drawing.Size(352, 340);
            this.lbPrimeNumbers.TabIndex = 4;
            // 
            // numUDStart
            // 
            this.numUDStart.Location = new System.Drawing.Point(13, 57);
            this.numUDStart.Maximum = new decimal(new int[] {
            -727379968,
            232,
            0,
            0});
            this.numUDStart.Name = "numUDStart";
            this.numUDStart.Size = new System.Drawing.Size(298, 22);
            this.numUDStart.TabIndex = 5;
            this.numUDStart.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numUDEnd
            // 
            this.numUDEnd.Location = new System.Drawing.Point(13, 86);
            this.numUDEnd.Maximum = new decimal(new int[] {
            1874919424,
            2328306,
            0,
            0});
            this.numUDEnd.Name = "numUDEnd";
            this.numUDEnd.Size = new System.Drawing.Size(298, 22);
            this.numUDEnd.TabIndex = 6;
            this.numUDEnd.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numUDEnd.ValueChanged += new System.EventHandler(this.numUD_ValueChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 487);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numUDEnd);
            this.Controls.Add(this.numUDStart);
            this.Controls.Add(this.lbPrimeNumbers);
            this.Controls.Add(this.lblPrimeCount);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.btnParallel);
            this.Controls.Add(this.btnSeq);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numUDStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUDEnd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeq;
        private System.Windows.Forms.Button btnParallel;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblPrimeCount;
        private System.Windows.Forms.ListBox lbPrimeNumbers;
        private System.Windows.Forms.NumericUpDown numUDStart;
        private System.Windows.Forms.NumericUpDown numUDEnd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
    }
}

