namespace WinAppUnitTest
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
            this.btnCalculateAdd = new System.Windows.Forms.Button();
            this.btnCalcSub = new System.Windows.Forms.Button();
            this.btnCalcDiv = new System.Windows.Forms.Button();
            this.btnCalcMult = new System.Windows.Forms.Button();
            this.txtFirstnum = new System.Windows.Forms.TextBox();
            this.txtSecondnum = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalculateAdd
            // 
            this.btnCalculateAdd.Location = new System.Drawing.Point(126, 202);
            this.btnCalculateAdd.Name = "btnCalculateAdd";
            this.btnCalculateAdd.Size = new System.Drawing.Size(91, 23);
            this.btnCalculateAdd.TabIndex = 0;
            this.btnCalculateAdd.Text = "Calculate Add";
            this.btnCalculateAdd.UseVisualStyleBackColor = true;
            this.btnCalculateAdd.Click += new System.EventHandler(this.btnCalculateAdd_Click);
            // 
            // btnCalcSub
            // 
            this.btnCalcSub.Location = new System.Drawing.Point(252, 202);
            this.btnCalcSub.Name = "btnCalcSub";
            this.btnCalcSub.Size = new System.Drawing.Size(90, 23);
            this.btnCalcSub.TabIndex = 3;
            this.btnCalcSub.Text = "Calculate Sub";
            this.btnCalcSub.UseVisualStyleBackColor = true;
            this.btnCalcSub.Click += new System.EventHandler(this.btnCalcSub_Click);
            // 
            // btnCalcDiv
            // 
            this.btnCalcDiv.Location = new System.Drawing.Point(369, 202);
            this.btnCalcDiv.Name = "btnCalcDiv";
            this.btnCalcDiv.Size = new System.Drawing.Size(86, 23);
            this.btnCalcDiv.TabIndex = 4;
            this.btnCalcDiv.Text = "Calculate Div";
            this.btnCalcDiv.UseVisualStyleBackColor = true;
            this.btnCalcDiv.Click += new System.EventHandler(this.btnCalcDiv_Click);
            // 
            // btnCalcMult
            // 
            this.btnCalcMult.Location = new System.Drawing.Point(495, 202);
            this.btnCalcMult.Name = "btnCalcMult";
            this.btnCalcMult.Size = new System.Drawing.Size(89, 23);
            this.btnCalcMult.TabIndex = 5;
            this.btnCalcMult.Text = "Calculate Mult";
            this.btnCalcMult.UseVisualStyleBackColor = true;
            this.btnCalcMult.Click += new System.EventHandler(this.btnCalcMult_Click);
            // 
            // txtFirstnum
            // 
            this.txtFirstnum.Location = new System.Drawing.Point(116, 85);
            this.txtFirstnum.Name = "txtFirstnum";
            this.txtFirstnum.Size = new System.Drawing.Size(100, 20);
            this.txtFirstnum.TabIndex = 6;
            // 
            // txtSecondnum
            // 
            this.txtSecondnum.Location = new System.Drawing.Point(241, 84);
            this.txtSecondnum.Name = "txtSecondnum";
            this.txtSecondnum.Size = new System.Drawing.Size(100, 20);
            this.txtSecondnum.TabIndex = 7;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(144, 294);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 8;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.txtSecondnum);
            this.Controls.Add(this.txtFirstnum);
            this.Controls.Add(this.btnCalcMult);
            this.Controls.Add(this.btnCalcDiv);
            this.Controls.Add(this.btnCalcSub);
            this.Controls.Add(this.btnCalculateAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculateAdd;
        private System.Windows.Forms.Button btnCalcSub;
        private System.Windows.Forms.Button btnCalcDiv;
        private System.Windows.Forms.Button btnCalcMult;
        private System.Windows.Forms.TextBox txtFirstnum;
        private System.Windows.Forms.TextBox txtSecondnum;
        private System.Windows.Forms.Label lblResult;
    }
}

