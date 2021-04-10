using System;
using System.Windows.Forms;

class ControlTest : Form
{
    private Label label;
    private Button button;

    public static void Main()
    {
        Application.Run(new ControlTest());
    }

    public ControlTest()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 100;

        this.label = new Label();
        this.label.Text = "いらっしゃいませ～";
        this.label.Dock = DockStyle.Top;

        this.button = new Button();
        this.button.Text = "購入";
        this.button.Dock = DockStyle.Bottom;

        this.button.Click += new EventHandler(this.bt_Click);

        this.label.Parent = this;
        this.button.Parent = this;
    }

    public void bt_Click(Object sender, EventArgs e)
    {
        this.label.Text = "ご購入ありがとうございました。";
        this.button.Enabled = false;
    }
}