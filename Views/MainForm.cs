using MaterialSkin;
using MaterialSkin.Controls;
using PlantillaMaterialForm.Controllers;

namespace PlantillaMaterialForm;

public partial class MainForm : MaterialForm
{
    private readonly MaterialSkinManager _materialSkinManager;
    private readonly Configuracion _configuracion = new Configuracion();
    private readonly bool _modoOscuro = Properties.Settings.Default.Dark_Mode;
    private readonly int _colorEsquema = Properties.Settings.Default.Scheme_Color;
    public MainForm()
    {
        _materialSkinManager = MaterialSkinManager.Instance;
        InitializeComponent();   
        InicializarMaterialSkin();
    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private void InicializarMaterialSkin()
    {
        _materialSkinManager.EnforceBackcolorOnAllComponents = true;
        _materialSkinManager.AddFormToManage(this);
        _materialSkinManager.Theme = _modoOscuro ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;
        _materialSkinManager.ColorScheme = ObtenerEsquema(_colorEsquema);
        
        switch_modo_oscuro.Checked = _modoOscuro;
        combobox_color_esquema.SelectedIndex = _colorEsquema;
    }
    private void EstablecerModoOscuro(object sender, EventArgs e)
    {
        _configuracion.EstablecerModoOscuro(switch_modo_oscuro.Checked);
        _materialSkinManager.Theme = switch_modo_oscuro.Checked ? MaterialSkinManager.Themes.DARK : MaterialSkinManager.Themes.LIGHT;

        this.Refresh();
    }


    private void combobox_color_esquema_SelectedIndexChanged(object sender, EventArgs e)
    {
        int numeroEsquema = combobox_color_esquema.SelectedIndex;
        _materialSkinManager.ColorScheme = ObtenerEsquema(numeroEsquema);
        _configuracion.CambiarColoresEsquema(numeroEsquema);

        this.Refresh();
    }

    private ColorScheme ObtenerEsquema(int numeroEsquema)
    {
        return numeroEsquema switch
        {
            0 => new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.Indigo100, TextShade.WHITE),
            1 => new ColorScheme(Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Indigo200, TextShade.WHITE),
            2 => new ColorScheme(Primary.Green600, Primary.Green700, Primary.Green200, Accent.Green200, TextShade.WHITE),
            _ => new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue700, TextShade.WHITE),
        };
    }

    private void CambiarColoresEsquema(object sender, EventArgs e)
    {
        int numeroEsquema = combobox_color_esquema.SelectedIndex;
        _materialSkinManager.ColorScheme = ObtenerEsquema(numeroEsquema);
        _configuracion.CambiarColoresEsquema(numeroEsquema);

        this.Refresh();
    }
}