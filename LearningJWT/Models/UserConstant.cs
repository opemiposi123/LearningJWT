namespace LearningJWT.Models
{
    public class UserConstant
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() { Username = "mahmood_admin", EmailAddress = "mahmood.admin@gmail.com", Password = "MyPass_w0rd", GivenName = "mahmood", Surname = "AbdulWaheed", Role = "Administrator" }, 
            new UserModel() { Username = "elyse_seller", EmailAddress = "elyse.seller@email.com", Password = "MyPass_w0rd", GivenName = "Elyse", Surname = "Lambert", Role = "Seller" },
        };
    }
}
