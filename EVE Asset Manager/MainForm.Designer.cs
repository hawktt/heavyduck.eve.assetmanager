namespace HeavyDuck.Eve.AssetManager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.toolbar = new System.Windows.Forms.ToolStrip();
            this.search_panel = new System.Windows.Forms.Panel();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menu_file = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_import = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_file_export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reports = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reports_category = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reports_location = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reports_material = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reports_pos = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_reports_loadouts = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_options = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_options_refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menu_options_keys = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_options_options = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_help_about = new System.Windows.Forms.ToolStripMenuItem();
            this.statusbar = new System.Windows.Forms.StatusStrip();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolbar
            // 
            this.toolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolbar.Location = new System.Drawing.Point(0, 24);
            this.toolbar.Margin = new System.Windows.Forms.Padding(0, 0, 6, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Padding = new System.Windows.Forms.Padding(9, 0, 1, 0);
            this.toolbar.Size = new System.Drawing.Size(772, 25);
            this.toolbar.TabIndex = 0;
            // 
            // search_panel
            // 
            this.search_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.search_panel.Location = new System.Drawing.Point(0, 49);
            this.search_panel.Name = "search_panel";
            this.search_panel.Size = new System.Drawing.Size(772, 142);
            this.search_panel.TabIndex = 1;
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file,
            this.menu_reports,
            this.menu_options,
            this.menu_help});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(772, 24);
            this.menu.TabIndex = 3;
            // 
            // menu_file
            // 
            this.menu_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_file_import,
            this.menu_file_export,
            this.toolStripSeparator1,
            this.menu_file_exit});
            this.menu_file.Name = "menu_file";
            this.menu_file.Size = new System.Drawing.Size(37, 20);
            this.menu_file.Text = "&File";
            // 
            // menu_file_import
            // 
            this.menu_file_import.Name = "menu_file_import";
            this.menu_file_import.Size = new System.Drawing.Size(146, 22);
            this.menu_file_import.Text = "Import XML...";
            // 
            // menu_file_export
            // 
            this.menu_file_export.Name = "menu_file_export";
            this.menu_file_export.Size = new System.Drawing.Size(146, 22);
            this.menu_file_export.Text = "Export CSV...";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // menu_file_exit
            // 
            this.menu_file_exit.Name = "menu_file_exit";
            this.menu_file_exit.Size = new System.Drawing.Size(146, 22);
            this.menu_file_exit.Text = "E&xit";
            // 
            // menu_reports
            // 
            this.menu_reports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_reports_category,
            this.menu_reports_location,
            this.menu_reports_material,
            this.menu_reports_pos,
            this.menu_reports_loadouts});
            this.menu_reports.Name = "menu_reports";
            this.menu_reports.Size = new System.Drawing.Size(59, 20);
            this.menu_reports.Text = "&Reports";
            // 
            // menu_reports_category
            // 
            this.menu_reports_category.Name = "menu_reports_category";
            this.menu_reports_category.Size = new System.Drawing.Size(174, 22);
            this.menu_reports_category.Text = "Assets by Category";
            // 
            // menu_reports_location
            // 
            this.menu_reports_location.Name = "menu_reports_location";
            this.menu_reports_location.Size = new System.Drawing.Size(174, 22);
            this.menu_reports_location.Text = "Assets by Location";
            // 
            // menu_reports_material
            // 
            this.menu_reports_material.Name = "menu_reports_material";
            this.menu_reports_material.Size = new System.Drawing.Size(174, 22);
            this.menu_reports_material.Text = "Materials";
            // 
            // menu_reports_pos
            // 
            this.menu_reports_pos.Name = "menu_reports_pos";
            this.menu_reports_pos.Size = new System.Drawing.Size(174, 22);
            this.menu_reports_pos.Text = "POS Fuel";
            // 
            // menu_reports_loadouts
            // 
            this.menu_reports_loadouts.Name = "menu_reports_loadouts";
            this.menu_reports_loadouts.Size = new System.Drawing.Size(174, 22);
            this.menu_reports_loadouts.Text = "Ship Loadouts";
            // 
            // menu_options
            // 
            this.menu_options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_options_refresh,
            this.toolStripSeparator2,
            this.menu_options_keys,
            this.menu_options_options});
            this.menu_options.Name = "menu_options";
            this.menu_options.Size = new System.Drawing.Size(61, 20);
            this.menu_options.Text = "&Options";
            // 
            // menu_options_refresh
            // 
            this.menu_options_refresh.Name = "menu_options_refresh";
            this.menu_options_refresh.Size = new System.Drawing.Size(174, 22);
            this.menu_options_refresh.Text = "Refresh Assets";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(171, 6);
            // 
            // menu_options_keys
            // 
            this.menu_options_keys.Name = "menu_options_keys";
            this.menu_options_keys.Size = new System.Drawing.Size(174, 22);
            this.menu_options_keys.Text = "Manage API Keys...";
            // 
            // menu_options_options
            // 
            this.menu_options_options.Name = "menu_options_options";
            this.menu_options_options.Size = new System.Drawing.Size(174, 22);
            this.menu_options_options.Text = "Options...";
            // 
            // menu_help
            // 
            this.menu_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_help_about});
            this.menu_help.Name = "menu_help";
            this.menu_help.Size = new System.Drawing.Size(44, 20);
            this.menu_help.Text = "&Help";
            // 
            // menu_help_about
            // 
            this.menu_help_about.Name = "menu_help_about";
            this.menu_help_about.Size = new System.Drawing.Size(107, 22);
            this.menu_help_about.Text = "&About";
            // 
            // statusbar
            // 
            this.statusbar.Location = new System.Drawing.Point(0, 534);
            this.statusbar.Name = "statusbar";
            this.statusbar.Size = new System.Drawing.Size(772, 22);
            this.statusbar.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 556);
            this.Controls.Add(this.statusbar);
            this.Controls.Add(this.search_panel);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "EVE Asset Manager";
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolbar;
        private System.Windows.Forms.Panel search_panel;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menu_file;
        private System.Windows.Forms.ToolStripMenuItem menu_file_exit;
        private System.Windows.Forms.ToolStripMenuItem menu_reports;
        private System.Windows.Forms.ToolStripMenuItem menu_reports_material;
        private System.Windows.Forms.ToolStripMenuItem menu_reports_loadouts;
        private System.Windows.Forms.ToolStripMenuItem menu_options;
        private System.Windows.Forms.ToolStripMenuItem menu_options_refresh;
        private System.Windows.Forms.ToolStripMenuItem menu_options_keys;
        private System.Windows.Forms.ToolStripMenuItem menu_help;
        private System.Windows.Forms.ToolStripMenuItem menu_help_about;
        private System.Windows.Forms.ToolStripMenuItem menu_file_import;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem menu_reports_pos;
        private System.Windows.Forms.ToolStripMenuItem menu_reports_location;
        private System.Windows.Forms.ToolStripMenuItem menu_reports_category;
        private System.Windows.Forms.ToolStripMenuItem menu_file_export;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem menu_options_options;
        private System.Windows.Forms.StatusStrip statusbar;
    }
}