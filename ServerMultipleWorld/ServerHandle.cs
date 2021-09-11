using GameServer;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServerMultipleWorlds
{
    class ServerHandle
    {
        public static void WelcomeReceived(int _fromClient, Packet _packet)
        {
            int _clientIdCheck = _packet.ReadInt();
            string _username = _packet.ReadString();

            Console.WriteLine($"{Server.clients[_fromClient].tcp.socket.Client.RemoteEndPoint} connect successfully and is now player {_fromClient}");
            if (_fromClient != _clientIdCheck)
            {
                Console.WriteLine($"Player \"{_username}\" (ID: {_fromClient} has assumed the wrong client ID ({_clientIdCheck})!");
            }
            Server.clients[_fromClient].SentIntoGame(_username);
            //TODO: send player to the game
        }
    }
}
