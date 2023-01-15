using PokemonGame;

Pokemon charizard = new Pokemon("Charizard", 100, 50, 40);
Pokemon wingull = new Pokemon("Wingull", 70, 100, 100);
Pokemon geodude = new Pokemon ("GeoDude");
Pokemon snorlax = new Pokemon("Snorlax");
Pokemon mewtwo = new Pokemon ("Mewtwo");
Pokemon butterfree = new Pokemon("Butterfree");
Pokemon articuno = new Pokemon("Articuno", 200, 70, 50);
Pokemon metapod = new Pokemon("metapod");

Fight roundOneOne = new Fight(charizard, wingull);
Fight roundOneTwo = new Fight(geodude, snorlax);
Fight roundOneThree = new Fight(butterfree,mewtwo);
Fight roundOneFour = new Fight(metapod,articuno);

Pokemon winner1 = roundOneOne.Battle();
Pokemon winner2 = roundOneTwo.Battle();
Pokemon winner3 = roundOneThree.Battle();
Pokemon winner4 = roundOneFour.Battle();

Fight semiFinalOne = new Fight(winner1, winner2);
Fight semiFinalTwo = new Fight(winner3, winner4);

Pokemon final1 = semiFinalOne.Battle();
Pokemon final2 = semiFinalTwo.Battle();

Fight final = new Fight(final1, final2);

Pokemon winner = final.Battle();

Console.WriteLine("The winner is " + winner.Name);