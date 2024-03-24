namespace Hitabi.Shared
{
    public static class ApplicationSettings
    {
        public static ApplicationMode ApplicationMode = ApplicationMode.Dev;
        public static byte[] JWT_KEY = new byte[64];
    }
}
