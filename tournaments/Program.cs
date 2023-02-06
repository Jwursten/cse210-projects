// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Team firebirds = new Team("Firebirds");

Player john = new Player("John Henderson", 12);
Player steve = new Player("Steve Geovanni", 23);

firebirds.AddPlayer(john);
firebirds.AddPlayer(steve);
firebirds.DisplayRoster();


Team bluebirds = new Team("Bluebirds");

Player bill = new Player("Bill Smith", 88);
Player frank = new Player("Frank Wilhelm", 46);

bluebirds.AddPlayer(bill);
bluebirds.AddPlayer(frank);
bluebirds.DisplayRoster();

