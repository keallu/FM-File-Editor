using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FMFileEditor
{
    public partial class FormMain : Form
    {
        private DataTable players;
        private DataTable clubs;
        private DataTable stadiums;
        private DataTable nations;
        private DataTable cities;
        private DataTable competitions;
        private DataTable awards;

        public FormMain()
        {
            InitializeComponent();

            Init();
        }

        private void Init()
        {
            players = new();
            players.Columns.Add("Id", typeof(string));
            players.Columns.Add("FirstName", typeof(string));
            players.Columns.Add("CommonName", typeof(string));
            players.Columns.Add("SecondName", typeof(string));
            players.PrimaryKey = new DataColumn[] { players.Columns["Id"] };

            clubs = new();
            clubs.Columns.Add("Id", typeof(string));
            clubs.Columns.Add("LongName", typeof(string));
            clubs.Columns.Add("ShortName", typeof(string));
            clubs.Columns.Add("SixLetterName", typeof(string));
            clubs.Columns.Add("Language", typeof(string));
            clubs.PrimaryKey = new DataColumn[] { clubs.Columns["Id"] };

            stadiums = new();
            stadiums.Columns.Add("Id", typeof(string));
            stadiums.Columns.Add("Name", typeof(string));
            stadiums.Columns.Add("Language", typeof(string));
            stadiums.PrimaryKey = new DataColumn[] { stadiums.Columns["Id"] };

            nations = new();
            nations.Columns.Add("Id", typeof(string));
            nations.Columns.Add("LongName", typeof(string));
            nations.Columns.Add("ShortName", typeof(string));
            nations.Columns.Add("Language", typeof(string));
            nations.PrimaryKey = new DataColumn[] { nations.Columns["Id"] };

            cities = new();
            cities.Columns.Add("Id", typeof(string));
            cities.Columns.Add("Name", typeof(string));
            cities.Columns.Add("Language", typeof(string));
            cities.PrimaryKey = new DataColumn[] { cities.Columns["Id"] };

            competitions = new();
            competitions.Columns.Add("Id", typeof(string));
            competitions.Columns.Add("LongName", typeof(string));
            competitions.Columns.Add("ShortName", typeof(string));
            competitions.Columns.Add("SixLetterName", typeof(string));
            competitions.Columns.Add("Language", typeof(string));
            competitions.PrimaryKey = new DataColumn[] { competitions.Columns["Id"] };

            awards = new();
            awards.Columns.Add("Id", typeof(string));
            awards.Columns.Add("LongName", typeof(string));
            awards.Columns.Add("ShortName", typeof(string));
            awards.Columns.Add("Language", typeof(string));
            awards.PrimaryKey = new DataColumn[] { awards.Columns["Id"] };

            dataGridViewPlayers.DataSource = players;
            dataGridViewClubs.DataSource = clubs;
            dataGridViewStadiums.DataSource = stadiums;
            dataGridViewNations.DataSource = nations;
            dataGridViewCities.DataSource = cities;
            dataGridViewCompetitions.DataSource = competitions;
            dataGridViewAwards.DataSource = awards;
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            Properties.Settings.Default.Upgrade();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void analyzerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form analyzer = new FormAnalyzer();
            analyzer.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form options = new FormOptions();
            options.ShowDialog();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form checkForUpdates = new FormCheckForUpdates();
            checkForUpdates.ShowDialog();
        }

        private void releaseNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form releaseNotes = new FormReleaseNotes();
            releaseNotes.ShowDialog();
        }

        private void aboutFMFileEditorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form about = new FormAbout();
            about.ShowDialog();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            NewFile();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void toolStripMenuItemMainInsert_Click(object sender, EventArgs e)
        {
            if (ActiveForm.ActiveControl is DataGridView)
            {
                DataGridView dataGridView = ActiveForm.ActiveControl as DataGridView;
                DataTable dataTable = dataGridView.DataSource as DataTable;

                DataRow row = dataTable.NewRow();
                row["Id"] = "";

                dataTable.Rows.InsertAt(row, dataGridView.CurrentRow.Index);
            }
        }

        private void toolStripMenuItemMainDelete_Click(object sender, EventArgs e)
        {
            if (ActiveForm.ActiveControl is DataGridView)
            {
                DataGridView dataGridView = ActiveForm.ActiveControl as DataGridView;
                DataTable dataTable = dataGridView.DataSource as DataTable;

                dataTable.Rows.RemoveAt(dataGridView.CurrentRow.Index);
            }
        }

        private void NewFile()
        {
            players.Clear();
            clubs.Clear();
            stadiums.Clear();
            nations.Clear();
            cities.Clear();
            competitions.Clear();
            awards.Clear();

            Text = $"FM File Editor";
        }

        private void OpenFile()
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Title = "Open";
                openFileDialog.Filter = "lnc Files (*.lnc)|*.lnc";
                openFileDialog.InitialDirectory = Properties.Settings.Default.DefaultFilePath;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    players.Clear();
                    clubs.Clear();
                    stadiums.Clear();
                    nations.Clear();
                    cities.Clear();
                    competitions.Clear();
                    awards.Clear();

                    string[] columns;
                    List<string> failedLines = new();

                    foreach (string line in File.ReadAllLines(filePath))
                    {
                        if (line.Length > 0)
                        {
                            if (!line.StartsWith("#"))
                            {
                                columns = line.Replace("\t", "").Split('"')
                                    .Select((element, index) => index % 2 == 0 ? element.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries) : new string[] { element })
                                    .SelectMany(element => element).ToArray();

                                if (columns.Length > 3 && columns[1] != "")
                                {
                                    switch (columns[0])
                                    {
                                        case "CHANGE_PLAYER_NAME":
                                            if (!AddToDataTable(players, columns, 4, false))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "CLUB_NAME_CHANGE":
                                        case "CLUB_LONG_NAME_CHANGE":
                                            if (!AddToDataTable(clubs, columns, 3, true, "LongName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "CLUB_SHORT_NAME_CHANGE":
                                            if (!AddToDataTable(clubs, columns, 3, true, "ShortName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "CLUB_6LETTER_NAME_CHANGE":
                                            if (!AddToDataTable(clubs, columns, 3, true, "SixLetterName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "STADIUM_NAME_CHANGE":
                                            if (!AddToDataTable(stadiums, columns, 3, false))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "NATION_NAME_CHANGE":
                                        case "NATION_LONG_NAME_CHANGE":
                                            if (!AddToDataTable(nations, columns, 3, true, "LongName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "NATION_SHORT_NAME_CHANGE":
                                            if (!AddToDataTable(nations, columns, 3, true, "ShortName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "CITY_NAME_CHANGE":
                                            if (!AddToDataTable(cities, columns, 3, false))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "COMP_NAME_CHANGE":
                                        case "COMP_LONG_NAME_CHANGE":
                                            if (!AddToDataTable(competitions, columns, 3, true, "LongName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "COMP_SHORT_NAME_CHANGE":
                                            if (!AddToDataTable(competitions, columns, 3, true, "ShortName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "COMP_6LETTER_NAME_CHANGE":
                                            if (!AddToDataTable(competitions, columns, 3, true, "SixLetterName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "AWARD_NAME_CHANGE":
                                        case "AWARD_LONG_NAME_CHANGE":
                                            if (!AddToDataTable(awards, columns, 3, true, "LongName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        case "AWARD_SHORT_NAME_CHANGE":
                                            if (!AddToDataTable(awards, columns, 3, true, "ShortName"))
                                            {
                                                failedLines.Add(line);
                                            }
                                            break;
                                        default:
                                            failedLines.Add(line);
                                            break;
                                    }
                                }
                                else
                                {
                                    failedLines.Add(line);
                                }
                            }
                        }
                    }

                    Text = $"FM File Editor - {filePath}";

                    if (failedLines.Count > 0)
                    {
                        Form error = new FormError(failedLines);
                        error.ShowDialog();
                    }
                }
            }
        }

        private static bool AddToDataTable(DataTable dataTable, string[] columns, int expectedValues, bool multiCommand = false, string multiCommandLabel = null)
        {
            if (columns.Length == 1 + expectedValues)
            {
                string[] values;
                DataRow row;

                values = new string[expectedValues];
                Array.Copy(columns, 1, values, 0, expectedValues);

                row = dataTable.Rows.Find(values[0]);

                if (multiCommand)
                {
                    if (row == null)
                    {
                        row = dataTable.NewRow();
                        row["Id"] = values[0];
                        dataTable.Rows.Add(row);
                    }

                    row[multiCommandLabel] = values[1];
                    row["Language"] = values[expectedValues - 1];
                }
                else
                {
                    if (row == null)
                    {
                        dataTable.Rows.Add(values);
                    }
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private void SaveFile()
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new();

            saveFileDialog.Title = "Save";
            saveFileDialog.Filter = "lnc Files (*.lnc)| *.lnc";
            saveFileDialog.InitialDirectory = Properties.Settings.Default.DefaultFilePath;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    using (StreamWriter streamWriter = new(stream))
                    {
                        WriteDataTableToFile(streamWriter, players, new string[] { "CHANGE_PLAYER_NAME" });
                        WriteDataTableToFile(streamWriter, clubs, new string[] { "CLUB_LONG_NAME_CHANGE", "CLUB_SHORT_NAME_CHANGE", "CLUB_6LETTER_NAME_CHANGE" });
                        WriteDataTableToFile(streamWriter, stadiums, new string[] { "STADIUM_NAME_CHANGE" });
                        WriteDataTableToFile(streamWriter, nations, new string[] { "NATION_LONG_NAME_CHANGE", "NATION_SHORT_NAME_CHANGE" });
                        WriteDataTableToFile(streamWriter, cities, new string[] { "CITY_NAME_CHANGE" });
                        WriteDataTableToFile(streamWriter, competitions, new string[] { "COMP_LONG_NAME_CHANGE", "COMP_SHORT_NAME_CHANGE", "COMP_6LETTER_NAME_CHANGE" });
                        WriteDataTableToFile(streamWriter, awards, new string[] { "AWARD_LONG_NAME_CHANGE", "AWARD_SHORT_NAME_CHANGE" });
                    }

                    stream.Close();
                }

                Text = $"FM File Editor - {saveFileDialog.FileName}";
            }
        }

        private static void WriteDataTableToFile(StreamWriter streamWriter, DataTable dataTable, string[] commands)
        {
            string value;
            List<string> lines = new();
            char delimiter = Properties.Settings.Default.Delimiter == 0 ? '\t' : ' ';

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                lines.Clear();

                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    value = j != 0 ? "\"" + dataTable.Rows[i].ItemArray[j].ToString().Replace("\"", "").Trim() + "\"" : dataTable.Rows[i].ItemArray[j].ToString().Replace("\"", "").Trim();

                    for (int k = 0; k < commands.Length; k++)
                    {
                        if (j == 0)
                        {
                            lines.Add("\"" + commands[k] + "\"");
                        }

                        if (commands.Length > 1)
                        {
                            if (j == 0 || j == k + 1 || j > commands.Length)
                            {
                                lines[k] += delimiter + value;

                                if (value == "\"\"" && j <= commands.Length)
                                {
                                    lines[k] = "#" + lines[k];
                                }
                            }
                        }
                        else
                        {
                            lines[k] += delimiter + value;
                        }
                    }
                }

                foreach (string line in lines)
                {
                    if (!line.StartsWith("#"))
                    {
                        streamWriter.WriteLine(line);
                    }
                }
            }
        }

        private void Exit()
        {
            Application.Exit();
        }
    }
}
