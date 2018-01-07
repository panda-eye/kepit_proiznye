using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace KEPIT_Proiznye
{
    public partial class Groups : Form
    {
        private List<string> a { get; set; }
        private string currentMonth { get; set; }
        private Settings pathes;
        public Groups(string currentMonth)
        {
            InitializeComponent();
            this.currentMonth = currentMonth;
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT_Settings.xml")) pathes = (Settings)new XmlSerializer(typeof(Settings)).Deserialize(File.OpenRead(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT_Settings.xml"));
            else pathes = new Settings();
            AddGroupsToList();
        }
        private void add_Click(object sender, EventArgs e)
        {
            if (new_name.TextLength <= 14 && new_name.TextLength >= 1 && new_name.Text.IndexOfAny(new char[] { '?', '"', ':', '>', '<', '\\', '/', '|', '*' }) == -1)
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<string>));
                if (File.Exists(pathes.SavePath + @"\Groups.xml"))
                {
                    {
                        FileStream fs = File.OpenRead(pathes.SavePath + @"\Groups.xml");
                        a = (List<string>)xs.Deserialize(fs);
                        fs.Close();
                    }
                    File.Delete(pathes.SavePath + @"\Groups.xml");
                    a.Add(new_name.Text);
                    {
                        FileStream fs = File.Create(pathes.SavePath + @"\Groups.xml");
                        xs.Serialize(fs, a);
                        fs.Close();
                    }
                }
                else
                {
                    a = new List<string>();
                    a.Add(new_name.Text);
                    {
                        FileStream fs = File.Create(pathes.SavePath + @"\Groups.xml");
                        xs.Serialize(fs, a);
                        fs.Close();
                    }
                }
            }
            new_name.Text = "";
            AddGroupsToList();
        }
        private void AddGroupsToList()
        {
            listBox1.Items.Clear();
            if (File.Exists(pathes.SavePath + @"\Groups.xml"))
            {
                var fs = File.OpenRead(pathes.SavePath + @"\Groups.xml");
                listBox1.Items.AddRange((new XmlSerializer(typeof(List<string>)).Deserialize(fs) as List<string>).ToArray());
                fs.Close();
            }
        }
        private void DeleteGroupFromList()
        {
            if (listBox1.SelectedItem != null)
            {
                object temp = listBox1.SelectedItem;
                string ttt = listBox1.GetItemText(temp);
                listBox1.Items.Remove(temp);
                //if (File.Exists(pathes.SavePath + @"\" + currentMonth + @"\" + ttt + ".xml")) File.Delete(pathes.SavePath + @"\" + currentMonth + @"\" + ttt + ".xml");
                RewriteFile();
            }
        }
        private void RewriteFile()
        {
            if(File.Exists(pathes.SavePath + @"\Groups.xml")) File.Delete(pathes.SavePath + @"\Groups.xml");
            if (listBox1.Items.Count > 0)
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<string>));
                var fs = File.Create(pathes.SavePath + @"\Groups.xml");
                var lst = new List<string>();
                foreach (object obj in listBox1.Items)
                {
                    lst.Add(listBox1.GetItemText(obj));
                }
                xs.Serialize(fs, lst);
                fs.Close();
            }
        }
        private void delete_Click(object sender, EventArgs e)
        {
            DeleteGroupFromList();
        }
    }
}
