using System.Net;
using System.Media;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = client.GetAsync("https://rur.hitmotop.com/get/music/20220603/ANNA_ASTI_-_Po_baram_74376135.mp3").Result;
        byte[] data = response.Content.ReadAsByteArrayAsync().Result;
        File.WriteAllBytes("C:\\Users\\Пользователь\\Desktop\\а.mp3", data);
        string soundFilePath = "path_to_your_sound_file.wav";

        Process.Start(new ProcessStartInfo { FileName = "C:\\Users\\Пользователь\\Desktop\\а.mp3", UseShellExecute = true });
    }
}
