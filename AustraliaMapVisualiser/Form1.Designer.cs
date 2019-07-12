namespace AustraliaMapVisualizer
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panelMain = new System.Windows.Forms.Panel();
            this.textBoxLeftSide = new System.Windows.Forms.TextBox();
            this.solveButton = new System.Windows.Forms.Button();
            this.StarpointText = new System.Windows.Forms.Label();
            this.numericUpDownTemprature = new System.Windows.Forms.NumericUpDown();
            this.labelTemprature = new System.Windows.Forms.Label();
            this.comboBoxStartPoint = new System.Windows.Forms.ComboBox();
            this.comboBoxEndPoint = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemprature)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelMain.Location = new System.Drawing.Point(12, 12);
            this.panelMain.Name = "panelMain";
            this.panelMain.Padding = new System.Windows.Forms.Padding(10);
            this.panelMain.Size = new System.Drawing.Size(627, 597);
            this.panelMain.TabIndex = 0;
            this.panelMain.Paint += new System.Windows.Forms.PaintEventHandler(PanelMainPaint);
            // 
            // textBoxLeftSide
            // 
            this.textBoxLeftSide.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxLeftSide.Location = new System.Drawing.Point(645, 12);
            this.textBoxLeftSide.Multiline = true;
            this.textBoxLeftSide.Name = "textBoxLeftSide";
            this.textBoxLeftSide.ReadOnly = true;
            this.textBoxLeftSide.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLeftSide.Size = new System.Drawing.Size(143, 329);
            this.textBoxLeftSide.TabIndex = 11;
            // 
            // solveButton
            // 
            this.solveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.solveButton.Location = new System.Drawing.Point(713, 620);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(75, 26);
            this.solveButton.TabIndex = 13;
            this.solveButton.Text = "Solve";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.SolveButton_ClickAsync);
            // 
            // StarpointText
            // 
            this.StarpointText.AutoSize = true;
            this.StarpointText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StarpointText.Location = new System.Drawing.Point(650, 344);
            this.StarpointText.Name = "StarpointText";
            this.StarpointText.Size = new System.Drawing.Size(138, 20);
            this.StarpointText.TabIndex = 14;
            this.StarpointText.Text = "Choose Startpoint";
            this.StarpointText.Click += new System.EventHandler(this.Label1_Click);
            // 
            // numericUpDownTemprature
            // 
            this.numericUpDownTemprature.Location = new System.Drawing.Point(654, 473);
            this.numericUpDownTemprature.Name = "numericUpDownTemprature";
            this.numericUpDownTemprature.Size = new System.Drawing.Size(134, 20);
            this.numericUpDownTemprature.TabIndex = 15;
            this.numericUpDownTemprature.ValueChanged += new System.EventHandler(this.NumericUpDownTemperature_ValueChanged);
            // 
            // labelTemprature
            // 
            this.labelTemprature.AutoSize = true;
            this.labelTemprature.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemprature.Location = new System.Drawing.Point(656, 450);
            this.labelTemprature.Name = "labelTemprature";
            this.labelTemprature.Size = new System.Drawing.Size(91, 20);
            this.labelTemprature.TabIndex = 17;
            this.labelTemprature.Text = "Temprature";
            // 
            // comboBoxStartPoint
            // 
            this.comboBoxStartPoint.DropDownHeight = 140;
            this.comboBoxStartPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxStartPoint.FormattingEnabled = true;
            this.comboBoxStartPoint.IntegralHeight = false;
            this.comboBoxStartPoint.ItemHeight = 13;
            this.comboBoxStartPoint.Location = new System.Drawing.Point(654, 367);
            this.comboBoxStartPoint.MaxDropDownItems = 5;
            this.comboBoxStartPoint.Name = "comboBoxStartPoint";
            this.comboBoxStartPoint.Size = new System.Drawing.Size(134, 21);
            this.comboBoxStartPoint.TabIndex = 18;
            this.comboBoxStartPoint.TabStop = false;
            this.comboBoxStartPoint.SelectedIndexChanged += new System.EventHandler(this.ComboBoxStartPoint_SelectedIndexChanged);
            // 
            // comboBoxEndPoint
            // 
            this.comboBoxEndPoint.DropDownHeight = 140;
            this.comboBoxEndPoint.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxEndPoint.FormattingEnabled = true;
            this.comboBoxEndPoint.IntegralHeight = false;
            this.comboBoxEndPoint.Location = new System.Drawing.Point(654, 414);
            this.comboBoxEndPoint.MaxDropDownItems = 5;
            this.comboBoxEndPoint.Name = "comboBoxEndPoint";
            this.comboBoxEndPoint.Size = new System.Drawing.Size(134, 21);
            this.comboBoxEndPoint.TabIndex = 20;
            this.comboBoxEndPoint.SelectedIndexChanged += new System.EventHandler(this.ComboBoxEndPoint_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(656, 391);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Choose Endpoint";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 649);
            this.Controls.Add(this.comboBoxEndPoint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxStartPoint);
            this.Controls.Add(this.labelTemprature);
            this.Controls.Add(this.numericUpDownTemprature);
            this.Controls.Add(this.StarpointText);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.textBoxLeftSide);
            this.Controls.Add(this.panelMain);
            this.Name = "Form1";
            base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTemprature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TextBox textBoxLeftSide;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.Label StarpointText;
        private System.Windows.Forms.NumericUpDown numericUpDownTemprature;
        private System.Windows.Forms.Label labelTemprature;
        private System.Windows.Forms.ComboBox comboBoxStartPoint;
        private System.Windows.Forms.ComboBox comboBoxEndPoint;
        private System.Windows.Forms.Label label1;
        private readonly Algorithms Algorithms;
    }
}

