using System;
using System.Windows.Forms;

class ControlTest : Form
{
    private Button[] buttons = new Button[6];
    private TableLayoutPanel tlp;

    public static void Main()
    {
        Application.Run(new ControlTest());
    }

    public ControlTest()
    {
        this.Text = "サンプル";
        this.Width = 300;
        this.Height = 200;

        this.tlp = new TableLayoutPanel();
        this.tlp.Dock = DockStyle.Fill;
        this.tlp.ColumnCount = 3;
        this.tlp.RowCount = 2;

        for (int i = 0; i < buttons.Length; i++)
        {
            this.buttons[i] = new Button();
            this.buttons[i].Text = Convert.ToString(i);
            this.buttons[i].Parent = this.tlp;
        }

        this.tlp.Parent = this;
    }
}