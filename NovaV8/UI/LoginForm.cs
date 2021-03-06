﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaV8
{
    public partial class LoginForm : Form
    {

        private Reports reports;
        public LoginForm()
        {
            InitializeComponent();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Felder leer?
            if (username.Text.Trim().Equals("") || password.Text.Equals(""))
            {
                MessageBox.Show("Bitte alle Felder ausfüllen", "Fehler");
                return;
            }
            // Lade User
            User user = UserService.FindUserByName(username.Text);
            // Benutzer gefunden und richtiges Passwort?
            if (user == null || !user.rightPassword(password.Text))
            {
                MessageBox.Show("Benutzername und Passwort stimmen nicht überein", "Fehler");
                return;

            }

            // Falls alles OK
            Utils.currentUser = user;
            base.Hide();
            if (reports == null)
            {
                reports = new Reports(this);
            }
            else
            {
                reports.refreshView();
            }
            reports.Visible = true;
        }

        public void ClearLoginFields()
        {
            username.Clear();
            password.Clear();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}

