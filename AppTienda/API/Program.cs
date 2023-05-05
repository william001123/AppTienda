using Aplicacion.Interfaces;
using Aplicacion.Servicios;
using AppFinanciero.Infraestructura.Datos.Contextos;
using Datos.Repositorio;
using Dominio.Interfaces.Repositorio;
using Dominio.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

#region "Inyección de dependencias"

//Cadena de conexión
var connectionString = builder.Configuration.GetConnectionString("Tienda");
builder.Services.AddDbContext<TiendaContexto>(x =>
{
    x.UseSqlServer(connectionString);
    x.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
});

builder.Services.AddTransient<TiendaContexto>();

//Inyección para los repositorios
builder.Services.AddTransient<IRepositorioBase<clsCategoriaDom, int>, clsCategoriaRepo>();
builder.Services.AddTransient<IRepositorioBase<clsEmpleadoDom, int>, clsEmpleadoRepo>();
builder.Services.AddTransient<IRepositorioInserList<clsMovimientoDom, int>, clsMovimientoRepo>();
builder.Services.AddTransient<IRepositorioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>>, clsMovimientoDetalleRepo>();
builder.Services.AddTransient<IRepositorioActuaEstado<clsOrdenDom, int, string>, clsOrdenRepo>();
builder.Services.AddTransient<IRepositorioObteIDEnc<clsOrdenDetalleDom, int, List<clsOrdenDetalleDom>>, clsOrdenDetalleRepo>();
builder.Services.AddTransient<IRepositorioProducto<clsProductoDom, int, double>, clsProductoRepo>();
builder.Services.AddTransient<IRepositorioBase<clsProveedorDom, int>, clsProveedorRepo>();
builder.Services.AddTransient<IRepositorioActuaEstado<clsRecepcionDom, int, string>, clsRecepcionRepo>();
builder.Services.AddTransient<IRepositorioObteIDEnc<clsRecepcionDetalleDom, int, List<clsRecepcionDetalleDom>>, clsRecepcionDetalleRepo>();
builder.Services.AddTransient<IRepositorioBase<clsTipoMovimientoDom, int>, clsTipoMovimientoRepo>();
builder.Services.AddTransient<IRepositorioBase<clsTipoOrigenDom, int>, clsTipoOrigenRepo>();
builder.Services.AddTransient<IRepositorioBase<clsTipoUnidadDom, int>, clsTipoUnidadRepo>();
builder.Services.AddTransient<IRepositorioObteIDEnc<clsUsuarioDom, int, clsUsuarioDom>, clsUsuarioRepo>();
builder.Services.AddTransient<IRepositorioActuaEstado<clsVentaDom, int, string>, clsVentaRepo>();
builder.Services.AddTransient<IRepositorioObteIDEnc<clsVentaDetalleDom, int, List<clsVentaDetalleDom>>, clsVentaDetalleRepo>();


//Inyección para los servicios
builder.Services.AddTransient<IServicioBase<clsCategoriaDom, int>, clsCategoriaServ>();
builder.Services.AddTransient<IServicioBase<clsEmpleadoDom, int>, clsEmpleadoServ>();
builder.Services.AddTransient<IServicioInserList<clsMovimientoDom, int>, clsMovimientoServ>();
builder.Services.AddTransient<IServicioMoviDetalle<clsMovimientoDetalleDom, int, List<clsMovimientoDetalleDom>>, clsMovimientoDetalleServ>();
builder.Services.AddTransient<IServicioActuaEstado<clsOrdenDom, int, string>, clsOrdenServ>();
builder.Services.AddTransient<IServicioObteIDEnc<clsOrdenDetalleDom, int, List<clsOrdenDetalleDom>>, clsOrdenDetalleServ>();
builder.Services.AddTransient<IServicioProducto<clsProductoDom, int, double>, clsProductoServ>();
builder.Services.AddTransient<IServicioBase<clsProveedorDom, int>, clsProveedorServ>();
builder.Services.AddTransient<IServicioActuaEstado<clsRecepcionDom, int, string>, clsRecepcionServ>();
builder.Services.AddTransient<IServicioObteIDEnc<clsRecepcionDetalleDom, int,List<clsRecepcionDetalleDom>>, clsRecepcionDetalleServ>();
builder.Services.AddTransient<IServicioBase<clsTipoMovimientoDom, int>, clsTipoMovimientoServ>();
builder.Services.AddTransient<IServicioBase<clsTipoOrigenDom, int>, clsTipoOrigenServ>();
builder.Services.AddTransient<IServicioBase<clsTipoUnidadDom, int>, clsTipoUnidadServ>();
builder.Services.AddTransient<IServicioObteIDEnc<clsUsuarioDom, int, clsUsuarioDom>, clsUsuarioServ>();
builder.Services.AddTransient<IServicioActuaEstado<clsVentaDom, int, string>, clsVentaServ>();
builder.Services.AddTransient<IServicioObteIDEnc<clsVentaDetalleDom, int, List<clsVentaDetalleDom>>, clsVentaDetalleServ>();

#endregion

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
