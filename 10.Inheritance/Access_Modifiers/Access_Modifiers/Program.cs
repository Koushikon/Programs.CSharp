namespace Access_Mofieiers
{
    public static class Program
    {
        static void Main()
        {
            var customer = new Customer();

            /**
             * Can't Acees his method its declared with Private modifiers
             * Because How Calculate Rating is done nothing concerns to the end user.
             */
            //var rating = customer.CalculateRating();

            /**
             * Can't access because of its Access level
             */
            // var gc1 = new GlodCustomer();
        }
    }
}