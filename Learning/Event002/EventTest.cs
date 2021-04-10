using System;
using System.Windows.Forms;

class EventTest : Form
{
    private Label label;
    private Button button;

    public static void Main()
    {
        Application.Run(new EventTest());
    }

    public EventTest()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 100;

        this.label = new Label();
        this.label.Text = "いらっしゃいませ";
        this.label.Width = 150;
        this.button = new Button();
        this.button.Text = "購入";
        this.button.Top = this.Top + this.label.Height;
        this.button.Width = this.label.Width;

        this.button.Parent = this;
        this.label.Parent = this;

        this.button.Click += new EventHandler(bt_Click);
    }

    public void bt_Click(object sender, EventArgs e)
    {
        this.label.Text = "ありがとうございます。";
    }
}
