using Patterns_DecoratorPattern.BeveragesMain;

namespace Patterns_DecoratorPattern.Decorator {

	class ChocolateAdd : BeveragesAddsBase {

		private BeveragesBase _beverage;

		public ChocolateAdd (BeveragesBase beverage) {
			_beverage = beverage;
			Description = _beverage.GetDescription () + " + Chocolate";
			Price = beverage.GetPrice () + chocoPrice;
		}

	}
}
