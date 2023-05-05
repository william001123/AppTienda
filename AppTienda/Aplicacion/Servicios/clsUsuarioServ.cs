﻿using Aplicacion.Interfaces;
using Aplicacion.Maestras;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using static Aplicacion.Maestras.MensajesBase;

namespace Aplicacion.Servicios
{
    public class clsUsuarioServ
        : IServicioObteIDEnc<clsUsuarioDom, int, clsUsuarioDom>
    {
        private readonly IRepositorioObteIDEnc<clsUsuarioDom, int, clsUsuarioDom> repo;
        private Excepcion excepcion = new Excepcion();

        public clsUsuarioServ(IRepositorioObteIDEnc<clsUsuarioDom, int, clsUsuarioDom> _repo) 
        {
            repo = _repo;
        }

        public void Actualizar(clsUsuarioDom entidad)
        {
            try
            {
                repo.Actualizar(entidad);
                repo.SalvarTodo();
            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Actualizar.GetEnumDescription());
            }
        }

        public void Eliminar(int entidadID)
        {
            repo.Eliminar(entidadID);
            repo.SalvarTodo();
        }

        public clsUsuarioDom Insertar(clsUsuarioDom entidad)
        {
            try
            {
                var result = repo.Insertar(entidad);
                repo.SalvarTodo();
                return result;
            }
            catch (Exception ex)
            {
                throw excepcion.Error(ex, Error.Insertar.GetEnumDescription());
            }
        }

        public clsUsuarioDom ObtenerPorID(int entidadID)
        {
            return repo.ObtenerPorID(entidadID);
        }

        public clsUsuarioDom ObtenerPorIDEnc(int entidadID)
        {
            return repo.ObtenerPorIDEnc(entidadID);
        }

        public List<clsUsuarioDom> ObtenerTodo()
        {
            return repo.ObtenerTodo();
        }
    }
}
