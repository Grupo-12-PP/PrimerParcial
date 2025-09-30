namespace PrimerParcial.Models
{
    public class SupportTicket
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }  // Ejemplo: "Open", "In Progress", "Closed"
    }
}