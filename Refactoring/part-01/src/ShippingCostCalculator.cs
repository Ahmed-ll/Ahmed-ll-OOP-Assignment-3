namespace Refactoring.Part01;

public interface IShippingCostCalculator
{
    string Carrier { get; }
    decimal Calculate(decimal weightKg);
}

public class AramexShippingCostCalculator : IShippingCostCalculator
{
    public string Carrier => "Aramex";
    public decimal Calculate(decimal weightKg) => weightKg * 12m;
}

public class FedExShippingCostCalculator : IShippingCostCalculator
{
    public string Carrier => "FedEx";
    public decimal Calculate(decimal weightKg) => weightKg * 15m;
}

public class DHLShippingCostCalculator : IShippingCostCalculator
{
    public string Carrier => "DHL";
    public decimal Calculate(decimal weightKg) => weightKg * 18m;
}

public class ShippingCostCalculator 
{
    private readonly IShippingCostCalculator _strategy;
    public ShippingCostCalculator(IShippingCostCalculator strategy) => _strategy = strategy;

    public decimal Calculate(decimal weightKg)
    {
        decimal cost = _strategy.Calculate(weightKg);
        return cost;
    }
}
