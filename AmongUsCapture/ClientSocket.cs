using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using SocketIOClient;

namespace AmongUsCapture
{
    public class ClientSocket
    { 
        private string ConnectCode = null;
        private HttpClient httpClient = new HttpClient();

        public void Connect(string url)
        {
            httpClient.BaseAddress = new Uri("http://localhost:8080");

            GameMemReader.getInstance().GameStateChanged += GameStateChangedHandler;
            GameMemReader.getInstance().PlayerChanged += PlayerChangedHandler;
            GameMemReader.getInstance().JoinedLobby += JoinedLobbyHandler;
        }

        public void SendConnectCode(string connectCode)
        {
			ConnectCode = connectCode;
            httpClient.DefaultRequestHeaders.Remove("Capture-Code");
            httpClient.DefaultRequestHeaders.Add("Capture-Code", connectCode);

            GameMemReader.getInstance().ForceUpdatePlayers();// FORCE UPDATE EVERYTHING
            GameMemReader.getInstance().ForceTransmitState();
        }

        private void GameStateChangedHandler(object sender, GameStateChangedEventArgs e)
        {
            if (ConnectCode == null)
                return;

            var data = new StringContent(JsonSerializer.Serialize(e), Encoding.UTF8, "application/json");
            httpClient.PutAsync("game-state", data);
        }

        private void PlayerChangedHandler(object sender, PlayerChangedEventArgs e)
        {
            if (ConnectCode == null)
                return;

            var data = new StringContent(JsonSerializer.Serialize(e), Encoding.UTF8, "application/json");
            httpClient.PutAsync("player-state", data);
        }

        private void JoinedLobbyHandler(object sender, LobbyEventArgs e)
        {
            if (ConnectCode == null)
                return;

            var data = new StringContent(JsonSerializer.Serialize(e), Encoding.UTF8, "application/json");
            httpClient.PutAsync("lobby-state", data);
        }
    }
}
