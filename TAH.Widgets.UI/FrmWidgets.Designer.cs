namespace TAH.Widgets.UI
{
    partial class FrmWidgets
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
            btnGenerate = new Button();
            lblResult = new Label();
            lblMessage = new Label();
            btnCatchMe = new Button();
            tmrGame = new System.Windows.Forms.Timer(components);
            lblTimer = new Label();
            lblTimerCaption = new Label();
            lblTimerCaption2 = new Label();
            SuspendLayout();
            // 
            // btnGenerate
            // 
            btnGenerate.Location = new Point(62, 42);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(83, 34);
            btnGenerate.TabIndex = 0;
            btnGenerate.Text = "Generate";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // lblResult
            // 
            lblResult.BackColor = Color.White;
            lblResult.BorderStyle = BorderStyle.Fixed3D;
            lblResult.FlatStyle = FlatStyle.Popup;
            lblResult.Location = new Point(62, 92);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(83, 37);
            lblResult.TabIndex = 1;
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblMessage
            // 
            lblMessage.BackColor = SystemColors.Control;
            lblMessage.FlatStyle = FlatStyle.Flat;
            lblMessage.Location = new Point(62, 140);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(83, 28);
            lblMessage.TabIndex = 2;
            lblMessage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCatchMe
            // 
            btnCatchMe.Location = new Point(345, 189);
            btnCatchMe.Name = "btnCatchMe";
            btnCatchMe.Size = new Size(83, 34);
            btnCatchMe.TabIndex = 3;
            btnCatchMe.Text = "Press Me";
            btnCatchMe.UseVisualStyleBackColor = true;
            btnCatchMe.Click += btnCatchMe_Click;
            // 
            // tmrGame
            // 
            tmrGame.Enabled = true;
            tmrGame.Interval = 1000;
            tmrGame.Tick += tmrGame_Tick;
            // 
            // lblTimer
            // 
            lblTimer.AutoSize = true;
            lblTimer.Font = new Font("Segoe UI", 18F);
            lblTimer.Location = new Point(323, 327);
            lblTimer.Name = "lblTimer";
            lblTimer.Size = new Size(133, 32);
            lblTimer.TabIndex = 4;
            lblTimer.Text = "00:00:00:00";
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimerCaption
            // 
            lblTimerCaption.AutoSize = true;
            lblTimerCaption.Font = new Font("Segoe UI", 18F);
            lblTimerCaption.Location = new Point(225, 295);
            lblTimerCaption.Name = "lblTimerCaption";
            lblTimerCaption.Size = new Size(329, 32);
            lblTimerCaption.TabIndex = 5;
            lblTimerCaption.Text = "Countdown to Chrismas 2026";
            lblTimerCaption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTimerCaption2
            // 
            lblTimerCaption2.AutoSize = true;
            lblTimerCaption2.Font = new Font("Segoe UI", 18F);
            lblTimerCaption2.Location = new Point(260, 360);
            lblTimerCaption2.Name = "lblTimerCaption2";
            lblTimerCaption2.Size = new Size(0, 32);
            lblTimerCaption2.TabIndex = 6;
            lblTimerCaption2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmWidgets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTimerCaption2);
            Controls.Add(lblTimerCaption);
            Controls.Add(lblTimer);
            Controls.Add(btnCatchMe);
            Controls.Add(lblMessage);
            Controls.Add(lblResult);
            Controls.Add(btnGenerate);
            Name = "FrmWidgets";
            Text = "Widgets";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerate;
        private Label lblResult;
        private Label lblMessage;
        private Button btnCatchMe;
        private System.Windows.Forms.Timer tmrGame;
        private Label lblTimer;
        private Label lblTimerCaption;
        private Label lblTimerCaption2;
    }
}
