using System;
using System.Windows.Forms;

class EventTest : Form
{
    private Label label;

    public static void Main()
    {
        Application.Run(new EventTest());
    }

    public EventTest()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 200;

        this.label = new Label();
        this.label.Text = "ようこそ";
        this.label.Parent = this;

        this.MouseEnter += new EventHandler(fm_MouseEnter);
        this.MouseLeave += new EventHandler(fm_MouseLeave);
        
    }

    public void fm_MouseEnter(Object sender, EventArgs e)
    {
        this.label.Text = "こんちゃ～す";
    }

    public void fm_MouseLeave(Object sender, EventArgs e)
    {
        this.label.Text = "うぃ～す";
    }
}
