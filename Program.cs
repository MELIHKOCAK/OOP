class CARD
{
    #region CONSTRUCTOR
    public CARD(double width, double height, double thickness)
    {
        WIDTH = width;
        HEIGHT = height;
        THICKNESS = thickness;
    }
    #endregion

    #region VARIABLES
    double width, height, thickness;
    #endregion

    #region WIDTH PROP
    public double WIDTH
    {
        get { return width; }
        set { width = value; }
    }
    #endregion

    #region HEIGHT PROP
    public double HEIGHT
    {
        get { return height; }
        set { height = value; }
    }
    #endregion

    #region THICKNESS PROP
    public double THICKNESS
    {
        get { return thickness; }
        set { thickness = value; }
    }
    #endregion


}

class IDENTITYCARD : CARD
{
    #region CONSTRUCTOR
    public IDENTITYCARD() : base(8.3, 5.1, 0.1)
    {
        WIDTH = base.WIDTH;
        HEIGHT = base.HEIGHT;
        THICKNESS = base.THICKNESS;
    }
    #endregion

    #region VARIABLES
    bool control;
    string name, surname, result;
    DateTime birthDay;
    #endregion

    #region NAME PROP
    public string NAME
    {
        get { return name; }
        set { name = value.ToUpper(); }
    }

    #endregion

    #region SURNAME PROP
    public string SURNAME
    {
        get { return surname; }
        set { surname = value.ToUpper(); }
    }

    #endregion

    #region BIRTHDAY PROP
    public string BIRTHDAY
    {
        get
        {
            if (control == true)
            {
                result = "Please, check your birthday";
                return result;
            }
            else
            {
                return birthDay.ToShortDateString();
            }
        }
        set
        {
            control = DateTime.Compare(DateTime.Now, Convert.ToDateTime(value)) < 0;
            if (control == true)
            {
                Console.WriteLine("Please, check your birthday");
            }
            else
            {
                birthDay = Convert.ToDateTime(value);
            }

        }
    }
    #endregion

}

internal class Program
{
    private static void Main(string[] args)
    {
        
    }
}