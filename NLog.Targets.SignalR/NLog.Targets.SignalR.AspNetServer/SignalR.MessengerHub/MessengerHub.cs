﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;


namespace NLog.Targets.SignalR.AspNetServer.SignalR.MessengerHub
{
    [HubName("messenger")]
    public class MessengerHub : Hub
    {
        private readonly Messenger _messenger;

        public MessengerHub() : this(Messenger.Instance) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="MessengerHub"/> class.
        /// </summary>
        /// <param name="messenger">The messenger.</param>
        public MessengerHub(Messenger messenger)
        {
            _messenger = messenger;

        }

        public void Heartbeat(string fromWho)
        {
            Debug.WriteLine(fromWho);
        }

        public void AddToGroup(string group)
        {
            Groups.Add(Context.ConnectionId, group);
        }

        /// <summary>
        /// Gets all messages.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Message> GetAllMessages()
        {
            return _messenger.GetAllMessages();
        }

        /// <summary>
        /// Broads the cast message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="group"> </param>
        public void BroadCastMessage(dynamic message, string group)
        {
            _messenger.BroadCastMessage(message,group);
            //Clients.Groups(new List<string>(){group}).broadcastMessage(group, message);
            //Clients.All.broadcastMessage("some name", message);

        }
    }
}