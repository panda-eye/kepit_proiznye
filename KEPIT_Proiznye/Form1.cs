using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using System.Xml.Serialization;

namespace KEPIT_Proiznye
{
    public partial class Form1 : Form
    {
        #region Переменные
        private List<Button> buttons = new List<Button>();
        private List<string> Groups { get; set; }
        private List<Info> List { get; set; }
        private int elementsCount = 0;
        private bool unsaved = false;
        private string FileName { get; set; }
        private System.Windows.Controls.Grid control;
        private object[] MonthList { get; set; }
        private string CurrentMonth { get; set; }
        private System.Windows.Controls.ScrollViewer scroll;
        
        #endregion
        #region Пути к файлам
        private string SavePath { get; set; }
        private string BackupPath { get; set; }
        #endregion
        public Form1()
        {
            InitializeComponent();
            AddToText("Form1 method");
            scroll = (System.Windows.Controls.ScrollViewer)((System.Windows.Controls.Border)((Table)elementHost2.Child).Content).Child;
            control = scroll.Content as System.Windows.Controls.Grid;
            lastTextBoxes = new List<System.Windows.UIElement>();
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT_Settings.xml"))
            {
                FileStream fs = File.OpenRead(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT_Settings.xml");
                pathes = (Settings)new XmlSerializer(typeof(Settings)).Deserialize(fs);
                fs.Close();
            }
            else pathes = new Settings();
            StartManager();
            LoadPathInfo();
            if (pathes.FirstStart == true)
            {
                whatsNew.Visible = true;
            }
            timer1.Enabled = true;
            GetGroups();
        }
        private void StartManager()
        {
            AddToText("StartManager method");
            Manager manager = new Manager();
            MonthList = manager.GetMonthList();
            comboBox1.Items.AddRange(MonthList);
            comboBox2.Items.AddRange(MonthList);
        }
        private void FirstStartMessage()
        {
            AddToText("FirstStartMessage");
            MessageBox.Show("Що нового:" + Line + "1. Друк списку проїзних квитків для всіх груп.");
        }
        private void LoadPathInfo()
        {
            AddToText("LoadPathInfo method");
            if (pathes.SavePath == "")
            {
                SavePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT";
                pathes.SavePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT";
            }
            else SavePath = pathes.SavePath;
            if (pathes.BackupPath == "") BackupPath = string.Empty;
            else
            {
                BackupPath = pathes.BackupPath;
                makeBackupPath.Text = pathes.BackupPath;
            }
            if (comboBox1.SelectedIndex == -1)
            {
                comboBox1.SelectedIndex = pathes.StartMonthIndex;
                comboBox2.SelectedIndex = pathes.StartMonthIndex;
            }
        }
        private void GetGroups()
        {
            AddToText("GetGroups method");
            active.Text = "—";
            panel1.Controls.Clear();
            Groups = null;
            buttons.Clear();
            if (CurrentMonth != null)
            {
                message.Visible = true;
                if (File.Exists(SavePath + @"\Groups.xml"))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(List<string>));
                    FileStream fs = File.OpenRead(SavePath + @"\Groups.xml");
                    Groups = (List<string>)xs.Deserialize(fs);
                    fs.Close();
                    message.Text = "Виберіть групу із списку для відображення.";
                    CreateGroupsButtons();
                }
                else
                {
                    message.Text = "Розпочніть роботу, створивши список груп (кнопка \"Групи\" вгорі).";
                    DeleteLastTextBoxes();
                }
            }
        }
        private void CreateGroupsButtons()
        {
            AddToText("CreateGroupsButtons method");
            if (Groups != null && Groups.Count > 0)
            {
                for (int vl = 0; vl < Groups.Count; vl++)
                {
                    Button button = new Button() { Text = Groups[vl], MinimumSize = new Size(100, 24), MaximumSize = new Size(200, 24), TextAlign = ContentAlignment.MiddleCenter, FlatStyle = FlatStyle.Flat };
                    button.FlatAppearance.BorderSize = 0;
                    button.FlatAppearance.MouseOverBackColor = Color.Plum;
                    button.BackColor = Color.LightSteelBlue;
                    Size size = button.PreferredSize;
                    button.Size = size;
                    if (buttons.Count == 0)
                    {
                        button.Location = new Point(3, 3);
                    }
                    else
                    {
                        int ind = buttons.Count - 1;
                        int x = buttons[ind].Location.X + buttons[ind].Size.Width + 2;
                        button.Location = new Point(x, 3);
                    }
                    button.Click += Button_Click;
                    buttons.Add(button);
                }
                panel1.Controls.AddRange(buttons.ToArray());
            }
        }
        private void Button_Click(object sender, EventArgs e)
        {
            AddToText("Button_Click event");
            if (!unsaved)
            {
                string name = ((Button)sender).Text;
                if (FileName != name || LastCurrentMonth != CurrentMonth)
                {
                    NewMethod(name);
                }
            }
            else
            {
                string name = ((Button)sender).Text;
                if (FileName != name || LastCurrentMonth != CurrentMonth)
                {
                    DialogResult dr = MessageBox.Show("Програма має незбережені дані. Бажаєте їх зберегти?", "Збереження даних", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                    if (dr == DialogResult.Yes)
                    {
                        unsaved = false;
                        Save();
                        NewMethod(name);
                    }
                    else if (dr == DialogResult.No)
                    {
                        unsaved = false;
                        NewMethod(name);
                    }
                }
            }
        }
        private void NewMethod(string name)
        {
            AddToText("NewMethod (name) method");
            FileName = name;
            active.Text = FileName;
            message.Visible = false;
            if (List != null) List = null;
            if (File.Exists(SavePath + @"\" + CurrentMonth + @"\" + FileName + ".xml"))
            {
                XmlSerializer xs = new XmlSerializer(typeof(List<Info>));
                FileStream fs = File.OpenRead(SavePath + @"\" + CurrentMonth + @"\" + FileName + ".xml");
                List = (List<Info>)xs.Deserialize(fs);
                fs.Close();
                DeleteLastTextBoxes(true);
            }
            else
            {
                DeleteLastTextBoxes(true);
            }
        }
        private List<System.Windows.UIElement> lastTextBoxes;
        private void DeleteLastTextBoxes()
        {
            AddToText("DeleteLastTextBoxes");
            var lastTB = control.Children.OfType<System.Windows.Controls.TextBox>() != null ? new List<System.Windows.UIElement>(control.Children.OfType<System.Windows.Controls.TextBox>()) : new List<System.Windows.UIElement>();
            if (lastTB.Count > 0)
            {
                foreach (System.Windows.Controls.TextBox tb in lastTB)
                {
                    DoubleAnimation da = new DoubleAnimation(0, new System.Windows.Duration(TimeSpan.FromSeconds(1)));
                    da.Completed += (sender, e) => { stopped = true; };
                    tb.BeginAnimation(System.Windows.UIElement.OpacityProperty, da, HandoffBehavior.SnapshotAndReplace);
                }
                lastTextBoxes.AddRange(lastTB);
                isNeedToDeleteLastBoxes = true;
            }
            scrollPos = -1;
            offset.BackColor = Color.LightSteelBlue;
            offset.FlatAppearance.MouseOverBackColor = Color.Plum;
        }
        private bool UpdateOnTick = false;
        private void DeleteLastTextBoxes(bool toUpd)
        {
            AddToText("DeleteLastTextBoxes (bool) method");
            UpdateOnTick = toUpd;
            var lastTB = control.Children.OfType<System.Windows.Controls.TextBox>() != null ? new List<System.Windows.UIElement>(control.Children.OfType<System.Windows.Controls.TextBox>()) : new List<System.Windows.UIElement>();
            if (lastTB.Count > 0)
            {
                foreach (System.Windows.Controls.TextBox tb in lastTB)
                {
                    DoubleAnimation da = new DoubleAnimation(0, new System.Windows.Duration(TimeSpan.FromSeconds(1)));
                    da.Completed += (sender, e) => { stopped = true; };
                    tb.BeginAnimation(System.Windows.UIElement.OpacityProperty, da);
                }
                lastTextBoxes.AddRange(lastTB);
                isNeedToDeleteLastBoxes = true;
            }
            else
            {
                Update();
            }
            scrollPos = -1;
            offset.BackColor = Color.LightSteelBlue;
            offset.FlatAppearance.MouseOverBackColor = Color.Plum;
        }
        private bool isNeedToDeleteLastBoxes = false;
        private void Timer_Tick(object sender, EventArgs e)
        {
            if (isNeedToDeleteLastBoxes)
            {
                AddToText("Timer_Tick event");
                var lTB = new List<System.Windows.UIElement>(lastTextBoxes);
                var temp_lTB = new List<System.Windows.UIElement>(lTB);
                lastTextBoxes.Clear();
                foreach (System.Windows.Controls.TextBox tb in lTB)
                {
                    if (stopped)
                    {
                        control.Children.Remove(tb);
                        temp_lTB.Remove(tb);
                    }
                    else
                    {
                        lastTextBoxes.Add(tb);
                    }
                }
                if (temp_lTB.Count == 0)
                {
                    stopped = false;
                    isNeedToDeleteLastBoxes = false;
                    var lastTB = control.Children.OfType<System.Windows.Controls.TextBox>() != null ? new List<System.Windows.Controls.TextBox>(control.Children.OfType<System.Windows.Controls.TextBox>()) : new List<System.Windows.Controls.TextBox>();
                    if (lastTB.Count > 0)
                    {
                        int perc = 0;
                        for (int q = 0; q < lastTB.Count; q += 13)
                        {
                            if ((string)lastTB[q].Tag == "not")
                            {
                                perc++;
                            }
                            else if ((string)lastTB[q].Tag == "n")
                            {
                                perc++;
                                lastTB[q].Tag = "";
                            }
                        }
                        ClearRows(perc);
                    }
                    if (UpdateOnTick)
                    {
                        ClearRows();
                        Update();
                        UpdateOnTick = false;
                    }
                }
            }
        }

        private void ClearRows()
        {
            AddToText("ClearRows method");
            if (control.RowDefinitions.Count > 2)
            {
                int count = control.RowDefinitions.Count;
                for (int vl = 2; vl < count; vl++)
                {
                    control.RowDefinitions.RemoveAt(2);
                }
            }
        }
        private void ClearRows(int countFromEnd)
        {
            AddToText("ClearRows (int) method");
            if (control.RowDefinitions.Count > 2)
            {
                int count = control.RowDefinitions.Count - 2 - countFromEnd;
                for (int vl = 0; vl < count; vl++)
                {
                    control.RowDefinitions.RemoveAt(2 + countFromEnd);
                }
            }
            elementsCount = control.RowDefinitions.Count - 2;
        }
        private new void Update()
        {
            AddToText("Update method");
            if (List != null)
            {
                int row = 2;
                var rows = control.RowDefinitions;
                int inf = 0;
                foreach (Info info in List)
                {
                    inf++;
                    int column = 0;
                    for (int vl = 0; vl < 13; vl++)
                    {
                        var box = new System.Windows.Controls.TextBox()
                        {
                            TextAlignment = System.Windows.TextAlignment.Center,
                            HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                            VerticalAlignment = System.Windows.VerticalAlignment.Center,
                            FontSize = 18,
                            BorderThickness = new System.Windows.Thickness(0),
                            Opacity = 0
                        };
                        DoubleAnimation da = new DoubleAnimation(1, new System.Windows.Duration(TimeSpan.FromSeconds(1)));
                        box.BeginAnimation(System.Windows.UIElement.OpacityProperty, da);
                        if (vl != 1 && vl != 5 && vl != 9)
                        {
                            if ((rows.Count - 2) % 2 == 0)
                            {
                                box.Background = System.Windows.Media.Brushes.LightGreen;
                            }
                            else
                            {
                                box.Background = System.Windows.Media.Brushes.LightCoral;
                            }
                        }
                        else
                        {
                            box.Background = System.Windows.Media.Brushes.LightGray;
                        }
                        if (vl == 0)
                        {
                            box.TextAlignment = System.Windows.TextAlignment.Left;
                            box.MinWidth = 200;
                            box.MaxLength = 42;
                            box.MaxWidth = 290;
#pragma warning disable IDE0029
                            box.Text = info.Name == null ? string.Empty : info.Name;
#pragma warning restore IDE0029
                            int c = List.Count;
                            if (List.Count == inf) box.Tag = "not";
                            else box.Tag = "n";
                            box.TextChanged += Box1_TextChanged;
                        }
                        else
                        {
#pragma warning disable IDE0029
                            box.Text = info.Numbers[vl - 1] == null ? string.Empty : info.Numbers[vl - 1];
#pragma warning restore IDE0029
                            box.Height = 23;
                            box.Width = 35;
                            box.MaxLength = 2;
                            box.TextChanged += (sender, e) => { unsaved = true; };
                        }
                        System.Windows.Controls.Grid.SetColumn(box, column);
                        System.Windows.Controls.Grid.SetRow(box, row);
                        control.Children.Add(box);
                        column++;
                    }
                    row++;
                    rows.Add(new System.Windows.Controls.RowDefinition() { Height = new System.Windows.GridLength(30) });
                }
                elementsCount = rows.Count - 2;
            }
            else
            {
                elementsCount = 1;
                var rows = control.RowDefinitions;
                int column = 0;
                for (int vl = 0; vl < 13; vl++)
                {
                    var box = new System.Windows.Controls.TextBox()
                    {
                        HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                        VerticalAlignment = System.Windows.VerticalAlignment.Center,
                        Height = 23,
                        FontSize = 18,
                        BorderThickness = new System.Windows.Thickness(0),
                        Tag = "not",
                        Opacity = 0
                    };
                    DoubleAnimation da = new DoubleAnimation(1, new System.Windows.Duration(TimeSpan.FromSeconds(1)));
                    box.BeginAnimation(System.Windows.UIElement.OpacityProperty, da);
                    if (vl != 1 && vl != 5 && vl != 9)
                    {
                        box.Background = System.Windows.Media.Brushes.LightGreen;
                    }
                    else
                    {
                        box.Background = System.Windows.Media.Brushes.LightGray;
                    }
                    if (vl == 0)
                    {
                        box.TextAlignment = System.Windows.TextAlignment.Left;
                        box.MinWidth = 200;
                        box.MaxLength = 42;
                        box.MaxWidth = 290;
                        box.Text = "1. ";
                        box.TextChanged += Box1_TextChanged;
                    }
                    else
                    {
                        box.TextAlignment = System.Windows.TextAlignment.Center;
                        box.Text = string.Empty;
                        box.Width = 35;
                        box.MaxLength = 2;
                        box.TextChanged += (sender, e) => { unsaved = true; };
                    }
                    System.Windows.Controls.Grid.SetColumn(box, column);
                    System.Windows.Controls.Grid.SetRow(box, 2);
                    control.Children.Add(box);
                    column++;
                }
                rows.Add(new System.Windows.Controls.RowDefinition() { Height = new System.Windows.GridLength(30) });
            }
        }

        private void Box1_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            AddToText("Box1_TextChanged event");
            unsaved = true;
            var cntrl = (System.Windows.Controls.TextBox)sender;
            if (cntrl.Text.Length > 0)
            {
                int length = elementsCount.ToString().Length;
                if (cntrl.Text != elementsCount.ToString() + ". " && cntrl.Text.Length > 3 && control.RowDefinitions.Count == 2 + elementsCount)
                {
                    if (cntrl.Text.Substring(0, length) == elementsCount.ToString())
                    {
                        NewMethod1(cntrl);
                    }
                }
            }
        }
        private void AddToText(string text)
        {
            bugReport += text + "; ";
        }
        private string bugReport = string.Empty;
        private void NewMethod1(System.Windows.Controls.TextBox cntrl)
        {
            if ((string)cntrl.Tag == "not")
            {
                AddToText("NewMethod1 (TextBox) method");
                cntrl.Tag = "";
                int column = 0;
                for (int vl1 = 0; vl1 < 13; vl1++)
                {
                    var box = new System.Windows.Controls.TextBox()
                    {
                        TextAlignment = System.Windows.TextAlignment.Center,
                        HorizontalAlignment = System.Windows.HorizontalAlignment.Center,
                        VerticalAlignment = System.Windows.VerticalAlignment.Center,
                        FontSize = 18,
                        BorderThickness = new System.Windows.Thickness(0),
                        Opacity = 0
                    };
                    DoubleAnimation da = new DoubleAnimation(1, new System.Windows.Duration(TimeSpan.FromSeconds(1)));
                    box.BeginAnimation(System.Windows.UIElement.OpacityProperty, da);
                    if (vl1 != 1 && vl1 != 5 && vl1 != 9)
                    {
                        if (elementsCount % 2 == 0)
                        {
                            box.Background = System.Windows.Media.Brushes.LightGreen;
                        }
                        else
                        {
                            box.Background = System.Windows.Media.Brushes.LightCoral;
                        }
                    }
                    else
                    {
                        box.Background = System.Windows.Media.Brushes.LightGray;
                    }

                    box.Tag = "not";
                    if (vl1 == 0)
                    {
                        box.TextAlignment = System.Windows.TextAlignment.Left;
                        box.MinWidth = 200;
                        box.MaxWidth = 290;
                        box.Height = 23;
                        box.MaxLength = 42;
                        box.Text = (elementsCount + 1).ToString() + ". ";
                        box.TextChanged += Box1_TextChanged;
                    }
                    else
                    {
                        box.Text = string.Empty;
                        box.Height = 23;
                        box.Width = 35;
                        box.MaxLength = 2;
                        box.TextChanged += (sender1, e1) => { unsaved = true; };
                    }
                    System.Windows.Controls.Grid.SetColumn(box, column);
                    System.Windows.Controls.Grid.SetRow(box, elementsCount + 2);
                    control.Children.Add(box);
                    column++;
                }
                elementsCount++;
                control.RowDefinitions.Add(new System.Windows.Controls.RowDefinition() { Height = new System.Windows.GridLength(30) });
                scroll.ScrollToBottom();
            }
        }
        private void Save(bool last = false)
        {
            AddToText("Save (bool) method");
            var count = control.Children.OfType<System.Windows.Controls.TextBox>();
            foreach (System.Windows.Controls.TextBox obj in control.Children.OfType<System.Windows.Controls.TextBox>())
            {
                switch (System.Windows.Controls.Grid.GetRow(obj))
                {
                    case 1:
                    case 0:
                        {
                            break;
                        }
                    default:
                        {
                            UnderSave(obj);
                            break;
                        }
                }
            }
            if (!Directory.Exists(SavePath + @"\" + CurrentMonth)) Directory.CreateDirectory(SavePath + @"\" + CurrentMonth);
            if (!last)
            {
                if (File.Exists(SavePath + @"\" + CurrentMonth + @"\" + FileName + ".xml")) File.Delete(SavePath + @"\" + CurrentMonth + @"\" + FileName + ".xml");
                XmlSerializer xs = new XmlSerializer(typeof(List<Info>));
                FileStream fs = File.Create(SavePath + @"\" + CurrentMonth + @"\" + FileName + ".xml");
                xs.Serialize(fs, listOfPersons);
                fs.Close();
            }
            else
            {
                if (File.Exists(SavePath + @"\" + LastCurrentMonth + @"\" + FileName + ".xml")) File.Delete(SavePath + @"\" + LastCurrentMonth + @"\" + FileName + ".xml");
                XmlSerializer xs = new XmlSerializer(typeof(List<Info>));
                FileStream fs = File.Create(SavePath + @"\" + LastCurrentMonth + @"\" + FileName + ".xml");
                xs.Serialize(fs, listOfPersons);
                fs.Close();
            }
            listOfPersons.Clear();
            unsaved = false;
        }
        private string[] n;
        private string nm;
        private List<Info> listOfPersons = new List<Info>();
        private void UnderSave(System.Windows.Controls.TextBox box)
        {
            AddToText("UnderSave (TextBox) method");
            int column = System.Windows.Controls.Grid.GetColumn(box);
            switch (column)
            {
                case 0:
                    {
                        n = new string[12];
                        nm = box.Text;
                        break;
                    }
                case 12:
                    {
                        if (box.Text.Length > 0)
                        {
                            int b = -1;
                            bool isNum = int.TryParse(box.Text, out b);
                            n[11] = isNum ? box.Text : null;
                        }
                        Info inf = new Info()
                        {
                            Name = nm,
                            Numbers = n
                        };
                        listOfPersons.Add(inf);
                        break;
                    }
                default:
                    {
                        if (box.Text.Length > 0)
                        {
                            int b = -1;
                            bool isNum = int.TryParse(box.Text, out b);
                            n[column - 1] = isNum ? box.Text : null;
                        }
                        break;
                    }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            AddToText("Form1_FormClosing event");
            if (unsaved)
            {
                DialogResult dr = MessageBox.Show("Програма має незбережені дані. Бажаєте їх зберегти?", "Збереження даних", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                if (dr == DialogResult.Yes)
                {
                    Save();
                }
                else if (dr == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
            if (!e.Cancel)
            {
                AddToText("Settings saving fragment");
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT_Settings.xml");
                FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT_Settings.xml");
                new XmlSerializer(typeof(Settings)).Serialize(fs, pathes);
                fs.Close();
            }
        }
        private int[] count_result;
        private int[] GetSum()
        {
            AddToText("GetSum method");
            int[] result = new int[12];
            count_result = new int[12];
            foreach (System.Windows.Controls.TextBox obj in control.Children.OfType<System.Windows.Controls.TextBox>().Where(tb => tb.Text.Length > 0))
            {
                switch (System.Windows.Controls.Grid.GetColumn(obj))
                {
                    case 1:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[0] += temp * 152;
                                count_result[0] += temp;
                            }
                            break;
                        }
                    case 2:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[1] += temp * 202;
                                count_result[1] += temp;
                            }
                            break;
                        }
                    case 3:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[2] += temp * 202;
                                count_result[2] += temp;
                            }
                            break;
                        }
                    case 4:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[3] += temp * 202;
                                count_result[3] += temp;
                            }
                            break;
                        }
                    case 5:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[4] += temp * 97;
                                count_result[4] += temp;
                            }
                            break;
                        }
                    case 6:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[5] += temp * 152;
                                count_result[5] += temp;
                            }
                            break;
                        }
                    case 7:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[6] += temp * 152;
                                count_result[6] += temp;
                            }
                            break;
                        }
                    case 8:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[7] += temp * 152;
                                count_result[7] += temp;
                            }
                            break;
                        }
                    case 9:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[8] += temp * 77;
                                count_result[8] += temp;
                            }
                            break;
                        }
                    case 10:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[9] += temp * 132;
                                count_result[9] += temp;
                            }
                            break;
                        }
                    case 11:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[10] += temp * 132;
                                count_result[10] += temp;
                            }
                            break;
                        }
                    case 12:
                        {
                            int temp = -1;
                            bool res = int.TryParse(obj.Text, out temp);
                            if (res)
                            {
                                result[11] += temp * 132;
                                count_result[11] += temp;
                            }
                            break;
                        }
                }
            }
            return result;
        }
        private int[] GetAllSum()
        {
            AddToText("GetAllSum method");
            all_count_result = new int[12];
            int[] result = new int[12];
            if (Groups != null && Groups.Count > 0)
            {
                foreach (string str in Groups)
                {
                    if (File.Exists(SavePath + @"\" + CurrentMonth + @"\" + str + ".xml"))
                    {
                        XmlSerializer xs = new XmlSerializer(typeof(List<Info>));
                        FileStream fs = File.OpenRead(SavePath + @"\" + CurrentMonth + @"\" + str + ".xml");
                        var tempList = (List<Info>)xs.Deserialize(fs);
                        fs.Close();
                        foreach (Info a in tempList)
                        {
                            for (int aa = 0; aa < 12; aa++)
                            {
                                int b = -1;
                                bool c = int.TryParse(a.Numbers[aa], out b);
                                if (c)
                                {
                                    all_count_result[aa] += b;
                                    switch (aa)
                                    {
                                        case 0:
                                            {
                                                result[aa] += b * 152;
                                                break;
                                            }
                                        case 1:
                                        case 2:
                                        case 3:
                                            {
                                                result[aa] += b * 202;
                                                break;
                                            }
                                        case 4:
                                            {
                                                result[aa] += b * 97;
                                                break;
                                            }
                                        case 5:
                                        case 6:
                                        case 7:
                                            {
                                                result[aa] += b * 152;
                                                break;
                                            }
                                        case 8:
                                            {
                                                result[aa] += b * 77;
                                                break;
                                            }
                                        case 9:
                                        case 10:
                                        case 11:
                                            {
                                                result[aa] += b * 132;
                                                break;
                                            }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            return result;
        }
        private int[] all_count_result;
        private void Button1_Click(object sender, EventArgs e)
        {
            AddToText("button1_Click event");
            int[] temp_sum = GetSum();
            int[] temp_all_sum = GetAllSum();
            Sum sum = new Sum(temp_sum, count_result, temp_all_sum, all_count_result);
            sum.ShowDialog();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            AddToText("button2_Click event");
            if (unsaved) Save();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            AddToText("button3_Click event");
            Groups gr = new Groups(CurrentMonth);
            DialogResult dr = gr.ShowDialog();
            string text = active.Text;
            GetGroups();
            if (Groups != null)
            {
                bool oh_yeah_baby = false;
                foreach (string str in Groups) if (str == text) oh_yeah_baby = true;
                if (!oh_yeah_baby)
                {
                    panel1.Controls.OfType<Button>().ElementAt(0).PerformClick();
                }
            }
        }
        private Settings pathes;
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AddToText("checkBox_CheckedChanged event");
            if (checkBox.Checked)
            {
                makeBackup.Visible = true;
                makeBackupPath.Visible = true;
                changeBackupMakePathButton.Visible = true;
                loadBackup.Visible = true;
                loadBackupPath.Visible = true;
                changeBackupLoadPathButton.Visible = true;
                testingPassword.Visible = true;
                testing.Visible = true;
                deleteAllData.Visible = true;
                changeSavePathButton.Visible = true;
                returnSavePathButton.Visible = true;
            }
            else
            {
                deleteAllData.Visible = false;
                makeBackup.Visible = false;
                makeBackupPath.Visible = false;
                changeBackupMakePathButton.Visible = false;
                loadBackup.Visible = false;
                loadBackupPath.Visible = false;
                changeBackupLoadPathButton.Visible = false;
                testingPassword.Visible = false;
                testingPassword.Text = "";
                testing.Visible = false;
                changeSavePathButton.Visible = false;
                returnSavePathButton.Visible = false;
            }
        }
        private void TestingPassword_TextChanged(object sender, EventArgs e)
        {
            if (testingPassword.Text == "karkon")
            {
                testing.Enabled = true;
            }
            else
            {
                testing.Enabled = false;
            }
        }
        private void ChangeSavePathButton_Click(object sender, EventArgs e)
        {
            AddToText("changeSavePathButton_Click event");
            savePathDialog.ShowNewFolderButton = true;
            savePathDialog.Description = "Виберіть папку, в яку буде здійснюватися збереження.";
            DialogResult dr = savePathDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (SavePath != savePathDialog.SelectedPath)
                {
                    string temp_path = SavePath;
                    SavePath = savePathDialog.SelectedPath;
                    pathes.SavePath = SavePath;
                    DeleteFiles(new DirectoryInfo(SavePath));
                    CopyFiles(new DirectoryInfo(temp_path), new DirectoryInfo(SavePath));
                    DeleteFiles(new DirectoryInfo(temp_path));
                }
            }
        }
        private void ReturnSavePathButton_Click(object sender, EventArgs e)
        {
            AddToText("returnSavePathButton_Click event");
            if (SavePath != Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT")
            {
                string temp_path = SavePath;
                SavePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT";
                pathes.SavePath = SavePath;
                DeleteFiles(new DirectoryInfo(SavePath));
                CopyFiles(new DirectoryInfo(temp_path), new DirectoryInfo(SavePath));
                DeleteFiles(new DirectoryInfo(temp_path));
            }
        }
        private void RestartButton_Click(object sender, EventArgs e)
        {
            AddToText("restartButton_Click event");
            Application.Restart();
        }
        private void ChangeBackupMakePathButton_Click(object sender, EventArgs e)
        {
            AddToText("changeBackupMakePathButton_Click event");
            makeBackupDialog.ShowNewFolderButton = true;
            makeBackupDialog.Description = "Виберіть папку, в яку буде здійснено резервне копіювання.";
            DialogResult dr = makeBackupDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                makeBackupPath.Text = makeBackupDialog.SelectedPath;
            }
        }
        private void ChangeBackupLoadPathButton_Click(object sender, EventArgs e)
        {
            AddToText("changebackupLoadPathButton_Click event");
            makeBackupDialog.ShowNewFolderButton = true;
            makeBackupDialog.Description = "Виберіть папку, з якої буде завантажене резервне копіювання.";
            DialogResult dr = makeBackupDialog.ShowDialog();
            if (dr == DialogResult.OK)
            {
                loadBackupPath.Text = makeBackupDialog.SelectedPath;
            }
        }
        private void MakeBackup_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(makeBackupPath.Text))
            {
                AddToText("makeBackup_Click event");
                if (!Directory.Exists(makeBackupPath.Text))
                {
                    try
                    {
                        Directory.CreateDirectory(makeBackupPath.Text);
                    }
                    catch { return; }
                }
                else
                {
                    DeleteFiles(new DirectoryInfo(makeBackupPath.Text));
                }
                pathes.BackupPath = makeBackupPath.Text;
                CopyFiles(new DirectoryInfo(SavePath), new DirectoryInfo(makeBackupPath.Text));
            }
        }
        private void LoadBackup_Click(object sender, EventArgs e)
        {
            AddToText("loadBackup_Click event");
            if (!string.IsNullOrEmpty(loadBackupPath.Text))
            {
                if (Directory.Exists(loadBackupPath.Text) && File.Exists(loadBackupPath.Text + @"\Groups.xml"))
                {
                    DialogResult dr = MessageBox.Show("Ви впевнені, що хочете завантажити резервне копіювання? Ця дія видалить всі файли, які вже збережені цією програмою (окрім інших резервних копіювань).", "Завантаження резервного копіювання", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                    if (dr == DialogResult.OK)
                    {
                        DeleteFiles(new DirectoryInfo(SavePath));
                        CopyFiles(new DirectoryInfo(loadBackupPath.Text), new DirectoryInfo(SavePath));
                        GetGroups();
                    }
                }
            }
        }
        private void CopyFiles(DirectoryInfo from, DirectoryInfo to)
        {
            AddToText("CopyFiles (DirectoryInfo, DirectoryInfo) method");
            foreach (DirectoryInfo dir in from.GetDirectories())
                CopyFiles(dir, to.CreateSubdirectory(dir.Name));
            foreach (FileInfo file in from.GetFiles())
                file.CopyTo(Path.Combine(to.FullName, file.Name));
        }
        private void DeleteFiles(DirectoryInfo from)
        {
            if (from.Exists)
            {
                AddToText("DeleteFiles (DirectoryInfo) method");
                var list = new List<DirectoryInfo>(from.GetDirectories());
                if (list.Count > 0)
                {
                    foreach (DirectoryInfo d in list)
                    {
                        d.Delete(true);
                    }
                }
                var list2 = new List<FileInfo>(from.GetFiles());
                if (list2.Count > 0)
                {
                    foreach (FileInfo f in list2)
                    {
                        f.Delete();
                    }
                }
            }
        }
        private void DeleteAllData_Click(object sender, EventArgs e)
        {
            AddToText("deleteAllData_Click event");
            var dr = MessageBox.Show("Ви впевнені, що хочете видалити всю інформацію і всі дані, пов'язані з цією програмою?", "Видалення файлів", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Yes)
            {
                DeleteFiles(new DirectoryInfo(SavePath));
                DeleteLastTextBoxes();
                GetGroups();
                unsaved = false;
            }
        }
        private void Testing_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Environment.CurrentDirectory: " + Environment.CurrentDirectory + Line + "Directory.GetCurrentDirectory(): " + Directory.GetCurrentDirectory() + Line + "Application.StartupPath: " + Application.StartupPath + Line + "AppData: " + Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            MessageBox.Show("savePath: " + SavePath + Line + "backupPath: " + BackupPath + Line + "pathes.SavePath: " + pathes.SavePath + Line + "pathes.BackupPath: " + pathes.BackupPath);
            MessageBox.Show("ComboBox info" + Line + "SelectedIndex: " + comboBox1.SelectedIndex + Environment.NewLine + "SelectedValue: " + comboBox1.SelectedValue + Environment.NewLine + "SelectedText: " + comboBox1.SelectedText);
        }
        private string Line { get { return Environment.NewLine + Environment.NewLine; } }

        private string LastCurrentMonth { get; set; }
        private object LastSelectedItem { get; set; }

        private void WhatsNew_Click(object sender, EventArgs e)
        {
            AddToText("whatsNew_Click event");
            pathes.FirstStart = false;
            whatsNew.Visible = false;
            FirstStartMessage();
        }
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddToText("comboBox1_SelectedIndexChanged event");
            LastCurrentMonth = CurrentMonth;
            CurrentMonth = (string)MonthList[comboBox1.SelectedIndex];
            if (!Directory.Exists(SavePath + @"\" + CurrentMonth)) Directory.CreateDirectory(SavePath + @"\" + CurrentMonth);
            active.Text = "—";
            if (!unsaved)
            {
                DeleteLastTextBoxes();
            }
            else
            {
                DialogResult dr = MessageBox.Show("Програма має незбережені дані. Бажаєте їх зберегти?", "Збереження даних", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button3);
                if (dr == DialogResult.Yes)
                {
                    unsaved = false;
                    Save(true);
                    DeleteLastTextBoxes();
                }
                else if (dr == DialogResult.No)
                {
                    unsaved = false;
                    DeleteLastTextBoxes();
                }
            }
            LastSelectedItem = comboBox1.SelectedItem;
        }

        private void StartMonthIndex_Click(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                if (pathes.StartMonthIndex != comboBox2.SelectedIndex)
                {
                    pathes.StartMonthIndex = comboBox2.SelectedIndex;
                }
            }
        }

        private void Up_Click(object sender, EventArgs e)
        {
            //DoubleAnimation da = new DoubleAnimation(0, new System.Windows.Duration(TimeSpan.FromSeconds(1)));
            //scroll.BeginAnimation(System.Windows.Controls.ScrollViewer.VerticalOffsetProperty, da);
            scroll.ScrollToTop();
        }

        private void Down_Click(object sender, EventArgs e)
        {
            //double d = scroll.ScrollableHeight;
            //DoubleAnimation da = new DoubleAnimation(d, new System.Windows.Duration(TimeSpan.FromSeconds(1)));
            //scroll.BeginAnimation(System.Windows.Controls.ScrollViewer.VerticalOffsetProperty, da);
            scroll.ScrollToBottom();
        }
        private double scrollPos = -1;
        private bool stopped = false;

        private void Offset_Click(object sender, EventArgs e)
        {
            if (scrollPos != -1)
            {
                if (scroll.VerticalOffset == scrollPos)
                {
                    scrollPos = -1;
                    offset.BackColor = Color.LightSteelBlue;
                    offset.FlatAppearance.MouseOverBackColor = Color.Plum;
                }
                else
                    scroll.ScrollToVerticalOffset(scrollPos);
            }
            else
            {
                scrollPos = scroll.VerticalOffset;
                offset.BackColor = Color.LightGreen;
                offset.FlatAppearance.MouseOverBackColor = Color.LightSeaGreen;
            }
        }

        private void Bug_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string date = dt.Day.ToString() + "_" + dt.Month.ToString() + "_" + dt.Year.ToString() + "_" + dt.Hour.ToString() + "_" + dt.Minute.ToString() + "_" + dt.Second.ToString() + "_" + dt.Millisecond.ToString();
            string bug_report_file_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\KEPIT_bug_report_" + date + ".txt";
            StreamWriter sw = new StreamWriter(bug_report_file_path);
            sw.Write(bugReport);
            sw.Close();
        }

        private void Print_Click(object sender, EventArgs e)
        {
            WordDocument wd = new WordDocument(Groups);
            wd.PrintDocument();
        }
    }
    public class Info
    {
        public string Name { get; set; }
        public string[] Numbers { get; set; }
    }
    public class Settings
    {
        public Settings()
        {
            SavePath = "";
            BackupPath = "";
            FirstStart = true;
            StartMonthIndex = 2;
        }
        public string SavePath { get; set; }
        public string BackupPath { get; set; }
        public bool FirstStart { get; set; }
        public int StartMonthIndex { get; set; }
    }

    public class WordDocument
    {
        public int Count { get; private set; }
        Microsoft.Office.Interop.Word.Application word;
        Microsoft.Office.Interop.Word.Document document;

        public WordDocument(List<string> Groups)
        {
            word = new Microsoft.Office.Interop.Word.Application()
            {
                ShowAnimation = false,
                Visible = false
            };
            object missing = System.Reflection.Missing.Value;
            document = word.Documents.Add(ref missing, ref missing, ref missing, ref missing);
            foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
            {
                Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlack;
                headerRange.Font.Size = 24;
                headerRange.Text = "Проїзні квитки";

                Microsoft.Office.Interop.Word.Paragraph para = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para.Range.set_Style(ref styleHeading2);
                para.Range.Text = new Manager().Month.ToString(); ;
                para.Range.InsertParagraphAfter();

                Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(headerRange.NextStoryRange, 5, 5, ref missing, ref missing);
                firstTable.Borders.Enable = 1;

                SetDataInTable(firstTable);
            }
        }

        public void SetDataInTable(Microsoft.Office.Interop.Word.Table firstTable)
        {
            foreach (Microsoft.Office.Interop.Word.Row row in firstTable.Rows)
            {
                foreach (Microsoft.Office.Interop.Word.Cell cell in row.Cells)
                {
                    if (cell.RowIndex == 1)
                    {
                        cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
                        cell.Range.Font.Bold = 0;
                        cell.Range.Font.Name = "Trebushet MS";
                        cell.Range.Font.Size = 10;
                        cell.Shading.BackgroundPatternColor = Microsoft.Office.Interop.Word.WdColor.wdColorGray15;
                        cell.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                        cell.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    }
                    else
                    {
                        cell.Range.Text = new Random().Next(10).ToString();
                    }
                }
            }
        }

        public void PrintDocument()
        {
            if (document != null)
            {
                document.PrintPreview();
            }
        }

        public bool SaveDocument()
        {
            if (document == null)
            {
                return false;
            }
            object path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            document.SaveAs2(path);
            return true;
        }

        public void SetGroupsCount(int count)
        {
            if (count > 0)
            {
                Count = count;
            }
        }
    }
}
