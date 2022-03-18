namespace prueba
{
    public partial class Form1 : Form
    {
        int lineGuide = 0;
        String nombre;
        String[] lineAlm = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt");




        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lineAlm = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt");
            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Append);
            StreamWriter canalEscritura = new StreamWriter(conector);

            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese un nombre");
                canalEscritura.Close();

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Ingrese una carrera");
                canalEscritura.Close();

            }
            else if (textBox3.Text == "")
            {
                MessageBox.Show("Ingrese un numero telefonico");
                canalEscritura.Close();

            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Ingrese una dirrecion");
                canalEscritura.Close();

            }
            else
            {
                int conta = (lineAlm.Length / 5) + 1;

                canalEscritura.WriteLine("200300" + conta.ToString());
                canalEscritura.WriteLine(textBox1.Text);
                canalEscritura.WriteLine(textBox2.Text);
                canalEscritura.WriteLine(textBox3.Text);
                canalEscritura.WriteLine(textBox4.Text);

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                lineGuide = 0;

                //Se cierra el archivo
                canalEscritura.Close();
            }
        }


        private void Button2_Click(object sender, EventArgs e)
        {
            lineAlm = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt");


            if (lineAlm.Length == 0)
            {
                MessageBox.Show("No hay registros almacenados :(");
            }
            else
            {

                if (lineGuide >= lineAlm.Length)
                {
                    lineGuide = 0;
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    MessageBox.Show("Ya no hay mas registros que mostrar");
                }
                else
                {
                    textBox1.Text = lineAlm[lineGuide + 1];
                    textBox2.Text = lineAlm[lineGuide + 2];
                    textBox3.Text = lineAlm[lineGuide + 3];
                    textBox4.Text = lineAlm[lineGuide + 4];
                    lineGuide += 5;
                }
            }





        }

        private void button3_Click(object sender, EventArgs e)

        {
            int cont = 0;
            int cantidad;
            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Open);
            StreamReader lector = new StreamReader(conector);
            while (lector.EndOfStream == false)
            {
                lector.ReadLine();
                cont++;
            }
            cantidad = cont / 5;
            MessageBox.Show("el archvio tiene " + cantidad + " registros");
            lector.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            lineGuide = 0;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Open);
            StreamReader lector = new StreamReader(conector);

            if (textBox1.Text != "")
            {
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                while (lector.EndOfStream == false)
                {
                    if (lector.ReadLine() + 1 == textBox1.Text)
                    {
                        textBox2.Text = lector.ReadLine();
                        textBox3.Text = lector.ReadLine();
                        textBox4.Text = lector.ReadLine();
                    }
                    else
                    {
                        lector.ReadLine();
                        lector.ReadLine();
                        lector.ReadLine();

                    }
                }

                if (textBox2.Text == "" && textBox3.Text == "" && textBox4.Text == "")
                {
                    MessageBox.Show("No se pudo encontrar ningun registro de nombre: " + textBox1.Text);
                }
                lector.Close();
            }
            else
            {
                lector.Close();

                MessageBox.Show("Primero seleccione un elemento del registro");
                lector.Close();
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            lineAlm = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt");
            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(conector);



            if (textBox1.Text != "")
            {

                if (MessageBox.Show("¿Desea guardar los cambios?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {

                    for (int i = 0; i < lineAlm.Length; i++)
                    {
                        if (lineAlm[i] == textBox1.Text)
                        {
                            i++;
                            textBox2.Text = lineAlm[i];
                            i++;
                            textBox3.Text = lineAlm[i];
                            i++;
                            textBox4.Text = lineAlm[i];
                        }

                    }

                    for (int i = 0; i < lineAlm.Length; i++)
                    {
                        escritor.WriteLine(lineAlm[i]);
                    }
                    escritor.Close();
                }
                else
                {
                    for (int i = 0; i < lineAlm.Length; i++)
                    {
                        if (lineAlm[i] == textBox1.Text)
                        {
                            i++;
                            lineAlm[i] = textBox2.Text;
                            i++;
                            lineAlm[i] = textBox3.Text;
                            i++;
                            lineAlm[i] = textBox4.Text;
                        }
                    }

                    for (int i = 0; i < lineAlm.Length; i++)
                    {
                        escritor.WriteLine(lineAlm[i]);
                    }
                    escritor.Close();

                }
            }
            else
            {
                escritor.Close();
                FileStream conectorr = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Open);
                StreamWriter escritorr = new StreamWriter(conectorr);
                for (int i = 0; i < lineAlm.Length; i++)
                {
                    escritorr.WriteLine(lineAlm[i]);
                }

                MessageBox.Show("Primero seleccione un elemento del registro");
                escritorr.Close();
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {

            lineAlm = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt");

            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(conector);
            if (textBox1.Text != "")
            {

                if (MessageBox.Show("¿Desea eliminar el registro de " + textBox1.Text + "?", "Confirmacion",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    for (int i = 0; i < lineAlm.Length; i++)
                    {
                        if (lineAlm[i + 1] == textBox1.Text)
                        {

                            lineAlm[i] = "null";
                            i++;
                            lineAlm[i] = "null";
                            i++;
                            lineAlm[i] = "null";
                            i++;
                            lineAlm[i] = "null";
                            i++;
                            lineAlm[i] = "null";


                            break;

                        }
                        else
                        {
                            i = +3;
                        }
                    }
                    for (int i = 0; i < lineAlm.Length; i++)
                    {
                        if (lineAlm[i] != "null")
                        {
                            escritor.WriteLine(lineAlm[i]);

                        }
                    }
                    escritor.Close();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                }
                else
                {
                    escritor.Close();
                    FileStream conectorr = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Open);
                    StreamWriter escritorr = new StreamWriter(conectorr);
                    for (int i = 0; i < lineAlm.Length; i++)
                    {
                        escritorr.WriteLine(lineAlm[i]);
                    }
                    escritorr.Close();
                }
            }
            else
            {
                escritor.Close();
                FileStream conectorr = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Open);
                StreamWriter escritorr = new StreamWriter(conectorr);
                for (int i = 0; i < lineAlm.Length; i++)
                {
                    escritorr.WriteLine(lineAlm[i]);
                }

                MessageBox.Show("Primero seleccione un elemento del registro");
                escritorr.Close();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Materias Materias = new Materias();
            Materias.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }
    }
}