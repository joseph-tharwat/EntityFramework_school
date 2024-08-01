namespace EF_simple.Models
{
    public class Connection
    {
        public static string SqlString { get; set; } = """
            Server=JOSEPH-THARWAT;
            Database=school;
            TrustServerCertificate=True;
            Trusted_Connection=True;
            """;


    }
}
