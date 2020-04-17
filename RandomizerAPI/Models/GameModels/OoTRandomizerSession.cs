using Newtonsoft.Json;

namespace RandomizerAPI.Models.GameModels
{
    public class OoTRandomizerSession
    {
        public int ID { get; set; }
        public string SessionID { get; set; }
        public string Password { get; set; }
        public Game Game { get; set; }
        public View View { get; set; }
        public OoTSpoilerLog SpoilerLog { get; set; }

        public OoTRandomizerSession(RandomizerSession session, View view = View.Spectator)
        {
            OoTSpoilerLog log = JsonConvert.DeserializeObject<OoTSpoilerLog>(session.SpoilerLog);

            SessionID = session.SessionID;
            Game = session.Game;
            View = view;
            Password = session.Password;
            ID = session.ID;
            SpoilerLog = log;
        }
    }
}
