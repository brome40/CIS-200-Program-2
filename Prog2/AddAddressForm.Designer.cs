
namespace Prog2
{
    partial class AddAddressForm
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.addressLbl = new System.Windows.Forms.Label();
            this.address1Box = new System.Windows.Forms.TextBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.cityLbl = new System.Windows.Forms.Label();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.stateLbl = new System.Windows.Forms.Label();
            this.stateBox = new System.Windows.Forms.ComboBox();
            this.zipLbl = new System.Windows.Forms.Label();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.okButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.errorIcon = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Location = new System.Drawing.Point(27, 46);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(53, 17);
            this.nameLbl.TabIndex = 1;
            this.nameLbl.Text = "Name: ";
            // 
            // nameBox
            // 
            this.nameBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameBox.Location = new System.Drawing.Point(96, 43);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(173, 22);
            this.nameBox.TabIndex = 1;
            this.nameBox.Tag = "Name";
            this.nameBox.Validating += new System.ComponentModel.CancelEventHandler(this.Input_Validating);
            this.nameBox.Validated += new System.EventHandler(this.Input_Validated);
            // 
            // addressLbl
            // 
            this.addressLbl.AutoSize = true;
            this.addressLbl.Location = new System.Drawing.Point(27, 81);
            this.addressLbl.Name = "addressLbl";
            this.addressLbl.Size = new System.Drawing.Size(64, 17);
            this.addressLbl.TabIndex = 3;
            this.addressLbl.Text = "Address:";
            // 
            // address1Box
            // 
            this.address1Box.Location = new System.Drawing.Point(96, 78);
            this.address1Box.Name = "address1Box";
            this.address1Box.Size = new System.Drawing.Size(173, 22);
            this.address1Box.TabIndex = 2;
            this.address1Box.Tag = "Address Line 1";
            this.address1Box.Validating += new System.ComponentModel.CancelEventHandler(this.Input_Validating);
            this.address1Box.Validated += new System.EventHandler(this.Input_Validated);
            // 
            // address2Box
            // 
            this.address2Box.Location = new System.Drawing.Point(96, 115);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(173, 22);
            this.address2Box.TabIndex = 3;
            this.address2Box.Tag = "Address Line 2";
            // 
            // cityLbl
            // 
            this.cityLbl.AutoSize = true;
            this.cityLbl.Location = new System.Drawing.Point(27, 156);
            this.cityLbl.Name = "cityLbl";
            this.cityLbl.Size = new System.Drawing.Size(35, 17);
            this.cityLbl.TabIndex = 6;
            this.cityLbl.Text = "City:";
            // 
            // cityBox
            // 
            this.cityBox.Location = new System.Drawing.Point(96, 153);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(173, 22);
            this.cityBox.TabIndex = 4;
            this.cityBox.Tag = "City";
            this.cityBox.Validating += new System.ComponentModel.CancelEventHandler(this.Input_Validating);
            this.cityBox.Validated += new System.EventHandler(this.Input_Validated);
            // 
            // stateLbl
            // 
            this.stateLbl.AutoSize = true;
            this.stateLbl.Location = new System.Drawing.Point(27, 194);
            this.stateLbl.Name = "stateLbl";
            this.stateLbl.Size = new System.Drawing.Size(45, 17);
            this.stateLbl.TabIndex = 8;
            this.stateLbl.Text = "State:";
            // 
            // stateBox
            // 
            this.stateBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateBox.FormattingEnabled = true;
            this.stateBox.Items.AddRange(new object[] {
            "AK",
            "CA",
            "CO",
            "IN",
            "KY",
            "NY",
            "TN",
            "",
            ""});
            this.stateBox.Location = new System.Drawing.Point(96, 191);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(173, 24);
            this.stateBox.TabIndex = 5;
            this.stateBox.Tag = "State";
            this.stateBox.Validating += new System.ComponentModel.CancelEventHandler(this.Input_Validating);
            this.stateBox.Validated += new System.EventHandler(this.Input_Validated);
            // 
            // zipLbl
            // 
            this.zipLbl.AutoSize = true;
            this.zipLbl.Location = new System.Drawing.Point(27, 237);
            this.zipLbl.Name = "zipLbl";
            this.zipLbl.Size = new System.Drawing.Size(32, 17);
            this.zipLbl.TabIndex = 10;
            this.zipLbl.Text = "Zip:";
            // 
            // zipBox
            // 
            this.zipBox.Location = new System.Drawing.Point(96, 234);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(173, 22);
            this.zipBox.TabIndex = 6;
            this.zipBox.Tag = "Zip";
            this.zipBox.Validating += new System.ComponentModel.CancelEventHandler(this.Input_Validating);
            this.zipBox.Validated += new System.EventHandler(this.Input_Validated);
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(96, 288);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 7;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(194, 288);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseDown);
            // 
            // errorIcon
            // 
            this.errorIcon.ContainerControl = this;
            // 
            // AddAddressForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 346);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.zipLbl);
            this.Controls.Add(this.stateBox);
            this.Controls.Add(this.stateLbl);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.cityLbl);
            this.Controls.Add(this.address2Box);
            this.Controls.Add(this.address1Box);
            this.Controls.Add(this.addressLbl);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.nameLbl);
            this.Name = "AddAddressForm";
            this.Text = "Add Address";
            ((System.ComponentModel.ISupportInitialize)(this.errorIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label addressLbl;
        private System.Windows.Forms.TextBox address1Box;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.Label cityLbl;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.Label stateLbl;
        private System.Windows.Forms.ComboBox stateBox;
        private System.Windows.Forms.Label zipLbl;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ErrorProvider errorIcon;
    }
}