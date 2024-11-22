namespace WinFormsImageList
{
    public partial class Form1 : Form
    {
        private int indice;
        private string[] nombres;

        public Form1()
        {
            InitializeComponent();
            nombres = new string[10];
            nombres[0] = "Hollywood's bleeding - Post Malone";
            nombres[1] = "           Austin - Post Malone";
            nombres[2] = "       Astroworld - Travis Scott";
            nombres[3] = "Ready to die - The Notorius B.I.G";
            nombres[4] = "   Operation Doomsday - MF Doom";
            nombres[5] = "          Smile - Charles ANS";
            nombres[6] = "       Porfiado - Cuarteto de Nos";
            nombres[7] = "             Caravana - WOS";
            nombres[8] = "    The Eminem Show - Eminem";
            nombres[9] = "  Mas Rap Bien Hecho - C Plan G";
            indice = 0;
            labelNombres.Text = nombres[indice];
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {
            indice++;

            if (indice > 9)
            {
                indice = 0;
            }

            labelFoto.ImageIndex = indice;
            labelNombres.Text = nombres[indice];
        }
    }
}
