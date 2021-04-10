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

        this.Click += new EventHandler(fm_Click);
    }

    public void fm_Click(Object sender, EventArgs e)
    {
        this.label.Text = "こんにちは";
    }
}
