namespace API.Entities
{
    public class AppUser
    {
        public int Id{get;set;}
        public string Username{get;set;}//avoid issue with identity framework

       public byte[] PasswordHash{get;set;}
       public byte[] PasswordSalt{get;set;}
        
    }
}