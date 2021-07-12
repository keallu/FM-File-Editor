
namespace FMFileEditor
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.toolStripMain = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonOpen = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewPlayers = new System.Windows.Forms.DataGridView();
            this.ColumnPlayersID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayersFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayersCommonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPlayersSecondName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewClubs = new System.Windows.Forms.DataGridView();
            this.ColumnClubsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClubsLongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClubsShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnClubsLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewStadiums = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewNations = new System.Windows.Forms.DataGridView();
            this.ColumnNationsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNationsLongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNationsShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNationsLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridViewCities = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.dataGridViewCompetitions = new System.Windows.Forms.DataGridView();
            this.ColumnCompetitionsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompetitionsLongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompetitionsShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCompetitionsLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.dataGridViewAwards = new System.Windows.Forms.DataGridView();
            this.ColumnAwardsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAwardsLongName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAwardsShortName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAwardsLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStadiumsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStadiumsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStadiumsLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCitiesID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCitiesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCitiesLanguage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubs)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStadiums)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNations)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitions)).BeginInit();
            this.tabPage7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAwards)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMain
            // 
            this.toolStripMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonOpen,
            this.toolStripButtonSave});
            this.toolStripMain.Location = new System.Drawing.Point(0, 0);
            this.toolStripMain.Name = "toolStripMain";
            this.toolStripMain.Size = new System.Drawing.Size(1292, 27);
            this.toolStripMain.TabIndex = 0;
            this.toolStripMain.Text = "toolStrip";
            // 
            // toolStripButtonOpen
            // 
            this.toolStripButtonOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonOpen.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonOpen.Image")));
            this.toolStripButtonOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonOpen.Name = "toolStripButtonOpen";
            this.toolStripButtonOpen.Size = new System.Drawing.Size(49, 24);
            this.toolStripButtonOpen.Text = "Open";
            this.toolStripButtonOpen.Click += new System.EventHandler(this.toolStripButtonOpen_Click);
            // 
            // toolStripButtonSave
            // 
            this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSave.Name = "toolStripButtonSave";
            this.toolStripButtonSave.Size = new System.Drawing.Size(44, 24);
            this.toolStripButtonSave.Text = "Save";
            this.toolStripButtonSave.Click += new System.EventHandler(this.toolStripButtonSave_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Controls.Add(this.tabPage4);
            this.tabControlMain.Controls.Add(this.tabPage5);
            this.tabControlMain.Controls.Add(this.tabPage6);
            this.tabControlMain.Controls.Add(this.tabPage7);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 27);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1292, 715);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewPlayers);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1284, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Players";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPlayers
            // 
            this.dataGridViewPlayers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPlayers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPlayersID,
            this.ColumnPlayersFirstName,
            this.ColumnPlayersCommonName,
            this.ColumnPlayersSecondName});
            this.dataGridViewPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPlayers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewPlayers.Name = "dataGridViewPlayers";
            this.dataGridViewPlayers.RowHeadersWidth = 51;
            this.dataGridViewPlayers.RowTemplate.Height = 29;
            this.dataGridViewPlayers.Size = new System.Drawing.Size(1278, 676);
            this.dataGridViewPlayers.TabIndex = 0;
            // 
            // ColumnPlayersID
            // 
            this.ColumnPlayersID.DataPropertyName = "Id";
            this.ColumnPlayersID.HeaderText = "ID";
            this.ColumnPlayersID.MinimumWidth = 6;
            this.ColumnPlayersID.Name = "ColumnPlayersID";
            // 
            // ColumnPlayersFirstName
            // 
            this.ColumnPlayersFirstName.DataPropertyName = "FirstName";
            this.ColumnPlayersFirstName.HeaderText = "First Name";
            this.ColumnPlayersFirstName.MinimumWidth = 6;
            this.ColumnPlayersFirstName.Name = "ColumnPlayersFirstName";
            // 
            // ColumnPlayersCommonName
            // 
            this.ColumnPlayersCommonName.DataPropertyName = "CommonName";
            this.ColumnPlayersCommonName.HeaderText = "Common Name";
            this.ColumnPlayersCommonName.MinimumWidth = 6;
            this.ColumnPlayersCommonName.Name = "ColumnPlayersCommonName";
            // 
            // ColumnPlayersSecondName
            // 
            this.ColumnPlayersSecondName.DataPropertyName = "SecondName";
            this.ColumnPlayersSecondName.HeaderText = "Second Name";
            this.ColumnPlayersSecondName.MinimumWidth = 6;
            this.ColumnPlayersSecondName.Name = "ColumnPlayersSecondName";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewClubs);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1284, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clubs";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClubs
            // 
            this.dataGridViewClubs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClubs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClubs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnClubsID,
            this.ColumnClubsLongName,
            this.ColumnClubsShortName,
            this.ColumnClubsLanguage});
            this.dataGridViewClubs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewClubs.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewClubs.Name = "dataGridViewClubs";
            this.dataGridViewClubs.RowHeadersWidth = 51;
            this.dataGridViewClubs.RowTemplate.Height = 29;
            this.dataGridViewClubs.Size = new System.Drawing.Size(1278, 676);
            this.dataGridViewClubs.TabIndex = 1;
            // 
            // ColumnClubsID
            // 
            this.ColumnClubsID.DataPropertyName = "Id";
            this.ColumnClubsID.HeaderText = "ID";
            this.ColumnClubsID.MinimumWidth = 6;
            this.ColumnClubsID.Name = "ColumnClubsID";
            // 
            // ColumnClubsLongName
            // 
            this.ColumnClubsLongName.DataPropertyName = "LongName";
            this.ColumnClubsLongName.HeaderText = "Long Name";
            this.ColumnClubsLongName.MinimumWidth = 6;
            this.ColumnClubsLongName.Name = "ColumnClubsLongName";
            // 
            // ColumnClubsShortName
            // 
            this.ColumnClubsShortName.DataPropertyName = "ShortName";
            this.ColumnClubsShortName.HeaderText = "Short Name";
            this.ColumnClubsShortName.MinimumWidth = 6;
            this.ColumnClubsShortName.Name = "ColumnClubsShortName";
            // 
            // ColumnClubsLanguage
            // 
            this.ColumnClubsLanguage.DataPropertyName = "Language";
            this.ColumnClubsLanguage.HeaderText = "Language";
            this.ColumnClubsLanguage.MinimumWidth = 6;
            this.ColumnClubsLanguage.Name = "ColumnClubsLanguage";
            this.ColumnClubsLanguage.Visible = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewStadiums);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1284, 682);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Stadiums";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewStadiums
            // 
            this.dataGridViewStadiums.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStadiums.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStadiums.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnStadiumsID,
            this.ColumnStadiumsName,
            this.ColumnStadiumsLanguage});
            this.dataGridViewStadiums.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStadiums.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewStadiums.Name = "dataGridViewStadiums";
            this.dataGridViewStadiums.RowHeadersWidth = 51;
            this.dataGridViewStadiums.RowTemplate.Height = 29;
            this.dataGridViewStadiums.Size = new System.Drawing.Size(1278, 676);
            this.dataGridViewStadiums.TabIndex = 2;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewNations);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1284, 682);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Nations";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewNations
            // 
            this.dataGridViewNations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNationsID,
            this.ColumnNationsLongName,
            this.ColumnNationsShortName,
            this.ColumnNationsLanguage});
            this.dataGridViewNations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewNations.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewNations.Name = "dataGridViewNations";
            this.dataGridViewNations.RowHeadersWidth = 51;
            this.dataGridViewNations.RowTemplate.Height = 29;
            this.dataGridViewNations.Size = new System.Drawing.Size(1278, 676);
            this.dataGridViewNations.TabIndex = 2;
            // 
            // ColumnNationsID
            // 
            this.ColumnNationsID.DataPropertyName = "Id";
            this.ColumnNationsID.HeaderText = "ID";
            this.ColumnNationsID.MinimumWidth = 6;
            this.ColumnNationsID.Name = "ColumnNationsID";
            // 
            // ColumnNationsLongName
            // 
            this.ColumnNationsLongName.DataPropertyName = "LongName";
            this.ColumnNationsLongName.HeaderText = "Long Name";
            this.ColumnNationsLongName.MinimumWidth = 6;
            this.ColumnNationsLongName.Name = "ColumnNationsLongName";
            // 
            // ColumnNationsShortName
            // 
            this.ColumnNationsShortName.DataPropertyName = "ShortName";
            this.ColumnNationsShortName.HeaderText = "Short Name";
            this.ColumnNationsShortName.MinimumWidth = 6;
            this.ColumnNationsShortName.Name = "ColumnNationsShortName";
            // 
            // ColumnNationsLanguage
            // 
            this.ColumnNationsLanguage.DataPropertyName = "Language";
            this.ColumnNationsLanguage.HeaderText = "Language";
            this.ColumnNationsLanguage.MinimumWidth = 6;
            this.ColumnNationsLanguage.Name = "ColumnNationsLanguage";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridViewCities);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1284, 682);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Cities";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCities
            // 
            this.dataGridViewCities.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCities.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCitiesID,
            this.ColumnCitiesName,
            this.ColumnCitiesLanguage});
            this.dataGridViewCities.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCities.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCities.Name = "dataGridViewCities";
            this.dataGridViewCities.RowHeadersWidth = 51;
            this.dataGridViewCities.RowTemplate.Height = 29;
            this.dataGridViewCities.Size = new System.Drawing.Size(1278, 676);
            this.dataGridViewCities.TabIndex = 3;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.dataGridViewCompetitions);
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(1284, 682);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Competitions";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // dataGridViewCompetitions
            // 
            this.dataGridViewCompetitions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCompetitions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompetitions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnCompetitionsID,
            this.ColumnCompetitionsLongName,
            this.ColumnCompetitionsShortName,
            this.ColumnCompetitionsLanguage});
            this.dataGridViewCompetitions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewCompetitions.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCompetitions.Name = "dataGridViewCompetitions";
            this.dataGridViewCompetitions.RowHeadersWidth = 51;
            this.dataGridViewCompetitions.RowTemplate.Height = 29;
            this.dataGridViewCompetitions.Size = new System.Drawing.Size(1278, 676);
            this.dataGridViewCompetitions.TabIndex = 2;
            // 
            // ColumnCompetitionsID
            // 
            this.ColumnCompetitionsID.DataPropertyName = "Id";
            this.ColumnCompetitionsID.HeaderText = "ID";
            this.ColumnCompetitionsID.MinimumWidth = 6;
            this.ColumnCompetitionsID.Name = "ColumnCompetitionsID";
            // 
            // ColumnCompetitionsLongName
            // 
            this.ColumnCompetitionsLongName.DataPropertyName = "LongName";
            this.ColumnCompetitionsLongName.HeaderText = "Long Name";
            this.ColumnCompetitionsLongName.MinimumWidth = 6;
            this.ColumnCompetitionsLongName.Name = "ColumnCompetitionsLongName";
            // 
            // ColumnCompetitionsShortName
            // 
            this.ColumnCompetitionsShortName.DataPropertyName = "ShortName";
            this.ColumnCompetitionsShortName.HeaderText = "Short Name";
            this.ColumnCompetitionsShortName.MinimumWidth = 6;
            this.ColumnCompetitionsShortName.Name = "ColumnCompetitionsShortName";
            // 
            // ColumnCompetitionsLanguage
            // 
            this.ColumnCompetitionsLanguage.DataPropertyName = "Language";
            this.ColumnCompetitionsLanguage.HeaderText = "Language";
            this.ColumnCompetitionsLanguage.MinimumWidth = 6;
            this.ColumnCompetitionsLanguage.Name = "ColumnCompetitionsLanguage";
            this.ColumnCompetitionsLanguage.Visible = false;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.dataGridViewAwards);
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(1284, 682);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Awards";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAwards
            // 
            this.dataGridViewAwards.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAwards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAwards.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAwardsID,
            this.ColumnAwardsLongName,
            this.ColumnAwardsShortName,
            this.ColumnAwardsLanguage});
            this.dataGridViewAwards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAwards.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewAwards.Name = "dataGridViewAwards";
            this.dataGridViewAwards.RowHeadersWidth = 51;
            this.dataGridViewAwards.RowTemplate.Height = 29;
            this.dataGridViewAwards.Size = new System.Drawing.Size(1278, 676);
            this.dataGridViewAwards.TabIndex = 2;
            // 
            // ColumnAwardsID
            // 
            this.ColumnAwardsID.DataPropertyName = "Id";
            this.ColumnAwardsID.HeaderText = "ID";
            this.ColumnAwardsID.MinimumWidth = 6;
            this.ColumnAwardsID.Name = "ColumnAwardsID";
            // 
            // ColumnAwardsLongName
            // 
            this.ColumnAwardsLongName.DataPropertyName = "LongName";
            this.ColumnAwardsLongName.HeaderText = "Long Name";
            this.ColumnAwardsLongName.MinimumWidth = 6;
            this.ColumnAwardsLongName.Name = "ColumnAwardsLongName";
            // 
            // ColumnAwardsShortName
            // 
            this.ColumnAwardsShortName.DataPropertyName = "ShortName";
            this.ColumnAwardsShortName.HeaderText = "Short Name";
            this.ColumnAwardsShortName.MinimumWidth = 6;
            this.ColumnAwardsShortName.Name = "ColumnAwardsShortName";
            // 
            // ColumnAwardsLanguage
            // 
            this.ColumnAwardsLanguage.DataPropertyName = "Language";
            this.ColumnAwardsLanguage.HeaderText = "Language";
            this.ColumnAwardsLanguage.MinimumWidth = 6;
            this.ColumnAwardsLanguage.Name = "ColumnAwardsLanguage";
            this.ColumnAwardsLanguage.Visible = false;
            // 
            // ColumnStadiumsID
            // 
            this.ColumnStadiumsID.DataPropertyName = "Id";
            this.ColumnStadiumsID.HeaderText = "ID";
            this.ColumnStadiumsID.MinimumWidth = 6;
            this.ColumnStadiumsID.Name = "ColumnStadiumsID";
            // 
            // ColumnStadiumsName
            // 
            this.ColumnStadiumsName.DataPropertyName = "Name";
            this.ColumnStadiumsName.HeaderText = "Name";
            this.ColumnStadiumsName.MinimumWidth = 6;
            this.ColumnStadiumsName.Name = "ColumnStadiumsName";
            // 
            // ColumnStadiumsLanguage
            // 
            this.ColumnStadiumsLanguage.DataPropertyName = "Language";
            this.ColumnStadiumsLanguage.HeaderText = "Language";
            this.ColumnStadiumsLanguage.MinimumWidth = 6;
            this.ColumnStadiumsLanguage.Name = "ColumnStadiumsLanguage";
            // 
            // ColumnCitiesID
            // 
            this.ColumnCitiesID.DataPropertyName = "Id";
            this.ColumnCitiesID.HeaderText = "ID";
            this.ColumnCitiesID.MinimumWidth = 6;
            this.ColumnCitiesID.Name = "ColumnCitiesID";
            // 
            // ColumnCitiesName
            // 
            this.ColumnCitiesName.DataPropertyName = "Name";
            this.ColumnCitiesName.HeaderText = "Name";
            this.ColumnCitiesName.MinimumWidth = 6;
            this.ColumnCitiesName.Name = "ColumnCitiesName";
            // 
            // ColumnCitiesLanguage
            // 
            this.ColumnCitiesLanguage.DataPropertyName = "Language";
            this.ColumnCitiesLanguage.HeaderText = "Language";
            this.ColumnCitiesLanguage.MinimumWidth = 6;
            this.ColumnCitiesLanguage.Name = "ColumnCitiesLanguage";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 742);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.toolStripMain);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FM File Editor";
            this.toolStripMain.ResumeLayout(false);
            this.toolStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayers)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClubs)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStadiums)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNations)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCities)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompetitions)).EndInit();
            this.tabPage7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAwards)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMain;
        private System.Windows.Forms.ToolStripButton toolStripButtonOpen;
        private System.Windows.Forms.ToolStripButton toolStripButtonSave;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewPlayers;
        private System.Windows.Forms.DataGridView dataGridViewClubs;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayersID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayersFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayersCommonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPlayersSecondName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClubsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClubsLongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClubsShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnClubsLanguage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewStadiums;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.DataGridView dataGridViewNations;
        private System.Windows.Forms.DataGridView dataGridViewCities;
        private System.Windows.Forms.DataGridView dataGridViewCompetitions;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompetitionsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompetitionsLongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompetitionsShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCompetitionsLanguage;
        private System.Windows.Forms.DataGridView dataGridViewAwards;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAwardsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAwardsLongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAwardsShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAwardsLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNationsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNationsLongName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNationsShortName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNationsLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStadiumsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStadiumsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStadiumsLanguage;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCitiesID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCitiesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCitiesLanguage;
    }
}

