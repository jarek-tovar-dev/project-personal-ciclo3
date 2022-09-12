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
                new Rutas{id=1, origen= new Estaciones{id=4,nombre="Centro1",direccion= "cra 90",coord_x= "14.4545",coord_y= "4.1254545",tipo= "Principal"}, destino = new Estaciones{id=5,nombre="Centro2",direccion= "cra 90",coord_x= "14.4545",coord_y= "4.1254545",tipo= "Principal"}, tiempo_estimado= 10},
                new Rutas{id=2, origen= new Estaciones{}, destino = new Estaciones{}, tiempo_estimado= 20},
                new Rutas{id=3, origen= new Estaciones{}, destino = new Estaciones{}, tiempo_estimado= 30}
            };
        }
 
        public IEnumerable<Rutas> GetAll()
        {
            return rutas;
        }
 
        public Rutas GetWithId(int id){
            return rutas.SingleOrDefault(e => e.id == id);
        }


        public Rutas Update(Rutas newRuta){
            var ruta= rutas.SingleOrDefault(b => b.id == newRuta.id);
            if(ruta != null){
                ruta.origen = newRuta.origen;
                ruta.destino = newRuta.destino;
                ruta.tiempo_estimado= newRuta.tiempo_estimado;
            }
            return ruta;
        }
    }
}