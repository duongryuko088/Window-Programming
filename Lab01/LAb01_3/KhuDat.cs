namespace LAb01_3
{
    class KhuDat
    {
        private string location;
        private double price;
        private double area;

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }
        public double Area
        {
            get
            {
                return area;
            }
            set
            {
                area = value;
            }
        }
        public virtual void Input()
        {
            System.Console.WriteLine("Input location: ");
            Location = System.Console.ReadLine();
            System.Console.WriteLine("Input price: ");
            Price = double.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Input area: ");
            Area = double.Parse(System.Console.ReadLine());
        }
        public virtual void Show()
        {
            System.Console.WriteLine("Location: {0} | Price: {1} | Area: {2}", this.Location, this.Price, this.Area);
        }
    }
    
}
