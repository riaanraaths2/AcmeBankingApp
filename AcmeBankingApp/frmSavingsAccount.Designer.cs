namespace AcmeBankingApp
{
    partial class frmSavingsAccount
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
            this.btnSavingsWithdraw = new System.Windows.Forms.Button();
            this.btnSavingsDeposit = new System.Windows.Forms.Button();
            this.txtSavingsWithdrawAmount = new System.Windows.Forms.TextBox();
            this.txtSavingsDepositAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSavingsBalance = new System.Windows.Forms.Label();
            this.txtSavingsBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSavingsWithdraw
            // 
            this.btnSavingsWithdraw.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSavingsWithdraw.Location = new System.Drawing.Point(507, 121);
            this.btnSavingsWithdraw.Name = "btnSavingsWithdraw";
            this.btnSavingsWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnSavingsWithdraw.TabIndex = 0;
            this.btnSavingsWithdraw.Text = "Withdraw";
            this.btnSavingsWithdraw.UseVisualStyleBackColor = true;
            this.btnSavingsWithdraw.Click += new System.EventHandler(this.btnSavingsWithdraw_Click);
            // 
            // btnSavingsDeposit
            // 
            this.btnSavingsDeposit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSavingsDeposit.Location = new System.Drawing.Point(507, 170);
            this.btnSavingsDeposit.Name = "btnSavingsDeposit";
            this.btnSavingsDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnSavingsDeposit.TabIndex = 1;
            this.btnSavingsDeposit.Text = "Deposit";
            this.btnSavingsDeposit.UseVisualStyleBackColor = true;
            this.btnSavingsDeposit.Click += new System.EventHandler(this.btnSavingsDeposit_Click);
            // 
            // txtSavingsWithdrawAmount
            // 
            this.txtSavingsWithdrawAmount.Location = new System.Drawing.Point(360, 121);
            this.txtSavingsWithdrawAmount.Name = "txtSavingsWithdrawAmount";
            this.txtSavingsWithdrawAmount.Size = new System.Drawing.Size(100, 22);
            this.txtSavingsWithdrawAmount.TabIndex = 2;
            // 
            // txtSavingsDepositAmount
            // 
            this.txtSavingsDepositAmount.Location = new System.Drawing.Point(360, 170);
            this.txtSavingsDepositAmount.Name = "txtSavingsDepositAmount";
            this.txtSavingsDepositAmount.Size = new System.Drawing.Size(100, 22);
            this.txtSavingsDepositAmount.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Withdrawel Amount: R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(193, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Deposit Amount: R";
            // 
            // lbSavingsBalance
            // 
            this.lbSavingsBalance.AutoSize = true;
            this.lbSavingsBalance.Location = new System.Drawing.Point(193, 225);
            this.lbSavingsBalance.Name = "lbSavingsBalance";
            this.lbSavingsBalance.Size = new System.Drawing.Size(128, 17);
            this.lbSavingsBalance.TabIndex = 6;
            this.lbSavingsBalance.Text = "Current Balance: R";
            // 
            // txtSavingsBalance
            // 
            this.txtSavingsBalance.Location = new System.Drawing.Point(360, 225);
            this.txtSavingsBalance.Name = "txtSavingsBalance";
            this.txtSavingsBalance.Size = new System.Drawing.Size(100, 22);
            this.txtSavingsBalance.TabIndex = 7;
            // 
            // frmSavingsAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSavingsBalance);
            this.Controls.Add(this.lbSavingsBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSavingsDepositAmount);
            this.Controls.Add(this.txtSavingsWithdrawAmount);
            this.Controls.Add(this.btnSavingsDeposit);
            this.Controls.Add(this.btnSavingsWithdraw);
            this.Name = "frmSavingsAccount";
            this.Text = "frmSavingsAccount";
            this.Load += new System.EventHandler(this.frmSavingsAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSavingsWithdraw;
        private System.Windows.Forms.Button btnSavingsDeposit;
        private System.Windows.Forms.TextBox txtSavingsWithdrawAmount;
        private System.Windows.Forms.TextBox txtSavingsDepositAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSavingsBalance;
        private System.Windows.Forms.TextBox txtSavingsBalance;
    }
}