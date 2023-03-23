using AES_algorithm.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AES_algorithm.UI
{
    public partial class CypherUI: Form
    {
        //Mode Selection Button Status

        private bool ecbMode = false;
        private bool cbcMode = false;
        private bool cfbMode = false;

        public CypherUI()
        { 
            InitializeComponent();
        }

        //Logic For Mode Selection
        private void ecbButton_Click(object sender, EventArgs e)
        {
            if(!ecbMode && !cbcMode && !cfbMode)
            {
                ecbMode = true;
                ecbButton.BackColor = Color.Red;

                // When Mode Is Selected, Requirements Shows Up
                symbolRequirement.Text = "Key must contain 16 symbols";
            }
            else
            {
                cbcMode = false;
                cfbMode = false;
                
                cbcButton.BackColor = Color.DarkGray;
                cfbButton.BackColor = Color.DarkGray;
            }
 
        }

        private void cbcButton_Click(object sender, EventArgs e)
        {
            if (!ecbMode && !cbcMode && !cfbMode)
            {
                cbcMode = true;
                cbcButton.BackColor = Color.Red;

                symbolRequirement.Text = "Key must contain 32 symbols";

            }
            else
            {
                ecbMode = false;
                cfbMode = false;

                ecbButton.BackColor = Color.DarkGray;
                cfbButton.BackColor = Color.DarkGray;
            }
        }

        private void cfbButton_Click(object sender, EventArgs e)
        {
            if (!ecbMode && !cbcMode && !cfbMode)
            {
                cfbMode = true;
                cfbButton.BackColor = Color.Red;

                symbolRequirement.Text = "Key must contain 32 symbols";
            }
            else
            {
                ecbMode = false;
                cbcMode = false;

                ecbButton.BackColor = Color.DarkGray;
                cbcButton.BackColor = Color.DarkGray;
            }
        }

        //Does Encrpytion By Selected Mode
        private void doCypherButton_Click(object sender, EventArgs e)
        {
            if (ecbMode){
                ECBMode ecb = new ECBMode();

                //Returns result to result TextBox
                resultTextBox.Text = ecb.encryptText(cypherTextBox.Text.ToString(), keyTextBox.Text.ToString());

            }
            else if(cbcMode)
            {
                CBCMode cbc = new CBCMode();

                resultTextBox.Text = cbc.encryptText(cypherTextBox.Text, keyTextBox.Text.ToString());

            }
            else if (cfbMode)
            {
                CFBMode cfb = new CFBMode();

                resultTextBox.Text = cfb.encryptText(cypherTextBox.Text, keyTextBox.Text.ToString());
            }
        }

        //Does Decryption By Selected Mode
        private void doDecypherButton_Click(object sender, EventArgs e)
        {
            if (ecbMode)
            {
                ECBMode ecb = new ECBMode();

                resultTextBox.Text = ecb.decryptText(cypherTextBox.Text.ToString(), keyTextBox.Text.ToString());
            }
            else if(cbcMode)
            {
                CBCMode cbc = new CBCMode();

                resultTextBox.Text = cbc.decryptText(cypherTextBox.Text, keyTextBox.Text.ToString());
            }
            else if (cfbMode)
            {
                CFBMode cfb = new CFBMode();

                resultTextBox.Text = cfb.decryptText(cypherTextBox.Text, keyTextBox.Text.ToString());
            }

        }

        //Reads Selected File
        private void readFileButton_Click(object sender, EventArgs e)
        {
            FileReadUtil read = new FileReadUtil();

            //Returns Text From Selected File
            cypherTextBox.Text = read.loadFromFile();

            //Resets "resultSaved" Label
            resultSaved.Text = "";

        }

        //Saves Result To File
        private void saveButton_Click(object sender, EventArgs e)
        {
            FileReadUtil save = new FileReadUtil();

            save.saveToFile(resultTextBox.Text.ToString());
            
            //Button Feedback For Saving Text Into File
            resultSaved.Text = "Result is saved";

        }

        
    }
}
