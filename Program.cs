/* Bu projede Türkiye cumhuriyeti kimlik kartının bilgisayar ortamına
 * aktarılmasına çalıştım. Bu işlemi gerçekleştirirken OOP paradigmasını
 * kullandım.*/


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
    public IDENTITYCARD(string idNumber) : base(8.3, 5.1, 0.1)
    {
        WIDTH = base.WIDTH;
        HEIGHT = base.HEIGHT;
        THICKNESS = base.THICKNESS;
        this.idNumber = idNumber.ToUpper().Trim();
    }
    #endregion

    #region VARIABLES
    bool control;
    string name, surname, result, nationality;
    DateTime birthDay;
    char gender;
    public readonly string idNumber; //Readonly keywordünü bildiğimi göstermek amaçlı bu örneği yaptım.
    #endregion

    #region NAME PROP
    public string NAME
    {
        get { return name; }
        set { name = value.ToUpper().Trim(); }
    }

    #endregion

    #region SURNAME PROP
    public string SURNAME
    {
        get { return surname; }
        set { surname = value.ToUpper().Trim(); }
    }

    #endregion

    #region BIRTHDAY PROP
    public string BIRTHDAY
    {
        get
        {
            if (control is true)
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
            if (control is true)
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

    #region GENDER PROP
    public string GENDER
    {
        get
        {
            return gender.ToString();
        }
        set
        {
            gender = Convert.ToChar(value.Trim().ToUpper());
        }
    }
    #endregion

    #region NATIONALITY GET - SET METHODS
    //Kapsülleme mantığının sadece Property ile değil method yardımı ile yapılabilidiğini göstermek amaçlı bu örneği yaptım.
    public string nationalityGet()
    {
        return nationality;
    }
    public void nationalitySet(string value)
    {
        nationality = value.ToUpper().Trim();
    }
    #endregion
}

internal class Program
{
    private static void Main(string[] args)
    {
        


    }
}