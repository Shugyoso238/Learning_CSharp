using System.Windows.Forms;
using System.Drawing;

class Learn
{
    public static void Main()
    {
        Form fm = new Form();
        fm.Text = "サンプル";
        fm.Width = 400;
        fm.Height = 300;

        PictureBox pb = new PictureBox();

        Car c = new Car();
        c.Move();
        c.Move();

        pb.Image = c.GetImage();
        pb.Top = c.Top;
        pb.Left = c.Left;
        pb.Parent = fm;

        Application.Run(fm);
    }
}

class Car
{
    private Image image;
    private int top;
    private int left;

    public Car()
    {
        this.image = Image.FromFile("C:\\C#練習用\\yasacs3\\YCSSample\\car.bmp");
        this.top = 0;
        this.left = 0;
    }

    public void Move()
    {
        this.top += 10;
        this.left += 10;
    }

    public void SetImage(Image image)
    {
        this.image = image;
    }

    public Image GetImage()
    {
        return this.image;
    }

    public int Top
    {
        set { this.top = value; }
        get { return this.top; }
    }

    public int Left
    {
        set{ this.left = value; }
        get { return this.left; }
    }


}
