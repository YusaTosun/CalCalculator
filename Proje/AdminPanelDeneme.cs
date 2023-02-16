﻿using CalCalculatorEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class AdminPanelDeneme : Form
    {
        bool sidebarExpand;
        User user;
        CreateFood createFoodForm;
        CreateCategory createCategoryForm;
        public AdminPanelDeneme(User currentUser)
        {
            InitializeComponent();
            IsMdiContainer = true;
            user = currentUser;
        }


        private void sidebarTimer_Tick(object sender, EventArgs e)
        {


            if (sidebarExpand)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width == sidebarContainer.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    sidebarTimer.Stop();
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width == sidebarContainer.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    sidebarTimer.Stop();
                }
            }
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebarTimer.Start();

            //If menu closed
            if (homeContainer.Visible && sidebarContainer.Width > 230)
            {
                homeContainer.Visible = false;
            }
            else if (!homeContainer.Visible && sidebarContainer.Width < 85)
            {
                homeContainer.Visible = true;
            }

        }

        private void btnContinueAsAnUser_Click(object sender, EventArgs e)
        {

            MainFormDeneme mainForm = new(user);
            mainForm.Show();
            this.Close();
        }
        private void btnCreateFood_Click(object sender, EventArgs e)
        {

            createFoodForm = new();
            createFoodForm.MdiParent = this;
            int height = createFoodForm.Height + 35;
            int width = createFoodForm.Width + 238;
            this.Size = new Size(width, height);
            if (this.ActiveMdiChild == null )
            {
                createFoodForm.Show();
            }
            else if(this.ActiveMdiChild != null ) 
            {
                this.ActiveMdiChild.Close();
                createFoodForm.Show();
            }
            
            

        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {

            createCategoryForm = new();
            createCategoryForm.MdiParent = this;
            int height = createCategoryForm.Height + 35;
            int width = createCategoryForm.Width + 238;
            this.Size = new Size(width, height);
            if (this.ActiveMdiChild == null)
            {
                createCategoryForm.Show();
            }
            else if (this.ActiveMdiChild != null)
            {
                this.ActiveMdiChild.Close();
                createCategoryForm.Show();
            }
            
            
        }

        private void btnShutDown_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Uygulamadan çıkmak istediğinize emin misiniz?", "Uygulamadan Çıkış", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK) // OK butonuna basıldı
            {
                // Uygulamayı kapat
                Application.Exit();
            }
        }
    }
}

