using Lab6C;

Laptop laptop1 = new Laptop("Macbook M2", 2000); //get default value for "origin"
Laptop laptop2 = new Laptop("Dell XPS13", 1500);
laptop2.Origin = "USA"; //change default value for "origin"

Person person1 = new Person("Hung Lam", laptop1);
person1.showPersonInfo();
Person person2 = new Person("Thu Huong", laptop2);
person2.showPersonInfo();