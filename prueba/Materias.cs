namespace prueba
{
    public partial class Materias : Form
    {
        String[] lineAlmMat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Materias.txt");
        String[] lineAlmDat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt");
        int control = -1;
        string nameUser;

        public Materias()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Materias_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Open);
            StreamReader lector = new StreamReader(conector);

            if (textBox64.Text != "")
            {
                comboBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";

                while (lector.EndOfStream == false)
                {
                    if (lector.ReadLine() == textBox64.Text)
                    {
                        control = 0;

                        label1.Visible = true;
                        label2.Visible = true;
                        label3.Visible = true;
                        label4.Visible = true;
                        label5.Visible = true;
                        comboBox1.Visible = true;
                        textBox2.Visible = true;
                        textBox3.Visible = true;
                        textBox4.Visible = true;
                        textBox5.Visible = true;
                        button2.Visible = true;


                    }
                    else
                    {
                        lector.ReadLine();
                        lector.ReadLine();
                        lector.ReadLine();
                        lector.ReadLine();

                    }

                }
                if (control == -1)
                {
                    MessageBox.Show("No se encontro ningun registro para " + textBox64.Text);
                    control = -1;

                }

                lector.Close();

            }
            else
            {
                lector.Close();

                MessageBox.Show("Primero seleccione un elemento del registro");
                lector.Close();
            }
            control = -1;

            comboBox1.Text = "Investigacion de operaciones";

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            comboBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            button2.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lineAlmMat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Materias.txt");

            lineAlmDat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt");
            List<string> list = new List<string>();




            for (int i = 0; i < lineAlmMat.Length; i++)
            {
                list.Add(lineAlmMat[i]);
            }
            string idName = textBox64.Text;

            for (int f = 0; f < lineAlmDat.Length; f++)
            {
                if (lineAlmDat[f] == idName)
                {
                    nameUser = lineAlmDat[f + 1];
                    break;
                }
                else
                {
                    f = f + 4;
                }
            }

            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Materias.txt", FileMode.Create);
            StreamWriter canalEscritura = new StreamWriter(conector);

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Ingrese una materia");

            }
            else
            {
                if (comboBox1.Text == "Arquitectura")
                {
                    for (int f = 0; f < list.Count; f++)
                    {

                        if (list[f] == idName)
                        {
                            if (list[f + 1] == "Arquitectura")
                            {
                                MessageBox.Show("Esta materia ya fue guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                f = list.Count;
                                break;
                            }
                            else if (list[f + 1] == "Seguridad")
                            {
                                f++;
                                list.Insert(f, comboBox1.Text); //materia
                                f++;
                                list.Insert(f, textBox2.Text); //u1
                                f++;
                                list.Insert(f, textBox3.Text); //u2
                                f++;
                                list.Insert(f, textBox4.Text); //u3
                                f++;
                                list.Insert(f, textBox5.Text); //y4

                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");

                                comboBox1.Text = "";
                                f = list.Count;
                                break;

                            }
                            else if (list[f + 1] == "Investigacion de operaciones")
                            {
                                f++;
                                list.Insert(f, comboBox1.Text); //materia
                                f++;
                                list.Insert(f, textBox2.Text); //u1
                                f++;
                                list.Insert(f, textBox3.Text); //u2
                                f++;
                                list.Insert(f, textBox4.Text); //u3
                                f++;
                                list.Insert(f, textBox5.Text); //y4

                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");

                                comboBox1.Text = "";
                                f = list.Count;
                                break;
                            }
                            else
                            {
                                list.Add(comboBox1.Text); //materia
                                f++;
                                list.Add(textBox2.Text); //u1
                                f++;
                                list.Add(textBox3.Text); //u2
                                f++;
                                list.Add(textBox4.Text); //u3
                                f++;
                                list.Add(textBox5.Text); //y4
                                comboBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");
                                f = list.Count;
                                break;
                            }
                        }
                        else
                        {
                            if (list.Count == f + 1)
                            {
                                list.Add(idName); //ID
                                list.Add(comboBox1.Text); //materia
                                f++;
                                list.Add(textBox2.Text); //u1
                                f++;
                                list.Add(textBox3.Text); //u2
                                f++;
                                list.Add(textBox4.Text); //u3
                                f++;
                                list.Add(textBox5.Text); //y4
                                comboBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");
                                f = list.Count;
                                break;
                            }
                        }
                    }

                }
                else if (comboBox1.Text == "Seguridad")
                {
                    for (int f = 0; f < list.Count; f++)
                    {

                        if (list[f] == idName)
                        {
                            if (list[f + 1] == "Arquitectura" && list.Count > f + 6)
                            {
                                if (list[f + 6] != "Seguridad")
                                {
                                    f = f + 6;
                                    list.Insert(f, comboBox1.Text); //materia
                                    f++;
                                    list.Insert(f, textBox2.Text); //u1
                                    f++;
                                    list.Insert(f, textBox3.Text); //u2
                                    f++;
                                    list.Insert(f, textBox4.Text); //u3
                                    f++;
                                    list.Insert(f, textBox5.Text); //y4

                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";

                                    MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                                + nameUser + " (" + textBox64.Text + ")");

                                    comboBox1.Text = "";
                                    f = list.Count;
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Esta materia ya fue guardada para "
                                      + nameUser + " (" + textBox64.Text + ")");
                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";

                                    f = list.Count;
                                    break;
                                }
                            }
                            else if (list[f + 1] == "Seguridad")
                            {
                                MessageBox.Show("Esta materia ya fue guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                f = list.Count;
                                break;

                            }
                            else if (list[f + 1] == "Investigacion de operaciones")
                            {
                                f++;
                                list.Insert(f, comboBox1.Text); //materia
                                f++;
                                list.Insert(f, textBox2.Text); //u1
                                f++;
                                list.Insert(f, textBox3.Text); //u2
                                f++;
                                list.Insert(f, textBox4.Text); //u3
                                f++;
                                list.Insert(f, textBox5.Text); //y4

                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");

                                comboBox1.Text = "";
                                f = list.Count;
                                break;
                            }
                            else
                            {
                                list.Add(comboBox1.Text); //materia
                                f++;
                                list.Add(textBox2.Text); //u1
                                f++;
                                list.Add(textBox3.Text); //u2
                                f++;
                                list.Add(textBox4.Text); //u3
                                f++;
                                list.Add(textBox5.Text); //y4
                                comboBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");
                                f = list.Count;
                                break;
                            }
                        }
                        else
                        {
                            if (list.Count == f + 1)
                            {
                                list.Add(idName); //ID
                                list.Add(comboBox1.Text); //materia
                                f++;
                                list.Add(textBox2.Text); //u1
                                f++;
                                list.Add(textBox3.Text); //u2
                                f++;
                                list.Add(textBox4.Text); //u3
                                f++;
                                list.Add(textBox5.Text); //y4
                                comboBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");
                                f = list.Count;
                                break;
                            }
                        }
                    }

                }
                else if (comboBox1.Text == "Investigacion de operaciones")
                {
                    for (int f = 0; f < list.Count; f++)
                    {

                        if (list[f] == idName)
                        {
                            if (list[f + 1] == "Arquitectura")
                            {
                                if (list.Count < 6)
                                {
                                    f++;
                                    list.Insert(f, comboBox1.Text); //materia
                                    f++;
                                    list.Insert(f, textBox2.Text); //u1
                                    f++;
                                    list.Insert(f, textBox3.Text); //u2
                                    f++;
                                    list.Insert(f, textBox4.Text); //u3
                                    f++;
                                    list.Insert(f, textBox5.Text); //y4

                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";

                                    MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                                + nameUser + " (" + textBox64.Text + ")");

                                    comboBox1.Text = "";
                                    f = list.Count;
                                    break;
                                }
                                else
                                {
                                    if (list[f + 6] == "Seguridad" && list.Count > f + 12)
                                    {
                                        if (list[f + 11] != "Investigacion de operaciones")
                                        {
                                            f = f + 12;
                                            list.Insert(f, comboBox1.Text); //materia
                                            f++;
                                            list.Insert(f, textBox2.Text); //u1
                                            f++;
                                            list.Insert(f, textBox3.Text); //u2
                                            f++;
                                            list.Insert(f, textBox4.Text); //u3
                                            f++;
                                            list.Insert(f, textBox5.Text); //y4

                                            textBox2.Text = "";
                                            textBox3.Text = "";
                                            textBox4.Text = "";
                                            textBox5.Text = "";

                                            MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                                        + nameUser + " (" + textBox64.Text + ")");

                                            comboBox1.Text = "";
                                            f = list.Count;
                                            break;
                                        }
                                        else
                                        {
                                            MessageBox.Show("Esta materia ya fue guardada para "
                                         + nameUser + " (" + textBox64.Text + ")");
                                            textBox2.Text = "";
                                            textBox3.Text = "";
                                            textBox4.Text = "";
                                            textBox5.Text = "";

                                            f = list.Count;
                                            break;
                                        }
                                    }
                                    else
                                    {
                                        f = f + 6;
                                        list.Add(comboBox1.Text); //materia
                                        f++;
                                        list.Add(textBox2.Text); //u1
                                        f++;
                                        list.Add(textBox3.Text); //u2
                                        f++;
                                        list.Add(textBox4.Text); //u3
                                        f++;
                                        list.Add(textBox5.Text); //y4

                                        textBox2.Text = "";
                                        textBox3.Text = "";
                                        textBox4.Text = "";
                                        textBox5.Text = "";

                                        MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                                    + nameUser + " (" + textBox64.Text + ")");

                                        comboBox1.Text = "";
                                        f = list.Count;
                                        break;
                                    }
                                }
                            }
                            else if (list[f + 1] == "Seguridad" && list.Count > f + 6)
                            {
                                if (list[f + 6] != "Investigacion de operaciones")
                                {
                                    f = f + 6;
                                    list.Insert(f, comboBox1.Text); //materia
                                    f++;
                                    list.Insert(f, textBox2.Text); //u1
                                    f++;
                                    list.Insert(f, textBox3.Text); //u2
                                    f++;
                                    list.Insert(f, textBox4.Text); //u3
                                    f++;
                                    list.Insert(f, textBox5.Text); //y4

                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";

                                    MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                                + nameUser + " (" + textBox64.Text + ")");

                                    comboBox1.Text = "";
                                    f = list.Count;
                                    break;
                                }
                                else
                                {
                                    MessageBox.Show("Esta materia ya fue guardada para "
                                      + nameUser + " (" + textBox64.Text + ")");
                                    textBox2.Text = "";
                                    textBox3.Text = "";
                                    textBox4.Text = "";
                                    textBox5.Text = "";

                                    f = list.Count;
                                    break;
                                }


                            }
                            else if (list[f + 1] == "Investigacion de operaciones")
                            {
                                MessageBox.Show("Esta materia ya fue guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                f = list.Count;
                                break;
                            }
                            else
                            {
                                list.Add(comboBox1.Text); //materia
                                f++;
                                list.Add(textBox2.Text); //u1
                                f++;
                                list.Add(textBox3.Text); //u2
                                f++;
                                list.Add(textBox4.Text); //u3
                                f++;
                                list.Add(textBox5.Text); //y4
                                comboBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");
                                f = list.Count;
                                break;
                            }
                        }
                        else
                        {
                            if (list.Count == f + 1)
                            {
                                list.Add(idName); //ID
                                list.Add(comboBox1.Text); //materia
                                f++;
                                list.Add(textBox2.Text); //u1
                                f++;
                                list.Add(textBox3.Text); //u2
                                f++;
                                list.Add(textBox4.Text); //u3
                                f++;
                                list.Add(textBox5.Text); //y4
                                comboBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";

                                MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                            + nameUser + " (" + textBox64.Text + ")");
                                f = list.Count;
                                break;
                            }
                        }
                    }

                }


            }

            if (list.Count < 1)
            { //caso base 

                for (int f = 0; f <= list.Count; f++)
                {
                    list.Add(idName); //ID
                    list.Add(comboBox1.Text); //materia
                    f++;
                    list.Add(textBox2.Text); //u1
                    f++;
                    list.Add(textBox3.Text); //u2
                    f++;
                    list.Add(textBox4.Text); //u3
                    f++;
                    list.Add(textBox5.Text); //y4
                    comboBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";

                    MessageBox.Show(comboBox1.Text + " a sido guardada para "
                                + nameUser + " (" + textBox64.Text + ")");
                    f = list.Count;
                    break;
                }

            }


            for (int r = 0; r < list.Count; r++)
            {
                if (list[r] == "")
                {
                    list[r] = "Sin registro";
                }


                canalEscritura.WriteLine(list[r]);

            }
            canalEscritura.Close();
        }
    }
}

