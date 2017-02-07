namespace CamaleonDataStudio
{
    partial class ConnectForm
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
            this.ConnectTypeLabel = new System.Windows.Forms.Label();
            this.ConnectType = new System.Windows.Forms.ComboBox();
            this.Connect = new System.Windows.Forms.Button();
            this.ConnectionStringLabel = new System.Windows.Forms.Label();
            this.ConnectionString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ConnectTypeLabel
            // 
            this.ConnectTypeLabel.AutoSize = true;
            this.ConnectTypeLabel.Location = new System.Drawing.Point(13, 13);
            this.ConnectTypeLabel.Name = "ConnectTypeLabel";
            this.ConnectTypeLabel.Size = new System.Drawing.Size(89, 13);
            this.ConnectTypeLabel.TabIndex = 0;
            this.ConnectTypeLabel.Text = "Tipo de conexión";
            // 
            // ConnectType
            // 
            this.ConnectType.FormattingEnabled = true;
            this.ConnectType.Location = new System.Drawing.Point(108, 10);
            this.ConnectType.Name = "ConnectType";
            this.ConnectType.Size = new System.Drawing.Size(304, 21);
            this.ConnectType.TabIndex = 1;
            // 
            // Connect
            // 
            this.Connect.Location = new System.Drawing.Point(337, 81);
            this.Connect.Name = "Connect";
            this.Connect.Size = new System.Drawing.Size(75, 23);
            this.Connect.TabIndex = 4;
            this.Connect.Text = "Conectar";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // ConnectionStringLabel
            // 
            this.ConnectionStringLabel.AutoSize = true;
            this.ConnectionStringLabel.Location = new System.Drawing.Point(13, 41);
            this.ConnectionStringLabel.Name = "ConnectionStringLabel";
            this.ConnectionStringLabel.Size = new System.Drawing.Size(91, 13);
            this.ConnectionStringLabel.TabIndex = 3;
            this.ConnectionStringLabel.Text = "Connection String";
            // 
            // ConnectionString
            // 
            this.ConnectionString.Location = new System.Drawing.Point(108, 38);
            this.ConnectionString.Name = "ConnectionString";
            this.ConnectionString.Size = new System.Drawing.Size(304, 20);
            this.ConnectionString.TabIndex = 4;
            // 
            // ConnectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 116);
            this.Controls.Add(this.ConnectionString);
            this.Controls.Add(this.ConnectionStringLabel);
            this.Controls.Add(this.Connect);
            this.Controls.Add(this.ConnectType);
            this.Controls.Add(this.ConnectTypeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectForm";
            this.Text = "Conexión";
            this.Load += new System.EventHandler(this.ConnectForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ConnectTypeLabel;
        private System.Windows.Forms.ComboBox ConnectType;
        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.Label ConnectionStringLabel;
        private System.Windows.Forms.TextBox ConnectionString;
    }
}