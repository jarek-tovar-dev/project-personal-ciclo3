using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioRutas
    {
        List<Rutas> rutas;
 
    public RepositorioRutas()
        {
            rutas= new List<Rutas>()
            {
                new Rutas{id=1, origen= new Estaciones{}, destino = new Estaciones{}, tiempo_estimado= 10},
                new Rutas{id=2, origen= new Estaciones{}, destino = new Estaciones{}, tiempo_estimado= 20}
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetWithId(int id){
            return rutas.SingleOrDefault(e => e.id == id);
        }
    }
}