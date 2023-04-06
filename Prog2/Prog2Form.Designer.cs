namespace UPVApp
{
    partial class Prog2Form
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
            this.mainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAddressMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addLetterMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAddressesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listParcelsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportText = new System.Windows.Forms.TextBox();
            this.mainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainFormMenuStrip
            // 
            this.mainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.insertMenuItem,
            this.reportMenuItem});
            this.mainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainFormMenuStrip.Name = "mainFormMenuStrip";
            this.mainFormMenuStrip.Size = new System.Drawing.Size(594, 28);
            this.mainFormMenuStrip.TabIndex = 0;
            this.mainFormMenuStrip.Text = "mainFormMenuStrip";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMenuItem,
            this.ExitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileMenuItem.Text = "&File";
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutMenuItem.Text = "&About";
            this.aboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ExitMenuItem.Text = "&Exit";
            this.ExitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // insertMenuItem
            // 
            this.insertMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addAddressMenuItem,
            this.addLetterMenuItem});
            this.insertMenuItem.Name = "insertMenuItem";
            this.insertMenuItem.Size = new System.Drawing.Size(59, 24);
            this.insertMenuItem.Text = "&Insert";
            // 
            // addAddressMenuItem
            // 
            this.addAddressMenuItem.Name = "addAddressMenuItem";
            this.addAddressMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addAddressMenuItem.Text = "&Address";
            this.addAddressMenuItem.Click += new System.EventHandler(this.AddAddressMenuItem_Click);
            // 
            // addLetterMenuItem
            // 
            this.addLetterMenuItem.Name = "addLetterMenuItem";
            this.addLetterMenuItem.Size = new System.Drawing.Size(224, 26);
            this.addLetterMenuItem.Text = "&Letter";
            this.addLetterMenuItem.Click += new System.EventHandler(this.AddLetterMenuItem_Click);
            // 
            // reportMenuItem
            // 
            this.reportMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAddressesMenuItem,
            this.listParcelsMenuItem});
            this.reportMenuItem.Name = "reportMenuItem";
            this.reportMenuItem.Size = new System.Drawing.Size(68, 24);
            this.reportMenuItem.Text = "&Report";
            // 
            // listAddressesMenuItem
            // 
            this.listAddressesMenuItem.Name = "listAddressesMenuItem";
            this.listAddressesMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listAddressesMenuItem.Text = "List &Addresses";
            this.listAddressesMenuItem.Click += new System.EventHandler(this.ListAddressesMenuItem_Click);
            // 
            // listParcelsMenuItem
            // 
            this.listParcelsMenuItem.Name = "listParcelsMenuItem";
            this.listParcelsMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listParcelsMenuItem.Text = "List &Parcels";
            this.listParcelsMenuItem.Click += new System.EventHandler(this.ListParcelsMenuItem_Click);
            // 
            // reportText
            // 
            this.reportText.Location = new System.Drawing.Point(21, 42);
            this.reportText.Multiline = true;
            this.reportText.Name = "reportText";
            this.reportText.Size = new System.Drawing.Size(545, 447);
            this.reportText.TabIndex = 1;
            // 
            // Prog2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 501);
            this.Controls.Add(this.reportText);
            this.Controls.Add(this.mainFormMenuStrip);
            this.MainMenuStrip = this.mainFormMenuStrip;
            this.Name = "Prog2Form";
            this.Text = "Program 2";
            this.mainFormMenuStrip.ResumeLayout(false);
            this.mainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAddressMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addLetterMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAddressesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listParcelsMenuItem;
        private System.Windows.Forms.TextBox reportText;
    }
}

