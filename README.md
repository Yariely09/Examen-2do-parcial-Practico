# Mi examen: Sistema de Inventario 

Este proyecto es un examen de programación donde desarrollé un sistema para organizar productos. La idea era crear una base sólida para que una tienda pueda registrar lo que vende y calcular automáticamente los impuestos, ya que no todos los productos pagan lo mismo.

## Explicación de lo que hice

Para que el código no fuera un desastre, lo organicé usando clases y objetos. Aquí te cuento cómo lo estructuré:

### La clase principal (Producto)
Esta es la madre de todas las clases en mi código. Aquí definí lo básico: nombre, código, precio y cantidad. Lo más importante aquí fue la **encapsulación**. Puse los datos en privado para que nadie los toque directamente, y creé propiedades con "get" y "set" para poder leerlos y cambiarlos de forma segura. También puse un método para mostrar la información del producto de golpe y no estar escribiendo "Console.WriteLine" a cada rato en el Main.

### Los tipos de productos (Herencia)
Como una laptop no es lo mismo que un cartón de leche, usé la **herencia**. Hice dos clases nuevas que "heredan" todo lo de Producto:
- **ProductoElectronico:** Esta clase ya tiene nombre y precio porque los hereda, pero le añadí el tiempo de garantía porque eso es clave en electrónicos.
- **ProductoAlimento:** A esta le añadí la fecha de vencimiento, que es lo más importante cuando vendes comida.

### El cálculo de impuestos (Polimorfismo)
Esta fue la parte más interesante. El requerimiento decía que los electrónicos pagan 18% de ITBIS y los alimentos solo el 8%. Para no hacer un código lleno de "if" y "else", usé **polimorfismo**:
1. En la clase base puse el método `CalcularImpuesto` como "virtual".
2. En las clases hijas usé "override" para escribir la fórmula real. 
Así, cuando el programa ve una Laptop, sabe que tiene que multiplicar por 0.18, y si ve un alimento, usa el 0.08 automáticamente.

## ¿Cómo se ve el resultado?

Cuando corres el programa, el Main crea los productos y los imprime tal cual se pidió. Por ejemplo, con una laptop la salida es esta:

Producto: Laptop 

Codigo: P1001 

Precio: 45000 

Cantidad: 5 

Garantia: 12 meses 

Impuesto: 8100


