namespace Library
{
    public class LibraryManagement : LibraryManagementCore
    {
        private EmailService emailService;

        public LibraryManagement()
        {
            emailService = new EmailService();
        }

        public void RegisterUser(string firstName, string lastName)
        {
            
        }

        public void RegisterUser(string firstName, string lastName, string userName)
        {
            var foundUser = false;
            foreach (var user in Store.Users)
                if (user.Email == userName)
                {
                    foundUser = true;
                    break;
                }

            if (foundUser)
                return;

            Store.Users.Add(new User(firstName, lastName, userName));
            emailService.SendEmail(userName);
        }
    }
}
