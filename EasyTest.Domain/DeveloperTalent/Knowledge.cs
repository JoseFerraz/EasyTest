namespace EasyTest.Domain
{
    public class Knowledge
    {
        public int Id { get; set; }
        public Technologies Technologies { get; set; }
        public Languages Languages { get; set; }
    }

    public class Technologies
    {
        public short? Ionic { get; set; }
        public short? Android { get; set; }
        public short? IOS { get; set; }
        public short? Html { get; set; }
        public short? Css { get; set; }
        public short? Bootstrap { get; set; }
        public short? JQuery { get; set; }
        public short? AngularJS { get; set; }
        public short? Java { get; set; }
        public short? AspNetMvc { get; set; }
        public short? C { get; set; }
        public short? CPlusPlus { get; set; }
        public short? Cake { get; set; }
        public short? Django { get; set; }
        public short? Magento { get; set; }
        public short? Php { get; set; }
        public short? Vue { get; set; }
        public short? WordPress { get; set; }
        public short? Python { get; set; }
        public short? Ruby { get; set; }
        public short? SqlServer { get; set; }
        public short? MySql { get; set; }
        public short? Salesforce { get; set; }
        public short? Photoshop { get; set; }
        public short? Illustrator { get; set; }
        public short? Seo { get; set; }
        public string Other { get; set; }
    }

    public class Languages
    {
        public bool English { get; set; }
        public bool Portuguese { get; set; }
        public bool Spanish { get; set; }
        public bool More { get; set; }
        public string Other { get; set; }
    }
}
