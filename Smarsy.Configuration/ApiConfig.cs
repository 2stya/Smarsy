namespace Smarsy.Configuration
{
    public static class ApiConfig
    {
        public static string ApiUrl => "http://localhost:50952";

        public static string ConnectionString
            =>
            "Data Source=mssql4.gear.host;Persist Security Info=True;Password=NewPassword!;User ID=smarsy;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";


        ////"Data Source = localhost;Initial Catalog=Smarsy; Integrated Security = True; Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout = 60; Encrypt=False;TrustServerCertificate=True";
        ////"Data Source=(localdb)\\ProjectsV13;Initial Catalog=Smarsy;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
        ////"Data Source=mssql4.gear.host;Persist Security Info=True;Password=NewPassword!;User ID=smarsy;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True";
    }
}
