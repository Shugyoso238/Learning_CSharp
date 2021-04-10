using System;
using System.Windows.Forms;

class ControlTest : Form
{
    private Button[] buttons = new Button[6];
    private FlowLayoutPanel flp;

    public static void Main()
    {
        Application.Run(new ControlTest());
    }

    public ControlTest()
    {
        this.Text = "サンプル";
        this.Width = 600;
        this.Height = 100;

        this.flp = new FlowLayoutPanel();
        this.flp.Dock = DockStyle.Fill;

        for(int i = 0; i < buttons.Length; i++)
        {
            this.buttons[i] = new Button();
            this.buttons[i].Text = Convert.ToString(i);
            this.buttons[i].Parent = this.flp;
        }

        this.flp.Parent = this;
    }
}
