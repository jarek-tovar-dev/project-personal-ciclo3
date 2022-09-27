using System.Collections.Generic;
using ProyectoCiclo3.App.Dominio;
using System.Linq;
using System;
 
namespace ProyectoCiclo3.App.Persistencia.AppRepositorios
{
    public class RepositorioBuses
    {
        List<Buses> buses;
        private readonly AppContext _appContext = new AppContext();
 
        public IEnumerable<Buses> GetAll()
        {
            return _appContext.Buses;
        }
 
        public Buses GetWithId(int id){
            return _appContext.Buses.Find(id);
        }

        public Buses Update(Buses newBus){
            var bus = _appContext.Buses.Find(newBus.id);
            if(bus != null){
                bus.marca = newBus.marca;
                bus.modelo = newBus.modelo;
                bus.kilometraje = newBus.kilometraje;
                bus.numero_asientos = newBus.numero_asientos;
                bus.placa = newBus.placa;
                //Guardar en base de datos
                 _appContext.SaveChanges();
            }
        return bus;
        }

        public Buses Create(Buses newBus)
        {
            var addBus = _appContext.Buses.Add(newBus);
            //Guardar en base de datos
            _appContext.SaveChanges();
            return addBus.Entity;
        }

        public Buses Delete(int id)
        {
            try{
                var bus = _appContext.Buses.Find(id);
                        if (bus != null){
                            _appContext.Buses.Remove(bus);
                            //Guardar en base de datos
                            _appContext.SaveChanges();
                        }

            }catch (System.Exception){
                    
                    throw;
            }
            return null;
        }

    }
}
