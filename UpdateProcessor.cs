namespace CAAttributes
{
    class UpdateProcessor
    {
        //The [Obsolete(string messege, bool)] attribute marks a code element as no longer recommended for use
        //

        //[Obsolete("this method will not be supported in the next release consider using DownloadAndInstall() instead",false)]
        //[Obsolete("this method will not be supported in the next release consider using DownloadAndInstall() instead",true)]

        [Obsolete("this method will not be supported in the next release consider using DownloadAndInstall() instead")]
        public static void Download(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Downloading {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }

        [Obsolete("this method will not be supported in the next release consider using DownloadAndInstall() instead")]
        public static void Install(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Installing {updates[i]}");
                System.Threading.Thread.Sleep(750);
            }
        }

        public static void DownloadAndInstall(Update[] updates)
        {
            for (int i = 0; i < updates.Length; i++)
            {
                Console.WriteLine($"Installing {updates[i]}");
                System.Threading.Thread.Sleep(750);
                Console.WriteLine($"Downloading {updates[i]}");

            }
        }
    }
}