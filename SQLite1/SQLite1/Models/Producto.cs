using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SQLite1.Models
{
  class Producto
  {
    // algo
    int algo = 0;

    public int Id { get; set; }
    public string Nombre { get; set; }
    public double Precio { get; set; }
    public string Descripcion { get; set; }

    private DBContex db;

    //ctor vacio
    public Producto()
    {

    }

    //ctor con parametro_contex
    public Producto(DBContex database)
    {
      this.db = database;
    }

    // GET ALL
    public Task<List<Producto>> Query(string sql)
    {
      return this.db.Conexion.QueryAsync<Producto>(sql);
    }

    // ADD
    public Task<bool> Agregar(Producto pro)
    {
      if (this.db.Conexion.InsertAsync(pro).Result == 1)
      {
        return Task.FromResult(true);
      }
      else
      {
        return Task.FromResult(false);
      }
    }

    // DELETE
    public Task<bool> Eliminar(Producto pro)
    {
      if (this.db.Conexion.DeleteAsync(pro).Result == 1)
      {
        return Task.FromResult(true);
      }
      else
      {
        return Task.FromResult(false);
      }
    }

    // UPDATE
    public Task<bool> Actualizar(Producto pro)
    {
      if (this.db.Conexion.UpdateAsync(pro).Result == 1)
      {
        return Task.FromResult(true);
      }
      else
      {
        return Task.FromResult(false);
      }
  
    }




  }
}
