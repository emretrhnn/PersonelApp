using System.ComponentModel;

namespace PersonelWinForms.DTOs
{
    public class MaasDto
    {
        [DisplayName("Maaş Yılı")]
        public string MaasYili { get; set; }

        [DisplayName("Maaş Ücreti")]
        public decimal MaasUcreti { get; set; }
    }
}
