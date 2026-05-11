using VeterinerKlinigi.DataAccess;
using VeterinerKlinigi.Entities;

namespace VeterinerKlinigi
{
    public partial class MuayeneGecmisiForm : Form
    {
        private readonly MuayeneDAL _muayeneDal = new();
        private readonly int _hayvanId;

        public MuayeneGecmisiForm(int hayvanId, string hayvanAdi)
        {
            InitializeComponent();
            _hayvanId = hayvanId;
            Text = $"{hayvanAdi} - Muayene Geçmiþi";
            StartPosition = FormStartPosition.CenterParent;
            ThemesHelperUygula();
        }

        private void MuayeneGecmisiForm_Load(object sender, EventArgs e)
        {
            GridiAyarla();
            Listele();
        }

        private void ThemesHelperUygula()
        {
            // Eðer varsa projedeki tema sýnýfýný uygula, yoksa boþ kalabilir.
            ThemeHelper.Uygula(this);
        }

        private void Listele()
        {
            var gecmis = _muayeneDal.GetByHayvanId(_hayvanId);
            dataGridView1.DataSource = gecmis;
        }

        private void GridiAyarla()
        {
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
        }
    }
}