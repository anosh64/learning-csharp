using System.IO;

namespace interfacesandtestability
{
    public interface IShippingCalculator
    {
        float CalculateShipping(Order order);
    }
    public class ShippingCalculator : IShippingCalculator // this is not inheritance!
    {                                                    // when it comes to interfaces,
                                                        // this is actually implement not inherit!
        public float CalculateShipping(Order order)
        {
            if (order.TotalPrice < 30f)
            {
                return order.TotalPrice * 0.1f;
            }

            return 0;
        }
    }
}