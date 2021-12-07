using System;
using System.Collections.Generic;
using Exiled.API.Features;
using Handlers = Exiled.Events.Handlers;

namespace AntiNorthwood
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Singleton;
        private EventHandlers handler;
        public override string Name => "AntiNorthwood";
        public override string Author => "Artyom <3";

        public override void OnEnabled()
        {
            Singleton = this;
            handler = new EventHandlers(this);

            Handlers.Player.PreAuthenticating += handler.OnFurryJoin;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Handlers.Player.PreAuthenticating -= handler.OnFurryJoin;

            Singleton = null;
            handler = null;
            base.OnDisabled();
        }
    }
}