using System;

namespace Vista
{
    static class Utiles
    {
        static public bool Validar(string campo,string tipo)
        {
            switch (tipo)
            {
                case "string":
                    if (campo.Trim() != "")
                    {
                        Convert.ToString(campo.Trim());
                        return true;
                    }
                    else
                        return false;


                case "int":
                    try
                    {
                        Convert.ToInt32(campo);
                        return true;
                    }
                    catch(Exception)
                    {
                        return false;
                    }


                case "double":
                    try
                    {
                        Convert.ToDouble(campo);
                        return true;
                    }
                    catch (Exception)
                    {
                        return false;
                        throw;
                    }

                default:
                return false;
            }
        }
    }
}
