using System.ComponentModel;

namespace PersonelWinForms.DTOs
{
    public class PersonelDto
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("Adı Soyadı")]
        public string AdSoyad { get; set; }

        [DisplayName("Kimlik No")]
        public string KimlikNo { get; set; }

        [DisplayName("Doğum Tarihi")]
        public string DogumTarih { get; set; }

        public List<MaasDto> MaasListesi { get; set; }
    }
}
