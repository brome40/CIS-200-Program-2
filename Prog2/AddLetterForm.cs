//Grading ID: 5342897
//Program 2
//Due 10/28/2021
//CIS 200-50

//File: AddLetterForm.cs
//This file loads the GUI, populates the combo boxes with address options,
//ensures all fields are validated, and stores the results in an internal property.
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
    public partial class AddLetterForm : Form
    {
        private readonly List<Address> localAddressList; //instance variable for address list, will not change

        private const decimal ZERO = 0; //used in cost validation

        //Constructor
        //Preconditions:  None
        //Postconditions: The GUI is initialized and argument passed to instance variable
        public AddLetterForm(List<Address> addresses)
        {
            InitializeComponent();
            localAddressList = addresses;  
        }

        //Load Event Handler
        //Preconditions:  None
        //Postconditions: Combo Boxes are populated with address names
        private void AddLetterForm_Load(object sender, EventArgs e)
        {
            foreach (Address a in localAddressList)
            {
                originBox.Items.Add(a.Name);
                destinationBox.Items.Add(a.Name);
            }
        }

        //Cancel Button Event Handler
        //Precondition: Cancel buttton is left-clicked
        //Postcondition: Subform is closed and Dialog Result is 'Cancel', even if validating prevents change of focus
        private void CancelButton_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
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
                if (s == fixedCostBox)
                    errorIcon.SetError(s, "Price must not be empty.");
                else
                    errorIcon.SetError(s, "Please select a Name from the list");
            }
            else if (s != fixedCostBox && originBox.Text == destinationBox.Text) //The origin and destination addresses cannot match
            {
                e.Cancel = true;
                errorIcon.SetError(s, "Addresses cannot be the same.");
            }
            else if (s == fixedCostBox) //cost validation
            {
                if (!decimal.TryParse(s.Text,out decimal cost)) //must be a decimal number
                {
                    e.Cancel = true;
                    errorIcon.SetError(s, "Please enter a decimal number");
                }
                else if (cost < ZERO) //cost cannot be negative
                {
                    e.Cancel = true;
                    errorIcon.SetError(s, "Cost cannot be negative");
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

        //New Letter Property
        internal Letter NewLetter
        {
            //Preconditions:  None
            //Postconditions: New Letter object is returned
            get
            {
                Address oAddress = localAddressList[originBox.SelectedIndex];      //User selected origin address
                Address dAddress = localAddressList[destinationBox.SelectedIndex]; //User selected destination address
                decimal cost = decimal.Parse(fixedCostBox.Text);                   //User entered cost as a decimal
                return new Letter(oAddress,dAddress,cost);
            }

        }
    }
}
