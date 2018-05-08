using Patterns_DecoratorPattern.BeveragesMain;

namespace Patterns_DecoratorPattern.Decorator {

	class MilkAdd : BeveragesAddsBase {
		private BeveragesBase _beverage;

		public MilkAdd (BeveragesBase beverage) {
			_beverage = beverage;
			Description = _beverage.GetDescription () + " + Milk";
			Price = beverage.GetPrice() + milkPrice;
		}
	}

}
