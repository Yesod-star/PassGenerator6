namespace PassGenerator._3_Services.Interface
{
    public interface IPasswordGenService
    {
        List<string> GenerateRandomPasswords(int passLength, int numberOfPasswords);
    }
}