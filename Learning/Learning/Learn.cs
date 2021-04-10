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

        PictureBox[] pb = new PictureBox[2];
        for(int i = 0; i < pb.Length; i++)
        {
            pb[i] = new PictureBox();
            pb[i].Parent = fm;
        }

        Car[] c = new Car[2];
        c[0] = new Car();
        c[1] = new RacingCar();
        for (int i = 0; i < c.Length; i++)
        {
            c[i].Move();
            pb[i].Image = c[i].GetImage();
            pb[i].Top = c[i].Top;
            pb[i].Left = c[i].Left;
        }

        Application.Run(fm);
    }
}

class Car
{
    private Image image;
    protected int top;
    protected int left;

    public Car()
    {
        this.image = Image.FromFile("C:\\C#練習用\\yasacs3\\YCSSample\\car.bmp");
        this.top = 0;
        this.left = 0;
    }

    virtual public void Move()
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

class RacingCar : Car
{
    public override void Move()
    {
        this.top += 100;
        this.left += 100;
    }
}
