using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru1
{
    public partial class Form1 : Form
    {
        public string[] headerlabels;
        public DataTable dt = new DataTable();
        public DataTable dt2 = new DataTable();
        public DataTable dt3 = new DataTable();
        public DataTable dt4 = new DataTable();
        public double guc1; //Fight'ta hesaplanacak olan güç
        public double guc2; //Fight'ta hesaplanacak olan güç
        public Form1()
        {
            InitializeComponent();
        }

        private void btnParseDisplay_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            txtFilePath.Text = openFileDialog1.FileName;
            BindDataCSV(txtFilePath.Text);
        }

        //Dosyayı tabloya bağlamak için oluşturduğum fonksiyon
        private void BindDataCSV(string filepath)
        {
            string[] lines = System.IO.File.ReadAllLines(filepath);
            if (lines.Length > 0)
            {
                //Headerları atamak için
                string firstline = lines[0];
                headerlabels = firstline.Split(',');

                foreach (string headerword in headerlabels)
                {
                    dt.Columns.Add(new DataColumn(headerword));
                    dt2.Columns.Add(new DataColumn(headerword));
                    dt3.Columns.Add(new DataColumn(headerword));
                    dt4.Columns.Add(new DataColumn(headerword));
                }

                //verileri atamak için
                for (int r = 1; r < lines.Length; r++)
                {
                    string[] dataWords = lines[r].Split(',');
                    DataRow dr = dt.NewRow();
                    int columnIndex = 0;

                    //Burada düzgün sıralaması için datagride int olarak atamayı denedim
                    //ancak datatable'dan datagride atarken program tekrar stringe çeviriyor
                    /*dr[0] = Convert.ToInt32(dataWords[0]);
                    dr[1] = dataWords[1]; 
                    dr[2] = dataWords[2];
                    dr[3] = dataWords[3];
                    dr[4] = Convert.ToInt32(dataWords[4]);
                    dr[5] = Convert.ToInt32(dataWords[5]);
                    dr[6] = Convert.ToInt32(dataWords[6]);
                    dr[7] = Convert.ToInt32(dataWords[7]);
                    dr[8] = Convert.ToInt32(dataWords[8]);
                    dr[9] = Convert.ToInt32(dataWords[9]);
                    dr[10] = Convert.ToInt32(dataWords[10]);
                    dr[11] = Convert.ToInt32(dataWords[11]);
                    dr[12] = dataWords[12];
                    */

                    
                    foreach (string headerword in headerlabels)
                    {
                        dr[headerword] = dataWords[columnIndex];
                        columnIndex++;
                    }
                    dt.Rows.Add(dr);
                }
            }
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
        }

        //Filtreleme
        private void btnFiltre_Click(object sender, EventArgs e)
        {
            if ((txtFiltreMin.Text != "") && (txtFiltreMax.Text != ""))
            {
                

                for (int r1 = 0; r1 < dt.Rows.Count; r1++)
                {
                    if ((kriterFiltre.SelectedIndex == 1) || (kriterFiltre.SelectedIndex == 2) || (kriterFiltre.SelectedIndex == 3) || (kriterFiltre.SelectedIndex == 12))
                    {
                        if ((dt.Rows[r1][kriterFiltre.SelectedIndex].ToString().CompareTo(txtFiltreMin.Text) >= 0) && (dt.Rows[r1][kriterFiltre.SelectedIndex].ToString().CompareTo(txtFiltreMax.Text) <= 0))
                        {
                            DataRow row1 = dt2.NewRow();
                            foreach (string headerword in headerlabels)
                            {
                                row1[headerword] = dt.Rows[r1][headerword];
                            }

                            dt2.Rows.Add(row1);
                        }
                    }

                    else if ((kriterFiltre.SelectedIndex == 0) || (kriterFiltre.SelectedIndex == 4) || (kriterFiltre.SelectedIndex == 5) || (kriterFiltre.SelectedIndex == 6) || (kriterFiltre.SelectedIndex == 7) || (kriterFiltre.SelectedIndex == 8) || (kriterFiltre.SelectedIndex == 9) || (kriterFiltre.SelectedIndex == 10) || (kriterFiltre.SelectedIndex == 11))
                    {
                        int hucre = Convert.ToInt32(dt.Rows[r1][kriterFiltre.SelectedIndex]);
                        int filtremin = Convert.ToInt32(txtFiltreMin.Text);
                        int filtremax = Convert.ToInt32(txtFiltreMax.Text);
                        if ((hucre >= filtremin) && (hucre <= filtremax))
                        {
                            DataRow row2 = dt2.NewRow();
                            foreach (string headerword in headerlabels)
                            {
                                row2[headerword] = dt.Rows[r1][headerword];
                            }

                            dt2.Rows.Add(row2);
                        }
                    }
                }
                dataGridView1.DataSource = dt2;
            }
            else
            {
                txtError.Text = "Lütfen iki kutucuğa da değer giriniz";
            }
        }
         //Arama
        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAramaGirdi.Text != "")
            {
                for (int r2 = 0; r2 < dt.Rows.Count; r2++)
                {
                    if (dt.Rows[r2][kriterAra.SelectedIndex].ToString() == txtAramaGirdi.Text)
                    {
                        DataRow row3 = dt3.NewRow();
                        foreach (string headerword in headerlabels)
                        {
                            row3[headerword] = dt.Rows[r2][headerword];
                        }
                        dt3.Rows.Add(row3);
                    }

                }

                dataGridView1.DataSource = dt3;
            }
            else
            {
                txtError.Text = "Lütfen bir arama girdisi giriniz";
            }
        }

        //Kapıştırma
        private void btnFight_Click(object sender, EventArgs e)
        {
            if ((txtPokeName1.Text != "") && (txtPokeName2.Text != ""))
            {
                for (int r3 = 0; r3 < dt.Rows.Count; r3++)
                {
                    if (dt.Rows[r3][1].ToString() == txtPokeName1.Text)
                    {
                         guc1 = 0.2 * Convert.ToInt32(dt.Rows[r3][5].ToString()) + 0.25 * Convert.ToInt32(dt.Rows[r3][6].ToString())
                            + 0.25 * Convert.ToInt32(dt.Rows[r3][7].ToString()) + 0.1 * Convert.ToInt32(dt.Rows[r3][8].ToString())
                            + 0.1 * Convert.ToInt32(dt.Rows[r3][9].ToString()) + 0.1 * Convert.ToInt32(dt.Rows[r3][10].ToString());
                    }
                }

                for (int r4 = 0; r4 < dt.Rows.Count; r4++)
                {
                    if (dt.Rows[r4][1].ToString() == txtPokeName2.Text)
                    {
                         guc2 = 0.2 * Convert.ToInt32(dt.Rows[r4][5].ToString()) + 0.25 * Convert.ToInt32(dt.Rows[r4][6].ToString())
                            + 0.25 * Convert.ToInt32(dt.Rows[r4][7].ToString()) + 0.1 * Convert.ToInt32(dt.Rows[r4][8].ToString())
                            + 0.1 * Convert.ToInt32(dt.Rows[r4][9].ToString()) + 0.1 * Convert.ToInt32(dt.Rows[r4][10].ToString());
                    }
                }

                if (guc1 > guc2)
                {
                    txtFightResult.Text = txtPokeName1.Text + " Wins!";
                }

                else if (guc2 > guc1)
                {
                    txtFightResult.Text = txtPokeName2.Text + " Wins!";
                }

                else if (guc1 == guc2)
                {
                    txtFightResult.Text = "Tie!";
                }
            }

            else
            {
                txtError.Text = "Lütfen iki kutucuğa da isim giriniz";
            }
        }

        //Reset
        private void btnReset_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
        }

        
    }
}
