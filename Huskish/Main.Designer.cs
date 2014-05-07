namespace Huskish
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.txtString = new System.Windows.Forms.TextBox();
            this.btnDecode = new System.Windows.Forms.Button();
            this.btnEncode = new System.Windows.Forms.Button();
            this.cboRotate = new System.Windows.Forms.ComboBox();
            this.cboGarbage = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtString
            // 
            this.txtString.AcceptsReturn = true;
            this.txtString.AcceptsTab = true;
            this.txtString.AllowDrop = true;
            this.txtString.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtString.Location = new System.Drawing.Point(12, 12);
            this.txtString.Multiline = true;
            this.txtString.Name = "txtString";
            this.txtString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtString.Size = new System.Drawing.Size(760, 159);
            this.txtString.TabIndex = 1;
            this.txtString.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtString_KeyDown);
            this.txtString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtString_KeyPress);
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecode.Location = new System.Drawing.Point(651, 177);
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(121, 23);
            this.btnDecode.TabIndex = 2;
            this.btnDecode.Text = "Decode";
            this.btnDecode.UseVisualStyleBackColor = true;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // btnEncode
            // 
            this.btnEncode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEncode.Location = new System.Drawing.Point(524, 177);
            this.btnEncode.Name = "btnEncode";
            this.btnEncode.Size = new System.Drawing.Size(121, 23);
            this.btnEncode.TabIndex = 3;
            this.btnEncode.Text = "Encode";
            this.btnEncode.UseVisualStyleBackColor = true;
            this.btnEncode.Click += new System.EventHandler(this.btnEncode_Click);
            // 
            // cboRotate
            // 
            this.cboRotate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboRotate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRotate.FormattingEnabled = true;
            this.cboRotate.ItemHeight = 13;
            this.cboRotate.Items.AddRange(new object[] {
            "None",
            "ROT5",
            "ROT13",
            "ROT18",
            "ROT47"});
            this.cboRotate.Location = new System.Drawing.Point(12, 178);
            this.cboRotate.Name = "cboRotate";
            this.cboRotate.Size = new System.Drawing.Size(121, 21);
            this.cboRotate.TabIndex = 4;
            // 
            // cboGarbage
            // 
            this.cboGarbage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cboGarbage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGarbage.FormattingEnabled = true;
            this.cboGarbage.ItemHeight = 13;
            this.cboGarbage.Items.AddRange(new object[] {
            "None",
            "Prestring",
            "Alternate",
            "Poststring"});
            this.cboGarbage.Location = new System.Drawing.Point(139, 178);
            this.cboGarbage.Name = "cboGarbage";
            this.cboGarbage.Size = new System.Drawing.Size(121, 21);
            this.cboGarbage.TabIndex = 6;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 212);
            this.Controls.Add(this.cboGarbage);
            this.Controls.Add(this.cboRotate);
            this.Controls.Add(this.btnEncode);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtString);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Huskish";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtString;
        private System.Windows.Forms.Button btnDecode;
        private System.Windows.Forms.Button btnEncode;
        private System.Windows.Forms.ComboBox cboRotate;
        private System.Windows.Forms.ComboBox cboGarbage;
    }
}

