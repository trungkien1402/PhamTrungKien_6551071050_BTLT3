namespace Cau5
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
            label1 = new Label();
            txtNhapTen = new TextBox();
            radRed = new RadioButton();
            groupBox1 = new GroupBox();
            radBlack = new RadioButton();
            radGreen = new RadioButton();
            radBlue = new RadioButton();
            groupBox2 = new GroupBox();
            chkU = new CheckBox();
            chkI = new CheckBox();
            chkBold = new CheckBox();
            label2 = new Label();
            lblLapTrinh = new TextBox();
            Thoat = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 96);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Nhap ten";
            // 
            // txtNhapTen
            // 
            txtNhapTen.Location = new Point(237, 91);
            txtNhapTen.Name = "txtNhapTen";
            txtNhapTen.Size = new Size(315, 27);
            txtNhapTen.TabIndex = 1;
            txtNhapTen.TextChanged += txtNhapTen_TextChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(61, 26);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 2;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radBlack);
            groupBox1.Controls.Add(radGreen);
            groupBox1.Controls.Add(radBlue);
            groupBox1.Controls.Add(radRed);
            groupBox1.Location = new Point(110, 155);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(247, 210);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Color";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radBlack.ForeColor = Color.Black;
            radBlack.Location = new Point(61, 171);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 5;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(61, 74);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 3;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radGreen_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(61, 123);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(58, 26);
            radBlue.TabIndex = 4;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseCompatibleTextRendering = true;
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chkU);
            groupBox2.Controls.Add(chkI);
            groupBox2.Controls.Add(chkBold);
            groupBox2.Location = new Point(443, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 210);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Font";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // chkU
            // 
            chkU.AutoSize = true;
            chkU.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point, 163);
            chkU.ForeColor = Color.Navy;
            chkU.Location = new Point(57, 137);
            chkU.Name = "chkU";
            chkU.Size = new Size(99, 24);
            chkU.TabIndex = 2;
            chkU.Text = "Gạch chân";
            chkU.UseVisualStyleBackColor = true;
            chkU.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // chkI
            // 
            chkI.AutoSize = true;
            chkI.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 163);
            chkI.ForeColor = Color.Navy;
            chkI.Location = new Point(57, 89);
            chkI.Name = "chkI";
            chkI.Size = new Size(101, 24);
            chkI.TabIndex = 1;
            chkI.Text = "In Nghiêng";
            chkI.UseVisualStyleBackColor = true;
            chkI.CheckedChanged += chkI_CheckedChanged;
            // 
            // chkBold
            // 
            chkBold.AutoSize = true;
            chkBold.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            chkBold.ForeColor = Color.Navy;
            chkBold.Location = new Point(57, 46);
            chkBold.Name = "chkBold";
            chkBold.Size = new Size(82, 24);
            chkBold.TabIndex = 0;
            chkBold.Text = "In Đậm";
            chkBold.UseVisualStyleBackColor = true;
            chkBold.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 394);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 5;
            label2.Text = "Lap Trinh Boi";
            label2.Click += label2_Click;
            // 
            // lblLapTrinh
            // 
            lblLapTrinh.BackColor = SystemColors.ScrollBar;
            lblLapTrinh.Location = new Point(323, 388);
            lblLapTrinh.Name = "lblLapTrinh";
            lblLapTrinh.Size = new Size(225, 27);
            lblLapTrinh.TabIndex = 6;
            // 
            // Thoat
            // 
            Thoat.Location = new Point(600, 382);
            Thoat.Name = "Thoat";
            Thoat.Size = new Size(66, 40);
            Thoat.TabIndex = 7;
            Thoat.Text = "Thoat";
            Thoat.UseVisualStyleBackColor = true;
            Thoat.Click += Thoat_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Thoat);
            Controls.Add(lblLapTrinh);
            Controls.Add(label2);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(txtNhapTen);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Dinh Dang";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNhapTen;
        private RadioButton radRed;
        private GroupBox groupBox1;
        private RadioButton radGreen;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private GroupBox groupBox2;
        private CheckBox chkU;
        private CheckBox chkI;
        private CheckBox chkBold;
        private Label label2;
        private TextBox lblLapTrinh;
        private Button Thoat;
    }
}
