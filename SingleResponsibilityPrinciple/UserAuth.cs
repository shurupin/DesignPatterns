namespace SingleResponsibilityPrinciple
{
    class UserAuth
    {
        private User User;

        public UserAuth(User user)
        {
            this.User = user;
        }

        public bool VerifyCredentials()
        {
            return true;
        }
    }

    internal class User
    {
    }
}
