namespace COMP1551_coursework
{
    partial class Form1
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
            StringTBI = new TextBox();
            OutputTB = new TextBox();
            SortedTB = new TextBox();
            EncryptBtn = new Button();
            InputALB = new Label();
            OutputLB = new Label();
            SortedOutputLB = new Label();
            Title = new Label();
            NumLB = new Label();
            EncNumI = new NumericUpDown();
            label3 = new Label();
            SortedTB2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)EncNumI).BeginInit();
            SuspendLayout();
            // 
            // StringTBI
            // 
            StringTBI.Location = new Point(291, 73);
            StringTBI.MaxLength = 40;
            StringTBI.Name = "StringTBI";
            StringTBI.Size = new Size(340, 27);
            StringTBI.TabIndex = 0;
            // 
            // OutputTB
            // 
            OutputTB.Location = new Point(291, 151);
            OutputTB.Name = "OutputTB";
            OutputTB.ReadOnly = true;
            OutputTB.Size = new Size(235, 27);
            OutputTB.TabIndex = 1;
            // 
            // SortedTB
            // 
            SortedTB.Location = new Point(291, 184);
            SortedTB.Name = "SortedTB";
            SortedTB.ReadOnly = true;
            SortedTB.Size = new Size(235, 27);
            SortedTB.TabIndex = 2;
            // 
            // EncryptBtn
            // 
            EncryptBtn.Location = new Point(291, 106);
            EncryptBtn.Name = "EncryptBtn";
            EncryptBtn.Size = new Size(125, 29);
            EncryptBtn.TabIndex = 3;
            EncryptBtn.Text = "Encrypt and sort";
            EncryptBtn.UseVisualStyleBackColor = true;
            EncryptBtn.Click += EncryptBtn_Click;
            // 
            // InputALB
            // 
            InputALB.AutoSize = true;
            InputALB.Location = new Point(126, 80);
            InputALB.Name = "InputALB";
            InputALB.Size = new Size(159, 20);
            InputALB.TabIndex = 4;
            InputALB.Text = "Input Capital Alphabet";
            // 
            // OutputLB
            // 
            OutputLB.AutoSize = true;
            OutputLB.Location = new Point(224, 154);
            OutputLB.Name = "OutputLB";
            OutputLB.Size = new Size(55, 20);
            OutputLB.TabIndex = 5;
            OutputLB.Text = "Output";
            // 
            // SortedOutputLB
            // 
            SortedOutputLB.AutoSize = true;
            SortedOutputLB.Location = new Point(186, 204);
            SortedOutputLB.Name = "SortedOutputLB";
            SortedOutputLB.RightToLeft = RightToLeft.No;
            SortedOutputLB.Size = new Size(99, 20);
            SortedOutputLB.TabIndex = 6;
            SortedOutputLB.Text = "SortedOutput";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(323, 25);
            Title.Name = "Title";
            Title.Size = new Size(137, 20);
            Title.TabIndex = 8;
            Title.Text = "Alphabet Encryptor";
            // 
            // NumLB
            // 
            NumLB.AutoSize = true;
            NumLB.Location = new Point(478, 110);
            NumLB.Name = "NumLB";
            NumLB.Size = new Size(153, 20);
            NumLB.TabIndex = 9;
            NumLB.Text = "Insert encrypt number";
            // 
            // EncNumI
            // 
            EncNumI.Location = new Point(422, 108);
            EncNumI.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            EncNumI.Minimum = new decimal(new int[] { 25, 0, 0, int.MinValue });
            EncNumI.Name = "EncNumI";
            EncNumI.Size = new Size(50, 27);
            EncNumI.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 421);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 11;
            label3.Text = "...";
            // 
            // SortedTB2
            // 
            SortedTB2.Location = new Point(291, 217);
            SortedTB2.Name = "SortedTB2";
            SortedTB2.ReadOnly = true;
            SortedTB2.Size = new Size(235, 27);
            SortedTB2.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SortedTB2);
            Controls.Add(label3);
            Controls.Add(EncNumI);
            Controls.Add(NumLB);
            Controls.Add(Title);
            Controls.Add(SortedOutputLB);
            Controls.Add(OutputLB);
            Controls.Add(InputALB);
            Controls.Add(EncryptBtn);
            Controls.Add(SortedTB);
            Controls.Add(OutputTB);
            Controls.Add(StringTBI);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)EncNumI).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox StringTBI;
        private TextBox OutputTB;
        private TextBox SortedTB;
        private Button EncryptBtn;
        private Label InputALB;
        private Label OutputLB;
        private Label SortedOutputLB;
        private Label NumLB;
        private Label Title;
        private NumericUpDown EncNumI;
        private Label label3;
        private TextBox SortedTB2;
    }
}
