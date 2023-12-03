 using Lab10;

 var group = new HeroGroup("Druzyna pierscienia");

 var war1 = new Warrior("Gorzak", 14);
 var war2 = new Warrior();
 var mag1 = new Mage();
 var mag2 = new Mage("Bolzano", 2, 11);
 group.Add(war1);
 group.Add(war2);
 group.Add(mag1);
 group.Add(mag2);
 Console.WriteLine(group.ToString());
 Console.WriteLine();
 
 war1.ChangeLife(11.32);
 war2.ChangeLife(97.81);
 mag1.ChangeLife(87.22);
 mag2.ChangeLife(39.97);
 Console.WriteLine(group.ToString());