namespace ClickerIDLE
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
            scoreLabel = new Label();
            cpsLabel = new Label();
            timer = new System.Windows.Forms.Timer(components);
            button = new Button();
            progressBar = new ProgressBar();
            grid = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)grid).BeginInit();
            SuspendLayout();
            // 
            // scoreLabel
            // 
            scoreLabel.Anchor = AnchorStyles.Top;
            scoreLabel.Font = new Font("Showcard Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(105, 26);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(364, 44);
            scoreLabel.TabIndex = 0;
            scoreLabel.Text = "Score will be here";
            scoreLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cpsLabel
            // 
            cpsLabel.Anchor = AnchorStyles.Top;
            cpsLabel.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cpsLabel.Location = new Point(105, 70);
            cpsLabel.Name = "cpsLabel";
            cpsLabel.Size = new Size(364, 36);
            cpsLabel.TabIndex = 1;
            cpsLabel.Text = "CPS will be here";
            cpsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            timer.Interval = 1000;
            timer.Tick += timer1_Tick;
            // 
            // button
            // 
            button.Anchor = AnchorStyles.Top;
            button.Font = new Font("Showcard Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button.Location = new Point(231, 452);
            button.Name = "button";
            button.Size = new Size(112, 49);
            button.TabIndex = 4;
            button.Text = "click";
            button.UseVisualStyleBackColor = true;
            button.Click += button1_Click;
            // 
            // progressBar
            // 
            progressBar.Anchor = AnchorStyles.Top;
            progressBar.Location = new Point(105, 109);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(364, 23);
            progressBar.TabIndex = 5;
            // 
            // grid
            // 
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grid.BackgroundColor = SystemColors.ActiveCaption;
            grid.BorderStyle = BorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid.Location = new Point(12, 147);
            grid.Name = "grid";
            grid.ReadOnly = true;
            grid.Size = new Size(550, 290);
            grid.TabIndex = 6;
            grid.DataBindingComplete += grid_DataBindingComplete;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(574, 678);
            Controls.Add(grid);
            Controls.Add(progressBar);
            Controls.Add(button);
            Controls.Add(cpsLabel);
            Controls.Add(scoreLabel);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label scoreLabel;
        private Label cpsLabel;
        private System.Windows.Forms.Timer timer;
        private Button button;
        private ProgressBar progressBar;
        private DataGridView grid;
    }
}
