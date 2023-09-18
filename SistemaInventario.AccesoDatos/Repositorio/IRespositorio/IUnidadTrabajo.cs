﻿using SistemaInventario.AccesoDatos.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.AccesoDatos.Repositorio.IRespositorio
{
    public interface IUnidadTrabajo : IDisposable
    {
        IBodega bodega { get; }

        Task Gaurdar();


    }
}
