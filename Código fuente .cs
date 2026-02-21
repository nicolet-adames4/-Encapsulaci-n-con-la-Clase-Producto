using System;

public class Producto
{
    private int id;
    private string nombre;
    private double precio;
    private int stock;

    public int GetId()
    {
        return id;
    }

    public void SetId(int id)
    {
        this.id = id;
    }

    public string GetNombre()
    {
        return nombre;
    }

    public void SetNombre(string nombre)
    {
        this.nombre = nombre;
    }

    public double GetPrecio()
    {
        return precio;
    }

    public void SetPrecio(double precio)
    {
        if (precio >= 0)
        {
            this.precio = precio;
        }
        else
        {
            Console.WriteLine("Error: El precio no puede ser negativo.");
        }
    }

    public int GetStock()
    {
        return stock;
    }

    public void SetStock(int stock)
    {
        if (stock >= 0)
        {
            this.stock = stock;
        }
        else
        {
            Console.WriteLine("Error: El stock no puede ser menor que 0.");
        }
    }

    public void DescontarStock(int cantidad)
    {
        if (cantidad <= stock)
        {
            stock -= cantidad;
        }
        else
        {
            Console.WriteLine("Error: No hay suficiente stock.");
        }
    }
} 