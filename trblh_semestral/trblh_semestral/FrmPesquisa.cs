﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trblh_semestral
{
    public partial class FrmPesquisa : Form
    {
        NpgsqlConnection conexao;
        public FrmPesquisa()
        {
            InitializeComponent();
        }

        private void BtnFiltro_Click(object sender, EventArgs e)
        {

        }
    }
}
