namespace PacmanSimulator
{
    partial class PacmanPlay
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
            this.PacmanGroupBox = new System.Windows.Forms.GroupBox();
            this.lblReport = new System.Windows.Forms.Label();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.btnPlace = new System.Windows.Forms.Button();
            this.ddlDirection = new System.Windows.Forms.ComboBox();
            this.lblFacing = new System.Windows.Forms.Label();
            this.updownY = new System.Windows.Forms.NumericUpDown();
            this.lblY = new System.Windows.Forms.Label();
            this.updownX = new System.Windows.Forms.NumericUpDown();
            this.lblX = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.groupBoxReport = new System.Windows.Forms.GroupBox();
            this.groupBoxAction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownX)).BeginInit();
            this.groupBoxReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // PacmanGroupBox
            // 
            this.PacmanGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PacmanGroupBox.Location = new System.Drawing.Point(13, 13);
            this.PacmanGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.PacmanGroupBox.Name = "PacmanGroupBox";
            this.PacmanGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.PacmanGroupBox.Size = new System.Drawing.Size(265, 250);
            this.PacmanGroupBox.TabIndex = 3;
            this.PacmanGroupBox.TabStop = false;
            this.PacmanGroupBox.Text = "Pacman ";
            // 
            // lblReport
            // 
            this.lblReport.AutoSize = true;
            this.lblReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReport.Location = new System.Drawing.Point(16, 18);
            this.lblReport.Name = "lblReport";
            this.lblReport.Size = new System.Drawing.Size(57, 17);
            this.lblReport.TabIndex = 4;
            this.lblReport.Text = "Report";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.btnRight);
            this.groupBoxAction.Controls.Add(this.btnLeft);
            this.groupBoxAction.Controls.Add(this.btnMove);
            this.groupBoxAction.Controls.Add(this.btnPlace);
            this.groupBoxAction.Controls.Add(this.ddlDirection);
            this.groupBoxAction.Controls.Add(this.lblFacing);
            this.groupBoxAction.Controls.Add(this.updownY);
            this.groupBoxAction.Controls.Add(this.lblY);
            this.groupBoxAction.Controls.Add(this.updownX);
            this.groupBoxAction.Controls.Add(this.lblX);
            this.groupBoxAction.Location = new System.Drawing.Point(298, 13);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(250, 172);
            this.groupBoxAction.TabIndex = 5;
            this.groupBoxAction.TabStop = false;
            // 
            // btnMove
            // 
            this.btnMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMove.Location = new System.Drawing.Point(88, 134);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 29);
            this.btnMove.TabIndex = 7;
            this.btnMove.Text = "Move";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // btnPlace
            // 
            this.btnPlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlace.Location = new System.Drawing.Point(88, 98);
            this.btnPlace.Name = "btnPlace";
            this.btnPlace.Size = new System.Drawing.Size(75, 30);
            this.btnPlace.TabIndex = 6;
            this.btnPlace.Text = "Place";
            this.btnPlace.UseVisualStyleBackColor = true;
            this.btnPlace.Click += new System.EventHandler(this.btnPlace_Click);
            // 
            // ddlDirection
            // 
            this.ddlDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ddlDirection.FormattingEnabled = true;
            this.ddlDirection.Location = new System.Drawing.Point(115, 59);
            this.ddlDirection.Name = "ddlDirection";
            this.ddlDirection.Size = new System.Drawing.Size(92, 24);
            this.ddlDirection.TabIndex = 5;
            // 
            // lblFacing
            // 
            this.lblFacing.AutoSize = true;
            this.lblFacing.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacing.Location = new System.Drawing.Point(49, 59);
            this.lblFacing.Name = "lblFacing";
            this.lblFacing.Size = new System.Drawing.Size(56, 17);
            this.lblFacing.TabIndex = 4;
            this.lblFacing.Text = "Facing";
            // 
            // updownY
            // 
            this.updownY.Location = new System.Drawing.Point(169, 18);
            this.updownY.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updownY.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownY.Name = "updownY";
            this.updownY.Size = new System.Drawing.Size(38, 22);
            this.updownY.TabIndex = 3;
            this.updownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblY.Location = new System.Drawing.Point(137, 18);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(18, 17);
            this.lblY.TabIndex = 2;
            this.lblY.Text = "Y";
            // 
            // updownX
            // 
            this.updownX.Location = new System.Drawing.Point(52, 18);
            this.updownX.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.updownX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.updownX.Name = "updownX";
            this.updownX.Size = new System.Drawing.Size(38, 22);
            this.updownX.TabIndex = 1;
            this.updownX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblX.Location = new System.Drawing.Point(16, 18);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(18, 17);
            this.lblX.TabIndex = 0;
            this.lblX.Text = "X";
            // 
            // btnLeft
            // 
            this.btnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLeft.Location = new System.Drawing.Point(6, 134);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(75, 29);
            this.btnLeft.TabIndex = 8;
            this.btnLeft.Text = "Left";
            this.btnLeft.UseVisualStyleBackColor = true;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnRight
            // 
            this.btnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRight.Location = new System.Drawing.Point(169, 134);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(75, 29);
            this.btnRight.TabIndex = 9;
            this.btnRight.Text = "Right";
            this.btnRight.UseVisualStyleBackColor = true;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // groupBoxReport
            // 
            this.groupBoxReport.Controls.Add(this.lblReport);
            this.groupBoxReport.Location = new System.Drawing.Point(298, 216);
            this.groupBoxReport.Name = "groupBoxReport";
            this.groupBoxReport.Size = new System.Drawing.Size(250, 47);
            this.groupBoxReport.TabIndex = 6;
            this.groupBoxReport.TabStop = false;
            // 
            // Pacman_Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 271);
            this.Controls.Add(this.groupBoxReport);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.PacmanGroupBox);
            this.KeyPreview = true;
            this.Name = "Pacman_Game";
            this.Text = "Pacman_Game";
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxAction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.updownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.updownX)).EndInit();
            this.groupBoxReport.ResumeLayout(false);
            this.groupBoxReport.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PacmanGroupBox;
        private System.Windows.Forms.Label lblReport;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.ComboBox ddlDirection;
        private System.Windows.Forms.Label lblFacing;
        private System.Windows.Forms.NumericUpDown updownY;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.NumericUpDown updownX;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Button btnPlace;
        private System.Windows.Forms.Button btnMove;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.GroupBox groupBoxReport;
    }
}