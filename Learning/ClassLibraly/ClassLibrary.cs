using System.Windows.Forms;
using System.Drawing;

class ClassLibrary : Form
{
    public static void Main()
    {
        Application.Run(new ClassLibrary());
    }

    public ClassLibrary()
    {
        this.Text = "サンプル";
        this.Width = 400;
        this.Height = 300;
        this.BackgroundImage = Image.FromFile("C:\\C#練習用\\yasacs3\\YCSSample\\car.bmp");
    }
}
