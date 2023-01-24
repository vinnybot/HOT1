using System.ComponentModel.DataAnnotations;

namespace OrderForm.Models
{
    public class OrderFormModel
    {
        [Required(ErrorMessage = "Please enter a quantity bro")]
        public int? Qty { get; set; }
        public string? DiscountCode { get; set; }

        public string? DiscountMessage { get; set; }

        public decimal? PricePerShirt { get; set; } = 15.00M;

        public decimal? Subtotal { get; set; } = 0;

        public decimal? Tax { get; set; } = 0.08M;
        public decimal? Total { get; set; } = 0;

        public decimal? CalculateTotal()
        {
            decimal? subTotal = 0;

            decimal? tax = 0;

            decimal? total = 0;

            if (DiscountCode == "1390")
            {
                PricePerShirt = 12;
                DiscountMessage = "20% Discount Applied";

                subTotal = PricePerShirt * Qty;

                tax = subTotal * Tax;

                total = subTotal + tax;
            }

            if (DiscountCode == "6175")
            {
                PricePerShirt = 10.50M;
                DiscountMessage = "30% Discount Applied";

                subTotal = PricePerShirt * Qty;

                tax = subTotal * Tax;

                total = subTotal + tax;
            }

            if (DiscountCode == "BB88")
            {
                PricePerShirt = 13.50M;
                DiscountMessage = "10% Discount Applied";

                subTotal = PricePerShirt * Qty;

                tax = subTotal * Tax;

                total = subTotal + tax;
            }

            else
            {
                subTotal = PricePerShirt * Qty;

                tax = subTotal * Tax;

                total = subTotal + tax;
            }

            return total;
        }
        public decimal? CalculateTax()
        {
            decimal? subTotal = PricePerShirt * Qty;
            decimal? tax = subTotal * Tax;

            return tax;
        }
        public decimal? CalculateSubTotal()
        {
            decimal? subTotal = PricePerShirt * Qty;

            return subTotal;
        }
    }
}
