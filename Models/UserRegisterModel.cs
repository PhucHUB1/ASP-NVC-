namespace T2210M_MVC1.Models
{
    public class UserRegisterModel 
    {
        public int id { get; set; }//abstract property
        public string Email { get; set; }

        public string Fullname { get; set; }

        public string Telephone { get; set; }
    }
}