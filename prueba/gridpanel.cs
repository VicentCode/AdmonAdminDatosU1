namespace prueba
{
    public partial class gridpanel : Form
    {
        private void abrirformhijo(object formhijo)
        {
            if (this.panel3.Controls.Count > 0)
            {
                this.panel3.Controls.RemoveAt(0);
            }
            Form fh = formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel3.Controls.Add(fh);
            this.panel3.Tag = fh;
            fh.Show();
        }
        public gridpanel()
        {
            InitializeComponent();
            abrirformhijo(new Form1());
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Form1());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            abrirformhijo(new Materias());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            abrirformhijo(new consultar());

        }
    }

}
