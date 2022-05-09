namespace Access_Mofieiers
{
    // Can be accessed with same assembly only
    internal class GlodCustomer : Customer
    {
        public string CardName { get; set; }
        public void OfferVoucher()
        {
            //var rating = this.CalculateRating(excludeOrders: true);
        }
    }
}