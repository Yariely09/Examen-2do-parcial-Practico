namespace ExamenPractico_2do_parcial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            ProductoElectronico miLaptop = new ProductoElectronico("Laptop", "P1001", 45000, 5, 12);

            // 2. Crear un ProductoAlimento
            ProductoAlimento miLeche = new ProductoAlimento("Leche Entera", "A2002", 75, 20, "10/05/2026");

            // Mostrar Información Laptop
            miLaptop.MostrarProducto();
            Console.WriteLine($"Garantia: {miLaptop.GarantiaMeses} meses");
            Console.WriteLine($"Impuesto: {miLaptop.CalcularImpuesto()}");

            // Mostrar Información Alimento
            miLeche.MostrarProducto();
            Console.WriteLine($"Vencimiento: {miLeche.FechaVencimiento}");
            Console.WriteLine($"Impuesto: {miLeche.CalcularImpuesto()}");
        }

        public class Producto
        {
            // Atributos privados
            private string nombre;
            private string codigo;
            private double precio;
            private int cantidad;

            // Propiedades públicas 
            public string Nombre
            {
                get { return nombre; }
                set { nombre = value; }
            }

            public string Codigo
            {
                get { return codigo; }
                set { codigo = value; }
            }

            public double Precio
            {
                get { return precio; }
                set { precio = value; }
            }

            public int Cantidad
            {
                get { return cantidad; }
                set { cantidad = value; }
            }

            // Constructor
            public Producto(string nombre, string codigo, double precio, int cantidad)
            {
                this.nombre = nombre;
                this.codigo = codigo;
                this.precio = precio;
                this.cantidad = cantidad;
            }

            // Método Virtual para Polimorfismo
            public virtual double CalcularImpuesto()
            {
                return 0;
            }

            public void MostrarProducto()
            {
                Console.WriteLine($"Producto: {Nombre}");
                Console.WriteLine($"Codigo: {Codigo}");
                Console.WriteLine($"Precio: {Precio}");
                Console.WriteLine($"Cantidad: {Cantidad}");
            }
        }

        // Clase Derivada: Electrónico
        public class ProductoElectronico : Producto
        {
            private int garantiaMeses;

            public int GarantiaMeses
            {
                get { return garantiaMeses; }
                set { garantiaMeses = value; }
            }

            public ProductoElectronico(string nombre, string codigo, double precio, int cantidad, int garantia)
                : base(nombre, codigo, precio, cantidad)
            {
                this.garantiaMeses = garantia;
            }

            // Polimorfismo: ITBIS 18%
            public override double CalcularImpuesto()
            {
                return Precio * 0.18;
            }
        }

        // Clase Derivada: Alimento
        public class ProductoAlimento : Producto
        {
            private string fechaVencimiento;

            public string FechaVencimiento
            {
                get { return fechaVencimiento; }
                set { fechaVencimiento = value; }
            }

            public ProductoAlimento(string nombre, string codigo, double precio, int cantidad, string fecha)
                : base(nombre, codigo, precio, cantidad)
            {
                this.fechaVencimiento = fecha;
            }

            // Polimorfismo: Impuesto 8%
            public override double CalcularImpuesto()
            {
                return Precio * 0.08;
            }
        }
    }
}