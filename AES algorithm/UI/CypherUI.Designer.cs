namespace AES_algorithm.UI
{
    partial class CypherUI
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
            this.ecbButton = new System.Windows.Forms.Button();
            this.selectMode = new System.Windows.Forms.Label();
            this.cbcButton = new System.Windows.Forms.Button();
            this.cfbButton = new System.Windows.Forms.Button();
            this.insertText = new System.Windows.Forms.Label();
            this.cypherTextBox = new System.Windows.Forms.TextBox();
            this.insertKey = new System.Windows.Forms.Label();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.resultOutput = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.readFileButton = new System.Windows.Forms.Button();
            this.doCypherButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.doDecypherButton = new System.Windows.Forms.Button();
            this.symbolRequirement = new System.Windows.Forms.Label();
            this.resultSaved = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ecbButton
            // 
            this.ecbButton.BackColor = System.Drawing.Color.DarkGray;
            this.ecbButton.Font = new System.Drawing.Font("Segoe UI Symbol", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ecbButton.Location = new System.Drawing.Point(58, 74);
            this.ecbButton.Name = "ecbButton";
            this.ecbButton.Size = new System.Drawing.Size(119, 87);
            this.ecbButton.TabIndex = 0;
            this.ecbButton.Text = "ECB";
            this.ecbButton.UseVisualStyleBackColor = false;
            this.ecbButton.Click += new System.EventHandler(this.ecbButton_Click);
            // 
            // selectMode
            // 
            this.selectMode.AutoSize = true;
            this.selectMode.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.selectMode.Location = new System.Drawing.Point(58, 31);
            this.selectMode.Name = "selectMode";
            this.selectMode.Size = new System.Drawing.Size(145, 29);
            this.selectMode.TabIndex = 1;
            this.selectMode.Text = "Select Mode";
            // 
            // cbcButton
            // 
            this.cbcButton.BackColor = System.Drawing.Color.DarkGray;
            this.cbcButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbcButton.Location = new System.Drawing.Point(225, 74);
            this.cbcButton.Name = "cbcButton";
            this.cbcButton.Size = new System.Drawing.Size(112, 87);
            this.cbcButton.TabIndex = 2;
            this.cbcButton.Text = "CBC";
            this.cbcButton.UseVisualStyleBackColor = false;
            this.cbcButton.Click += new System.EventHandler(this.cbcButton_Click);
            // 
            // cfbButton
            // 
            this.cfbButton.BackColor = System.Drawing.Color.DarkGray;
            this.cfbButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cfbButton.Location = new System.Drawing.Point(386, 74);
            this.cfbButton.Name = "cfbButton";
            this.cfbButton.Size = new System.Drawing.Size(112, 87);
            this.cfbButton.TabIndex = 3;
            this.cfbButton.Text = "CFB";
            this.cfbButton.UseVisualStyleBackColor = false;
            this.cfbButton.Click += new System.EventHandler(this.cfbButton_Click);
            // 
            // insertText
            // 
            this.insertText.AutoSize = true;
            this.insertText.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertText.Location = new System.Drawing.Point(58, 203);
            this.insertText.Name = "insertText";
            this.insertText.Size = new System.Drawing.Size(349, 29);
            this.insertText.TabIndex = 4;
            this.insertText.Text = "Insert Text To Cypher/Decypher";
            // 
            // cypherTextBox
            // 
            this.cypherTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cypherTextBox.Location = new System.Drawing.Point(58, 247);
            this.cypherTextBox.Multiline = true;
            this.cypherTextBox.Name = "cypherTextBox";
            this.cypherTextBox.Size = new System.Drawing.Size(440, 106);
            this.cypherTextBox.TabIndex = 5;
            // 
            // insertKey
            // 
            this.insertKey.AutoSize = true;
            this.insertKey.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertKey.Location = new System.Drawing.Point(58, 385);
            this.insertKey.Name = "insertKey";
            this.insertKey.Size = new System.Drawing.Size(122, 29);
            this.insertKey.TabIndex = 6;
            this.insertKey.Text = "Insert Key";
            // 
            // keyTextBox
            // 
            this.keyTextBox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keyTextBox.Location = new System.Drawing.Point(58, 429);
            this.keyTextBox.Multiline = true;
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(440, 48);
            this.keyTextBox.TabIndex = 7;
            // 
            // resultOutput
            // 
            this.resultOutput.AutoSize = true;
            this.resultOutput.Font = new System.Drawing.Font("Bahnschrift SemiBold", 14.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resultOutput.Location = new System.Drawing.Point(58, 501);
            this.resultOutput.Name = "resultOutput";
            this.resultOutput.Size = new System.Drawing.Size(82, 29);
            this.resultOutput.TabIndex = 8;
            this.resultOutput.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultTextBox.Location = new System.Drawing.Point(58, 547);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(440, 48);
            this.resultTextBox.TabIndex = 9;
            // 
            // readFileButton
            // 
            this.readFileButton.BackColor = System.Drawing.SystemColors.Control;
            this.readFileButton.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.readFileButton.Location = new System.Drawing.Point(58, 780);
            this.readFileButton.Name = "readFileButton";
            this.readFileButton.Size = new System.Drawing.Size(440, 42);
            this.readFileButton.TabIndex = 10;
            this.readFileButton.Text = "Read From File";
            this.readFileButton.UseVisualStyleBackColor = false;
            this.readFileButton.Click += new System.EventHandler(this.readFileButton_Click);
            // 
            // doCypherButton
            // 
            this.doCypherButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doCypherButton.Location = new System.Drawing.Point(58, 651);
            this.doCypherButton.Name = "doCypherButton";
            this.doCypherButton.Size = new System.Drawing.Size(199, 89);
            this.doCypherButton.TabIndex = 11;
            this.doCypherButton.Text = "Cypher";
            this.doCypherButton.UseVisualStyleBackColor = true;
            this.doCypherButton.Click += new System.EventHandler(this.doCypherButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.saveButton.Location = new System.Drawing.Point(58, 839);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(440, 42);
            this.saveButton.TabIndex = 12;
            this.saveButton.Text = "Save To File";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // doDecypherButton
            // 
            this.doDecypherButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.doDecypherButton.Location = new System.Drawing.Point(299, 651);
            this.doDecypherButton.Name = "doDecypherButton";
            this.doDecypherButton.Size = new System.Drawing.Size(199, 89);
            this.doDecypherButton.TabIndex = 13;
            this.doDecypherButton.Text = "Decypher";
            this.doDecypherButton.UseVisualStyleBackColor = true;
            this.doDecypherButton.Click += new System.EventHandler(this.doDecypherButton_Click);
            // 
            // symbolRequirement
            // 
            this.symbolRequirement.AutoSize = true;
            this.symbolRequirement.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.symbolRequirement.ForeColor = System.Drawing.Color.Red;
            this.symbolRequirement.Location = new System.Drawing.Point(265, 391);
            this.symbolRequirement.Name = "symbolRequirement";
            this.symbolRequirement.Size = new System.Drawing.Size(0, 23);
            this.symbolRequirement.TabIndex = 14;
            // 
            // resultSaved
            // 
            this.resultSaved.AutoSize = true;
            this.resultSaved.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resultSaved.ForeColor = System.Drawing.Color.ForestGreen;
            this.resultSaved.Location = new System.Drawing.Point(217, 904);
            this.resultSaved.Name = "resultSaved";
            this.resultSaved.Size = new System.Drawing.Size(0, 23);
            this.resultSaved.TabIndex = 15;
            // 
            // CypherUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 951);
            this.Controls.Add(this.resultSaved);
            this.Controls.Add(this.symbolRequirement);
            this.Controls.Add(this.doDecypherButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.doCypherButton);
            this.Controls.Add(this.readFileButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultOutput);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.insertKey);
            this.Controls.Add(this.cypherTextBox);
            this.Controls.Add(this.insertText);
            this.Controls.Add(this.cfbButton);
            this.Controls.Add(this.cbcButton);
            this.Controls.Add(this.selectMode);
            this.Controls.Add(this.ecbButton);
            this.Name = "CypherUI";
            this.Text = "AES Cypher/Decypher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ecbButton;
        private Label selectMode;
        private Button cbcButton;
        private Button cfbButton;
        private Label insertText;
        private TextBox cypherTextBox;
        private Label insertKey;
        private TextBox keyTextBox;
        private Label resultOutput;
        private TextBox resultTextBox;
        private Button readFileButton;
        private Button doCypherButton;
        private Button saveButton;
        private Button doDecypherButton;
        private Label symbolRequirement;
        private Label resultSaved;
    }
}