
namespace Prog2
{
    partial class AddLetterForm
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
            this.originLbl = new System.Windows.Forms.Label();
            this.destinationLbl = new System.Windows.Forms.Label();
            this.fixedCostLbl = new System.Windows.Forms.Label();
            this.originBox = new System.Windows.Forms.ComboBox();
            this.destinationBox = new System.Windows.Forms.ComboBox();
            this.fixedCostBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // originLbl
            // 
            this.originLbl.AutoSize = true;
            this.originLbl.Location = new System.Drawing.Point(12, 36);
            this.originLbl.Name = "originLbl";
            this.originLbl.Size = new System.Drawing.Size(106, 17);
            this.originLbl.TabIndex = 0;
            this.originLbl.Text = "Origin Address:";
            // 
            // destinationLbl
            // 
            this.destinationLbl.AutoSize = true;
            this.destinationLbl.Location = new System.Drawing.Point(12, 83);
            this.destinationLbl.Name = "destinationLbl";
            this.destinationLbl.Size = new System.Drawing.Size(139, 17);
            this.destinationLbl.TabIndex = 1;
            this.destinationLbl.Text = "Destination Address:";
            // 
            // fixedCostLbl
            // 
            this.fixedCostLbl.AutoSize = true;
            this.fixedCostLbl.Location = new System.Drawing.Point(12, 132);
            this.fixedCostLbl.Name = "fixedCostLbl";
            this.fixedCostLbl.Size = new System.Drawing.Size(77, 17);
            this.fixedCostLbl.TabIndex = 2;
            this.fixedCostLbl.Text = "Fixed Cost:";
            // 
            // originBox
            // 
            this.originBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.originBox.FormattingEnabled = true;
            this.originBox.Location = new System.Drawing.Point(176, 33);
            this.originBox.Name = "originBox";
            this.originBox.Size = new System.Drawing.Size(160, 24);
            this.originBox.TabIndex = 1;
            this.originBox.Validating += new System.ComponentModel.CancelEventHandler(this.Input_Validating);
            this.originBox.Validated += new System.EventHandler(this.Input_Validated);
            // 
            // destinationBox
            // 
            this.destinationBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.destinationBox.FormattingEnabled = true;
            this.destinationBox.Location = new System.Drawing.Point(176, 80);
            this.destinationBox.Name = "destinationBox";
            this.destinationBox.Size = new System.Drawing.Size(160, 24);
            this.destinationBox.TabIndex = 2;
            this.destinationBox.Validating += new System.ComponentModel.CancelEventHandler(this.Input_Validating);
            this.destinationBox.Validated += new System.EventHandler(this.Input_Validated);
            // 
            // fixedCostBox
            // 
            this.fixedCostBox.Location = new System.Drawing.Point(176, 129);
            this.fixedCostBox.Name = "fixedCostBox";
            this.fixedCostBox.Size = new System.Drawing.Size(160, 22);
            this.fixedCostBox.TabIndex = 3;
            this.fixedCostBox.Validating += new System.ComponentModel.CancelEventHandler(this.Input_Validating);
            this.fixedCostBox.Validated += new System.EventHandler(this.Input_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(76, 206);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(176, 206);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseDown);
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // AddLetterForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 277);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.fixedCostBox);
            this.Controls.Add(this.destinationBox);
            this.Controls.Add(this.originBox);
            this.Controls.Add(this.fixedCostLbl);
            this.Controls.Add(this.destinationLbl);
            this.Controls.Add(this.originLbl);
            this.Name = "AddLetterForm";
            this.Text = "Add Letter";
            this.Load += new System.EventHandler(this.AddLetterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label originLbl;
        private System.Windows.Forms.Label destinationLbl;
        private System.Windows.Forms.Label fixedCostLbl;
        private System.Windows.Forms.ComboBox originBox;
        private System.Windows.Forms.ComboBox destinationBox;
        private System.Windows.Forms.TextBox fixedCostBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorIcon;
    }
}