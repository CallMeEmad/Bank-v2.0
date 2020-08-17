namespace BankApp
{
    partial class frmMainBank
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
            this.dgCustomers = new System.Windows.Forms.DataGridView();
            this.txtCostomerNum = new System.Windows.Forms.TextBox();
            this.cmbAccessModifiers = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCustomers
            // 
            this.dgCustomers.AllowUserToAddRows = false;
            this.dgCustomers.AllowUserToDeleteRows = false;
            this.dgCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCustomers.Location = new System.Drawing.Point(12, 130);
            this.dgCustomers.Name = "dgCustomers";
            this.dgCustomers.ReadOnly = true;
            this.dgCustomers.Size = new System.Drawing.Size(632, 224);
            this.dgCustomers.TabIndex = 0;
            // 
            // txtCostomerNum
            // 
            this.txtCostomerNum.Location = new System.Drawing.Point(290, 32);
            this.txtCostomerNum.Name = "txtCostomerNum";
            this.txtCostomerNum.Size = new System.Drawing.Size(128, 20);
            this.txtCostomerNum.TabIndex = 1;
            this.txtCostomerNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostomerNum_KeyPress);
            // 
            // cmbAccessModifiers
            // 
            this.cmbAccessModifiers.FormattingEnabled = true;
            this.cmbAccessModifiers.Items.AddRange(new object[] {
            "1 ",
            "2",
            "3"});
            this.cmbAccessModifiers.Location = new System.Drawing.Point(170, 55);
            this.cmbAccessModifiers.Name = "cmbAccessModifiers";
            this.cmbAccessModifiers.Size = new System.Drawing.Size(248, 21);
            this.cmbAccessModifiers.TabIndex = 2;
            this.cmbAccessModifiers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbAccessModifiers_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(424, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "شماره مشتری : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "سطح دسترسی : ";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(290, 82);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 5;
            this.btnInsert.Text = "افزودن";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 360);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 6;
            this.btnCalculate.Text = "محاسبه ";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // frmMainBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 395);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAccessModifiers);
            this.Controls.Add(this.txtCostomerNum);
            this.Controls.Add(this.dgCustomers);
            this.MaximumSize = new System.Drawing.Size(672, 434);
            this.MinimumSize = new System.Drawing.Size(672, 434);
            this.Name = "frmMainBank";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "فرم مشتریان";
            this.Load += new System.EventHandler(this.frmMainBank_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCustomers;
        private System.Windows.Forms.TextBox txtCostomerNum;
        private System.Windows.Forms.ComboBox cmbAccessModifiers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnCalculate;
    }
}

