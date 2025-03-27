namespace Module2BaiSo7_LENGOCTHAOVY
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.lblDesignedBy = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.picTurnOn = new System.Windows.Forms.PictureBox();
            this.picTurnOff = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(200, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(143, 22);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(256, 253);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(44, 16);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Text = "label2";
            // 
            // lblDesignedBy
            // 
            this.lblDesignedBy.AutoSize = true;
            this.lblDesignedBy.Location = new System.Drawing.Point(50, 320);
            this.lblDesignedBy.Name = "lblDesignedBy";
            this.lblDesignedBy.Size = new System.Drawing.Size(87, 16);
            this.lblDesignedBy.TabIndex = 3;
            this.lblDesignedBy.Text = "Designed by:";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(398, 320);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picTurnOn
            // 
            this.picTurnOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picTurnOn.Image = global::Module2BaiSo7_LENGOCTHAOVY.Properties.Resources.lighton;
            this.picTurnOn.Location = new System.Drawing.Point(234, 103);
            this.picTurnOn.Name = "picTurnOn";
            this.picTurnOn.Size = new System.Drawing.Size(109, 122);
            this.picTurnOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTurnOn.TabIndex = 5;
            this.picTurnOn.TabStop = false;
            this.picTurnOn.Click += new System.EventHandler(this.picTurnOn_Click);
            // 
            // picTurnOff
            // 
            this.picTurnOff.Image = global::Module2BaiSo7_LENGOCTHAOVY.Properties.Resources.lightoff;
            this.picTurnOff.Location = new System.Drawing.Point(234, 103);
            this.picTurnOff.Name = "picTurnOff";
            this.picTurnOff.Size = new System.Drawing.Size(109, 122);
            this.picTurnOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTurnOff.TabIndex = 6;
            this.picTurnOff.TabStop = false;
            this.picTurnOff.Click += new System.EventHandler(this.picTurnOff_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picTurnOff);
            this.Controls.Add(this.picTurnOn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblDesignedBy);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTurnOff)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Label lblDesignedBy;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picTurnOn;
        private System.Windows.Forms.PictureBox picTurnOff;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

