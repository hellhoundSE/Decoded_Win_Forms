namespace Decoder
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
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBox_showPoem = new System.Windows.Forms.RichTextBox();
            this.comboBox_row = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_word = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_poem = new System.Windows.Forms.ComboBox();
            this.txt_wordfield = new System.Windows.Forms.RichTextBox();
            this.Bnt_enctypt = new System.Windows.Forms.Button();
            this.txt_encrypted = new System.Windows.Forms.RichTextBox();
            this.DbGrid = new System.Windows.Forms.DataGridView();
            this.logBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Btn_goToCreateKey = new System.Windows.Forms.Button();
            this.Btn_goToInputKey = new System.Windows.Forms.Button();
            this.Btn_goToLogs = new System.Windows.Forms.Button();
            this.Btn_confirmCreating = new System.Windows.Forms.Button();
            this.textBox_provideKey = new System.Windows.Forms.TextBox();
            this.Btn_confirmInputing = new System.Windows.Forms.Button();
            this.txt_keyCode = new System.Windows.Forms.TextBox();
            this.txt_textToEncode = new System.Windows.Forms.RichTextBox();
            this.Btn_readFromFile = new System.Windows.Forms.Button();
            this.Btn_back = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.btn_saaveToFile = new System.Windows.Forms.Button();
            this.cb_searchType = new System.Windows.Forms.ComboBox();
            this.txt_fieldToSearch = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.checkbox_encodeSerch = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.textBox_Count = new System.Windows.Forms.TextBox();
            this.checkBox_Count = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.DbGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBox_showPoem
            // 
            this.textBox_showPoem.Location = new System.Drawing.Point(12, 21);
            this.textBox_showPoem.Name = "textBox_showPoem";
            this.textBox_showPoem.Size = new System.Drawing.Size(278, 366);
            this.textBox_showPoem.TabIndex = 2;
            this.textBox_showPoem.Text = "";
            this.textBox_showPoem.Visible = false;
            // 
            // comboBox_row
            // 
            this.comboBox_row.FormattingEnabled = true;
            this.comboBox_row.Location = new System.Drawing.Point(366, 146);
            this.comboBox_row.Name = "comboBox_row";
            this.comboBox_row.Size = new System.Drawing.Size(243, 21);
            this.comboBox_row.TabIndex = 4;
            this.comboBox_row.Visible = false;
            this.comboBox_row.SelectedIndexChanged += new System.EventHandler(this.comboBox_row_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(308, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "row";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(308, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "word";
            this.label2.Visible = false;
            // 
            // comboBox_word
            // 
            this.comboBox_word.FormattingEnabled = true;
            this.comboBox_word.Location = new System.Drawing.Point(488, 184);
            this.comboBox_word.Name = "comboBox_word";
            this.comboBox_word.Size = new System.Drawing.Size(121, 21);
            this.comboBox_word.TabIndex = 7;
            this.comboBox_word.Visible = false;
            this.comboBox_word.SelectedIndexChanged += new System.EventHandler(this.comboBox_word_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "poem";
            this.label3.Visible = false;
            // 
            // comboBox_poem
            // 
            this.comboBox_poem.FormattingEnabled = true;
            this.comboBox_poem.Location = new System.Drawing.Point(527, 112);
            this.comboBox_poem.Name = "comboBox_poem";
            this.comboBox_poem.Size = new System.Drawing.Size(82, 21);
            this.comboBox_poem.TabIndex = 8;
            this.comboBox_poem.Visible = false;
            this.comboBox_poem.SelectedIndexChanged += new System.EventHandler(this.comboBox_poem_SelectedIndexChanged);
            // 
            // txt_wordfield
            // 
            this.txt_wordfield.Enabled = false;
            this.txt_wordfield.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_wordfield.Location = new System.Drawing.Point(418, 219);
            this.txt_wordfield.Name = "txt_wordfield";
            this.txt_wordfield.Size = new System.Drawing.Size(191, 51);
            this.txt_wordfield.TabIndex = 10;
            this.txt_wordfield.Text = "";
            this.txt_wordfield.Visible = false;
            // 
            // Bnt_enctypt
            // 
            this.Bnt_enctypt.Location = new System.Drawing.Point(635, 106);
            this.Bnt_enctypt.Name = "Bnt_enctypt";
            this.Bnt_enctypt.Size = new System.Drawing.Size(100, 30);
            this.Bnt_enctypt.TabIndex = 11;
            this.Bnt_enctypt.Text = "Encrypt";
            this.Bnt_enctypt.UseVisualStyleBackColor = true;
            this.Bnt_enctypt.Visible = false;
            this.Bnt_enctypt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // txt_encrypted
            // 
            this.txt_encrypted.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_encrypted.Location = new System.Drawing.Point(311, 106);
            this.txt_encrypted.Name = "txt_encrypted";
            this.txt_encrypted.Size = new System.Drawing.Size(235, 201);
            this.txt_encrypted.TabIndex = 12;
            this.txt_encrypted.Text = "";
            this.txt_encrypted.Visible = false;
            // 
            // DbGrid
            // 
            this.DbGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DbGrid.Location = new System.Drawing.Point(30, 28);
            this.DbGrid.Name = "DbGrid";
            this.DbGrid.Size = new System.Drawing.Size(738, 324);
            this.DbGrid.TabIndex = 13;
            this.DbGrid.Visible = false;
            this.DbGrid.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DbGrid_CellContentDoubleClick);
            this.DbGrid.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DbGrid_ColumnHeaderMouseClick);
            // 
            // logBindingSource
            // 
            this.logBindingSource.DataMember = "Log";
            // 
            // Btn_goToCreateKey
            // 
            this.Btn_goToCreateKey.Location = new System.Drawing.Point(635, 106);
            this.Btn_goToCreateKey.Name = "Btn_goToCreateKey";
            this.Btn_goToCreateKey.Size = new System.Drawing.Size(100, 30);
            this.Btn_goToCreateKey.TabIndex = 14;
            this.Btn_goToCreateKey.Text = "Create key";
            this.Btn_goToCreateKey.UseVisualStyleBackColor = true;
            this.Btn_goToCreateKey.Click += new System.EventHandler(this.Btn_goToCreateKey_Click);
            // 
            // Btn_goToInputKey
            // 
            this.Btn_goToInputKey.Location = new System.Drawing.Point(635, 165);
            this.Btn_goToInputKey.Name = "Btn_goToInputKey";
            this.Btn_goToInputKey.Size = new System.Drawing.Size(100, 30);
            this.Btn_goToInputKey.TabIndex = 15;
            this.Btn_goToInputKey.Text = "Input key";
            this.Btn_goToInputKey.UseVisualStyleBackColor = true;
            this.Btn_goToInputKey.Click += new System.EventHandler(this.Btn_goToInputKey_Click);
            // 
            // Btn_goToLogs
            // 
            this.Btn_goToLogs.Location = new System.Drawing.Point(635, 223);
            this.Btn_goToLogs.Name = "Btn_goToLogs";
            this.Btn_goToLogs.Size = new System.Drawing.Size(100, 30);
            this.Btn_goToLogs.TabIndex = 16;
            this.Btn_goToLogs.Text = "Logs";
            this.Btn_goToLogs.UseVisualStyleBackColor = true;
            this.Btn_goToLogs.Click += new System.EventHandler(this.Btn_goToLogs_Click);
            // 
            // Btn_confirmCreating
            // 
            this.Btn_confirmCreating.Location = new System.Drawing.Point(635, 223);
            this.Btn_confirmCreating.Name = "Btn_confirmCreating";
            this.Btn_confirmCreating.Size = new System.Drawing.Size(100, 30);
            this.Btn_confirmCreating.TabIndex = 17;
            this.Btn_confirmCreating.Text = "Confirm";
            this.Btn_confirmCreating.UseVisualStyleBackColor = true;
            this.Btn_confirmCreating.Visible = false;
            this.Btn_confirmCreating.Click += new System.EventHandler(this.Btn_confirmCreating_Click);
            // 
            // textBox_provideKey
            // 
            this.textBox_provideKey.Location = new System.Drawing.Point(527, 184);
            this.textBox_provideKey.Name = "textBox_provideKey";
            this.textBox_provideKey.Size = new System.Drawing.Size(82, 20);
            this.textBox_provideKey.TabIndex = 18;
            this.textBox_provideKey.Visible = false;
            this.textBox_provideKey.TextChanged += new System.EventHandler(this.textBox_provideKey_TextChanged);
            // 
            // Btn_confirmInputing
            // 
            this.Btn_confirmInputing.Location = new System.Drawing.Point(635, 223);
            this.Btn_confirmInputing.Name = "Btn_confirmInputing";
            this.Btn_confirmInputing.Size = new System.Drawing.Size(100, 30);
            this.Btn_confirmInputing.TabIndex = 19;
            this.Btn_confirmInputing.Text = "Confirm";
            this.Btn_confirmInputing.UseVisualStyleBackColor = true;
            this.Btn_confirmInputing.Visible = false;
            this.Btn_confirmInputing.Click += new System.EventHandler(this.Btn_confirmInputing_Click);
            // 
            // txt_keyCode
            // 
            this.txt_keyCode.Enabled = false;
            this.txt_keyCode.Location = new System.Drawing.Point(418, 51);
            this.txt_keyCode.Name = "txt_keyCode";
            this.txt_keyCode.Size = new System.Drawing.Size(75, 20);
            this.txt_keyCode.TabIndex = 20;
            this.txt_keyCode.Text = "txtasdas";
            this.txt_keyCode.Visible = false;
            // 
            // txt_textToEncode
            // 
            this.txt_textToEncode.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txt_textToEncode.Location = new System.Drawing.Point(30, 106);
            this.txt_textToEncode.Name = "txt_textToEncode";
            this.txt_textToEncode.Size = new System.Drawing.Size(235, 201);
            this.txt_textToEncode.TabIndex = 21;
            this.txt_textToEncode.Text = "";
            this.txt_textToEncode.Visible = false;
            // 
            // Btn_readFromFile
            // 
            this.Btn_readFromFile.Location = new System.Drawing.Point(75, 322);
            this.Btn_readFromFile.Name = "Btn_readFromFile";
            this.Btn_readFromFile.Size = new System.Drawing.Size(100, 30);
            this.Btn_readFromFile.TabIndex = 22;
            this.Btn_readFromFile.Text = "Read from file";
            this.Btn_readFromFile.UseVisualStyleBackColor = true;
            this.Btn_readFromFile.Visible = false;
            this.Btn_readFromFile.Click += new System.EventHandler(this.txt_readFromFile_Click);
            // 
            // Btn_back
            // 
            this.Btn_back.Location = new System.Drawing.Point(635, 384);
            this.Btn_back.Name = "Btn_back";
            this.Btn_back.Size = new System.Drawing.Size(100, 30);
            this.Btn_back.TabIndex = 23;
            this.Btn_back.Text = "back";
            this.Btn_back.UseVisualStyleBackColor = true;
            this.Btn_back.Click += new System.EventHandler(this.Btn_back_Click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(635, 165);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(100, 30);
            this.btn_decrypt.TabIndex = 24;
            this.btn_decrypt.Text = "Dectypt";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Visible = false;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_Click);
            // 
            // btn_saaveToFile
            // 
            this.btn_saaveToFile.Location = new System.Drawing.Point(368, 322);
            this.btn_saaveToFile.Name = "btn_saaveToFile";
            this.btn_saaveToFile.Size = new System.Drawing.Size(100, 30);
            this.btn_saaveToFile.TabIndex = 25;
            this.btn_saaveToFile.Text = "Save to file";
            this.btn_saaveToFile.UseVisualStyleBackColor = true;
            this.btn_saaveToFile.Visible = false;
            this.btn_saaveToFile.Click += new System.EventHandler(this.btn_saaveToFile_Click);
            // 
            // cb_searchType
            // 
            this.cb_searchType.FormattingEnabled = true;
            this.cb_searchType.Location = new System.Drawing.Point(30, 393);
            this.cb_searchType.Name = "cb_searchType";
            this.cb_searchType.Size = new System.Drawing.Size(121, 21);
            this.cb_searchType.TabIndex = 26;
            this.cb_searchType.Visible = false;
            this.cb_searchType.SelectedIndexChanged += new System.EventHandler(this.cb_searchType_SelectedIndexChanged);
            // 
            // txt_fieldToSearch
            // 
            this.txt_fieldToSearch.Location = new System.Drawing.Point(30, 430);
            this.txt_fieldToSearch.Name = "txt_fieldToSearch";
            this.txt_fieldToSearch.Size = new System.Drawing.Size(121, 20);
            this.txt_fieldToSearch.TabIndex = 27;
            this.txt_fieldToSearch.Visible = false;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(30, 485);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 30);
            this.btn_search.TabIndex = 28;
            this.btn_search.Text = "search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Visible = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // checkbox_encodeSerch
            // 
            this.checkbox_encodeSerch.AutoSize = true;
            this.checkbox_encodeSerch.Location = new System.Drawing.Point(30, 462);
            this.checkbox_encodeSerch.Name = "checkbox_encodeSerch";
            this.checkbox_encodeSerch.Size = new System.Drawing.Size(62, 17);
            this.checkbox_encodeSerch.TabIndex = 29;
            this.checkbox_encodeSerch.Text = "encode";
            this.checkbox_encodeSerch.UseVisualStyleBackColor = true;
            this.checkbox_encodeSerch.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Selected key";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Provide text here";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Provide key here";
            this.label6.Visible = false;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(174, 393);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Less / earlier";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Visible = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(174, 417);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.Text = "Equalse";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(174, 441);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 17);
            this.radioButton3.TabIndex = 35;
            this.radioButton3.Text = "Greate / Later";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Visible = false;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBox_Count
            // 
            this.textBox_Count.Enabled = false;
            this.textBox_Count.Location = new System.Drawing.Point(227, 462);
            this.textBox_Count.Name = "textBox_Count";
            this.textBox_Count.Size = new System.Drawing.Size(63, 20);
            this.textBox_Count.TabIndex = 37;
            this.textBox_Count.Visible = false;
            // 
            // checkBox_Count
            // 
            this.checkBox_Count.AutoSize = true;
            this.checkBox_Count.Location = new System.Drawing.Point(174, 464);
            this.checkBox_Count.Name = "checkBox_Count";
            this.checkBox_Count.Size = new System.Drawing.Size(54, 17);
            this.checkBox_Count.TabIndex = 38;
            this.checkBox_Count.Text = "Count";
            this.checkBox_Count.UseVisualStyleBackColor = true;
            this.checkBox_Count.Visible = false;
            this.checkBox_Count.CheckedChanged += new System.EventHandler(this.checkBox_Count_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.checkBox_Count);
            this.Controls.Add(this.textBox_Count);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkbox_encodeSerch);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_fieldToSearch);
            this.Controls.Add(this.cb_searchType);
            this.Controls.Add(this.btn_saaveToFile);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.Btn_back);
            this.Controls.Add(this.Btn_readFromFile);
            this.Controls.Add(this.txt_textToEncode);
            this.Controls.Add(this.txt_keyCode);
            this.Controls.Add(this.Btn_confirmInputing);
            this.Controls.Add(this.textBox_provideKey);
            this.Controls.Add(this.Btn_confirmCreating);
            this.Controls.Add(this.Btn_goToLogs);
            this.Controls.Add(this.Btn_goToInputKey);
            this.Controls.Add(this.Btn_goToCreateKey);
            this.Controls.Add(this.DbGrid);
            this.Controls.Add(this.txt_encrypted);
            this.Controls.Add(this.Bnt_enctypt);
            this.Controls.Add(this.txt_wordfield);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_poem);
            this.Controls.Add(this.comboBox_word);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_row);
            this.Controls.Add(this.textBox_showPoem);
            this.Name = "Form1";
            this.Text = "AaA";
            ((System.ComponentModel.ISupportInitialize)(this.DbGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox textBox_showPoem;
        private System.Windows.Forms.ComboBox comboBox_row;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_word;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_poem;
        private System.Windows.Forms.RichTextBox txt_wordfield;
        private System.Windows.Forms.Button Bnt_enctypt;
        private System.Windows.Forms.RichTextBox txt_encrypted;
        private System.Windows.Forms.DataGridView DbGrid;
        private System.Windows.Forms.BindingSource logBindingSource;
        private System.Windows.Forms.Button Btn_goToCreateKey;
        private System.Windows.Forms.Button Btn_goToInputKey;
        private System.Windows.Forms.Button Btn_goToLogs;
        private System.Windows.Forms.Button Btn_confirmCreating;
        private System.Windows.Forms.TextBox textBox_provideKey;
        private System.Windows.Forms.Button Btn_confirmInputing;
        private System.Windows.Forms.TextBox txt_keyCode;
        private System.Windows.Forms.RichTextBox txt_textToEncode;
        private System.Windows.Forms.Button Btn_readFromFile;
        private System.Windows.Forms.Button Btn_back;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.Button btn_saaveToFile;
        private System.Windows.Forms.ComboBox cb_searchType;
        private System.Windows.Forms.TextBox txt_fieldToSearch;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.CheckBox checkbox_encodeSerch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.TextBox textBox_Count;
        private System.Windows.Forms.CheckBox checkBox_Count;
    }
}

