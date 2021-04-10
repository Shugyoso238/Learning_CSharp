using System;
using System.Windows.Forms;

class EventTest : Form
{
    private Label label1;
    private Label label2;

    public static void Main()
    {
        Application.Run(new EventTest());
    }

    public EventTest()
    {
        this.Text = "サンプル";
        this.Width = 250;
        this.Height = 200;

        this.label1 = new Label();
        this.label1.Text = "矢印キーでお選びください";
        this.label1.Width = this.Width;

        this.label2 = new Label();
        this.label2.Top = this.label1.Bottom;

        this.label1.Parent = this;
        this.label2.Parent = this;

        this.KeyDown += new KeyEventHandler(this.fm_KeyDown);
    }

    public void fm_KeyDown(Object sender, KeyEventArgs e)
    {
        String str;
        switch (e.KeyCode)
        {
            case Keys.Up:
                str = "上";
                break;
            case Keys.Down:
                str = "下";
                break;
            case Keys.Right:
                str = "右";
                break;
            case Keys.Left:
                str = "左";
                break;
            default:
                str = "他のキー";
                break;
        }
        this.label2.Text = str + "ですね。";
    }
}
