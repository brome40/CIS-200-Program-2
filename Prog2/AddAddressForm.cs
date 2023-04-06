//Grading ID: 5342897
//Program 2
//Due 10/28/2021
//CIS 200-50

//File: AddAddressForm.cs
//This class creates the GUI for the main Add Address Form. It also ensures validation for all required fields
//and stores the results as a new Address object which can be accessed by the other forms.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prog2
{
    public partial class AddAddressForm : Form
    {
        //Constructor
        //Precondition:  None
        //Postcondition: The GUI is Initialized
        public AddAddressForm()
        {
            InitializeComponent();
        }

        //Cancel Button Event Handler
        //Precondition: Cancel buttton is left-clicked
        //Postcondition: Subform is closed and Dialog Result is 'Cancel', even if validating prevents change of focus
        private void CancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                this.DialogResult = DialogResult.Cancel;
        }

        //OK Button Event Handler
        //Precondition: OK buttton is pressed and validation confirmed for all required fields
        //Postcondition: Subform is closed and Dialog Result is 'OK'
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren() == true)
                this.DialogResult = DialogResult.OK;
        }

        //Input Validating Event Handler
        //Preconditions:  Trying to change focus from input box
        //Postconditions: Focus is locked and error shown if validation fails
        private void Input_Validating(object sender, CancelEventArgs e)
        {
            Control s = (Control)sender; //downcast sender to Control Type

            if (String.IsNullOrWhiteSpace(s.Text) == true) //input cannot be empty
            {
                e.Cancel = true;
                if (sender == stateBox)
                    errorIcon.SetError(s, "Select a state from the list.");
                else
                    errorIcon.SetError(s, $"{s.Tag} must not be empty.");
            }
            else if (s == zipBox) //zip code validation
            {
                if (!int.TryParse(s.Text, out int zip))
                {
                    e.Cancel = true;
                    errorIcon.SetError(s, "Zip must be an integer");
                }
                else if (s.Text.Length != 5)
                {
                    e.Cancel = true;
                    errorIcon.SetError(s, "Zip must be 5 digits");
                }
                else if (zip >= Address.MAX_ZIP || zip <= Address.MIN_ZIP)
                {
                    e.Cancel = true;
                    errorIcon.SetError(s, "Zip must be between 0 and 99999");
                }
            }
        }

        //Input Validated Event Handler
        //Preconditions:  Validating was successful 
        //Postconditions: Error message is removed from respective box
        private void Input_Validated(object sender, EventArgs e)
        {
            errorIcon.SetError(sender as Control, "");
        }

        //New Address Property
        internal Address NewAddress //Can be accessed by other forms in namespace
        {
            //Preconditions:  None
            //Postconditions: New Address object is returned
            get
            {
                Address newAddress; //local variable to contain the new address object

                if (string.IsNullOrWhiteSpace(address2Box.Text) == true)
                    newAddress = new Address(nameBox.Text, address1Box.Text, cityBox.Text, stateBox.Text, int.Parse(zipBox.Text));
                else
                    newAddress = new Address(nameBox.Text, address1Box.Text, address2Box.Text, cityBox.Text, stateBox.Text, int.Parse(zipBox.Text));
                
                return newAddress;
            }
        }
    }
}
