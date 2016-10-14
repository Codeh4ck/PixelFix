namespace PixelFix
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvColors = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdRemoveSelected = new System.Windows.Forms.Button();
            this.cmdAddColor = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numRotatorDuration = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.cmdBegin = new System.Windows.Forms.Button();
            this.cmdReadMe = new System.Windows.Forms.Button();
            this.timerThreadStopper = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRotatorDuration)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvColors);
            this.groupBox1.Controls.Add(this.cmdRemoveSelected);
            this.groupBox1.Controls.Add(this.cmdAddColor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numRotatorDuration);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 248);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rotator settings...";
            // 
            // lvColors
            // 
            this.lvColors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lvColors.Location = new System.Drawing.Point(16, 95);
            this.lvColors.Name = "lvColors";
            this.lvColors.Size = new System.Drawing.Size(245, 112);
            this.lvColors.TabIndex = 6;
            this.lvColors.UseCompatibleStateImageBehavior = false;
            this.lvColors.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Color Value";
            this.columnHeader1.Width = 207;
            // 
            // cmdRemoveSelected
            // 
            this.cmdRemoveSelected.Location = new System.Drawing.Point(111, 213);
            this.cmdRemoveSelected.Name = "cmdRemoveSelected";
            this.cmdRemoveSelected.Size = new System.Drawing.Size(150, 23);
            this.cmdRemoveSelected.TabIndex = 5;
            this.cmdRemoveSelected.Text = "Remove selected...";
            this.cmdRemoveSelected.UseVisualStyleBackColor = true;
            this.cmdRemoveSelected.Click += new System.EventHandler(this.cmdRemoveSelected_Click);
            // 
            // cmdAddColor
            // 
            this.cmdAddColor.Location = new System.Drawing.Point(16, 213);
            this.cmdAddColor.Name = "cmdAddColor";
            this.cmdAddColor.Size = new System.Drawing.Size(89, 23);
            this.cmdAddColor.TabIndex = 4;
            this.cmdAddColor.Text = "Add color...";
            this.cmdAddColor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cmdAddColor.UseVisualStyleBackColor = true;
            this.cmdAddColor.Click += new System.EventHandler(this.cmdAddColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Rotator colors:";
            // 
            // numRotatorDuration
            // 
            this.numRotatorDuration.Location = new System.Drawing.Point(16, 46);
            this.numRotatorDuration.Name = "numRotatorDuration";
            this.numRotatorDuration.Size = new System.Drawing.Size(245, 21);
            this.numRotatorDuration.TabIndex = 1;
            this.numRotatorDuration.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRotatorDuration.ValueChanged += new System.EventHandler(this.numRotatorDuration_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rotation duration (minutes):";
            // 
            // cmdBegin
            // 
            this.cmdBegin.Location = new System.Drawing.Point(203, 266);
            this.cmdBegin.Name = "cmdBegin";
            this.cmdBegin.Size = new System.Drawing.Size(90, 23);
            this.cmdBegin.TabIndex = 1;
            this.cmdBegin.Text = "Begin fix!";
            this.cmdBegin.UseVisualStyleBackColor = true;
            this.cmdBegin.Click += new System.EventHandler(this.cmdBegin_Click);
            // 
            // cmdReadMe
            // 
            this.cmdReadMe.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.cmdReadMe.ForeColor = System.Drawing.Color.Red;
            this.cmdReadMe.Location = new System.Drawing.Point(13, 266);
            this.cmdReadMe.Name = "cmdReadMe";
            this.cmdReadMe.Size = new System.Drawing.Size(90, 23);
            this.cmdReadMe.TabIndex = 2;
            this.cmdReadMe.Text = "README";
            this.cmdReadMe.UseVisualStyleBackColor = true;
            this.cmdReadMe.Click += new System.EventHandler(this.cmdReadMe_Click);
            // 
            // timerThreadStopper
            // 
            this.timerThreadStopper.Interval = 3000;
            this.timerThreadStopper.Tick += new System.EventHandler(this.timerThreadStopper_Tick);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 301);
            this.Controls.Add(this.cmdReadMe);
            this.Controls.Add(this.cmdBegin);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pixel Fix";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMain_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRotatorDuration)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdRemoveSelected;
        private System.Windows.Forms.Button cmdAddColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numRotatorDuration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmdBegin;
        private System.Windows.Forms.Button cmdReadMe;
        private System.Windows.Forms.ListView lvColors;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Timer timerThreadStopper;
    }
}

