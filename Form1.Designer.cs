namespace NEUTRINO_GUIs
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
            this.RUN = new System.Windows.Forms.Button();
            this.musicFileSelect = new System.Windows.Forms.Button();
            this.scorefile = new System.Windows.Forms.Label();
            this.runFileSellect = new System.Windows.Forms.Button();
            this.whereRunfile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RUN
            // 
            this.RUN.BackColor = System.Drawing.SystemColors.Control;
            this.RUN.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RUN.Location = new System.Drawing.Point(354, 357);
            this.RUN.Name = "RUN";
            this.RUN.Size = new System.Drawing.Size(100, 30);
            this.RUN.TabIndex = 0;
            this.RUN.Text = "RUN";
            this.RUN.UseVisualStyleBackColor = false;
            this.RUN.Click += new System.EventHandler(this.RUN_Click);
            // 
            // musicFileSelect
            // 
            this.musicFileSelect.BackColor = System.Drawing.SystemColors.Control;
            this.musicFileSelect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.musicFileSelect.Location = new System.Drawing.Point(342, 276);
            this.musicFileSelect.Name = "musicFileSelect";
            this.musicFileSelect.Size = new System.Drawing.Size(130, 30);
            this.musicFileSelect.TabIndex = 1;
            this.musicFileSelect.Text = "楽譜ファイルを選択";
            this.musicFileSelect.UseVisualStyleBackColor = false;
            this.musicFileSelect.Click += new System.EventHandler(this.楽譜ファイル選択_Click);
            // 
            // scorefile
            // 
            this.scorefile.AutoSize = true;
            this.scorefile.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scorefile.ForeColor = System.Drawing.SystemColors.Control;
            this.scorefile.Location = new System.Drawing.Point(145, 259);
            this.scorefile.Name = "scorefile";
            this.scorefile.Size = new System.Drawing.Size(532, 14);
            this.scorefile.TabIndex = 2;
            this.scorefile.Text = "C:\\Program Files\\NEUTRINO\\NEUTRINO-Windows_v0.510\\NEUTRINO\\score\\musicxml¥1\r\n";
            // 
            // runFileSellect
            // 
            this.runFileSellect.BackColor = System.Drawing.SystemColors.Control;
            this.runFileSellect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.runFileSellect.Location = new System.Drawing.Point(341, 165);
            this.runFileSellect.Name = "runFileSellect";
            this.runFileSellect.Size = new System.Drawing.Size(130, 30);
            this.runFileSellect.TabIndex = 3;
            this.runFileSellect.Text = "Runファイルを選択";
            this.runFileSellect.UseVisualStyleBackColor = false;
            this.runFileSellect.Click += new System.EventHandler(this.runFileSellect_Click);
            // 
            // whereRunfile
            // 
            this.whereRunfile.AutoSize = true;
            this.whereRunfile.ForeColor = System.Drawing.SystemColors.Control;
            this.whereRunfile.Location = new System.Drawing.Point(235, 147);
            this.whereRunfile.Name = "whereRunfile";
            this.whereRunfile.Size = new System.Drawing.Size(359, 15);
            this.whereRunfile.TabIndex = 4;
            this.whereRunfile.Text = "C:\\Program Files\\NEUTRINO\\NEUTRINO-Widnows_v0.500¥Run.bat\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.whereRunfile);
            this.Controls.Add(this.runFileSellect);
            this.Controls.Add(this.scorefile);
            this.Controls.Add(this.musicFileSelect);
            this.Controls.Add(this.RUN);
            this.Name = "Form1";
            this.Text = "NEUTRINO_GUIs";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button RUN;
        private Button musicFileSelect;
        private Label scorefile;
        private Button runFileSellect;
        private Label whereRunfile;
    }
}