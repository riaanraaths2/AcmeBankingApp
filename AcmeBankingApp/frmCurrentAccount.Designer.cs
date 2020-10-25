namespace AcmeBankingApp
{
    partial class frmCurrentAccount
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
            this.txtCurrentBalance = new System.Windows.Forms.TextBox();
            this.lbSavingsBalance = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCurrentDepositAmount = new System.Windows.Forms.TextBox();
            this.txtCurrentWithdrawAmount = new System.Windows.Forms.TextBox();
            this.btnCurrentDeposit = new System.Windows.Forms.Button();
            this.btnCurrentWithdraw = new System.Windows.Forms.Button();
            this.lAvailableBalance = new System.Windows.Forms.Label();
            this.txtAvailableBalance = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCurrentBalance
            // 
            this.txtCurrentBalance.Location = new System.Drawing.Point(335, 232);
            this.txtCurrentBalance.Name = "txtCurrentBalance";
            this.txtCurrentBalance.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentBalance.TabIndex = 15;
            // 
            // lbSavingsBalance
            // 
            this.lbSavingsBalance.AutoSize = true;
            this.lbSavingsBalance.Location = new System.Drawing.Point(199, 232);
            this.lbSavingsBalance.Name = "lbSavingsBalance";
            this.lbSavingsBalance.Size = new System.Drawing.Size(114, 17);
            this.lbSavingsBalance.TabIndex = 14;
            this.lbSavingsBalance.Text = "Current Balance:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Deposit Amount:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Withdrawel Amount:";
            // 
            // txtCurrentDepositAmount
            // 
            this.txtCurrentDepositAmount.Location = new System.Drawing.Point(335, 177);
            this.txtCurrentDepositAmount.Name = "txtCurrentDepositAmount";
            this.txtCurrentDepositAmount.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentDepositAmount.TabIndex = 11;
            // 
            // txtCurrentWithdrawAmount
            // 
            this.txtCurrentWithdrawAmount.Location = new System.Drawing.Point(335, 128);
            this.txtCurrentWithdrawAmount.Name = "txtCurrentWithdrawAmount";
            this.txtCurrentWithdrawAmount.Size = new System.Drawing.Size(100, 22);
            this.txtCurrentWithdrawAmount.TabIndex = 10;
            // 
            // btnCurrentDeposit
            // 
            this.btnCurrentDeposit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCurrentDeposit.Location = new System.Drawing.Point(471, 177);
            this.btnCurrentDeposit.Name = "btnCurrentDeposit";
            this.btnCurrentDeposit.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentDeposit.TabIndex = 9;
            this.btnCurrentDeposit.Text = "Deposit";
            this.btnCurrentDeposit.UseVisualStyleBackColor = true;
            this.btnCurrentDeposit.Click += new System.EventHandler(this.btnCurrentDeposit_Click);
            // 
            // btnCurrentWithdraw
            // 
            this.btnCurrentWithdraw.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCurrentWithdraw.Location = new System.Drawing.Point(471, 128);
            this.btnCurrentWithdraw.Name = "btnCurrentWithdraw";
            this.btnCurrentWithdraw.Size = new System.Drawing.Size(75, 23);
            this.btnCurrentWithdraw.TabIndex = 8;
            this.btnCurrentWithdraw.Text = "Withdraw";
            this.btnCurrentWithdraw.UseVisualStyleBackColor = true;
            this.btnCurrentWithdraw.Click += new System.EventHandler(this.btnCurrentWithdraw_Click);
            // 
            // lAvailableBalance
            // 
            this.lAvailableBalance.AutoSize = true;
            this.lAvailableBalance.Location = new System.Drawing.Point(202, 280);
            this.lAvailableBalance.Name = "lAvailableBalance";
            this.lAvailableBalance.Size = new System.Drawing.Size(124, 17);
            this.lAvailableBalance.TabIndex = 16;
            this.lAvailableBalance.Text = "Available Balance:";
            // 
            // txtAvailableBalance
            // 
            this.txtAvailableBalance.Location = new System.Drawing.Point(335, 280);
            this.txtAvailableBalance.Name = "txtAvailableBalance";
            this.txtAvailableBalance.Size = new System.Drawing.Size(100, 22);
            this.txtAvailableBalance.TabIndex = 17;
            // 
            // frmCurrentAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtAvailableBalance);
            this.Controls.Add(this.lAvailableBalance);
            this.Controls.Add(this.txtCurrentBalance);
            this.Controls.Add(this.lbSavingsBalance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCurrentDepositAmount);
            this.Controls.Add(this.txtCurrentWithdrawAmount);
            this.Controls.Add(this.btnCurrentDeposit);
            this.Controls.Add(this.btnCurrentWithdraw);
            this.Name = "frmCurrentAccount";
            this.Text = "frmCurrentAccount";
            this.Load += new System.EventHandler(this.frmCurrentAccount_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurrentBalance;
        private System.Windows.Forms.Label lbSavingsBalance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCurrentDepositAmount;
        private System.Windows.Forms.TextBox txtCurrentWithdrawAmount;
        private System.Windows.Forms.Button btnCurrentDeposit;
        private System.Windows.Forms.Button btnCurrentWithdraw;
        private System.Windows.Forms.Label lAvailableBalance;
        private System.Windows.Forms.TextBox txtAvailableBalance;
    }
}