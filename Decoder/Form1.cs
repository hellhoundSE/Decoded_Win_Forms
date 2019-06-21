using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder
{
    public partial class Form1 : Form
    {
        List<List<string>> poems = new List<List<string>>();
        string key = "";
        string keyCode = "";
        int searchWay = 0;

        public Form1()
        {
            InitializeComponent();
            GetInputFromFile("poem1.txt");
            GetInputFromFile("poem2.txt");
            GetInputFromFile("poem3.txt");

            for (int i = 1; i <= poems.Count; i++)
            {
                comboBox_poem.Items.Add(i);
            }

            List<string> searchList= new List<string>();
            cb_searchType.Items.Add("by id");
            cb_searchType.Items.Add("by word");
            cb_searchType.Items.Add("by key");
            cb_searchType.Items.Add("by result");
            cb_searchType.Items.Add("by time");
            cb_searchType.Items.Add("by encode/decode");

        }

        private void GetInputFromFile(string path)
        {
            StreamReader sr = new StreamReader(path);
            List<string> list = new List<string>();
            while (sr.Peek() != -1)
            {
                list.Add(sr.ReadLine());
            }
            sr.Close();
            poems.Add(list);
        }

        private void comboBox_poem_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 1;
            textBox_showPoem.Text = "";
            comboBox_row.Items.Clear();
            foreach (string line in poems[comboBox_poem.SelectedIndex])
            {
                comboBox_row.Items.Add(line + "(" + i++ + ")");
                textBox_showPoem.Text += line + "\n";
            }
            
        }
        private void comboBox_row_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = 1;
            comboBox_word.Items.Clear();
            foreach (string word in poems[comboBox_poem.SelectedIndex][comboBox_row.SelectedIndex].Split(' '))
            {
                comboBox_word.Items.Add(word + "(" + (i++) + ")");
            }
        }
        private void comboBox_word_SelectedIndexChanged(object sender, EventArgs e)
        {
            key = "";
            foreach (char c in comboBox_word.SelectedItem.ToString())
            {
                if (c >= 'A' && c <= 'z')
                    key += (char)c;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string word = txt_textToEncode.Text;
            string encrypted = Encoder.encode(word, key);

            txt_encrypted.Text = encrypted;

            DbEntities db = new DbEntities();

            Log l = new Log();
            l.datetime = System.DateTime.Now;
            l.key = key;
            l.word = word;
            l.result = encrypted;
            l.emcoded = true;

            db.Log.Add(l);
            db.SaveChanges();

            DbGrid.DataSource = db.Log.ToList();
        }

        private void Btn_goToCreateKey_Click(object sender, EventArgs e)
        {
            showZero(false);
            showOne(true);
        }
        private void Btn_goToInputKey_Click(object sender, EventArgs e)
        {
            showZero(false);
            showTwo(true);
        }

        private void textBox_provideKey_TextChanged(object sender, EventArgs e)
        {
                string possibleKey = "";
                int poem_num = 0;
                int line_num = 0;
                int word_num = 0;
                Boolean check = true;
                if (textBox_provideKey.Text.Length == 3 || textBox_provideKey.Text.Length == 4){

                    if (textBox_provideKey.Text.Length == 3)
                    {
                        char[] tab = textBox_provideKey.Text.ToCharArray();

                        if (int.TryParse(tab[0] + "", out poem_num) && int.TryParse(tab[1] + "", out line_num) &&
                            int.TryParse(tab[2] + "", out word_num))
                        {
                            check = true;
                        }
                    }
                    if (textBox_provideKey.Text.Length == 4)
                    {
                        char[] tab = textBox_provideKey.Text.ToCharArray();
                        if (int.TryParse(tab[0] + "", out poem_num) && int.TryParse(tab[1] + "" + tab[2], out line_num) &&
                            int.TryParse(tab[3] + "", out word_num))
                        {
                            check = true;
                        }
                    }
                    if (check && poems.Count > poem_num - 1 && poem_num > 0)
                    {
                        List<string> poem = poems[poem_num - 1];

                        if (poem.Count > line_num - 1 && line_num > 0)
                        {
                            string line = poem[line_num - 1];
                            if (line.Split(' ').Length > word_num - 1 && word_num > 0)
                            {
                                string[] words = line.Split(' ');
                                foreach(char c in words[word_num - 1])
                                {
                                    if (Encoder.characters.Contains(c))
                                    {
                                    possibleKey += c;
                                    }
                                }
                                txt_wordfield.Text = possibleKey;
                                key = possibleKey;
                                keyCode = poem_num + "" + line_num + "" + word_num;
                            }
                        }
                    }
                }
        }


        private void Btn_confirmCreating_Click(object sender, EventArgs e)
        {
            if(!key.Equals(""))
            {
                keyCode = (comboBox_poem.SelectedIndex + 1 )+ "" + (comboBox_row.SelectedIndex + 1 )+ "" + (comboBox_word.SelectedIndex + 1);
                txt_keyCode.Text = keyCode;                
                showOne(false);
                showFour(true);
            }
        }
        private void Btn_confirmInputing_Click(object sender, EventArgs e)
        {
            if (!key.Equals(""))
            {
                txt_keyCode.Text = keyCode;
                showTwo(false);
                showFour(true);
            }

        }



        private void showZero(Boolean t)
        {

            Btn_back.Visible = !t;
            Btn_goToCreateKey.Visible = t;
            Btn_goToInputKey.Visible = t;
            Btn_goToLogs.Visible = t;
        }
        private void showOne(Boolean t)
        {
            if (!t)
            {
                textBox_showPoem.Text = "";
            }
            label1.Visible = t;
            label2.Visible = t;
            label3.Visible = t;

            comboBox_poem.Visible = t;
            comboBox_row.Visible = t;
            comboBox_word.Visible = t;
            textBox_showPoem.Visible = t;
            Btn_confirmCreating.Visible = t;
        }
        private void showTwo(Boolean t)
        {
            if (!t)
            {
                textBox_provideKey.Text = "";
                txt_wordfield.Text = "";
            }
            textBox_provideKey.Visible = t;
            txt_wordfield.Visible = t;
            Btn_confirmInputing.Visible = t;
            label6.Visible = t;
        }
        private void showThree(Boolean t)
        {
            if (!t)
            {
            }
            DbGrid.Visible = t;
            cb_searchType.Visible = t;
            btn_search.Visible = t;
            txt_fieldToSearch.Visible = t;
            radioButton1.Visible = t;
            radioButton2.Visible = t;
            radioButton3.Visible = t;
            checkBox_Count.Visible = t;
        }
        private void showFour(Boolean t)
        {
            if (!t)
            {
                txt_keyCode.Text = "";
                txt_textToEncode.Text = "";
                txt_encrypted.Text = "";
                key = "";

            }
            label4.Visible = t;
            txt_keyCode.Visible = t;
            txt_textToEncode.Visible = t;
            Bnt_enctypt.Visible = t;
            Btn_readFromFile.Visible = t;
            txt_encrypted.Visible = t;
            btn_decrypt.Visible = t;
            btn_saaveToFile.Visible = t;
            label5.Visible = t;
            
        }

        private void txt_readFromFile_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            { 
               StreamReader sr = new StreamReader(openFileDialog1.FileName);
               txt_textToEncode.Text = "";
               while (sr.Peek() != -1)
               {
                   txt_textToEncode.Text += sr.ReadLine();
               }
               sr.Close();
            }
            
        }

        private void Btn_back_Click(object sender, EventArgs e)
        {
            showOne(false);
            showTwo(false);
            showThree(false);
            showFour(false);
            showZero(true);
        }

        private void btn_decrypt_Click(object sender, EventArgs e)
        {
            string word = txt_textToEncode.Text;
            string encrypted = Encoder.decode(word, key);

            txt_encrypted.Text = encrypted;

            DbEntities db = new DbEntities();

            Log l = new Log();
            l.datetime = System.DateTime.Now;
            l.key = key;
            l.word = word;
            l.result = encrypted;
            l.emcoded = false;

            db.Log.Add(l);
            db.SaveChanges();

            DbGrid.DataSource = db.Log.ToList();


        }

        private void Btn_goToLogs_Click(object sender, EventArgs e)
        {
            showZero(false);
            showThree(true);
        }

        private void btn_saaveToFile_Click(object sender, EventArgs e)
        {
            System.IO.File.WriteAllText(Application.StartupPath +
                System.DateTime.Now.Year+""+
                System.DateTime.Now.Month + ""+
                System.DateTime.Now.Day+""+
                System.DateTime.Now.Hour+""+
                System.DateTime.Now.Minute+""+ System.DateTime.Now.Second+".txt", txt_encrypted.Text);
        }

        private void cb_searchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            DbEntities db = new DbEntities();
            DbGrid.DataSource = db.Log.ToList();

            if (cb_searchType.SelectedIndex == 5)
            {
                txt_fieldToSearch.Visible = false;
                checkbox_encodeSerch.Visible = true;
            }
            else
            {
                txt_fieldToSearch.Visible = true;
                checkbox_encodeSerch.Visible = false;
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            searchWay = 0;
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            searchWay = 1;
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            searchWay = 2;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            DbEntities db = new DbEntities();

            switch (cb_searchType.SelectedIndex)
            {

                case 0:
                    {
                        int id;
                        if(int.TryParse(txt_fieldToSearch.Text,out id)){
                            switch (searchWay)
                            {
                                case 2:
                                    DbGrid.DataSource = db.Log.Where(x => x.Id <= id).Select(x => x).ToList();
                                    break;
                                case 1:
                                    DbGrid.DataSource = db.Log.Where(x => x.Id == id).Select(x => x).ToList();
                                    break;
                                case 0:
                                    DbGrid.DataSource = db.Log.Where(x => x.Id >= id).Select(x => x).ToList();
                                    break;
                            }
                        }
                    }
                    break;
                case 1:
                    DbGrid.DataSource = db.Log.Where(x => x.word.Contains(txt_fieldToSearch.Text)).Select(x => x).ToList();
                    break;
                case 2:
                    DbGrid.DataSource = db.Log.Where(x => x.key.Contains(txt_fieldToSearch.Text)).Select(x => x).ToList();
                    break;
                case 3:
                    DbGrid.DataSource = db.Log.Where(x => x.result.Contains(txt_fieldToSearch.Text)).Select(x => x).ToList();
                    break;
                case 4:
                    {
                        DateTime time;
                        System.Diagnostics.Debug.WriteLine("before");
                        if (DateTime.TryParse(txt_fieldToSearch.Text, out time)){
                            System.Diagnostics.Debug.WriteLine("parsed");
                            System.Diagnostics.Debug.WriteLine(time.ToString());
                            switch (searchWay)
                            {
                                case 0:
                                    DbGrid.DataSource = db.Log.Where(x => x.datetime <= time).Select(x => x).ToList();
                                    break;
                                case 1:
                                    DbGrid.DataSource = db.Log.Where(x => x.datetime == time).Select(x => x).ToList();
                                    break;
                                case 2:
                                    DbGrid.DataSource = db.Log.Where(x => x.datetime >= time).Select(x => x).ToList();
                                    break;
                            }
                        }
                    }
                    break;
                case 5:
                    DbGrid.DataSource = db.Log.Where(x => x.emcoded == checkbox_encodeSerch.Checked).Select(x => x).ToList();
                    break;
            }
            if (checkBox_Count.Checked)
            {
                textBox_Count.Text = DbGrid.RowCount+"";
            }
        }

        private void checkBox_Count_CheckedChanged(object sender, EventArgs e)
        {
            textBox_Count.Visible = checkBox_Count.Checked;
        }

        private void DbGrid_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DbEntities db = new DbEntities();
            List<Log> list;

            switch (e.ColumnIndex)
            {
                case 0:
                    list = db.Log.OrderBy(c => c.Id).ToList();
                    break;
                case 1:
                    list = db.Log.OrderBy(c => c.word).ToList();
                    break;
                case 2:
                    list = db.Log.OrderBy(c => c.key).ToList();
                    break;
                case 3:
                    list = db.Log.OrderBy(c => c.result).ToList();
                    break;
                case 4:
                    list = db.Log.OrderBy(c => c.emcoded).ToList();
                    break;
                case 5:
                    list = db.Log.OrderBy(c => c.datetime).ToList();

                    break;
                default:
                    list = db.Log.ToList();
                    break;
            }
            DbGrid.DataSource = list;
        }

        private void DbGrid_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DbEntities db = new DbEntities();
            List<Log> list;

            switch (e.ColumnIndex)
            {
                case 0:
                    list = db.Log.OrderBy(c => c.Id).ToList();
                    break;
                case 1:
                    list = db.Log.OrderBy(c => c.word).ToList();
                    break;
                case 2:
                    list = db.Log.OrderBy(c => c.key).ToList();
                    break;
                case 3:
                    list = db.Log.OrderBy(c => c.result).ToList();
                    break;
                case 4:
                    list = db.Log.OrderBy(c => c.emcoded).ToList();
                    break;
                case 5:
                    list = db.Log.OrderBy(c => c.datetime).ToList();

                    break;
                default:
                    list = db.Log.ToList();
                    break;
            }
            list.Reverse();
            DbGrid.DataSource = list;
        }

    }
}
