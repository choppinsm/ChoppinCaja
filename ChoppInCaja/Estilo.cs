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
        public Color ColorMesaActiva => FromAppSetting("ColorMesaActiva");
        public Color ColorCerrarCaja => FromAppSetting("ColorCerrarCaja");
        public Color ColorAbrirCerrarMesa => FromAppSetting("AbrirCerrarMesa");
        public Color ColorABM => FromAppSetting("ColorABM");
        public Color ColorTotal => FromAppSetting("ColorTotal");
        public Color ColorEstado => FromAppSetting("ColorEstado");
        public Color ColorBarraEstado => FromAppSetting("ColorBarraEstado");
        

        private Color FromAppSetting(string key)
        {
            return Color.FromName(ConfigurationManager.AppSettings[key]);
        }

        private T FromAppSetting<T>(string key)
        {
            return (T)Enum.Parse(typeof(T), ConfigurationManager.AppSettings[key], true);
        }
    }
}
