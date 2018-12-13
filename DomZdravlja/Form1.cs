﻿using DomZdravlja.PropertyClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DomZdravlja.Helpers;

namespace DomZdravlja
{
    public partial class Form1 : Form
    {
        List<PropertyZaposleni> listaZaposlenih = new List<PropertyZaposleni>();

        public Form1()
        {
            InitializeComponent();
            ucitajZaposlene();
        }

        private void ucitajZaposlene()
        {
            PropertyZaposleni zaposleni = new PropertyZaposleni();
            SqlDataReader dataReader = SqlHelper.ExecuteReader(SqlHelper.GetConnectionString(), CommandType.Text, zaposleni.GetSelectQuery());

            while (dataReader.Read())
            {
                PropertyZaposleni pomZaposleni = new PropertyZaposleni();
                pomZaposleni.ZaposleniID = (int)dataReader["ZaposleniID"];
                pomZaposleni.Zvanje = (string)dataReader["Zvanje"];
                pomZaposleni.RadnoMjesto = (string)dataReader["RadnoMjesto"];
                pomZaposleni.KorisnickoIme = (string)dataReader["KorisnickoIme"];
                pomZaposleni.Password = (string)dataReader["Password"];
                pomZaposleni.TipZaposlenog = (string)dataReader["TipZaposlenog"];
                pomZaposleni.OsobaID = (int)dataReader["OsobaID"];
                listaZaposlenih.Add(pomZaposleni);
            }
        }

        private void btnIzlaz_Click(object sender, EventArgs e)
        {

            this.Close();
            Application.Exit();

        }

        private void btnNastavi_Click(object sender, EventArgs e)
        {
            dugme();
        }

        private void dugme()
        {
            bool provjera = false;

            foreach (var item in listaZaposlenih)
            {
                if (item.KorisnickoIme.Equals(txtKorisnickoIme.Text))
                {
                    if (item.Password.Equals(txtLozinka.Text))
                    {
                        GlavnaForma glavnaForma = new GlavnaForma();
                        this.Hide();
                        glavnaForma.Show();                        
                    }
                    else
                        MessageBox.Show("Pogrešna lozinka!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    provjera = true;
                    break;
                }
            }
            if (!provjera)
                MessageBox.Show("Pogrešno korisničko ime!", "Greška", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void btnIzlaz_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnIzlaz_MouseLeave(object sender, EventArgs e)
        {

        }


        private void txtLozinka_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                dugme();
            }
        }
    }
}