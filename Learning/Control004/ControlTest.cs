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
            this.labels[i].Text = "This is a Car.";
            this.labels[i].Width = 200;
        }

        this.labels[0].Font = new Font("Arial", 12, FontStyle.Bold);
        this.labels[1].Font = new Font("Times New Roman", 14, FontStyle.Bold);
        this.labels[2].Font = new Font("Courier New", 16, FontStyle.Bold);

        for (int i = 0; i < labels.Length; i++)
        {
            this.labels[i].Parent = tlp;
        }
        this.tlp.Parent = this;
    }
}