namespace dotnet_wallet
{
    partial class dotnetwallet
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrivateKey = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPrivateKey = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGenerateSeed = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMnemonic = new System.Windows.Forms.Label();
            this.lblMnemonicAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(121, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Generate address by Private Key";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPrivateKey
            // 
            this.btnPrivateKey.Location = new System.Drawing.Point(33, 100);
            this.btnPrivateKey.Name = "btnPrivateKey";
            this.btnPrivateKey.Size = new System.Drawing.Size(157, 24);
            this.btnPrivateKey.TabIndex = 2;
            this.btnPrivateKey.Text = "Generate via Private Key";
            this.btnPrivateKey.UseVisualStyleBackColor = true;
            this.btnPrivateKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Private Key";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblPrivateKey
            // 
            this.lblPrivateKey.AutoSize = true;
            this.lblPrivateKey.Location = new System.Drawing.Point(121, 142);
            this.lblPrivateKey.Name = "lblPrivateKey";
            this.lblPrivateKey.Size = new System.Drawing.Size(10, 13);
            this.lblPrivateKey.TabIndex = 4;
            this.lblPrivateKey.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Address";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(121, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(10, 13);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "-";
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Generate address by Seed Phrase";
            // 
            // btnGenerateSeed
            // 
            this.btnGenerateSeed.Location = new System.Drawing.Point(33, 278);
            this.btnGenerateSeed.Name = "btnGenerateSeed";
            this.btnGenerateSeed.Size = new System.Drawing.Size(157, 23);
            this.btnGenerateSeed.TabIndex = 8;
            this.btnGenerateSeed.Text = "Generate via Seed Phrase";
            this.btnGenerateSeed.UseVisualStyleBackColor = true;
            this.btnGenerateSeed.Click += new System.EventHandler(this.btnGenerateSeed_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Mnemonic";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Address";
            // 
            // lblMnemonic
            // 
            this.lblMnemonic.AutoSize = true;
            this.lblMnemonic.Location = new System.Drawing.Point(121, 325);
            this.lblMnemonic.Name = "lblMnemonic";
            this.lblMnemonic.Size = new System.Drawing.Size(10, 13);
            this.lblMnemonic.TabIndex = 11;
            this.lblMnemonic.Text = "-";
            // 
            // lblMnemonicAddress
            // 
            this.lblMnemonicAddress.AutoSize = true;
            this.lblMnemonicAddress.Location = new System.Drawing.Point(124, 368);
            this.lblMnemonicAddress.Name = "lblMnemonicAddress";
            this.lblMnemonicAddress.Size = new System.Drawing.Size(10, 13);
            this.lblMnemonicAddress.TabIndex = 12;
            this.lblMnemonicAddress.Text = "-";
            // 
            // dotnetwallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(695, 517);
            this.Controls.Add(this.lblMnemonicAddress);
            this.Controls.Add(this.lblMnemonic);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnGenerateSeed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblPrivateKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPrivateKey);
            this.Controls.Add(this.label1);
            this.Name = "dotnetwallet";
            this.Text = "dotnet-wallet";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrivateKey;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPrivateKey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGenerateSeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMnemonic;
        private System.Windows.Forms.Label lblMnemonicAddress;
    }
}

