using SQLite;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace SQLite1.Models
{
  class DBContex
  {
    public SQLiteAsyncConnection Conexion { get; set; }

    public DBContex(string path)
    {
      try
      {
        this.Conexion = new SQLiteAsyncConnection(path);
        this.Conexion.CreateTableAsync<Producto>().Wait();
      }
      catch (Exception e)
      {

        Debug.Print("Error" + e.Message);
      }

    }


  }
}
