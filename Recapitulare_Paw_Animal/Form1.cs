using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recapitulare_Paw_Animal
{
    public partial class Form1 : Form
    {
        BindingList<Animal> lstAnimale = new BindingList<Animal>(); //initializezi lista pentru grid
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = lstAnimale; //punem lista de animale in grid
        }

        private void btn_VarstaAnimal_Click(object sender, EventArgs e)
        {
            Animal animal1 = new Animal("1", "Leu", new DateTime(2003, 11, 5), "savana", 2);
            int varstaAnimal = animal1.varstaAnimal();

            MessageBox.Show($"Animalul {animal1.Denumire} are {varstaAnimal} ani");
        }

        private void btn_AdaugaAnimal_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            if (form2.ShowDialog() == DialogResult.OK)
            {
                lstAnimale.Add(form2.a1);
                MessageBox.Show("S-a adaugat animalul!");
            }
            else
            {
                MessageBox.Show("Nu s-a adaugat niciun animal!");
            }
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void deserializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                lstAnimale.Clear(); //avem o lista si trebuie curatata inainte sa adaugam
                lstAnimale = (BindingList<Animal>)bf.Deserialize(fileStream);
                fileStream.Close();
            }

            }

            private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fileStream, lstAnimale);
                fileStream.Close();
            }
        }
    }
}
