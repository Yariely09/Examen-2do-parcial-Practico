# Sistema de Gestión de Inventario

Este es un caso práctico desarrollado en **C#** para demostrar el uso de la **Programación Orientada a Objetos (POO)**. El sistema permite gestionar diferentes tipos de productos aplicando reglas de negocio específicas para el cálculo de impuestos.

## 🚀 Requerimientos del Sistema

El sistema cumple con los siguientes pilares de POO:

* **Encapsulación**: Todos los atributos de la clase `Producto` son privados y se acceden mediante propiedades públicas con bloques `get` y `set`.
* **Herencia**: Se utiliza una clase base `Producto` de la cual heredan `ProductoElectronico` y `ProductoAlimento`.
* **Polimorfismo**: El método `CalcularImpuesto()` es virtual en la clase base y se redefine (`override`) en las clases derivadas según la tasa correspondiente.

## 📊 Reglas de Impuestos

| Tipo de Producto | Tasa de Impuesto (ITBIS) | Atributo Adicional |
| :--- | :--- | :--- |
| **Electrónico** | 18% | Garantía (Meses) |
| **Alimento** | 8% | Fecha de Vencimiento |

## 💻 Ejemplo de Código (Main)

La implementación en el punto de entrada principal crea objetos específicos y muestra la información formateada:

```csharp
// Ejemplo de creación de un producto electrónico
ProductoElectronico laptop = new ProductoElectronico("Laptop", "P1001", 45000, 5, 12);

// Salida esperada
Producto: Laptop 
Codigo: P1001 
Precio: 45000 
Cantidad: 5 
Garantia: 12 meses 
Impuesto: 8100
