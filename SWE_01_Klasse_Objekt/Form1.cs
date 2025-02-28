namespace SWE_01_Klasse_Objekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            Fahrzeug vespa = new Fahrzeug(); //objekt erstellen (Objektverweis wird angelegt) 
            lblShow.Text = vespa.ToString(); //Objekt wird erzeugt 
            vespa.accelerate(20);
            lblShow.Text += "\n" + vespa.ToString();  
        }
    }
}
