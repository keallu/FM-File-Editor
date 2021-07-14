using System;
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

        private void toolStripButtonNew_Click(object sender, EventArgs e)
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

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Filter = "lnc Files (*.lnc)|*.lnc";

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
                    int passed = 0;
                    int failed = 0;

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

                    Text = $"FM File Editor - {filePath}";

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
                    row["Language"] = values[expectedValues - 1];
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
            SaveFileDialog saveFileDialog = new();

            saveFileDialog.Filter = "lnc Files (*.lnc)| *.lnc";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if ((stream = saveFileDialog.OpenFile()) != null)
                {
                    using (StreamWriter streamWriter = new(stream))
                    {
                        WriteDataTableToFile(streamWriter, players, "CHANGE_PLAYER_NAME");
                        WriteDataTableToFile(streamWriter, clubs, "CLUB_NAME_CHANGE", "CLUB_SHORT_NAME_CHANGE");
                        WriteDataTableToFile(streamWriter, stadiums, "STADIUM_NAME_CHANGE");
                        WriteDataTableToFile(streamWriter, nations, "NATION_LONG_NAME_CHANGE", "NATION_SHORT_NAME_CHANGE");
                        WriteDataTableToFile(streamWriter, cities, "CITY_NAME_CHANGE");
                        WriteDataTableToFile(streamWriter, competitions, "COMP_LONG_NAME_CHANGE", "COMP_SHORT_NAME_CHANGE");
                        WriteDataTableToFile(streamWriter, awards, "AWARD_LONG_NAME_CHANGE", "AWARD_SHORT_NAME_CHANGE");
                    }

                    stream.Close();
                }

                Text = $"FM File Editor - {saveFileDialog.FileName}";
            }
        }

        private static void WriteDataTableToFile(StreamWriter streamWriter, DataTable dataTable, string change1, string change2 = null)
        {
            string value;
            string line1;
            string line2;

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                line1 = "\"" + change1 + "\"";
                line2 = "\"" + change2 + "\"";

                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    value = j != 0 ? "\"" + dataTable.Rows[i].ItemArray[j].ToString().Trim() + "\"" : dataTable.Rows[i].ItemArray[j].ToString().Trim();

                    if (change2 != null)
                    {
                        if (j != 2)
                        {
                            line1 += '\t' + value;
                        }
                        if (j != 1)
                        {
                            line2 += '\t' + value;
                        }
                    }
                    else
                    {
                        line1 += '\t' + value;
                    }
                }

                if (change2 != null)
                {
                    streamWriter.WriteLine(line1);
                    streamWriter.WriteLine(line2);
                }
                else
                {
                    streamWriter.WriteLine(line1);
                }
            }
        }
    }
}
