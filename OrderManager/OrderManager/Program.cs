class Program
{
    static void Main()
    {
        Console.WriteLine( "O Z O N" );

        string name = GetInput( "Enter your name: " );
        Console.Write( $"Hello {name}! " );
        string product = GetInput( "Enter your product: " );
        int count = Convert.ToInt16( GetInput( "Enter count your product: " ) );
        string address = GetInput( "Enter your address: " );

        Console.WriteLine( $"Здравствуйте, {name}, вы заказали {count} {product} на адрес {address}, все верно?" );
        Check( name, product, count, address );
    }
    static void Check( string name, string product, int count, string address )
    {
        string check = Console.ReadLine().ToLower(); ;
        if (check == "да" || check == "yes")
        {
            DateTime now = DateTime.Now;
            int todays_date = now.Day;
            Console.WriteLine( $"{name}, Ваш заказ {product} в количестве {count} оформлен! Ожидайте доставку по адресу {address} к {todays_date + 3} июля." );
        }
        else
        {
            Main();
        }
    }
    static string GetInput( string message )
    {
        string input;
        do
        {
            Console.Write( message );
            input = Console.ReadLine();

            if (string.IsNullOrEmpty( input ))
            {
                Console.WriteLine( "Value is not recognized" );
            }
        } while (string.IsNullOrEmpty( input ));

        return input;
    }
}

