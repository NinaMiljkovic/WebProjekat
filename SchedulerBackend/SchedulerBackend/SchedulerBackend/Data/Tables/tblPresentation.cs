using System.ComponentModel.DataAnnotations;

namespace SchedulerBackend.Data.Tables
{
    public class tblPresentation
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
    }
}
