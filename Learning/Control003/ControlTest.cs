using System;
using System.Windows.Forms;
using System.Drawing;

class ControlTest : Form
{
    private Label[] labels = new Label[3];
    private TableLayoutPanel tlp;

    public static void Main()
    {
        Application.Run(new ControlTest());
    }

    public ControlTest()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 200;

        this.tlp = new TableLayoutPanel();
        this.tlp.Dock = DockStyle.Fill;
        this.tlp.ColumnCount = 1;
        this.tlp.RowCount = 3;

        for (int i = 0; i < labels.Length; i++)
        {
            this.labels[i] = new Label();
            this.labels[i].Text = i + "号車です.";
        }

        this.labels[0].ForeColor = Color.Black;
        this.labels[1].ForeColor = Color.Black;
        this.labels[2].ForeColor = Color.Black;

        this.labels[0].BackColor = Color.White;
        this.labels[1].BackColor = Color.Gray;
        this.labels[2].BackColor = Color.White;

        this.labels[0].TextAlign = ContentAlignment.TopLeft;
        this.labels[1].TextAlign = ContentAlignment.MiddleCenter;
        this.labels[2].TextAlign = ContentAlignment.BottomRight;

        this.labels[0].BorderStyle = BorderStyle.None;
        this.labels[1].BorderStyle = BorderStyle.FixedSingle;
        this.labels[2].BorderStyle = BorderStyle.Fixed3D;

        for(int i = 0; i < labels.Length; i++)
        {
            this.labels[i].Parent = tlp;
        }
        this.tlp.Parent = this;
    }
}