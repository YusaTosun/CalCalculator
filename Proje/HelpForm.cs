﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Proje
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }


        private void ıconButton2_Click(object sender, EventArgs e)
        {

            // FontDialog örneği oluşturun
            FontDialog fontDialog = new FontDialog();

            // Varsayılan yazı tipi ayarlarını ayarlayın
            fontDialog.Font = rtbContact.Font;

            // Kullanıcıya yazı tipi seçimini gösterin
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                // Kullanıcının seçtiği yazı tipini ayarlayın
                rtbContact.Font = fontDialog.Font;
            }

        }
    }
}
