using Patterns_DecoratorPattern.BeveragesMain;

namespace Patterns_DecoratorPattern.Decorator {

	class SugarAdd : BeveragesAddsBase {

		private BeveragesBase _beverage;

		public SugarAdd (BeveragesBase beverage) {
			_beverage = beverage;
			Description = _beverage.GetDescription () + " + Sugar";
			Price = beverage.GetPrice () + sugarPrice;
		}

	}
}
