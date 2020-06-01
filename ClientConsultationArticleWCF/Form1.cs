using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientConsultationArticleWCF.ServiceReference1;


namespace ClientConsultationArticleWCF
{
    public partial class Form1 : Form
    {
        private List<article> allArticles,selectedArticles;
        private ConsultationArticlesWebServiceClient service;
        public Form1()
        {
        InitializeComponent();
        service = new ConsultationArticlesWebServiceClient();
        allArticles = service.getAllArticles().ToList();
        selectedArticles = allArticles;
        dataGridView1.DataSource = allArticles;
        }

        private void dataGridView1_CurrentCellChanged(object sender, EventArgs e)
        {
        if (dataGridView1.SelectedCells.Count > 0) richTextBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        if (dataGridView1.SelectedCells.Count > 0) richTextBox1.Text = dataGridView1.SelectedCells[0].Value.ToString();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try { 
        selectedArticles = (List<article>)dataGridView1.DataSource;
        service.setArticles(selectedArticles.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de sauvegarde   " + ex.Message);

            }
        }

        private void likes_Click(object sender, EventArgs e)
        { 
            try { 
        dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value =
                Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString()) + 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur selectionnez toute la ligne pour faire un like   " + ex.Message);

            }

        }

        private void dislikes_Click(object sender, EventArgs e)
        {
            try { 
        dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value = 
                Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString())+1;

            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur selectionnez toute la ligne pour faire un dislike   " + ex.Message);

            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
        this.Close();
        }

        private void displayall_Click(object sender, EventArgs e)
        {
            try { 
        dataGridView1.DataSource = allArticles;
        selectedArticles = allArticles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur affichage   " + ex.Message);

            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            try { 
        allArticles = service.getAllArticles().ToList();
        dataGridView1.DataSource = allArticles;
        selectedArticles = allArticles;
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur actualisation   " + ex.Message);

            }
        }

        private void searchMode_CheckStateChanged(object sender, EventArgs e)
        {
            if (searchMode.Checked) { search.Text = "DB Search"; }
            else { search.Text = "local Search"; }
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                if (searchMode.Checked) { selectedArticles = service.getArticles(textBox1.Text).ToList(); }
                else { selectedArticles = service.getLocalSearch(textBox1.Text, allArticles.ToArray()).ToList(); }
                dataGridView1.DataSource = selectedArticles;
                dataGridView1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erreur de recherche   "+ ex.Message);
   
            }
         
        }
    }
}
