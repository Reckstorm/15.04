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
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Text = "Form1";

            RedTr.Location = new Point(0, 0);
            RedTr.Maximum = 255;
            RedTr.Minimum = 0;
            RedTr.Size = new Size(150, 450);
            RedTr.Orientation = Orientation.Vertical;
            RedTr.ValueChanged += (s, e) => RedLB.Text = RedTr.Value.ToString();

            RedLB.Location = new Point(0, RedTr.Height);
            RedLB.Text = "0";

            GreenTr.Location = new Point(RedTr.Location.X + RedTr.Width + 10, 0);
            GreenTr.Maximum = 255;
            GreenTr.Minimum = 0;
            GreenTr.Size = new Size(150, 450);
            GreenTr.Orientation = Orientation.Vertical;
            GreenTr.ValueChanged += (s, e) => GreenLB.Text = GreenTr.Value.ToString();

            GreenLB.Location = new Point(RedTr.Location.X + RedTr.Width + 10, GreenTr.Height);
            GreenLB.Text = "0";

            BlueTr.Location = new Point(GreenTr.Location.X + GreenTr.Width + 10, 0);
            BlueTr.Maximum = 255;
            BlueTr.Minimum = 0;
            BlueTr.Size = new Size(150, 450);
            BlueTr.Orientation = Orientation.Vertical;
            BlueTr.ValueChanged += (s, e) => BlueLB.Text = BlueTr.Value.ToString();

            BlueLB.Location = new Point(GreenTr.Location.X + GreenTr.Width + 10, BlueTr.Height);
            BlueLB.Text = "0";

            this.Controls.Add(RedTr);
            this.Controls.Add(GreenTr);
            this.Controls.Add(BlueTr);

            this.Controls.Add(RedLB);
            this.Controls.Add(GreenLB);
            this.Controls.Add(BlueLB);
        }
        TrackBar RedTr = new TrackBar();
        TrackBar GreenTr = new TrackBar();
        TrackBar BlueTr = new TrackBar();

        Label RedLB = new Label();
        Label GreenLB = new Label();
        Label BlueLB = new Label();
        #endregion
    }
}