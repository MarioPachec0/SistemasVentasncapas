﻿using SistemaVentas.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemasVentas.DAL
{
    public class ClienteDal
    {
        public DataTable ListarClientesDal()
        {
            string consulta = "select * from cliente";
            DataTable Lista = conexion.EjecutarDataTabla(consulta, "tabla");
            return Lista;

        }
        public void InsertarClienteDal(Cliente cliente)
        {
            string consulta = "insert into cliente values('" + cliente.IdPersona + "'," +
                                                           "'" + cliente.TipoCliente + "'," +
                                                           "'" + cliente.CodigoCliente + "'," +
                                                           "'Activo')";
            conexion.Ejecutar(consulta);
        }
    }
}
