namespace ApiBlogDDD.Domain.Entities
{
    public class Authenticate
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public bool Success { get; set; }
        public string Token { get; set; }
    }
}
