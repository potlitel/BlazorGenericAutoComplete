namespace BlazorGenericAutoComplete.Models
{
    public class Tarea
    {
        public int id { get; set; }

        public string name { get; set; } = null!;

        public string description { get; set; } = null!;

        public bool completed { get; set; }
    }
}