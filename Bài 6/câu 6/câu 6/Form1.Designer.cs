namespace câu_6
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
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            picBig = new PictureBox();
            picSmall = new PictureBox();
            chkVisble = new CheckBox();
            groupBox3 = new GroupBox();
            btnExit = new Button();
            btnClear = new Button();
            btnDisplay = new Button();
            groupBox2 = new GroupBox();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radGreen = new RadioButton();
            radRed = new RadioButton();
            txtMessage = new TextBox();
            label2 = new Label();
            txtName = new TextBox();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            toolTip2 = new ToolTip(components);
            lblMessage = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picSmall).BeginInit();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picBig);
            groupBox1.Controls.Add(picSmall);
            groupBox1.Controls.Add(chkVisble);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(txtMessage);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(76, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(480, 357);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "InputName & Message";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // picBig
            // 
            picBig.Image = Properties.Resources._20240407_124828;
            picBig.Location = new Point(202, 225);
            picBig.Name = "picBig";
            picBig.Size = new Size(95, 72);
            picBig.TabIndex = 8;
            picBig.TabStop = false;
            picBig.Click += picBig_Click;
            // 
            // picSmall
            // 
            picSmall.Image = Properties.Resources._20240407_124828;
            picSmall.Location = new Point(218, 203);
            picSmall.Name = "picSmall";
            picSmall.Size = new Size(57, 44);
            picSmall.TabIndex = 7;
            picSmall.TabStop = false;
            picSmall.Click += pictureBox1_Click;
            // 
            // chkVisble
            // 
            chkVisble.AutoSize = true;
            chkVisble.Location = new Point(177, 149);
            chkVisble.Name = "chkVisble";
            chkVisble.Size = new Size(133, 24);
            chkVisble.TabIndex = 6;
            chkVisble.Text = "Message Visble";
            chkVisble.UseVisualStyleBackColor = true;
            chkVisble.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnExit);
            groupBox3.Controls.Add(btnClear);
            groupBox3.Controls.Add(btnDisplay);
            groupBox3.Location = new Point(323, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(151, 196);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Action";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(26, 142);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 2;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(26, 77);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 1;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDisplay
            // 
            btnDisplay.Location = new Point(26, 26);
            btnDisplay.Name = "btnDisplay";
            btnDisplay.Size = new Size(94, 29);
            btnDisplay.TabIndex = 0;
            btnDisplay.Text = "Display";
            btnDisplay.UseVisualStyleBackColor = true;
            btnDisplay.Click += btnDisplay_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radBlack);
            groupBox2.Controls.Add(radBlue);
            groupBox2.Controls.Add(radGreen);
            groupBox2.Controls.Add(radRed);
            groupBox2.Location = new Point(15, 156);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(147, 195);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Color";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlack.ForeColor = Color.Black;
            radBlack.Location = new Point(20, 156);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(67, 24);
            radBlack.TabIndex = 3;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Cursor = Cursors.SizeAll;
            radBlue.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radBlue.ForeColor = Color.Blue;
            radBlue.Location = new Point(20, 117);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(61, 24);
            radBlue.TabIndex = 2;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radGreen
            // 
            radGreen.AutoSize = true;
            radGreen.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radGreen.ForeColor = Color.Green;
            radGreen.Location = new Point(20, 78);
            radGreen.Name = "radGreen";
            radGreen.Size = new Size(72, 24);
            radGreen.TabIndex = 1;
            radGreen.TabStop = true;
            radGreen.Text = "Green";
            radGreen.UseVisualStyleBackColor = true;
            radGreen.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            radRed.ForeColor = Color.Red;
            radRed.Location = new Point(20, 38);
            radRed.Name = "radRed";
            radRed.Size = new Size(57, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(142, 80);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(253, 27);
            txtMessage.TabIndex = 3;
            txtMessage.TextChanged += textBox2_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 87);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Message:";
            label2.Click += label2_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(142, 38);
            txtName.Name = "txtName";
            txtName.Size = new Size(253, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 45);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // toolTip1
            // 
            toolTip1.Popup += toolTip1_Popup;
            // 
            // toolTip2
            // 
            toolTip2.Popup += toolTip2_Popup;
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.BackColor = Color.LightCoral;
            lblMessage.Location = new Point(91, 411);
            lblMessage.MinimumSize = new Size(450, 30);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(450, 30);
            lblMessage.TabIndex = 1;
            lblMessage.Click += lblMessage_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMessage);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += frmDinhDang;
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBig).EndInit();
            ((System.ComponentModel.ISupportInitialize)picSmall).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private TextBox txtName;
        private TextBox txtMessage;
        private Label label2;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radGreen;
        private RadioButton radRed;
        private PictureBox picSmall;
        private CheckBox chkVisble;
        private PictureBox picBig;
        private Button btnExit;
        private Button btnClear;
        private Button btnDisplay;
        private ToolTip toolTip1;
        private ToolTip toolTip2;
        private Label lblMessage;
    }
}
