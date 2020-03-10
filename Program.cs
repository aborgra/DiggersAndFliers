using System;
using System.Collections.Generic;

namespace DiggersAndFliers {
    class Program {
        static void Main (string[] args) {
            Ant ant = new Ant () {
                Dig = true,
                Name = "Ant",
                Color = "brown",
                Food = "dirt"
            };

            BettaFish betta = new BettaFish () {
                Swim = true,
                Name = "Betta",
                Color = "red",
                Food = "food"
            };

            CopperheadSnake copperSnake = new CopperheadSnake () {
                Move = true,
                Name = "Copper",
                Color = "brown",
                Food = "mice"
            };

            Earthworm worm = new Earthworm () {
                Dig = true,
                Name = "Worm",
                Color = "brown",
                Food = "dirt"
            };

            Finch bird = new Finch () {
                Fly = true,
                Name = "Bird",
                Color = "orange",
                Food = "seeds"
            };

            Gerbil gerbil = new Gerbil () {
                Move = true,
                Name = "Gerbil",
                Color = "brown",
                Food = "seeds"
            };

            Mice mouse = new Mice () {
                Move = true,
                Name = "Mouse",
                Color = "white",
                Food = "seeds"
            };

            Parakeet smallBird = new Parakeet () {
                Fly = true,
                Name = "Parakeet",
                Color = "orange",
                Food = "seeds"
            };

            Rattlesnake rattler = new Rattlesnake () {
                Move = true,
                Name = "Rattler",
                Color = "green",
                Food = "rats"
            };

            Terrapin turtle = new Terrapin () {
                Swim = true,
                Name = "Turts",
                Color = "green",
                Food = "fish"
            };

            Container animalContainer = new Container ();

            animalContainer.Diggers.Add (worm);
            animalContainer.Diggers.Add (ant);
            animalContainer.Movers.Add (copperSnake);
            animalContainer.Movers.Add (gerbil);
            animalContainer.Movers.Add (mouse);
            animalContainer.Movers.Add (rattler);
            animalContainer.Fliers.Add (bird);
            animalContainer.Fliers.Add (smallBird);
            animalContainer.Swimmers.Add (betta);
            animalContainer.Swimmers.Add (turtle);

            foreach (var animal in animalContainer.Diggers) {
                Console.WriteLine (animal.ToString ());
            }

            foreach (var animal in animalContainer.Movers) {
                Console.WriteLine (animal.ToString ());
            }

            foreach (var animal in animalContainer.Fliers) {
                Console.WriteLine (animal.ToString ());
            }

            foreach (var animal in animalContainer.Swimmers) {
                Console.WriteLine (animal.ToString ());
            }

        }
    }
}