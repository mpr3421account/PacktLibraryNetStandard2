using Packt.Shared;
using System.Reflection;

//Person bob = new Person();//C# 1.0 or later
//var bob =  new Person();//C# 3.0 or later
Person bob = new();// C# 9.0 or later
WriteLine(bob.ToString());

//using Env = System.Environment;
//WriteLine(Env.OSVersion);
//WriteLine(Env.MachineName);
//WriteLine(Env.CurrentDirectory);

bob.Name = "Bob Smith";
bob.DateOfBirth = new DateTime (1965,12,22);

bob.BucketList =  WondersOfTheAncientWorld.HangingGardensOfBabylon  | WondersOfTheAncientWorld.MausoleumAtHalicarnassus;
WriteLine($"{bob.Name}'s bucket list is {bob.BucketList}");
//bob.BucketList = (WondersOfTheAncientWorld)18;

bob.Children.Add(new Person { Name = "Alfred" });//C# 3.0 and later
bob.Children.Add(new() { Name = "Zoe" });//C# 9.0 and later
WriteLine($"{bob.Name} has {bob.Children.Count} children:");
foreach(var child in bob.Children)
{
    WriteLine($"{child.Name}");
}


WriteLine(format: "{0} was born on {1:dddd, d MMMM yyyy}", arg0: bob.Name, arg1: bob.DateOfBirth);
WriteLine($"{bob.Name} was born on {bob.DateOfBirth}");

Person alice = new()
{
    Name = "Alice Jones",
    DateOfBirth = new(1998, 3, 7) // C# 9.0 or later
};
WriteLine(format: "{0} was born on {1:dd MMM yy}",
  arg0: alice.Name,
  arg1: alice.DateOfBirth);

bob.FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia;
WriteLine(format: "{0}'s favorite wonder is {1}. Its integer is {2}.", arg0: bob.Name, arg1: bob.FavoriteAncientWonder, arg2: (int)bob.FavoriteAncientWonder);