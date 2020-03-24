using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NatAbb_MediaPlayer
{
    public partial class NatAbbPhoneBook : Form
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public NatAbbPhoneBook()
        {
            InitializeComponent();
        }

        private void ViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.Phones;
            dataGridView1.Columns["dbname"].Visible = true;
            dataGridView1.Columns["dbnumber"].Visible = true;
            dataGridView1.Columns["Name1"].Visible = false;
            dataGridView1.Columns["Number"].Visible = false;
            button1.Enabled = true;

        }

        private void InsetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns["dbname"].Visible = false;
            dataGridView1.Columns["dbnumber"].Visible = false;
            dataGridView1.Columns["Name1"].Visible = true;
            dataGridView1.Columns["Number"].Visible = true;
            button1.Enabled = true;
            dataGridView1.Refresh();

        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns["dbname"].Visible = false;
            dataGridView1.Columns["dbnumber"].Visible = false;
            dataGridView1.Columns["Name1"].Visible = true;
            dataGridView1.Columns["Number"].Visible = true;
            button1.Enabled = true;
            dataGridView1.Refresh();

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.database1DataSet.Table);

        }
    }
}
