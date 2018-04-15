﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameSky
{
    public partial class FlameSkyFavorites : MetroFramework.Forms.MetroForm
    {
        public FlameSkyFavorites()
        {
            InitializeComponent();
        }

        private void FlameSkyFavorites_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'flameSkyFavoritesDataSet.Favorites' table. You can move, or remove it, as needed.
            this.favoritesTableAdapter.Fill(this.flameSkyFavoritesDataSet.Favorites);

        }

        private void favoritesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.favoritesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.flameSkyFavoritesDataSet);

        }
    }
}
