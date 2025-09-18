public class InoviceCalculator
{
    public double CalculateTotal()
    {
        double subTotal = 0;
        foreach (var item in Items)
        {
            subTotal += item.Price;
        }
        return subTotal + (subTotal * TaxRate);
    }a
}