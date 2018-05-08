namespace Patterns_DecoratorPattern.BeveragesMain {

	public abstract class BeveragesBase {
		protected string Description = "";
		protected double Price;

		protected double sugarPrice = 25;
		protected double milkPrice = 40;
		protected double chocoPrice = 75;

		public string GetDescription () {
			return Description;
		}

		public double GetPrice () {
			return Price;
		}
		
	}
}
