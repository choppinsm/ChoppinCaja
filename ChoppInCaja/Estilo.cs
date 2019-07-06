using System;
using System.Collections.Generic;
using System.Drawing;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ChoppInCaja
{
    public class Estilo
    {
        private Estilo() { }
        private static Estilo instance = null;
        public static Estilo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Estilo();
                }
                return instance;
            }
        }

        public Color ColorVentas => FromAppSetting("ColorVentas");
        public Color ColorMesaAbierta => FromAppSetting("ColorMesaAbierta");
        public Color ColorMesaCerrada => FromAppSetting("ColorMesaCerrada");
        public Color ColorCerrarCaja => FromAppSetting("ColorCerrarCaja");
        public Color ColorAbrirCerrarMesa => FromAppSetting("AbrirCerrarMesa");
        public Color ColorABM => FromAppSetting("ColorABM");
        public Color ColorTotal => FromAppSetting("ColorTotal");
        public Color ColorEstado => FromAppSetting("ColorEstado");
        public Color ColorBarraEstado => FromAppSetting("ColorBarraEstado");
        public Color ColorProductoFondo => FromAppSetting("ColorProductoFondo");
        public Color ColorProductoBorde => FromAppSetting("ColorProductoBorde");
        public Brush ColorProductoLetra => FromAppSetting<Brush>("ColorProductoLetra");
        public int TamañoProductoLetra => FromAppSetting<int>("TamañoProductoLetra");
        public string FuenteProductoLetra => FromAppSetting<string>("FuenteProductoLetra");
        public int ProductoAncho => FromAppSetting<int>("ProductoAncho");
        public int ProductoAlto => FromAppSetting<int>("ProductoAlto");
        public int MargenMesaAncho => FromAppSetting<int>("MargenMesaAncho");
        public int MargenMesaAlto => FromAppSetting<int>("MargenMesaAlto");
        public int MargenProductoAncho => FromAppSetting<int>("MargenProductoAncho");
        public int MargenProductoAlto => FromAppSetting<int>("MargenProductoAlto");
        public int ProductoLargoNombreMaximo => FromAppSetting<int>("ProductoLargoNombreMaximo");
        public int ProductoBordeAncho => FromAppSetting<int>("ProductoBordeAncho");

        private Color FromAppSetting(string key)
        {
            return Color.FromName(ConfigurationManager.AppSettings[key]);
        }

        private T FromAppSetting<T>(string key)
        {
            if (typeof(T).IsEnum)
            {
                return (T)Enum.Parse(typeof(T), ConfigurationManager.AppSettings[key], true);
            }
            if (typeof(T) == typeof(Brush))
            {
                return (T)(object)new SolidBrush(FromAppSetting(key));
            }
            return (T)Convert.ChangeType(ConfigurationManager.AppSettings[key], typeof(T));
        }
    }
}
