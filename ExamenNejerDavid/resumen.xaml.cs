﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamenNejerDavid
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class resumen : ContentPage
    {
        public resumen(string usuario, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
            lblClave.Text = clave;
            txtUsuario.Text = usuario;
            txtClave.Text = clave;

        }



        private void btnVer_Clicked(object sender, EventArgs e)
        {
            txtFinal.Text = txtFinal.Text;
        }
    }
}