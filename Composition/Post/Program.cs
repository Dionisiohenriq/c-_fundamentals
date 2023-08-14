





using Post.Entities;

Coment c1 = new Coment("Have a nice trip!");
Coment c2 = new Coment("Wow that's awesome!");
Posts p1 = new Posts(
    DateTime.Parse("21/06/2018 13:05:44"),
    "Traveling to New Zealand",
    "I'm going to visit this wonderful country!",
    12
    );

p1.AddComent(c1);
p1.AddComent(c2);


Coment c3 = new Coment("Good night");
Coment c4 = new Coment("May the force be with you");
Posts p2 = new Posts(
    DateTime.Parse("28/07/2018 23:14:19"),
    "Good night guys",
    "See you tomorrow",
    5
    );

p2.AddComent(c3);
p2.AddComent(c4);

Console.WriteLine(p1);
Console.WriteLine(p2);