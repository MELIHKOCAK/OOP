/* Bu projede Türkiye cumhuriyeti kimlik kartının bilgisayar ortamına
 * aktarılmasına çalıştım. Bu işlemi gerçekleştirirken OOP paradigmasını
 * kullandım.*/


using System.Text;

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
    string name, surname, result, nationality, documentNo, motherName, fatherName, issuedBy;
    DateTime birthDay,validUntil;
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

    #region MOTHERNAME PROP
    public string MOTHERNAME
    {
        get { return motherName; }
        set { motherName = value.ToUpper().ToString(); }
    }
    #endregion

    #region FATHERNAME PROP
    public string FATHERNAME
    {
        get { return fatherName; }
        set { fatherName = value.ToUpper().ToString(); }
    }
    #endregion

    #region ISSUEDBY PROP
    public string ISSUEDBY
    {
        get { return issuedBy; }
        set { issuedBy = value.ToUpper().ToString(); }
    }
    #endregion

    #region DOCUMENTNO PROP
    public string DOCUMENTNO
    {
        get { return documentNo; }
        set { documentNo = value.ToUpper().Trim(); }
    }
    #endregion

    #region VALIDUNTIL PROP
    public string VALIDUNTIL
    {
        get { return birthDay.AddYears(50).ToShortDateString(); }
        
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

    #region OVERRIDE TOSTRING
    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(idNumber)
            .AppendLine(SURNAME)
            .AppendLine(NAME)
            .AppendLine(BIRTHDAY)
            .AppendLine(VALIDUNTIL)
            .AppendLine(GENDER)
            .AppendLine(nationalityGet())
            .AppendLine(MOTHERNAME)
            .AppendLine(FATHERNAME)
            .AppendLine(ISSUEDBY);
        Console.WriteLine(sb);
        return "";
    }
    #endregion
}

internal class Program
{
    private static void Main(string[] args)
    {

        IDENTITYCARD melih = new IDENTITYCARD("11111111111") 
        { 
            SURNAME="KOÇak",
            NAME="Melih",
            BIRTHDAY="11/11/2000",
            DOCUMENTNO="5551",
            GENDER="E",
            MOTHERNAME="Ayşe",
            FATHERNAME="ÖmEr",
            ISSUEDBY="İçİŞLERi BakAnlIğI"
        };
        melih.nationalitySet("T.C.");
        melih.ToString();

    }
}