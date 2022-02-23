namespace HopfieldRecognizer
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.butCreateNN = new System.Windows.Forms.Button();
            this.butAddPattern = new System.Windows.Forms.Button();
            this.panelStoredImages = new System.Windows.Forms.Panel();
            this.butRunDynamics = new System.Windows.Forms.Button();
            this.gbNNProperties = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblNNSize = new System.Windows.Forms.Label();
            this.lblNumberOfPatterns = new System.Windows.Forms.Label();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.lblStaticEnergy = new System.Windows.Forms.Label();
            this.lblStaticSizeOfNN = new System.Windows.Forms.Label();
            this.lblStaticNumberOfPatterns = new System.Windows.Forms.Label();
            this.gbNNCurrentState = new System.Windows.Forms.GroupBox();
            this.imNNState = new ImageMagnifier.ImageMagnifier();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.gbPatternsInNN = new System.Windows.Forms.GroupBox();
            this.gbNNProperties.SuspendLayout();
            this.gbNNCurrentState.SuspendLayout();
            this.gbPatternsInNN.SuspendLayout();
            this.SuspendLayout();
            // 
            // butCreateNN
            // 
            this.butCreateNN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCreateNN.Location = new System.Drawing.Point(16, 15);
            this.butCreateNN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butCreateNN.Name = "butCreateNN";
            this.butCreateNN.Size = new System.Drawing.Size(288, 28);
            this.butCreateNN.TabIndex = 1;
            this.butCreateNN.Text = "Create Neural Network (1000 Neurons)";
            this.butCreateNN.UseVisualStyleBackColor = true;
            this.butCreateNN.Click += new System.EventHandler(this.CreateNNBut_Click);
            // 
            // butAddPattern
            // 
            this.butAddPattern.Enabled = false;
            this.butAddPattern.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butAddPattern.Location = new System.Drawing.Point(16, 50);
            this.butAddPattern.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butAddPattern.Name = "butAddPattern";
            this.butAddPattern.Size = new System.Drawing.Size(288, 28);
            this.butAddPattern.TabIndex = 1;
            this.butAddPattern.Text = "Add pattern to Neural network";
            this.butAddPattern.UseVisualStyleBackColor = true;
            this.butAddPattern.Click += new System.EventHandler(this.AddPatternBut_Click);
            // 
            // panelStoredImages
            // 
            this.panelStoredImages.AutoScroll = true;
            this.panelStoredImages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelStoredImages.Location = new System.Drawing.Point(4, 19);
            this.panelStoredImages.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStoredImages.Name = "panelStoredImages";
            this.panelStoredImages.Size = new System.Drawing.Size(140, 579);
            this.panelStoredImages.TabIndex = 0;
            // 
            // butRunDynamics
            // 
            this.butRunDynamics.Enabled = false;
            this.butRunDynamics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butRunDynamics.Location = new System.Drawing.Point(16, 86);
            this.butRunDynamics.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butRunDynamics.Name = "butRunDynamics";
            this.butRunDynamics.Size = new System.Drawing.Size(288, 28);
            this.butRunDynamics.TabIndex = 4;
            this.butRunDynamics.Text = "Run network dynamics";
            this.butRunDynamics.UseVisualStyleBackColor = true;
            this.butRunDynamics.Click += new System.EventHandler(this.RunDynamicsBut_Click);
            // 
            // gbNNProperties
            // 
            this.gbNNProperties.Controls.Add(this.label5);
            this.gbNNProperties.Controls.Add(this.lblNNSize);
            this.gbNNProperties.Controls.Add(this.lblNumberOfPatterns);
            this.gbNNProperties.Controls.Add(this.lblEnergy);
            this.gbNNProperties.Controls.Add(this.lblStaticEnergy);
            this.gbNNProperties.Controls.Add(this.lblStaticSizeOfNN);
            this.gbNNProperties.Controls.Add(this.lblStaticNumberOfPatterns);
            this.gbNNProperties.Location = new System.Drawing.Point(3, 122);
            this.gbNNProperties.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNNProperties.Name = "gbNNProperties";
            this.gbNNProperties.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNNProperties.Size = new System.Drawing.Size(315, 186);
            this.gbNNProperties.TabIndex = 5;
            this.gbNNProperties.TabStop = false;
            this.gbNNProperties.Text = "Properties of Neural Network";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 2;
            // 
            // lblNNSize
            // 
            this.lblNNSize.AutoSize = true;
            this.lblNNSize.Location = new System.Drawing.Point(180, 32);
            this.lblNNSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNNSize.Name = "lblNNSize";
            this.lblNNSize.Size = new System.Drawing.Size(0, 17);
            this.lblNNSize.TabIndex = 2;
            // 
            // lblNumberOfPatterns
            // 
            this.lblNumberOfPatterns.AutoSize = true;
            this.lblNumberOfPatterns.Location = new System.Drawing.Point(185, 59);
            this.lblNumberOfPatterns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumberOfPatterns.Name = "lblNumberOfPatterns";
            this.lblNumberOfPatterns.Size = new System.Drawing.Size(0, 17);
            this.lblNumberOfPatterns.TabIndex = 2;
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.Location = new System.Drawing.Point(185, 103);
            this.lblEnergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(0, 17);
            this.lblEnergy.TabIndex = 2;
            // 
            // lblStaticEnergy
            // 
            this.lblStaticEnergy.AutoSize = true;
            this.lblStaticEnergy.Location = new System.Drawing.Point(15, 105);
            this.lblStaticEnergy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaticEnergy.Name = "lblStaticEnergy";
            this.lblStaticEnergy.Size = new System.Drawing.Size(162, 17);
            this.lblStaticEnergy.TabIndex = 1;
            this.lblStaticEnergy.Text = "Current value of Energy:";
            // 
            // lblStaticSizeOfNN
            // 
            this.lblStaticSizeOfNN.AutoSize = true;
            this.lblStaticSizeOfNN.Location = new System.Drawing.Point(13, 32);
            this.lblStaticSizeOfNN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaticSizeOfNN.Name = "lblStaticSizeOfNN";
            this.lblStaticSizeOfNN.Size = new System.Drawing.Size(156, 17);
            this.lblStaticSizeOfNN.TabIndex = 0;
            this.lblStaticSizeOfNN.Text = "Size of Neural Network:";
            // 
            // lblStaticNumberOfPatterns
            // 
            this.lblStaticNumberOfPatterns.AutoSize = true;
            this.lblStaticNumberOfPatterns.Location = new System.Drawing.Point(13, 59);
            this.lblStaticNumberOfPatterns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStaticNumberOfPatterns.Name = "lblStaticNumberOfPatterns";
            this.lblStaticNumberOfPatterns.Size = new System.Drawing.Size(134, 17);
            this.lblStaticNumberOfPatterns.TabIndex = 0;
            this.lblStaticNumberOfPatterns.Text = "Number of patterns:";
            // 
            // gbNNCurrentState
            // 
            this.gbNNCurrentState.Controls.Add(this.imNNState);
            this.gbNNCurrentState.Location = new System.Drawing.Point(3, 315);
            this.gbNNCurrentState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNNCurrentState.Name = "gbNNCurrentState";
            this.gbNNCurrentState.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbNNCurrentState.Size = new System.Drawing.Size(315, 283);
            this.gbNNCurrentState.TabIndex = 5;
            this.gbNNCurrentState.TabStop = false;
            this.gbNNCurrentState.Text = "Current State of NN";
            // 
            // imNNState
            // 
            this.imNNState.ImageToMagnify = ((System.Drawing.Image)(resources.GetObject("imNNState.ImageToMagnify")));
            this.imNNState.Location = new System.Drawing.Point(24, 18);
            this.imNNState.MagnificationCoefficient = 20;
            this.imNNState.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imNNState.Name = "imNNState";
            this.imNNState.Size = new System.Drawing.Size(200, 200);
            this.imNNState.TabIndex = 0;
            this.imNNState.Text = "imNNState";
            this.imNNState.Visible = false;
            this.imNNState.Click += new System.EventHandler(this.imNNState_Click);
            // 
            // gbPatternsInNN
            // 
            this.gbPatternsInNN.Controls.Add(this.panelStoredImages);
            this.gbPatternsInNN.Dock = System.Windows.Forms.DockStyle.Right;
            this.gbPatternsInNN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPatternsInNN.Location = new System.Drawing.Point(325, 0);
            this.gbPatternsInNN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPatternsInNN.Name = "gbPatternsInNN";
            this.gbPatternsInNN.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbPatternsInNN.Size = new System.Drawing.Size(148, 602);
            this.gbPatternsInNN.TabIndex = 0;
            this.gbPatternsInNN.TabStop = false;
            this.gbPatternsInNN.Text = "Patterns in NN";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 602);
            this.Controls.Add(this.gbNNCurrentState);
            this.Controls.Add(this.gbNNProperties);
            this.Controls.Add(this.butRunDynamics);
            this.Controls.Add(this.butAddPattern);
            this.Controls.Add(this.butCreateNN);
            this.Controls.Add(this.gbPatternsInNN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hopfield neural network usage Example";
            this.Load += new System.EventHandler(this.HopfieldRecognizerMainForm_Load);
            this.gbNNProperties.ResumeLayout(false);
            this.gbNNProperties.PerformLayout();
            this.gbNNCurrentState.ResumeLayout(false);
            this.gbPatternsInNN.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butCreateNN;
        private System.Windows.Forms.Button butAddPattern;
        private System.Windows.Forms.Panel panelStoredImages;
        private System.Windows.Forms.Button butRunDynamics;
        private System.Windows.Forms.GroupBox gbNNProperties;
        private System.Windows.Forms.GroupBox gbNNCurrentState;
        private System.Windows.Forms.OpenFileDialog ofd;
        private ImageMagnifier.ImageMagnifier imNNState;
        private System.Windows.Forms.Label lblStaticSizeOfNN;
        private System.Windows.Forms.Label lblStaticNumberOfPatterns;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblNNSize;
        private System.Windows.Forms.Label lblNumberOfPatterns;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label lblStaticEnergy;
        private System.Windows.Forms.GroupBox gbPatternsInNN;
    }
}