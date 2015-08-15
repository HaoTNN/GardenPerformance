﻿using System;
using System.Collections.Generic;
using System.Text;

using Sandbox.Common;
using Sandbox.Common.ObjectBuilders;
using Sandbox.Definitions;
using Sandbox.ModAPI;
using VRage.Library.Utils;
using Interfaces = Sandbox.ModAPI.Interfaces;
using InGame = Sandbox.ModAPI.Ingame;

using SEGarden;
using SEGarden.Logging;
using SEGarden.Logic;
using SEGarden.Logic.Common;
//using SEGarden.Notifications;

using GardenPerformance.Concealment.Messaging.Handlers;

namespace GardenPerformance.Concealment.Sessions {

    class ClientConcealSession {

        private static Logger Log = 
            new Logger("GardenPerformance.Concealment.Sessions.ClientConcealSession");

        public static ClientMessageHandler Messenger;

        public void Initialize() {
            GardenGateway.Commands.addCommands(Commands.FullTree);
            Messenger = new ClientMessageHandler();
        }

        public void Terminate() {

        }

        public static void DebugWorldNames() {
            Log.Info("Trying to figure out what to use for name:", "SetSectorFromWorldName");
            Log.Info("Sector.ToString " + MyAPIGateway.Session.GetWorld().Sector.ToString(), "UpdateWorldName");
            Log.Info("Sector.Position " + MyAPIGateway.Session.GetWorld().Sector.Position, "UpdateWorldName");
            Log.Info("World.ToString" + MyAPIGateway.Session.GetWorld().ToString(), "UpdateWorldName");
            Log.Info("Session.Name " + MyAPIGateway.Session.Name, "UpdateWorldName");
            Log.Info("World.Session.Name  " + MyAPIGateway.Session.GetWorld().Checkpoint.SessionName, "UpdateWorldName");
            Log.Info("Session.ToString " + MyAPIGateway.Session.ToString(), "UpdateWorldName");
            Log.Info("Session.WorkshopID " + MyAPIGateway.Session.WorkshopId, "UpdateWorldName");
            Log.Info("Session.WorkshopID " + MyAPIGateway.Session.WorkshopId, "UpdateWorldName");
        }

    }

}
