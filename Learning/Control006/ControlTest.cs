using System;
using System.Windows.Forms;

class ControlTest : Form
{
    private Label label;
    private CheckBox checkBox1;
    private CheckBox checkBox2;
    private FlowLayoutPanel flp;

    public static void Main()
    {
        Application.Run(new ControlTest());
    }

    public ControlTest()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 200;

        this.label = new Label();
        this.label.Text = "いらっしゃいませ～";
        this.label.Dock = DockStyle.Top;

        this.checkBox1 = new CheckBox();
        this.checkBox2 = new CheckBox();

        this.checkBox1.Text = "車";
        this.checkBox2.Text = "トラック";

        this.flp = new FlowLayoutPanel();
        this.flp.Dock = DockStyle.Bottom;

        this.checkBox1.Parent = flp;
        this.checkBox2.Parent = flp;

        this.label.Parent = this;
        this.flp.Parent = this;

        this.checkBox1.CheckedChanged += new EventHandler(this.cb_CheckedChanged);
        this.checkBox2.CheckedChanged += new EventHandler(this.cb_CheckedChanged);
    }

    public void cb_CheckedChanged(Object sender, EventArgs e)
    {
        CheckBox tmp = (CheckBox)sender;

        if(tmp.Checked)
        {
            this.label.Text = tmp.Text + "を選びました。";
        }
        else
        {
            this.label.Text = tmp.Text + "をやめました。";
        }
    }
}