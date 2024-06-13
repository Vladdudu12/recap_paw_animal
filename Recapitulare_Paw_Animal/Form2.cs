using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recapitulare_Paw_Animal
{
    public partial class Form2 : Form
    {
        public Animal a1 { get; set; } //ca sa avem acces si in form 1 la acest animal
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            string id = "-";
            string denumire = "-";
            DateTime dataNastere = new DateTime();
            string habitat = "-";
            float inaltime = 0; //cream aceleasi atribute din clasa, fara private in fata

            if (tb_id.Text.Length > 0)
            {
                id = tb_id.Text;
            }
            if(tb_denumire.Text.Length > 0)
            {
                denumire = tb_denumire.Text;

            }
            if(dtp_dataNasterii.Text.Length > 0)
            {
                dataNastere = DateTime.Parse(dtp_dataNasterii.Text);

            }
            if(cb_habitat.Text.Length > 0)
            {
                habitat = cb_habitat.Text;

            }
            if(tb_inaltime.Text.Length > 0 && float.TryParse(tb_inaltime.Text, out inaltime))
            {
                inaltime = float.Parse(tb_inaltime.Text);
            }

            a1 = new Animal(id, denumire, dataNastere, habitat, inaltime); //animalul de mai sus ia atributele citite de noi
            DialogResult = DialogResult.OK; //OBLIGATORIU INCHIDEM CU OK
            Close(); //inchidem formul
    }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel; //OBLIGATORIU PRIMIM REZULTATUL CANCEL
            Close(); //inchidem formul
        }
    }
}
