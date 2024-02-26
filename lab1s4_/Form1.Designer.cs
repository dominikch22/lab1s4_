namespace lab1s4_
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
            this.powerCh = new System.Windows.Forms.CheckBox();
            this.rootCh = new System.Windows.Forms.CheckBox();
            this.inverseCh = new System.Windows.Forms.CheckBox();
            this.execute = new System.Windows.Forms.Button();
            this.number = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.backgroundCheckBox = new System.Windows.Forms.CheckBox();
            this.fontColorCheckBox = new System.Windows.Forms.CheckBox();
            this.fontSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.background = new System.Windows.Forms.TextBox();
            this.color = new System.Windows.Forms.TextBox();
            this.size = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.inputN = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.executeNumbersList = new System.Windows.Forms.Button();
            this.elementInput = new System.Windows.Forms.TextBox();
            this.addSorted = new System.Windows.Forms.Button();
            this.clearSorted = new System.Windows.Forms.Button();
            this.sortedBox = new System.Windows.Forms.ListBox();
            this.sortAscending = new System.Windows.Forms.Button();
            this.sortDescending = new System.Windows.Forms.Button();
            this.showNumbersButton = new System.Windows.Forms.Button();
            this.showStringsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // powerCh
            // 
            this.powerCh.AutoSize = true;
            this.powerCh.Location = new System.Drawing.Point(18, 55);
            this.powerCh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.powerCh.Name = "powerCh";
            this.powerCh.Size = new System.Drawing.Size(126, 24);
            this.powerCh.TabIndex = 0;
            this.powerCh.Text = "potegowanie";
            this.powerCh.UseVisualStyleBackColor = true;
            this.powerCh.CheckedChanged += new System.EventHandler(this.powerCh_CheckedChanged);
            // 
            // rootCh
            // 
            this.rootCh.AutoSize = true;
            this.rootCh.Location = new System.Drawing.Point(18, 91);
            this.rootCh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rootCh.Name = "rootCh";
            this.rootCh.Size = new System.Drawing.Size(114, 24);
            this.rootCh.TabIndex = 1;
            this.rootCh.Text = "pierwiastek";
            this.rootCh.UseVisualStyleBackColor = true;
            this.rootCh.CheckedChanged += new System.EventHandler(this.rootCh_CheckedChanged);
            // 
            // inverseCh
            // 
            this.inverseCh.AutoSize = true;
            this.inverseCh.Location = new System.Drawing.Point(24, 128);
            this.inverseCh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inverseCh.Name = "inverseCh";
            this.inverseCh.Size = new System.Drawing.Size(117, 24);
            this.inverseCh.TabIndex = 2;
            this.inverseCh.Text = "odwrotnosc";
            this.inverseCh.UseVisualStyleBackColor = true;
            this.inverseCh.CheckedChanged += new System.EventHandler(this.inverseCh_CheckedChanged);
            // 
            // execute
            // 
            this.execute.Location = new System.Drawing.Point(20, 163);
            this.execute.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.execute.Name = "execute";
            this.execute.Size = new System.Drawing.Size(112, 35);
            this.execute.TabIndex = 3;
            this.execute.Text = "wykonaj";
            this.execute.UseVisualStyleBackColor = true;
            this.execute.Click += new System.EventHandler(this.execute_Click);
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(18, 15);
            this.number.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(148, 26);
            this.number.TabIndex = 4;
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(20, 209);
            this.result.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 20);
            this.result.TabIndex = 5;
            // 
            // backgroundCheckBox
            // 
            this.backgroundCheckBox.AutoSize = true;
            this.backgroundCheckBox.Location = new System.Drawing.Point(280, 20);
            this.backgroundCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backgroundCheckBox.Name = "backgroundCheckBox";
            this.backgroundCheckBox.Size = new System.Drawing.Size(91, 24);
            this.backgroundCheckBox.TabIndex = 6;
            this.backgroundCheckBox.Text = "kolor tła";
            this.backgroundCheckBox.UseVisualStyleBackColor = true;
            this.backgroundCheckBox.CheckedChanged += new System.EventHandler(this.backgroundCheckBox_CheckedChanged);
            // 
            // fontColorCheckBox
            // 
            this.fontColorCheckBox.AutoSize = true;
            this.fontColorCheckBox.Location = new System.Drawing.Point(280, 57);
            this.fontColorCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fontColorCheckBox.Name = "fontColorCheckBox";
            this.fontColorCheckBox.Size = new System.Drawing.Size(175, 24);
            this.fontColorCheckBox.TabIndex = 7;
            this.fontColorCheckBox.Text = "zmien kolor czcionki";
            this.fontColorCheckBox.UseVisualStyleBackColor = true;
            this.fontColorCheckBox.CheckedChanged += new System.EventHandler(this.fontColorCheckBox_CheckedChanged);
            // 
            // fontSizeCheckBox
            // 
            this.fontSizeCheckBox.AutoSize = true;
            this.fontSizeCheckBox.Location = new System.Drawing.Point(280, 94);
            this.fontSizeCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fontSizeCheckBox.Name = "fontSizeCheckBox";
            this.fontSizeCheckBox.Size = new System.Drawing.Size(193, 24);
            this.fontSizeCheckBox.TabIndex = 8;
            this.fontSizeCheckBox.Text = "zmien rozmiar czcionki";
            this.fontSizeCheckBox.UseVisualStyleBackColor = true;
            this.fontSizeCheckBox.CheckedChanged += new System.EventHandler(this.fontSizeCheckBox_CheckedChanged);
            // 
            // background
            // 
            this.background.Location = new System.Drawing.Point(476, 15);
            this.background.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.background.Name = "background";
            this.background.Size = new System.Drawing.Size(148, 26);
            this.background.TabIndex = 9;
            // 
            // color
            // 
            this.color.Location = new System.Drawing.Point(476, 54);
            this.color.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(148, 26);
            this.color.TabIndex = 10;
            // 
            // size
            // 
            this.size.Location = new System.Drawing.Point(476, 88);
            this.size.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(148, 26);
            this.size.TabIndex = 11;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(344, 134);
            this.text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(48, 20);
            this.text.TabIndex = 12;
            this.text.Text = "Tekst";
            // 
            // changeLabel
            // 
            this.changeLabel.Location = new System.Drawing.Point(501, 128);
            this.changeLabel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(112, 35);
            this.changeLabel.TabIndex = 13;
            this.changeLabel.Text = "wykonaj";
            this.changeLabel.UseVisualStyleBackColor = true;
            this.changeLabel.Click += new System.EventHandler(this.changeLabel_Click);
            // 
            // clear
            // 
            this.clear.Location = new System.Drawing.Point(1018, 15);
            this.clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(112, 35);
            this.clear.TabIndex = 14;
            this.clear.Text = "wyczysc";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(884, 15);
            this.add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(112, 35);
            this.add.TabIndex = 15;
            this.add.Text = "dodaj";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(711, 18);
            this.inputN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(148, 26);
            this.inputN.TabIndex = 16;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(711, 83);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(418, 324);
            this.listBox.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(711, 418);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 24);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "potegowanie";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(711, 454);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(114, 24);
            this.checkBox2.TabIndex = 19;
            this.checkBox2.Text = "pierwiastek";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(711, 489);
            this.checkBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(117, 24);
            this.checkBox3.TabIndex = 20;
            this.checkBox3.Text = "odwrotnosc";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // executeNumbersList
            // 
            this.executeNumbersList.Location = new System.Drawing.Point(910, 420);
            this.executeNumbersList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.executeNumbersList.Name = "executeNumbersList";
            this.executeNumbersList.Size = new System.Drawing.Size(112, 35);
            this.executeNumbersList.TabIndex = 21;
            this.executeNumbersList.Text = "wykonaj";
            this.executeNumbersList.UseVisualStyleBackColor = true;
            this.executeNumbersList.Click += new System.EventHandler(this.executeNumbersList_Click);
            // 
            // elementInput
            // 
            this.elementInput.Location = new System.Drawing.Point(1206, 18);
            this.elementInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.elementInput.Name = "elementInput";
            this.elementInput.Size = new System.Drawing.Size(148, 26);
            this.elementInput.TabIndex = 22;
            // 
            // addSorted
            // 
            this.addSorted.Location = new System.Drawing.Point(1362, 14);
            this.addSorted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addSorted.Name = "addSorted";
            this.addSorted.Size = new System.Drawing.Size(112, 35);
            this.addSorted.TabIndex = 23;
            this.addSorted.Text = "dodaj";
            this.addSorted.UseVisualStyleBackColor = true;
            this.addSorted.Click += new System.EventHandler(this.addSorted_Click);
            // 
            // clearSorted
            // 
            this.clearSorted.Location = new System.Drawing.Point(1482, 14);
            this.clearSorted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearSorted.Name = "clearSorted";
            this.clearSorted.Size = new System.Drawing.Size(112, 35);
            this.clearSorted.TabIndex = 24;
            this.clearSorted.Text = "wyczysc";
            this.clearSorted.UseVisualStyleBackColor = true;
            this.clearSorted.Click += new System.EventHandler(this.clearSorted_Click);
            // 
            // sortedBox
            // 
            this.sortedBox.FormattingEnabled = true;
            this.sortedBox.ItemHeight = 20;
            this.sortedBox.Location = new System.Drawing.Point(1202, 91);
            this.sortedBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortedBox.Name = "sortedBox";
            this.sortedBox.Size = new System.Drawing.Size(418, 324);
            this.sortedBox.TabIndex = 25;
            // 
            // sortAscending
            // 
            this.sortAscending.Location = new System.Drawing.Point(1346, 489);
            this.sortAscending.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortAscending.Name = "sortAscending";
            this.sortAscending.Size = new System.Drawing.Size(112, 35);
            this.sortAscending.TabIndex = 30;
            this.sortAscending.Text = "rosnaco";
            this.sortAscending.UseVisualStyleBackColor = true;
            this.sortAscending.Click += new System.EventHandler(this.sortAscending_Click);
            // 
            // sortDescending
            // 
            this.sortDescending.Location = new System.Drawing.Point(1466, 489);
            this.sortDescending.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sortDescending.Name = "sortDescending";
            this.sortDescending.Size = new System.Drawing.Size(112, 35);
            this.sortDescending.TabIndex = 31;
            this.sortDescending.Text = "malejaco";
            this.sortDescending.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sortDescending.UseVisualStyleBackColor = true;
            this.sortDescending.Click += new System.EventHandler(this.sortDescending_Click);
            // 
            // showNumbersButton
            // 
            this.showNumbersButton.Location = new System.Drawing.Point(1346, 454);
            this.showNumbersButton.Name = "showNumbersButton";
            this.showNumbersButton.Size = new System.Drawing.Size(112, 33);
            this.showNumbersButton.TabIndex = 32;
            this.showNumbersButton.Text = "liczby";
            this.showNumbersButton.UseVisualStyleBackColor = true;
            this.showNumbersButton.Click += new System.EventHandler(this.showNumbersButton_Click);
            // 
            // showStringsButton
            // 
            this.showStringsButton.Location = new System.Drawing.Point(1464, 454);
            this.showStringsButton.Name = "showStringsButton";
            this.showStringsButton.Size = new System.Drawing.Size(112, 33);
            this.showStringsButton.TabIndex = 33;
            this.showStringsButton.Text = "napisy";
            this.showStringsButton.UseVisualStyleBackColor = true;
            this.showStringsButton.Click += new System.EventHandler(this.showStringsButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 692);
            this.Controls.Add(this.showStringsButton);
            this.Controls.Add(this.showNumbersButton);
            this.Controls.Add(this.sortDescending);
            this.Controls.Add(this.sortAscending);
            this.Controls.Add(this.sortedBox);
            this.Controls.Add(this.clearSorted);
            this.Controls.Add(this.addSorted);
            this.Controls.Add(this.elementInput);
            this.Controls.Add(this.executeNumbersList);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.inputN);
            this.Controls.Add(this.add);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.text);
            this.Controls.Add(this.size);
            this.Controls.Add(this.color);
            this.Controls.Add(this.background);
            this.Controls.Add(this.fontSizeCheckBox);
            this.Controls.Add(this.fontColorCheckBox);
            this.Controls.Add(this.backgroundCheckBox);
            this.Controls.Add(this.inverseCh);
            this.Controls.Add(this.rootCh);
            this.Controls.Add(this.powerCh);
            this.Controls.Add(this.result);
            this.Controls.Add(this.number);
            this.Controls.Add(this.execute);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "delegaty";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox powerCh;
        private System.Windows.Forms.CheckBox rootCh;
        private System.Windows.Forms.CheckBox inverseCh;
        private System.Windows.Forms.Button execute;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.CheckBox backgroundCheckBox;
        private System.Windows.Forms.CheckBox fontColorCheckBox;
        private System.Windows.Forms.CheckBox fontSizeCheckBox;
        private System.Windows.Forms.TextBox background;
        private System.Windows.Forms.TextBox color;
        private System.Windows.Forms.TextBox size;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button changeLabel;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.TextBox inputN;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.Button executeNumbersList;
        private System.Windows.Forms.TextBox elementInput;
        private System.Windows.Forms.Button addSorted;
        private System.Windows.Forms.Button clearSorted;
        private System.Windows.Forms.ListBox sortedBox;
        private System.Windows.Forms.Button sortAscending;
        private System.Windows.Forms.Button sortDescending;
        private System.Windows.Forms.Button showNumbersButton;
        private System.Windows.Forms.Button showStringsButton;
    }
}

