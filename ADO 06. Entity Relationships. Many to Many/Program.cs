using ADO_06._Entity_Relationships._Many_to_Many;
using Microsoft.EntityFrameworkCore;

using SocialContext db = new();
//SocialNetwork fasebook = new SocialNetwork() {Name="Facebook" };
//SocialNetwork instagram = new SocialNetwork() {Name="Instagram" };
//SocialNetwork ok = new SocialNetwork() {Name="Ok" };
//User user1 = new User() { 
//    FirstName="Nadir",
//    LastName = "Zamanov",
//    Login = "MoguDa",
//    Password = "P@ss12345"
//};
//fasebook.Users.Add(user1);
//instagram.Users.Add(user1);
//ok.Users.Add(user1);
//db.SocialNetworks.AddRange(fasebook, instagram, ok);
//db.SaveChanges();

//var networks = db.SocialNetworks.Include(s => s.Users).ToList();
//foreach (var network in networks)
//{
//    Console.WriteLine(network);
//    foreach (var user in network.Users)
//    {
//        Console.WriteLine($"        {user}");
//    }
//}

var users = db.Users.Include(u=>u.SocialNetworks).ToList();
foreach (var user in users)
{
    Console.WriteLine(user);
	foreach (var sn in user.SocialNetworks)
	{
        Console.WriteLine($"        {sn}");
    }
}
