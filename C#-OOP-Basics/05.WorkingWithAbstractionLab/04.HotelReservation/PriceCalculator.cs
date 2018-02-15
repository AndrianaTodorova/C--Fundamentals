class PriceCalculator
{

    public string Calculate(decimal pricePerdDay, int days, Season season, Discount discount)
    {
        int seasonDigit = (int) season;
        decimal priceBeforeDiscount = pricePerdDay * days * seasonDigit;
        decimal totalPrice = priceBeforeDiscount - (priceBeforeDiscount * (int) discount / 100);
        return $"{totalPrice:f2}";
    }
}