using DetalleEstudiante.DAL;
using DetalleEstudiante.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DetalleEstudiante.BLL
{
    public class DetalleBLL
    {
        
            public static bool Guardar(Asistencia asistencia)
            {
                bool paso = false;
                Contexto db = new Contexto();


                try
                {
                    if (db.Asistencia.Add(asistencia) != null)
                        paso = db.SaveChanges() > 0;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    db.Dispose();
                }

                return paso;
            }

            public static bool Modificar(Asistencia asistencia)
            {
                bool paso = false;
                Contexto db = new Contexto();
                try

            {
                    var Anterior = DetalleBLL.Buscar(asistencia.AsistenciasId);
                    foreach (var item in Anterior.Detalles)
                    {
                        if (!asistencia.Detalles.Exists(d => d.DetalleAsistenciasId == item.DetalleAsistenciasId))
                            db.Entry(item).State = EntityState.Deleted;
                    }
                    db.Entry(asistencia).State = EntityState.Modified;
                    paso = (db.SaveChanges() > 0);
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    db.Dispose();
                }
                return paso;
           
               

            }
         
            
            public static bool Eliminar(int id)
            {
                bool paso = false;
                Contexto db = new Contexto();
                try
                {
                    var eliminar = db.Asistencia.Find(id);
                    db.Entry(eliminar).State = EntityState.Deleted;

                    paso = (db.SaveChanges() > 0);
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    db.Dispose();
                }
                return paso;
            }

       
            public static Asistencia Buscar(int id)
            {
                Asistencia asistencia = new Asistencia();
                Contexto db = new Contexto();

                try
                {
                    asistencia = db.Asistencia.Find(id);
                    if (asistencia != null)
                    {
                        asistencia.Detalles.Count();
                    }
                    else
                    {
                        db.Dispose();
                        return asistencia;
                    }

                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    db.Dispose();
                }

                return asistencia;
            }

            public static List<Asistencia> GetList(Expression<Func<Asistencia, bool>> asistencias)
            {
                List<Asistencia> Lista = new List<Asistencia>();

                Contexto db = new Contexto();
                try
                {
                    Lista = db.Asistencia.Where(asistencias).ToList();
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    db.Dispose();
                }
                return Lista;
            }


        }

    }
