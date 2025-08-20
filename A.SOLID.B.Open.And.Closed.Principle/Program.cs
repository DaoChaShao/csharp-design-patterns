namespace A.SOLID.B.Open.And.Closed.Principle;

class Program
{
    static void Main(string[] args)
    {
        #region Initialisation

        var random = new Random();
        var colours = new List<Colour> { Colour.Red, Colour.Yellow, Colour.Blue };
        var sizes = new List<Size> { Size.Large, Size.Medium, Size.Small };
        var products = new List<string> { "bike", "cup", "bag" };

        var cart = new List<Product>();

        #endregion

        #region OOP

        var amountProducts = random.Next(5, 11);
        for (var i = 0; i < amountProducts; i++)
        {
            var product = new Product(
                products[random.Next(products.Count)],
                colours[random.Next(colours.Count)],
                sizes[random.Next(sizes.Count)]
            );
            Console.WriteLine($"Product {i + 1}: {product}");
            cart.Add(product);
        }

        Console.WriteLine($"The cart contains {cart.Count} products.");

        #endregion

        #region OCP - Initialise filter

        var filter = new Filter();

        #endregion

        #region OCP - Colour

        var selectedColour = colours[random.Next(colours.Count)];
        var specificationColour = new SpecificationColour(selectedColour);

        var productsColour = filter.Products(cart, specificationColour);
        foreach (var product in productsColour)
        {
            Console.WriteLine($"The {selectedColour} product is: {product}");
        }

        #endregion

        #region OCP - Size

        var selectedSize = sizes[random.Next(sizes.Count)];
        var specificationSize = new SpecificationSize(selectedSize);

        var productsSize = filter.Products(cart, specificationSize);
        foreach (var product in productsSize)
        {
            Console.WriteLine($"The {selectedSize} product is: {product}");
        }

        #endregion

        #region OCP - And

        var specificationAnd = new SpecificationAnd(specificationColour, specificationSize);

        var productsAnd = filter.Products(cart, specificationAnd);
        foreach (var product in productsAnd)
        {
            Console.WriteLine($"The {product.Name} with {product.Colour} and {product.Size} is filtered.");
        }

        #endregion
    }
}