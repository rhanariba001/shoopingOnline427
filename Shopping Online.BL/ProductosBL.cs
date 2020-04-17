﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Online.BL
{
    public class ProductosBL
    {
        Contexto _contexto;

        public List<Producto> ListaDeProductos { get; set; }

        public ProductosBL()
        {
            _contexto = new Contexto();
            ListaDeProductos = new List<Producto>();
        }
        public List<Producto> ObtenerProductos()
        {
           ListaDeProductos = _contexto.Productos.Include("Categoria")
                .OrderBy(r => r.categoria.Descripcion)
                .ThenBy(r => r.Descripcion).ToList();

           

            return ListaDeProductos;
        }
        public List<Producto> ObtenerProductosActivos()
        {
            ListaDeProductos = _contexto.Productos
                .Include("Categoria")
                .Where(r => r.Activo == true)
                .OrderBy(r => r.Descripcion)
                .ToList();

            return ListaDeProductos;
        }
        public void GuardarProducto(Producto producto)
        {
            if (producto.Id == 0)
            {
                _contexto.Productos.Add(producto);
            }
            else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);

                productoExistente.Descripcion = producto.Descripcion;
                productoExistente.Precio = producto.Precio;
                productoExistente.CategoriaId = producto.CategoriaId;
                if (producto.UrlImagen != null)
                {
                    productoExistente.UrlImagen = producto.UrlImagen;
                }

              
            }

          
            _contexto.SaveChanges();
        }

        public Producto ObtenerProducto(int id)
        {
            var producto = _contexto.Productos.Include("Categoria").FirstOrDefault(p=>p.Id  == id);
            return producto;
        }
        public void EliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);

            _contexto.Productos.Remove(producto); 
            _contexto.SaveChanges();
        }
    }
}
