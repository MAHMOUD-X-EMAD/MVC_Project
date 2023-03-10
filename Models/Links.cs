using System.ComponentModel.DataAnnotations;

namespace Final.Models
{
    public class Links
    {
        public Links() { }
        public int Id { get; set; }
        [RegularExpression ("/^(http(s)?:\\/\\/)?([\\w]+\\.)?linkedin\\.com\\/(pub|in|profile)/")]
        public string Linkedin { get; set; }
        [RegularExpression("/\r\n^(http(s?):\\/\\/)?(www\\.)?github\\.([a-z])+\\/([A-Za-z0-9]{1,})+\\/?$\r\n/")]
        public string GitHub { get; set; }
        public bool isDeleted { get; set; }
    }
}
