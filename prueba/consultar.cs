namespace prueba
{
    public partial class consultar : Form
    {
        public consultar()
        {
            InitializeComponent();
        }
        int lineGuide = 0;

        String[] lineAlmMat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Materias.txt");
        String[] lineAlmDat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt");
        String lolasd, id, name, carr, tel, dir;
        int control = -1;

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
      

            private void button3_Click(object sender, EventArgs e)
        {
            lineAlmMat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Materias.txt");

            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Materias.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(conector);


            if (MessageBox.Show("¿Desea eliminar el registro de " + textBox1.Text + "?", "Confirmacion",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int f = 0; f < lineAlmMat.Length; f++)
                {
                    if (lineAlmMat[f] == textBox644.Text)
                    {
                        try
                        {
                            if (lineAlmMat[f + 1] == textBox1.Text)
                            {
                                f++;
                                lineAlmMat[f] = "null";
                                f++;
                                lineAlmMat[f] = "null";
                                f++;
                                lineAlmMat[f] = "null";
                                f++;
                                lineAlmMat[f] = "null";
                                f++;
                                lineAlmMat[f] = "null";

                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;

                                f = lineAlmMat.Length;
                                break;
                            }
                            else if (lineAlmMat[f + 6] == textBox1.Text)
                            {
                                lineAlmMat[f + 6] = "null";
                                lineAlmMat[f + 7] = "null";
                                lineAlmMat[f + 8] = "null";
                                lineAlmMat[f + 9] = "null";
                                lineAlmMat[f + 10] = "null";

                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;
                                f = lineAlmMat.Length;
                                break;
                            }
                            else if (lineAlmMat[f + 11] == textBox1.Text)
                            {
                                control = 0;
                                lineAlmMat[f + 11] = "null";//Materia
                                lineAlmMat[f + 12] = "null";
                                lineAlmMat[f + 13] = "null";
                                lineAlmMat[f + 14] = "null";
                                lineAlmMat[f + 15] = "null";
                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;
                                f = lineAlmMat.Length;
                                break;
                            }
                        }
                        catch
                        {
                            control = -1; f = lineAlmMat.Length;
                        }



                        textBox5.Text = "";
                        textBox2.Text = "";
                        textBox3.Text = "";
                        textBox4.Text = "";
                    }
                }

                for (int i = 0; i < lineAlmMat.Length; i++)
                {
                    if (lineAlmMat[i] != "null")
                    {
                        escritor.WriteLine(lineAlmMat[i]);

                    }
                }

                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;

                button3.Visible = false;
                button2.Visible = false;


                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox9.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox10.Visible = false;
                textBox6.Visible = false;
                MessageBox.Show(comboBox12.Text + "eliminada con exito del registro de " + textBox644.Text);

                escritor.Close();
            }
            else
            {

                for (int i = 0; i < lineAlmMat.Length; i++)
                {
                    escritor.WriteLine(lineAlmMat[i]);
                }

                MessageBox.Show("Primero seleccione un elemento del registro");
                escritor.Close();


            }

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            button3.Visible = false;
            button2.Visible = false;


            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox9.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox10.Visible = false;
            textBox6.Visible = false;

        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            lineAlmMat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Materias.txt");
            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Materias.txt", FileMode.Create);
            StreamWriter escritor = new StreamWriter(conector);




            if (MessageBox.Show("¿Desea guardar los cambios?", "",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                for (int f = 0; f < lineAlmMat.Length; f++)
                {
                    if (lineAlmMat[f] == textBox644.Text)
                    {
                        try
                        {
                            if (lineAlmMat[f + 1] == textBox1.Text)
                            {
                                f++;
                                f++;
                                lineAlmMat[f] = textBox2.Text;
                                f++;
                                lineAlmMat[f] = textBox3.Text;
                                f++;
                                lineAlmMat[f] = textBox4.Text;
                                f++;
                                lineAlmMat[f] = textBox5.Text;

                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;

                                f = lineAlmMat.Length;
                                break;
                            }
                            else if (lineAlmMat[f + 6] == textBox1.Text)
                            {
                                lineAlmMat[f + 7] = textBox2.Text;
                                lineAlmMat[f + 8] = textBox3.Text;
                                lineAlmMat[f + 9] = textBox4.Text;
                                lineAlmMat[f + 10] = textBox5.Text;

                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;
                                f = lineAlmMat.Length;
                                break;
                            }
                            else if (lineAlmMat[f + 11] == textBox1.Text)
                            {
                                control = 0;

                                lineAlmMat[f + 12] = textBox2.Text;
                                lineAlmMat[f + 13] = textBox3.Text;
                                lineAlmMat[f + 14] = textBox4.Text;
                                lineAlmMat[f + 15] = textBox5.Text;
                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;
                                f = lineAlmMat.Length;
                                break;
                            }
                            else
                            {
                                control = -1;
                                f = lineAlmMat.Length;
                                break;
                            }
                        }
                        catch
                        {
                            control = -1; f = lineAlmMat.Length;
                        }
                    }

                }

                for (int i = 0; i < lineAlmMat.Length; i++)
                {
                    escritor.WriteLine(lineAlmMat[i]);
                }
                escritor.Close();
            }
            else
            {

                for (int f = 0; f < lineAlmMat.Length; f++)
                {
                    if (lineAlmMat[f] == textBox644.Text)
                    {
                        try
                        {
                            if (lineAlmMat[f + 1] == textBox1.Text)
                            {
                                f++;
                                f++;
                                textBox2.Text = lineAlmMat[f];
                                f++;
                                textBox3.Text = lineAlmMat[f];
                                f++;
                                textBox4.Text = lineAlmMat[f];
                                f++;
                                textBox5.Text = lineAlmMat[f];

                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;

                                f = lineAlmMat.Length;
                                break;
                            }
                            else if (lineAlmMat[f + 6] == textBox1.Text)
                            {
                                textBox2.Text = lineAlmMat[7];
                                textBox3.Text = lineAlmMat[8];
                                textBox4.Text = lineAlmMat[9];
                                textBox5.Text = lineAlmMat[10];

                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;
                                f = lineAlmMat.Length;
                                break;
                            }
                            else if (lineAlmMat[f + 11] == textBox1.Text)
                            {
                                control = 0;

                                textBox2.Text = lineAlmMat[12];
                                textBox3.Text = lineAlmMat[13];
                                textBox4.Text = lineAlmMat[14];
                                textBox5.Text = lineAlmMat[15];
                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;
                                f = lineAlmMat.Length;
                                break;
                            }
                            else
                            {
                                control = -1;
                                f = lineAlmMat.Length;
                                break;
                            }
                        }
                        catch
                        {
                            control = -1; f = lineAlmMat.Length;
                        }
                    }

                }
                for (int i = 0; i < lineAlmMat.Length; i++)
                {
                    escritor.WriteLine(lineAlmMat[i]);
                }
                escritor.Close();

            }



        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;

            button3.Visible = false;
            button2.Visible = false;


            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox9.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox10.Visible = false;
            textBox6.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lineAlmMat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Materias.txt");
            lineAlmDat = File.ReadAllLines(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt");

            FileStream conector = new FileStream(@"C:\Users\vicen\OneDrive\Escritorio\Datos.txt", FileMode.Open);
            StreamReader lector = new StreamReader(conector);


            int lola = 0;
            while (lector.EndOfStream == false)
            {
                lola++;
                if (lector.ReadLine() == textBox644.Text)
                {
                    id = lector.ReadLine();
                    name = lector.ReadLine();
                    carr = lector.ReadLine();
                    tel = lector.ReadLine();
                    dir = lector.ReadLine();
                    break;


                }
                else
                {
                    lector.ReadLine();
                    lector.ReadLine();
                    lector.ReadLine();

                    lector.ReadLine();


                }
            }
            lector.Close();
            if (textBox644.Text != "" && comboBox12.Text != "")
            {
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox9.Text = "";
                textBox7.Text = "";
                textBox8.Text = "";
                textBox10.Text = "";
                textBox6.Text = "";


                for (int f = 0; f < lineAlmMat.Length; f++)
                {
                    lolasd = lineAlmMat[f];
                    if (lineAlmMat[f] == textBox644.Text)

                    {
                        try
                        {
                            if (lineAlmMat[f + 1] == comboBox12.Text)
                            {
                                control = 0;
                                f++;
                                textBox1.Text = lineAlmMat[f];
                                f++;
                                textBox2.Text = lineAlmMat[f];
                                f++;
                                textBox3.Text = lineAlmMat[f];
                                f++;
                                textBox4.Text = lineAlmMat[f];
                                f++;
                                textBox5.Text = lineAlmMat[f];

                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;

                                f = lineAlmMat.Length;
                                break;
                            }
                            else if (lineAlmMat[f + 6] == comboBox12.Text)
                            {
                                control = 0;

                                textBox1.Text = lineAlmMat[f + 6];
                                textBox2.Text = lineAlmMat[f + 7];
                                textBox3.Text = lineAlmMat[f + 8];
                                textBox4.Text = lineAlmMat[f + 9];
                                textBox5.Text = lineAlmMat[f + 10];
                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;
                                f = lineAlmMat.Length;
                                break;
                            }
                            else if (lineAlmMat[f + 11] == comboBox12.Text)
                            {
                                control = 0;

                                textBox1.Text = lineAlmMat[f + 11];
                                textBox2.Text = lineAlmMat[f + 12];
                                textBox3.Text = lineAlmMat[f + 13];
                                textBox4.Text = lineAlmMat[f + 14];
                                textBox5.Text = lineAlmMat[f + 15];
                                textBox6.Text = id;
                                textBox7.Text = name;
                                textBox8.Text = carr;
                                textBox9.Text = tel;
                                textBox10.Text = dir;
                                f = lineAlmMat.Length;
                                break;
                            }
                            else
                            {
                                control = -1;
                                f = lineAlmMat.Length;
                                break;
                            }
                        }
                        catch
                        {
                            control = -1; f = lineAlmMat.Length;
                        }

                    }
                    else
                    {
                        control = -1;
                    }

                }
            }
            else
            {
                MessageBox.Show("Primero seleccione un elemento del registro");
                control = 6;
            }

            if (control == -1)
            {
                label1.Visible = false;

                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;

                button3.Visible = false;
                button2.Visible = false;


                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                textBox9.Visible = false;
                textBox7.Visible = false;
                textBox8.Visible = false;
                textBox10.Visible = false;
                textBox6.Visible = false;
                MessageBox.Show(comboBox12.Text + " no a sido guardada para " + textBox644.Text);

            }
            else if (control == 0)
            {
                label1.Visible = true;

                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                label11.Visible = true;
                button3.Visible = true;
                button2.Visible = true;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
                textBox9.Visible = true;
                textBox7.Visible = true;
                textBox8.Visible = true;
                textBox10.Visible = true;
                textBox6.Visible = true;
            }
            else
            {
                control = -1;
            }




        }
    }
}
