using Microsoft.AspNetCore.Mvc;
using ProductosApi.Models;

namespace ProductosApi.Controllers;

[ApiController]
[Route("api/Productos")]
public class ProductoControllers : ControllerBase
{
    private readonly ProductoDbContext _context;

    public ProductoControllers(ProductoDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Producto>> GetProductos()
    {
        var productos = _context.Productos.ToList();
        return Ok(productos);
    }

    [HttpGet("{productoId}")]
    public ActionResult<Producto> GetProducto(int productoId)
    {
        var producto = _context.Productos.Find(productoId);
        if (producto == null) return NotFound("El producto solicitado no existe");
        return Ok(producto);
    }

    [HttpPost]
    public ActionResult<Producto> PostProducto(ProductosInsert productoinsert)
    {
        var productoNuevo = new Producto
        {
            Nombre = productoinsert.Nombre,
            Marca = productoinsert.Marca,
            Alto = productoinsert.Alto,
            Ancho = productoinsert.Ancho,
            Profundidad = productoinsert.Profundidad,
            Peso = productoinsert.Peso
        };

        _context.Productos.Add(productoNuevo);
        _context.SaveChanges();

        return CreatedAtAction(nameof(GetProducto),
            new { productoId = productoNuevo.Id },
            productoNuevo);
    }

    [HttpPut("{productoId}")]
    public ActionResult PutProducto(int productoId, ProductosInsert productosInsert)
    {
        var producto = _context.Productos.Find(productoId);
        if (producto == null) return NotFound("No se encontró el producto");

        producto.Nombre = productosInsert.Nombre;
        producto.Marca = productosInsert.Marca;
        producto.Alto = productosInsert.Alto;
        producto.Ancho = productosInsert.Ancho;
        producto.Profundidad = productosInsert.Profundidad;
        producto.Peso = productosInsert.Peso;

        _context.SaveChanges();
        return Ok($"Producto {productoId} {producto.Nombre} modificado");
    }

    [HttpDelete("{productoId}")]
    public ActionResult DeleteProducto(int productoId)
    {
        var producto = _context.Productos.Find(productoId);
        if (producto == null) return NotFound("No se encontró el producto");

        _context.Productos.Remove(producto);
        _context.SaveChanges();
        return Ok($"Producto {productoId} {producto.Nombre} eliminado");
    }
}
