using System.Text.Json;
using System.Windows.Forms;
using System.Xml.XPath;

namespace _15._04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Text = "Form1";
            this.FormClosing += (s, e) =>
            {
                if (ListBox.Items.Count > 0)
                {
                    File.WriteAllText(path, "");
                    foreach (var item in ListBox.Items)
                    {
                        File.AppendAllText(path, $"{item.ToString()}\n");
                    }
                }
            };

            RedTr.Location = new Point(0, 0);
            RedTr.Maximum = 255;
            RedTr.Minimum = 0;
            RedTr.Size = new Size(150, 450);
            RedTr.Orientation = Orientation.Vertical;
            RedTr.ValueChanged += (s, e) =>
            {
                RedLB.Text = RedTr.Value.ToString();
                panelRGB.BackColor = Color.FromArgb(255, RedTr.Value, panelRGB.BackColor.G, panelRGB.BackColor.B);
            };

            RedLB.Location = new Point(0, RedTr.Height);
            RedLB.Text = "0";

            GreenTr.Location = new Point(RedTr.Location.X + RedTr.Width + 10, 0);
            GreenTr.Maximum = 255;
            GreenTr.Minimum = 0;
            GreenTr.Size = new Size(150, 450);
            GreenTr.Orientation = Orientation.Vertical;
            GreenTr.ValueChanged += (s, e) =>
            {
                GreenLB.Text = GreenTr.Value.ToString();
                panelRGB.BackColor = Color.FromArgb(255, panelRGB.BackColor.R, GreenTr.Value, panelRGB.BackColor.B);
            };

            GreenLB.Location = new Point(RedTr.Location.X + RedTr.Width + 10, GreenTr.Height);
            GreenLB.Text = "0";

            BlueTr.Location = new Point(GreenTr.Location.X + GreenTr.Width + 10, 0);
            BlueTr.Maximum = 255;
            BlueTr.Minimum = 0;
            BlueTr.Size = new Size(150, 450);
            BlueTr.Orientation = Orientation.Vertical;
            BlueTr.ValueChanged += (s, e) =>
            {
                BlueLB.Text = BlueTr.Value.ToString();
                panelRGB.BackColor = Color.FromArgb(255, panelRGB.BackColor.R, panelRGB.BackColor.G, BlueTr.Value);
            };

            BlueLB.Location = new Point(GreenTr.Location.X + GreenTr.Width + 10, BlueTr.Height);
            BlueLB.Text = "0";

            panelRGB.Location = new Point(0, RedLB.Location.Y + RedLB.Height + 10);
            panelRGB.Width = 450;
            panelRGB.Height = 200;

            ListBox.Location = new Point(BlueTr.Location.X + BlueTr.Width + 10, 10);
            ListBox.Width = 150;
            ListBox.Height = 400;
            if (File.Exists(path) && File.ReadAllText(path).Length > 0)
            {
                string temp = File.ReadAllText(path);
                foreach (string line in temp.Split('\n')) ListBox.Items.Add(line);
            }
            ListBox.SelectedIndexChanged += (s, e) =>
            {
                string[] temp;
                if (ListBox.SelectedIndex >= 0)
                {
                    temp = ListBox.SelectedItem.ToString().Split(',');
                    RedLB.Text = temp[0];
                    RedTr.Value = int.Parse(temp[0]);
                    GreenLB.Text = temp[1];
                    GreenTr.Value = int.Parse(temp[1]);
                    BlueLB.Text = temp[2];
                    BlueTr.Value = int.Parse(temp[2]);
                    panelRGB.BackColor = Color.FromArgb(int.Parse(temp[0]), int.Parse(temp[1]), int.Parse(temp[2]));
                }

            };

            save.Location = new Point(BlueTr.Location.X + BlueTr.Width + 10, ListBox.Location.Y + ListBox.Height + 10);
            //save.Text = "Save";

            save.BackgroundImage = Image.FromFile("E:\\Projects\\15.04\\Star.png");
            save.BackgroundImageLayout = ImageLayout.Zoom;
            save.Size = new Size(150, 30);
            save.Click += (s, e) =>
            {
                ListBox.Items.Add($"{RedLB.Text},{GreenLB.Text},{BlueLB.Text}");
            };

            CheckBox.Location = new Point(BlueTr.Location.X + BlueTr.Width + 10, save.Location.Y + save.Height + 10);
            CheckBox.Text = "Night";
            CheckBox.CheckedChanged += (s, e) =>
            {
                if (CheckBox.Checked == true)
                {
                    this.BackColor = Color.DarkSlateGray;
                    CheckBox.Text = "Day";
                }
                else
                {
                    this.BackColor = Color.WhiteSmoke;
                    CheckBox.Text = "Night";
                }
            };

            this.Controls.Add(RedTr);
            this.Controls.Add(GreenTr);
            this.Controls.Add(BlueTr);

            this.Controls.Add(RedLB);
            this.Controls.Add(GreenLB);
            this.Controls.Add(BlueLB);

            this.Controls.Add(panelRGB);

            this.Controls.Add(ListBox);
            this.Controls.Add(save);
            this.Controls.Add(CheckBox);
        }
        TrackBar RedTr = new TrackBar();
        TrackBar GreenTr = new TrackBar();
        TrackBar BlueTr = new TrackBar();

        Label RedLB = new Label();
        Label GreenLB = new Label();
        Label BlueLB = new Label();

        Panel panelRGB = new Panel();
        Button save = new Button();
        ListBox ListBox = new ListBox();

        CheckBox CheckBox = new CheckBox();

        string path = "E:\\Projects\\15.04\\Colours.txt";
        #endregion
    }
}