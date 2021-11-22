using System.IO;
namespace bonus_lab
{
    public class Author
    {
        private string name;
        private char gender;
        private string email;

        public Author(string tempName, char tempGender, string tempEmail)
        {
            name = tempName;
            gender = tempGender;
            email = tempEmail;
        }
        public string GetName()
        {
            return name;
        }
        public void SetName(string tempName)
        {
            name = tempName;
        }
        public char GetGender()
        {
            return gender;
        }
        public void SetGender(char tempGender)
        {
            gender = tempGender;
        }
        public string GetEmail()
        {
            return email;
        }
        public void SetEmail(string tempEmail)
        {
            email = tempEmail;
        }

        public override string ToString()
        {
            return $"name = {this.GetName()}, email = {this.GetEmail()}, gender = {this.GetGender()}";
        }
    }
}