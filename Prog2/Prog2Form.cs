//Grading ID: 5342897
//Program 2
//Due 10/28/2021
//CIS 200-50

//File: Prog2Form.cs
//This class creates the GUI for the main Program 2 Form. It includes a menu bar containing
//File (About & Exit), Insert (Address & Parcel), and Report (List Addresses & List Forms) 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UPVApp
{
    public partial class Prog2Form : Form
    {
        private UserParcelView upv; //Reference to instance of UserParcelView
        string NL = Environment.NewLine; //NewLine shorthand

        //Constructor
        //Precondition:  None
        //Postcondition: The GUI is Initialized and initial lists of test addressses and test parcels created.
        public Prog2Form()
        {
            InitializeComponent();

            upv = new UserParcelView();    

            //Test Addresses
            upv.AddAddress("  John Smith  ", "   123 Any St.   ", "  Apt. 45 ",
                "  Louisville   ", "  KY   ", 40202); // Test Address 1
            upv.AddAddress("Jane Doe", "987 Main St.",
                "Beverly Hills", "CA", 90210);        // Test Address 2
            upv.AddAddress("James Kirk", "654 Roddenberry Way", "Suite 321",
                "El Paso", "TX", 79901);              // Test Address 3
            upv.AddAddress("John Crichton", "678 Pau Place", "Apt. 7",
                "Portland", "ME", 04101);             // Test Address 4
            upv.AddAddress("Jacob Green", "443 Verde Ave.", "Portland",
                "OR", 97035);                         // Test Address 5
            upv.AddAddress("Peter Parker", "20 Ingram St.", "Flushing", 
                "NY", 11375);                         // Test Address 6
            upv.AddAddress("Tony Stark", "10880 Malibu Point", "Malibu",
                "CA", 90265);                         // Test Address 7
            upv.AddAddress("Eric Adams", "602 5th St.", "Room 13",
                "Topeka", "KS", 66546);               // Test Address 8

            //Test Parcels
            upv.AddLetter(upv.AddressAt(1), upv.AddressAt(6), 5.5M);  //Test Letter 1
            upv.AddLetter(upv.AddressAt(0), upv.AddressAt(4), 3.35M); //Test Letter 2
            upv.AddGroundPackage(upv.AddressAt(4), upv.AddressAt(5), 5, 13, 3, 15); //Test GroundPackage 1
            upv.AddGroundPackage(upv.AddressAt(2), upv.AddressAt(7), 6, 7, 4, 10);  //Test GroundPackage 2
            upv.AddNextDayAirPackage(upv.AddressAt(3), upv.AddressAt(0), 15, 10, 15, 77, 3.50M); //Test NextDayAirPackage 1
            upv.AddNextDayAirPackage(upv.AddressAt(7), upv.AddressAt(2), 6, 10, 4, 8, 4.14M);    //Test NextDayAirPackage 2
            upv.AddTwoDayAirPackage(upv.AddressAt(3), upv.AddressAt(2), 5, 5, 4, 11, TwoDayAirPackage.Delivery.Saver);  //Test TwoDayAirPackage 1
            upv.AddTwoDayAirPackage(upv.AddressAt(6), upv.AddressAt(1), 6, 3, 5, 100, TwoDayAirPackage.Delivery.Early); //Test TwoDayAirPackage 2
        }

        //Exit Event Handler Method
        //Preconditions:  Exit menu button is clicked
        //Postconditions: The program is closed and stops running
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //About Event Handler Method
        //Preconditions:  About menu button is clicked
        //Postconditions: Dialog box is displayed containing program information
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Program 2\n" +
                            $"Section #:  CIS 200-50\n" +
                            $"Grading ID: 5342897\n" +
                            $"Due: 10/28/2021","About");
        }

        //Insert Address Event Handler Method
        //Preconditions:  Insert Address menu button is clicked
        //Postconditions: A dialog box is opened and the input is displayed and added to the list of addresses.
        private void AddAddressMenuItem_Click(object sender, EventArgs e)
        {
            Prog2.AddAddressForm addressForm = new Prog2.AddAddressForm(); //New instance of Add Address Form
            DialogResult result;                                           //Result of Add Address Form. Can be OK or Cancel

            result = addressForm.ShowDialog();  //Modal Add Address Form is displayed until OK or Cancel is chosen

            if (result == DialogResult.OK)
            {
                reportText.Text =  $"New Address Added:{NL}{NL}";
                reportText.Text += addressForm.NewAddress;   //New Address is displayed on main form
                upv.AddressList.Add(addressForm.NewAddress); //New Address is added to list
            }
        }

        ////Insert Letter Event Handler Method
        //Preconditions:  Insert  menu Letter is clicked
        //Postconditions: A dialog box is opened and the input is displayed and added to the list of addresses.
        private void AddLetterMenuItem_Click(object sender, EventArgs e)
        {
            Prog2.AddLetterForm letterForm = new Prog2.AddLetterForm(upv.AddressList); //New instance of Add Letter Form
            DialogResult result;                                        //Result of Add Letter Form. Can be OK or Cancel

            result = letterForm.ShowDialog();   //Modal Add Letter Form is displayed until OK or Cancel is chosen

            if (result == DialogResult.OK)
            {
                reportText.Text = $"New Letter Added:{NL}{NL}";
                reportText.Text += letterForm.NewLetter;   //New Letter is displayed on main form
                upv.ParcelList.Add(letterForm.NewLetter);  //New Letter is added to parcel list
            }
        }

        //List Addresses Event Handler Method
        //Preconditions:  List Addresses menu button is clicked
        //Postconditions: The list of address objects is displayed 
        private void ListAddressesMenuItem_Click(object sender, EventArgs e)
        {
            reportText.Text = $"List of Addresses{NL}{NL}";
            foreach (Address a in upv.AddressList)
            {
                reportText.Text += a + NL;
                reportText.Text += $"-------------------------{NL}";
            }
        }

        ////List Parcels Event Handler Method
        //Preconditions:  List Parcels menu button is clicked
        //Postconditions: The list of parcel objects is displayed as well as total cost
        private void ListParcelsMenuItem_Click(object sender, EventArgs e)
        {
            reportText.Text = $"List of Parcels{NL}{NL}";
            foreach (Parcel p in upv.ParcelList)
            {
                reportText.Text += p + NL;
                reportText.Text += $"-------------------------{NL}";
            }
            decimal totalCost = 0; // Running total of parcel costs
            foreach (Parcel p in upv.ParcelList)
                totalCost += p.CalcCost();
            reportText.Text += $"Total cost of Parcels:{totalCost:C}{NL}";
        }

        
    }
}
