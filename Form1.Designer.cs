namespace GPAXM
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
            lbinputGPA = new Label();
            tbinputGPA = new TextBox();
            tbGPAX = new TextBox();
            tbGPAMax = new TextBox();
            tbGPAMin = new TextBox();
            btAdd = new Button();
            lbGPAX = new Label();
            lbGPAMax = new Label();
            inGPAMIn = new Label();
            btReset = new Button();
            lbGPAList = new ListBox();
            SuspendLayout();
            // 
            // lbinputGPA
            // 
            lbinputGPA.AutoSize = true;
            lbinputGPA.ForeColor = SystemColors.ControlDarkDark;
            lbinputGPA.Location = new Point(121, 76);
            lbinputGPA.Name = "lbinputGPA";
            lbinputGPA.Size = new Size(93, 20);
            lbinputGPA.TabIndex = 0;
            lbinputGPA.Text = "ใส่คะแนน GPA";
            // 
            // tbinputGPA
            // 
            tbinputGPA.ForeColor = SystemColors.ControlDarkDark;
            tbinputGPA.Location = new Point(250, 69);
            tbinputGPA.Name = "tbinputGPA";
            tbinputGPA.Size = new Size(125, 27);
            tbinputGPA.TabIndex = 1;
            // 
            // tbGPAX
            // 
            tbGPAX.ForeColor = SystemColors.ControlDarkDark;
            tbGPAX.Location = new Point(250, 146);
            tbGPAX.Name = "tbGPAX";
            tbGPAX.Size = new Size(125, 27);
            tbGPAX.TabIndex = 2;
            // 
            // tbGPAMax
            // 
            tbGPAMax.ForeColor = SystemColors.ControlDarkDark;
            tbGPAMax.Location = new Point(250, 197);
            tbGPAMax.Name = "tbGPAMax";
            tbGPAMax.Size = new Size(125, 27);
            tbGPAMax.TabIndex = 3;
            // 
            // tbGPAMin
            // 
            tbGPAMin.ForeColor = SystemColors.ControlDarkDark;
            tbGPAMin.Location = new Point(249, 251);
            tbGPAMin.Name = "tbGPAMin";
            tbGPAMin.Size = new Size(125, 27);
            tbGPAMin.TabIndex = 4;
            // 
            // btAdd
            // 
            btAdd.BackColor = SystemColors.AppWorkspace;
            btAdd.ForeColor = SystemColors.ButtonHighlight;
            btAdd.Location = new Point(415, 69);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(94, 27);
            btAdd.TabIndex = 5;
            btAdd.Text = "AddData";
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // lbGPAX
            // 
            lbGPAX.AutoSize = true;
            lbGPAX.ForeColor = SystemColors.ControlDarkDark;
            lbGPAX.Location = new Point(126, 153);
            lbGPAX.Name = "lbGPAX";
            lbGPAX.Size = new Size(90, 20);
            lbGPAX.TabIndex = 6;
            lbGPAX.Text = "GPA เฉลี่ยรวม";
            // 
            // lbGPAMax
            // 
            lbGPAMax.AutoSize = true;
            lbGPAMax.ForeColor = SystemColors.ControlDarkDark;
            lbGPAMax.Location = new Point(142, 200);
            lbGPAMax.Name = "lbGPAMax";
            lbGPAMax.Size = new Size(71, 20);
            lbGPAMax.TabIndex = 7;
            lbGPAMax.Text = "GPA สูงสุด";
            // 
            // inGPAMIn
            // 
            inGPAMIn.AutoSize = true;
            inGPAMIn.ForeColor = SystemColors.ControlDarkDark;
            inGPAMIn.Location = new Point(139, 251);
            inGPAMIn.Name = "inGPAMIn";
            inGPAMIn.Size = new Size(73, 20);
            inGPAMIn.TabIndex = 8;
            inGPAMIn.Text = "GPA ต่ำสุด";
            // 
            // btReset
            // 
            btReset.BackColor = SystemColors.AppWorkspace;
            btReset.ForeColor = SystemColors.ButtonHighlight;
            btReset.Location = new Point(240, 328);
            btReset.Name = "btReset";
            btReset.Size = new Size(79, 29);
            btReset.TabIndex = 9;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = false;
            btReset.Click += btReset_Click;
            // 
            // lbGPAList
            // 
            lbGPAList.BackColor = SystemColors.Menu;
            lbGPAList.ForeColor = SystemColors.ControlDarkDark;
            lbGPAList.FormattingEnabled = true;
            lbGPAList.Location = new Point(44, 112);
            lbGPAList.Name = "lbGPAList";
            lbGPAList.Size = new Size(483, 184);
            lbGPAList.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(559, 391);
            Controls.Add(btReset);
            Controls.Add(inGPAMIn);
            Controls.Add(lbGPAMax);
            Controls.Add(lbGPAX);
            Controls.Add(btAdd);
            Controls.Add(tbGPAMin);
            Controls.Add(tbGPAMax);
            Controls.Add(tbGPAX);
            Controls.Add(tbinputGPA);
            Controls.Add(lbinputGPA);
            Controls.Add(lbGPAList);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbinputGPA;
        private TextBox tbinputGPA;
        private TextBox tbGPAX;
        private TextBox tbGPAMax;
        private TextBox tbGPAMin;
        private Button btAdd;
        private Label lbGPAX;
        private Label lbGPAMax;
        private Label inGPAMIn;
        private Button btReset;
        private ListBox lbGPAList;
    }
}
