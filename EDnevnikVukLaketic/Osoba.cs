using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EDnevnikVukLaketic
{
    public partial class Osoba : Form
    {
        int broj_sloga = 0;
        DataTable tabela;

        private void Load_Data()
        {
            SqlConnection veza = Konekcija.Connect();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Osoba", veza);
            tabela = new DataTable();
            adapter.Fill(tabela);
            TxtPopulate();
        }

        private void TxtPopulate()
        {
            if (tabela.Rows.Count == 0)
            {
                txt_id.Text = "";
                txt_ime.Text = "";
                txt_prezime.Text = "";
                txt_adresa.Text = "";
                txt_jmbg.Text = "";
                txt_email.Text = "";
                txt_pass.Text = "";
                txt_uloga.Text = "";
                btn_delete.Enabled = false;
            }
            else
            {
                txt_id.Text = tabela.Rows[broj_sloga]["id"].ToString();
                txt_ime.Text = tabela.Rows[broj_sloga]["ime"].ToString();
                txt_prezime.Text = tabela.Rows[broj_sloga]["prezime"].ToString();
                txt_adresa.Text = tabela.Rows[broj_sloga]["adresa"].ToString();
                txt_jmbg.Text = tabela.Rows[broj_sloga]["jmbg"].ToString();
                txt_email.Text = tabela.Rows[broj_sloga]["email"].ToString();
                txt_pass.Text = tabela.Rows[broj_sloga]["pass"].ToString();
                txt_uloga.Text = tabela.Rows[broj_sloga]["uloga"].ToString();
                btn_delete.Enabled = true;
            }

            if (broj_sloga == tabela.Rows.Count - 1)
            {
                btn_next.Enabled = false;
                btn_last.Enabled = false;
            }
            else
            {
                btn_next.Enabled = true;
                btn_last.Enabled = true;
            }

            if (broj_sloga == 0)
            {
                btn_prev.Enabled = false;
                btn_first.Enabled = false;
            }
            else
            {
                btn_prev.Enabled = true;
                btn_first.Enabled = true;
            }
        }

        public Osoba()
        {
            InitializeComponent();
        }

        private void Osoba_Load(object sender, EventArgs e)
        {
            Load_Data();
            TxtPopulate();
        }

        private void btn_first_Click(object sender, EventArgs e)
        {
            broj_sloga = 0;
            TxtPopulate();
        }

        private void btn_prev_Click(object sender, EventArgs e)
        {
            broj_sloga--;
            TxtPopulate();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("INSERT INTO Osoba (ime, prezime, adresa, jmbg, email, pass, uloga)VALUES('");
            Naredba.Append(txt_ime.Text + "', '");
            Naredba.Append(txt_prezime.Text + "', '");
            Naredba.Append(txt_adresa.Text + "', '");
            Naredba.Append(txt_jmbg.Text + "', '");
            Naredba.Append(txt_email.Text + "', '");
            Naredba.Append(txt_pass.Text + "', '");
            Naredba.Append(txt_uloga.Text + "')");
            SqlConnection veza = Konekcija.Connect();
            SqlCommand Komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                Komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception GRESKA)
            {
                MessageBox.Show(GRESKA.Message);
            }

            Load_Data();
            broj_sloga = tabela.Rows.Count - 1;
            TxtPopulate();
            inf.Text = "Podatak uspesno dodat!";
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            StringBuilder Naredba = new StringBuilder("UPDATE Osoba SET ");
            Naredba.Append("ime = '" + txt_ime.Text + "', ");
            Naredba.Append("prezime = '" + txt_prezime.Text + "', ");
            Naredba.Append("adresa = '" + txt_adresa.Text + "', ");
            Naredba.Append("jmbg = '" + txt_jmbg.Text + "', ");
            Naredba.Append("email = '" + txt_email.Text + "', ");
            Naredba.Append("pass = '" + txt_pass.Text + "', ");
            Naredba.Append("uloga = '" + txt_uloga.Text + "' ");
            Naredba.Append("WHERE id = " + txt_id.Text);
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda = new SqlCommand(Naredba.ToString(), veza);
            try
            {
                veza.Open();
                komanda.ExecuteNonQuery();
                veza.Close();
            }
            catch (Exception GRESKA)
            {
                MessageBox.Show(GRESKA.Message);
            }
            Load_Data();
            TxtPopulate();
            inf.Text = "Podatak uspesno izmenjen!";
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            Boolean posl = true;
            string Naredba1 = "DELETE FROM Raspodela WHERE nastavnik_id = " + txt_id.Text;
            string Naredba2 = "DELETE FROM Ocena WHERE ucenik_id = " + txt_id.Text;
            string Naredba3 = "DELETE FROM Upisnica WHERE osoba_id = " + txt_id.Text;
            string Naredba4 = "DELETE FROM Odeljenje WHERE razredni_id = " + txt_id.Text;
            string Naredba = "DELETE FROM Osoba WHERE Osoba.id = " + txt_id.Text;
            if (broj_sloga == tabela.Rows.Count - 1) 
            {
                broj_sloga--;
                posl = false;
            }
            if (broj_sloga < 0) broj_sloga = 0;
            SqlConnection veza = Konekcija.Connect();
            SqlCommand komanda1 = new SqlCommand(Naredba1, veza);
            SqlCommand komanda2 = new SqlCommand(Naredba2, veza);
            SqlCommand komanda3 = new SqlCommand(Naredba3, veza);
            SqlCommand komanda4 = new SqlCommand(Naredba4, veza);
            SqlCommand komanda = new SqlCommand(Naredba, veza);
            Boolean brisano = false;
            try
            {
                veza.Open();
                komanda1.ExecuteNonQuery();
                komanda2.ExecuteNonQuery();
                komanda3.ExecuteNonQuery();
                komanda4.ExecuteNonQuery();
                komanda.ExecuteNonQuery();
                veza.Close();
                brisano = true;
            }
            catch (Exception GRESKA)
            {
                MessageBox.Show(GRESKA.Message);
            }

            if (brisano && posl) 
            {
                Load_Data();
                if (broj_sloga > 0) broj_sloga--;
                TxtPopulate();
            }
            else 
            {
                Load_Data();
                TxtPopulate();
            }
            inf.Text = "Podatak uspesno obrisan!";
        }
    

        private void btn_next_Click(object sender, EventArgs e)
        {
            broj_sloga++;
            TxtPopulate();
        }

        private void btn_last_Click(object sender, EventArgs e)
        {
            broj_sloga = tabela.Rows.Count - 1;
            TxtPopulate();
        }
    }
}
