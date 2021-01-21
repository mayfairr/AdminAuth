using Oxide.Game.Rust.Cui;
using Oxide.Core.Libraries.Covalence;
using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace Oxide.Plugins
{
    [Info("AdminAuth", "mayfairr", "1.0")]
    public class AdminAuth : CovalencePlugin
    {
        #region Config
        private PluginConfig config;
        public class PluginConfig
        {
            public string DiscordWebhook;
            public int UseLimit;
        }
        protected override void LoadDefaultConfig()
        {
            Config.WriteObject(GetDefaultConfig(), true);
        }
        private PluginConfig GetDefaultConfig()
        {
            return new PluginConfig
            {
                DiscordWebhook = "",
                UseLimit = 30,

            };
        }
        private void SaveConfig() => Config.WriteObject(config, true);
        #endregion

        #region ServerHooks
        private void Init()
        {
            config = Config.ReadObject<PluginConfig>();
        }
        #endregion

        #region Commands
        [Command("request"), Permission("AdminAuth.request")]
        private void Settings(IPlayer player, string command, string[] args)
        {
           //Admin Commands
        }
        #endregion
    }
}