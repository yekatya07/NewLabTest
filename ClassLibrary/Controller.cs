namespace ClassLibrary
{
    public class Controller
    {
        public static triangleInfo GoControl(string f, string s, string t)
        {
            triangleInfo triangle = new triangleInfo();

            if (DB.SearchInfo(f, s, t) == null) DB.AddInfo(f, s, t);
            Send send = new Send();
            send.SendInfo(DB.SearchInfo(f, s, t));
            return DB.SearchInfo(f, s, t);
        }
    }
}
