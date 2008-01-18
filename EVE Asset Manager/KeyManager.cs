using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HeavyDuck.Utilities.Forms;

namespace HeavyDuck.Eve.AssetManager
{
    public partial class KeyManager : Form
    {
        private static KeyManager the_instance = null;

        private KeyManager()
        {
            InitializeComponent();

            // set up key grid
            GridHelper.Initialize(grid_keys, false);
            GridHelper.AddColumn(grid_keys, "userID", "User ID");
            GridHelper.AddColumn(grid_keys, "apiKey", "Full API Key");
            grid_keys.AllowUserToAddRows = true;
            grid_keys.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_keys.Columns["userID"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            grid_keys.DataSource = Program.ApiKeys;
            grid_keys.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // set up character grid
            GridHelper.Initialize(grid_characters, true);
            GridHelper.AddColumn(grid_characters, "userID", "User ID");
            GridHelper.AddColumn(grid_characters, "name", "Name");
            GridHelper.AddColumn(grid_characters, "characterID", "Character ID");
            GridHelper.AddColumn(grid_characters, "corporationName", "Corporation");
            GridHelper.AddColumn(grid_characters, "corporationID", "Corp ID");
            grid_characters.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid_characters.DataSource = Program.Characters;

            // no sorty-sort arrows
            GridHelper.DisableClickToSort(grid_keys, false);
            GridHelper.DisableClickToSort(grid_characters, false);

            // event handlers
            remove_button.Click += new EventHandler(remove_button_Click);
            refresh_button.Click += new EventHandler(refresh_button_Click);
        }

        private void remove_button_Click(object sender, EventArgs e)
        {
            List<DataRow> rows = new List<DataRow>(grid_keys.SelectedRows.Count);
            DataRowView view;

            // mark the rows we are going to kill
            foreach (DataGridViewRow selected in grid_keys.SelectedRows)
            {
                view = selected.DataBoundItem as DataRowView;
                if (view != null) rows.Add(view.Row);
            }

            // delete them...
            foreach (DataRow row in rows)
                row.Delete();

            // ... and accept the changes
            Program.ApiKeys.AcceptChanges();
        }

        private void refresh_button_Click(object sender, EventArgs e)
        {
            Program.RefreshCharacters();
        }

        public static new void Show(IWin32Window parent)
        {
            if (Monitor.TryEnter(typeof(KeyManager)))
            {
                if (the_instance == null) the_instance = new KeyManager();
                the_instance.ShowDialog(parent);

                Monitor.Exit(typeof(KeyManager));
            }
            else
            {
                throw new InvalidOperationException("The KeyManager is already open");
            }
        }
    }
}