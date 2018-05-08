using System;
using Patterns_DecoratorPattern.BeveragesMain;
using Patterns_DecoratorPattern.Decorator;

namespace Patterns_DecoratorPattern {
	class Program {
		static void Main (string[] args) {
			BeveragesBase coffee = new Coffee ();
			BeveragesBase blackTea = new BlackTea ();
			BeveragesBase greenTea = new GreenTea ();

			Console.WriteLine ("Standard beverages: ");
			ShowBeverageInfo (coffee);
			ShowBeverageInfo (blackTea);
			ShowBeverageInfo (greenTea);

			BeveragesBase cappuccino = new MilkAdd (new SugarAdd (new Coffee ()));
			BeveragesBase blackTeaWithSugar = new SugarAdd (new BlackTea ());
			BeveragesBase hotChocolateWithMilk = new ChocolateAdd (new SugarAdd (new MilkAdd (new Coffee ())));

			Console.WriteLine ("Custom beverages: ");
			ShowBeverageInfo (cappuccino);
			ShowBeverageInfo (blackTeaWithSugar);
			ShowBeverageInfo (hotChocolateWithMilk);

			Console.ReadLine ();
		}

		static void ShowBeverageInfo (BeveragesBase beverage) {
			Console.WriteLine ("Beverage: {0}. Price: {1}.", beverage.GetDescription(), beverage.GetPrice());
		}

	}
}
