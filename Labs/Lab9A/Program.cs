using Lab9A;

Movie movie1 = new Movie();
movie1.setName("ABCD");
movie1.setDirector("123213");
 
movie1.showMovieInfo();

Movie movie2 = new Movie("Hello", "Demo", 2023);
movie2.showMovieInfo();
Console.WriteLine("Published Year : " + movie2.getYear());
