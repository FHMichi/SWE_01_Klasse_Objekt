namespace SWE_01_Klasse_Objekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fahrzeug vespa = new Fahrzeug();
        Fahrzeug schwalbe = new Fahrzeug("Moped");
        Fahrzeug yamaha = new Fahrzeug(50);
        Fahrzeug honda = new Fahrzeug("Bike", 75);


        private void btnShow_Click(object sender, EventArgs e)
        {
            lblShow.Text = vespa + "\n" + schwalbe + "\n"
                          + yamaha + "\n" + honda;

            /*
            Fahrzeug vespa = new Fahrzeug(); //objekt erstellen (Objektverweis wird angelegt) 
            lblShow.Text = "";
            lblShow.Text = vespa.ToString(); //Objekt wird erzeugt 
            vespa.accelerate(20);
            lblShow.Text += "\n" + vespa.ToString();  
            */

            //das geht nicht: 
            // lblAnzeige.Text = vespa.speed;
            lblShow.Text += "\n Geschwindigkeit:  " + vespa.Speed.ToString();

        }

        private void btaccelerate_Click(object sender, EventArgs e)
        {
            honda.accelerate(10);
        }

        private void btBend_Click(object sender, EventArgs e)
        {
            //umbiegen
            yamaha = honda; 
        }
    }
}
