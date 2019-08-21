using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using System.Net;
using Newtonsoft.Json;
using System.IO;
using System.Diagnostics;

namespace FilmDB
{
    public partial class MainForm : Form
    {
        ContextMenu rightClickMenu = new ContextMenu();
        MenuItem deleteRow = new MenuItem();

        public MainForm()
        {
            InitializeComponent();
            // Display Film Table
            RefreshFilmView();
            // Populate years
            PopulateYearDropDown();
            // Init menu
            rightClickMenu.MenuItems.Add(deleteRow);
            rightClickMenu.MenuItems[0].Click += new System.EventHandler(this.deleteRow_Click);
            // Init info view
            info_TitleAndYear.Text = Convert.ToString(FilmTable.Rows[0].Cells["TITLE"].Value + " (" + FilmTable.Rows[0].Cells["YEAR"].Value + ")");
            info_Director.Text = Convert.ToString(FilmTable.Rows[0].Cells["DIRECTOR"].Value);
            info_Plot.Text = Convert.ToString(FilmTable.Rows[0].Cells["PLOT"].Value);
            btn_ViewImdb.Text = "IMDB: www.imdb.com/title/" + Convert.ToString(FilmTable.Rows[0].Cells["IMDB_ID"].Value);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_AddFilm_Click(object sender, EventArgs e)
        {
            // Read and validate 
            string name = txt_FilmName.Text;
            string year = cmb_Year.Text;

            // Add film to db
            DatabaseOperations.AddFilm(name,year);
            RefreshFilmView();
        }

        private void PopulateYearDropDown()
        {
            for (int i = 2016; i >=1900 ; i--)
            {
                cmb_Year.Items.Add(i.ToString());
            }
        }

        private void RefreshFilmView()
        {
            FilmTable.DataSource = DatabaseOperations.ShowAllFilms();
        }

        private void UpdateInfo(string location, string title, string year, string director, string plot, string imdb)
        {
            posterBox.ImageLocation = (location != "N/A") ? location : "";
            
            title = (title.Length > 20) ? title.Substring(0,20) + "..." : title;
            info_TitleAndYear.Text = title + " (" + year + ")";
            info_Director.Text = director;
            info_Plot.Text = plot;
            btn_ViewImdb.Text = "IMDB: www.imdb.com/title/" + imdb;
        }

        private void FilmTable_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            // Retrieve poster location
            if (e.RowIndex < FilmTable.Rows.Count-1)
            {
                UpdateInfo(FilmTable.Rows[e.RowIndex].Cells["POSTER"].Value.ToString(),
                  FilmTable.Rows[e.RowIndex].Cells["TITLE"].Value.ToString(),
                  FilmTable.Rows[e.RowIndex].Cells["YEAR"].Value.ToString(),
                  FilmTable.Rows[e.RowIndex].Cells["DIRECTOR"].Value.ToString(),
                  FilmTable.Rows[e.RowIndex].Cells["PLOT"].Value.ToString(),
                  FilmTable.Rows[e.RowIndex].Cells["IMDB_ID"].Value.ToString());  
            } 
        }

        // Button Functions

        private void btn_Search_Click(object sender, EventArgs e)
        {
            if (txt_Search.Text != "" && cmb_SearchType.Text != "")
            {
                DatabaseOperations.Search(txt_Search.Text, cmb_SearchType.Text, FilmTable);
            }
        }

        private void btn_ViewAll_Click(object sender, EventArgs e)
        {
            RefreshFilmView();
        }

        private void FilmTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int mouseOverRow = FilmTable.HitTest(e.X, e.Y).RowIndex;
                if (mouseOverRow >= 0)
                {
                    rightClickMenu.MenuItems[0].Text = string.Format("Delete " 
                        + FilmTable.Rows[mouseOverRow].Cells["TITLE"].Value
                        + " (" + FilmTable.Rows[mouseOverRow].Cells["YEAR"].Value + ") ID : " 
                        + FilmTable.Rows[mouseOverRow].Cells["ID"].Value, mouseOverRow.ToString());

                }
                rightClickMenu.Show(FilmTable, new Point(e.X, e.Y));
            }
        }

        private void deleteRow_Click(object sender, System.EventArgs e)
        {
            MenuItem deleteObj = (MenuItem)sender;
            string[] menuText = deleteObj.Text.Split(new char[] { ':' });
            string filmId = menuText[1].Replace(" ", "");
            DatabaseOperations.RemoveFilm(filmId);
            RefreshFilmView();
        }

        private void btn_ViewImdb_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Process.Start("chrome.exe", btn.Text.Replace("IMDB: ",""));
        }

        private void btn_ViewImdb_MouseEnter(object sender, EventArgs e)
        {
            ButtonStyleEnter(sender);
        }

        private void btn_ViewImdb_MouseLeave(object sender, EventArgs e)
        {
            ButtonStyleLeave(sender);
        }

        private void btn_Search_MouseEnter(object sender, EventArgs e)
        {
            ButtonStyleEnter(sender);
        }

        private void btn_Search_MouseLeave(object sender, EventArgs e)
        {
            ButtonStyleLeave(sender);
        }

        private void btn_ViewAll_MouseEnter(object sender, EventArgs e)
        {
            ButtonStyleEnter(sender);
        }

        private void btn_ViewAll_MouseLeave(object sender, EventArgs e)
        {
            ButtonStyleLeave(sender);
        }

        private void btn_AddFilm_MouseEnter(object sender, EventArgs e)
        {
            ButtonStyleEnter(sender);
        }

        private void btn_AddFilm_MouseLeave(object sender, EventArgs e)
        {
            ButtonStyleLeave(sender);
        }

        private void ButtonStyleEnter(object sender)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Black;
            btn.ForeColor = Color.White; 
        }

        private void ButtonStyleLeave(object sender){
            Button btn = (Button)sender;
            btn.BackColor = Color.DimGray;
            btn.ForeColor = Color.White; 
        }
    
    }

    public static class DatabaseOperations
    {
        public static string conn_string = "Data Source=(LocalDB)\\v11.0;Initial Catalog=\"C:\\USERS\\JCOOKE\\DOCUMENTS\\VISUAL STUDIO 2013\\PROJECTS\\FILMDB\\FILMDB\\FILMDATABASE.MDF\";Integrated Security=True;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        public static DataTable ShowAllFilms()
        {
            // Show all films in film table
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM films;",conn);
                DataTable output = new DataTable();
                dataAdapter.Fill(output);
                return output;
            }
        }

        public static void AddFilm(string film, string year){

            // Add film to Films table
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                if (FilmExists(film, year) == false)
                {
                    try
                    {
                        Film newFilm = ApiOperations.FilmRequest(film, year);

                        string query = "INSERT INTO films (TITLE, YEAR, DIRECTOR, WRITER, GENRE, PLOT, POSTER, IMDB_RATING, IMDB_ID) VALUES " +
                            "(" +
                                "'" + newFilm.title.Replace("'","''") + "'," +
                                "'" + newFilm.year + "'," +
                                "'" + newFilm.director.Replace("'", "''") + "'," +
                                "'" + newFilm.writer.Replace("'", "''") + "'," +
                                "'" + newFilm.genre + "'," +
                                "'" + newFilm.plot.Replace("'", "''") + "'," +
                                "'" + newFilm.poster + "'," +
                                "'" + newFilm.imdbRating + "'," +
                                "'" + newFilm.imdbId + "'" +
                            ");";

                        using (SqlCommand cmd = new SqlCommand(query,conn))
                        {
                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (SqlException sql_ex)
                    {
                        MessageBox.Show(sql_ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("'" + film + "' already exists.");
                }
                conn.Close();
            }
        }

        public static void RemoveFilm(string filmId)
        {
            // Remove film
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                try
                {
                    string query = "DELETE FROM films WHERE ID = " + filmId + ";";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
                catch (SqlException sql_ex)
                {
                    MessageBox.Show(sql_ex.Message);
                }
                conn.Close();
            }
        }

        public static bool FilmExists(string film, string year)
        {
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT title, year FROM films WHERE title = '" + film + "' AND year = '" + year + "';", conn);
                SqlDataReader result = cmd.ExecuteReader();
                return result.HasRows;
            }
        }

        public static void Search(string query, string column, DataGridView FilmTable)
        {
            bool searchResult = false;
            using (SqlConnection conn = new SqlConnection(conn_string))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM films WHERE " + column + " LIKE '%" + query + "%';", conn);
                DataTable result = new DataTable();
                adapter.Fill(result);
                searchResult = (result.Rows.Count > 0) ? true : false;
                if (searchResult)
                {
                    FilmTable.DataSource = result;
                }
            }
  
        }
    }

    public static class ApiOperations
    {
        public static Film FilmRequest(string film, string year){
            
            Film retrievedFilm = new Film();
            
            try
            {
                // Retrieve film from api
                string url = "http://www.omdbapi.com/?t=" + film + "&y=" + year + "&plot=long&type=movie&r=json";
                WebResponse response = WebRequest.Create(url).GetResponse();    
                using(StreamReader reader = new StreamReader(response.GetResponseStream()))
	            {
                    var jsonObject = JsonConvert.DeserializeObject<dynamic>(reader.ReadToEnd());
                    retrievedFilm.title = jsonObject.Title;
                    retrievedFilm.year = jsonObject.Year;
                    retrievedFilm.director = jsonObject.Director;
                    retrievedFilm.writer = jsonObject.Writer;
                    retrievedFilm.genre = jsonObject.Genre;
                    retrievedFilm.plot = jsonObject.Plot;
                    retrievedFilm.poster = jsonObject.Poster;
                    retrievedFilm.imdbRating = jsonObject.imdbRating;
                    retrievedFilm.imdbId = jsonObject.imdbID;
	            }
            }
            catch (WebException web_ex)
            {
                MessageBox.Show(web_ex.Message);    
            }

            return retrievedFilm;
        }

    }

    public class Film
    {
        public string title;
        public int year;
        public string director;
        public string writer;
        public string genre;
        public string plot;
        public string poster;
        public double imdbRating;
        public string imdbId;
    }
}
