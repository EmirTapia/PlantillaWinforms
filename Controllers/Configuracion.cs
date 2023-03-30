using MaterialSkin.Controls;

namespace PlantillaMaterialForm.Controllers
{
    public class Configuracion
    {
        public void EstablecerModoOscuro(bool darkmode) 
        {
            Properties.Settings.Default.Dark_Mode = darkmode;
            GuardarCambios();
        }
        public void CambiarColoresEsquema(int schemecolor)
        {
            Properties.Settings.Default.Scheme_Color = schemecolor;
            GuardarCambios();
        }
        private void GuardarCambios()
        {
            Properties.Settings.Default.Save();
        }
    }
}
