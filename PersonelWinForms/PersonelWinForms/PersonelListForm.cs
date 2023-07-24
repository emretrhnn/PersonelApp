using PersonelWinForms.Contexts;
using PersonelWinForms.DTOs;
using PersonelWinForms.Entities;

namespace PersonelWinForms
{
    public partial class PersonelListForm : Form
    {
        PersonelBilgileriDbContext _db = new PersonelBilgileriDbContext();
        public PersonelListForm()
        {
            InitializeComponent();
        }

        private void PersonelListForm_Load(object sender, EventArgs e)
        {
            try
            {

                PersonelList();
            }
            catch (Exception exp)
            {

                MessageBox.Show("İşlem sırasında hata meydana geldi! (" + exp.Message + " | " + exp.InnerException?.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void PersonelList()
        {
            List<Personel> personelListesi = _db.Personeller.ToList();
            dgvPersonel.DataSource = personelListesi;

        }

        
    }
}
