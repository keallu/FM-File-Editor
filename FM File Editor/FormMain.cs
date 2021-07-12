using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FMFileEditor
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "lnc Files (*.lnc)|*.lnc";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    DataTable players = new();
                    players.Columns.Add("Id", typeof(string));
                    players.Columns.Add("FirstName", typeof(string));
                    players.Columns.Add("CommonName", typeof(string));
                    players.Columns.Add("SecondName", typeof(string));
                    players.PrimaryKey = new DataColumn[] { players.Columns["Id"] };

                    DataTable clubs = new();
                    clubs.Columns.Add("Id", typeof(string));
                    clubs.Columns.Add("LongName", typeof(string));
                    clubs.Columns.Add("ShortName", typeof(string));
                    clubs.Columns.Add("Language", typeof(string));
                    clubs.PrimaryKey = new DataColumn[] { clubs.Columns["Id"] };

                    DataTable stadiums = new();
                    stadiums.Columns.Add("Id", typeof(string));
                    stadiums.Columns.Add("Name", typeof(string));
                    stadiums.Columns.Add("Language", typeof(string));
                    stadiums.PrimaryKey = new DataColumn[] { stadiums.Columns["Id"] };

                    DataTable nations = new();
                    nations.Columns.Add("Id", typeof(string));
                    nations.Columns.Add("LongName", typeof(string));
                    nations.Columns.Add("ShortName", typeof(string));
                    nations.Columns.Add("Language", typeof(string));
                    nations.PrimaryKey = new DataColumn[] { nations.Columns["Id"] };

                    DataTable cities = new();
                    cities.Columns.Add("Id", typeof(string));
                    cities.Columns.Add("Name", typeof(string));
                    cities.Columns.Add("Language", typeof(string));
                    cities.PrimaryKey = new DataColumn[] { cities.Columns["Id"] };

                    DataTable competitions = new();
                    competitions.Columns.Add("Id", typeof(string));
                    competitions.Columns.Add("LongName", typeof(string));
                    competitions.Columns.Add("ShortName", typeof(string));
                    competitions.Columns.Add("Language", typeof(string));
                    competitions.PrimaryKey = new DataColumn[] { competitions.Columns["Id"] };

                    DataTable awards = new();
                    awards.Columns.Add("Id", typeof(string));
                    awards.Columns.Add("LongName", typeof(string));
                    awards.Columns.Add("ShortName", typeof(string));
                    awards.Columns.Add("Language", typeof(string));
                    awards.PrimaryKey = new DataColumn[] { awards.Columns["Id"] };

                    string item;
                    string[] columns;
                    int passed = 0;
                    int failed = 0;

                    foreach (string line in File.ReadAllLines(filePath))
                    {
                        item = line.Trim();

                        if (item.Length > 0)
                        {
                            if (!item.StartsWith("#"))
                            {
                                item = item.Replace("\"", "");

                                columns = item.Split('\t', StringSplitOptions.TrimEntries);

                                if (columns.Length > 3 && columns[1] != "")
                                {
                                    switch (columns[0])
                                    {
                                        case "CHANGE_PLAYER_NAME":
                                            if (AddToDataTable(players, columns, 4, false, ""))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "CLUB_NAME_CHANGE":
                                            if (AddToDataTable(clubs, columns, 3, true, "LongName"))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "CLUB_SHORT_NAME_CHANGE":
                                            if (AddToDataTable(clubs, columns, 3, true, "ShortName"))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "STADIUM_NAME_CHANGE":
                                            if (AddToDataTable(stadiums, columns, 3, false, ""))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "NATION_LONG_NAME_CHANGE":
                                            if (AddToDataTable(nations, columns, 3, true, "LongName"))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "NATION_SHORT_NAME_CHANGE":
                                            if (AddToDataTable(nations, columns, 3, true, "ShortName"))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "CITY_NAME_CHANGE":
                                            if (AddToDataTable(cities, columns, 3, false, ""))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "COMP_LONG_NAME_CHANGE":
                                            if (AddToDataTable(competitions, columns, 3, true, "LongName"))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "COMP_SHORT_NAME_CHANGE":
                                            if (AddToDataTable(competitions, columns, 3, true, "ShortName"))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "AWARD_LONG_NAME_CHANGE":
                                            if (AddToDataTable(awards, columns, 3, true, "LongName"))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        case "AWARD_SHORT_NAME_CHANGE":
                                            if (AddToDataTable(awards, columns, 3, true, "ShortName"))
                                            {
                                                passed++;
                                            }
                                            else
                                            {
                                                failed++;
                                            }

                                            break;
                                        default:

                                            break;
                                    }
                                }
                            }
                        }
                    }

                    dataGridViewPlayers.DataSource = players;
                    dataGridViewClubs.DataSource = clubs;
                    dataGridViewStadiums.DataSource = stadiums;
                    dataGridViewNations.DataSource = nations;
                    dataGridViewCities.DataSource = cities;
                    dataGridViewCompetitions.DataSource = competitions;
                    dataGridViewAwards.DataSource = awards;

                    string message;

                    if (failed > 0)
                    {
                        message = $"{passed} changes was imported while {failed} failed because of syntax error or missing arguments.";
                    }
                    else
                    {
                        message = $"{passed} changes was imported.";
                    }

                    MessageBox.Show(message, "File opened and changes imported");
                }
            }

        }

        private static bool AddToDataTable(DataTable dataTable, string[] columns, int expectedValues, bool multiNaming, string multiNamingLabel)
        {
            if (columns.Length == 1 + expectedValues)
            {
                string[] values;
                DataRow row;

                values = new string[expectedValues];
                Array.Copy(columns, 1, values, 0, expectedValues);

                row = dataTable.Rows.Find(values[0]);

                if (row == null)
                {
                    dataTable.Rows.Add(values);
                }
                else if (multiNaming)
                {
                    row[multiNamingLabel] = values[1];
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            Stream stream;
            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "lnc Files(*.lnc)| *.lnc";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    using (StreamWriter streamWriter = new StreamWriter(stream))
                    {
                        WriteDataGridViewToFile(streamWriter, dataGridViewPlayers, "CHANGE_PLAYER_NAME");
                        WriteMultiNamingDataGridViewToFile(streamWriter, dataGridViewClubs, "CLUB_NAME_CHANGE", "CLUB_SHORT_NAME_CHANGE");
                        WriteDataGridViewToFile(streamWriter, dataGridViewStadiums, "STADIUM_NAME_CHANGE");
                        WriteMultiNamingDataGridViewToFile(streamWriter, dataGridViewNations, "NATION_LONG_NAME_CHANGE", "NATION_SHORT_NAME_CHANGE");
                        WriteDataGridViewToFile(streamWriter, dataGridViewCities, "CITY_NAME_CHANGE");
                        WriteMultiNamingDataGridViewToFile(streamWriter, dataGridViewCompetitions, "COMP_LONG_NAME_CHANGE", "COMP_SHORT_NAME_CHANGE");
                        WriteMultiNamingDataGridViewToFile(streamWriter, dataGridViewAwards, "AWARD_LONG_NAME_CHANGE", "AWARD_SHORT_NAME_CHANGE");
                    }

                    stream.Close();
                }
            }
        }

        private static void WriteDataGridViewToFile(StreamWriter streamWriter, DataGridView dataGridView, string change)
        {
            string value;
            string line;

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                line = "\"" + change + "\"";

                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    value = j != 0 ? "\"" + dataGridView.Rows[i].Cells[j].EditedFormattedValue.ToString() + "\"" : dataGridView.Rows[i].Cells[j].EditedFormattedValue.ToString();

                    line += '\t' + value;
                }

                streamWriter.WriteLine(line);
            }
        }

        private static void WriteMultiNamingDataGridViewToFile(StreamWriter streamWriter, DataGridView dataGridView, string changeLong, string changeShort)
        {
            string value;
            string lineLong;
            string lineShort;

            for (int i = 0; i < dataGridView.Rows.Count - 1; i++)
            {
                lineLong = "\"" + changeLong + "\"";
                lineShort = "\"" + changeShort + "\"";

                for (int j = 0; j < dataGridView.Columns.Count; j++)
                {
                    value = j != 0 ? "\"" + dataGridView.Rows[i].Cells[j].EditedFormattedValue.ToString() + "\"" : dataGridView.Rows[i].Cells[j].EditedFormattedValue.ToString();

                    if (j != 2)
                    {
                        lineLong += '\t' + value;
                    }
                    if (j != 1)
                    {
                        lineShort += '\t' + value;
                    }
                }

                streamWriter.WriteLine(lineLong);
                streamWriter.WriteLine(lineShort);
            }
        }
    }
}
