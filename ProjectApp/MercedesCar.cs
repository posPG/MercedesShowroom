namespace ProjectApp
{
    /// <summary>
    /// General car interface
    /// </summary>
    interface ICarType
    {
        string brand { get; set; }
        Options.Color color { get; set; }
        int price { get; set; }
        string getCall();
    }

    /// <summary>
    /// Main Mercedes car class
    /// </summary>
    public class MercedesCar:ICarType
    {
        public string brand { get; set; }
        public Options.Color color { get; set; }
        public int price { get; set; }
        public Options.Engine engine { get; set; }

        /// <summary>
        /// General car model constructor
        /// </summary>
        /// <param name="brand">Brand of the car</param>
        /// <param name="color">Color of the car</param>
        /// <param name="engine">Engine of the car</param>
        /// <param name="price">Price of the car</param>
        public MercedesCar(string brand, Options.Color color, Options.Engine engine, int price)
        {
            this.brand = "Mercedes";
            this.color = color;
            this.engine = engine;
            this.price = price;
        }

        /// <summary>
        /// Call cars provider to buy chosen ones
        /// </summary>
        /// <returns>Contact information</returns>
        public string getCall()
        {
            return "If you want us to call, please fill the Shopping Cart with at least one element";
        }
    }
}
