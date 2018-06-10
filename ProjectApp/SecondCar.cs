namespace ProjectApp
{
    /// <summary>
    /// Mercedes AMG GT car logic handler
    /// </summary>
    public class SecondCar:MercedesCar
    {
        public string name { get; set; }
        /// <summary>
        /// Possible prices
        /// </summary>
        public int[] prices = new int[3] { 1100000, 1480000, 1790000 };

        /// <summary>
        /// Car model constructor
        /// </summary>
        /// <param name="carBrand">Brand of the car</param>
        /// <param name="carColor">Color of the car</param>
        /// <param name="carEngine">Engine of the car</param>
        /// <param name="price">Erice of the car</param>
        public SecondCar(string carBrand, Options.Color carColor, Options.Engine carEngine, int price)
            :base(carBrand, carColor, carEngine, price)
        {
            base.brand = carBrand;
            base.color = carColor;
            base.engine = carEngine;
            base.price = price;
        }

        /// <summary>
        /// Car model constructor with set name
        /// </summary>
        /// <param name="brand">Brand of the car</param>
        /// <param name="color">Color of the car</param>
        /// <param name="engine">Engine of the car</param>
        /// <param name="name">Name of the car</param>
        /// <param name="price">Price of the car</param>
        public SecondCar(string brand, Options.Color color, Options.Engine engine, string name, int price)
            :base(brand, color, engine, price)
        {
            this.name = "AMG GT";
        }
    }
}
