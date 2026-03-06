using Exiled.API.Interfaces;
using System.Collections.Generic;

namespace ServerStatus
{
    public class Config : ConfigBase, IConfig
    {
        private int port = Exiled.API.Features.Server.Port;
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        // Map properties to ConfigBase
        public string BindAddress { get => base.ip; set => base.ip = value; }
        public int CustomPort { get => base.customport; set => base.customport = value; }

        public int Port { get => port; set => port = value; }
        public string Password { get; set; } = "";
        public int DefaultBroadcastSeconds { get; set; } = 10;
        public bool EnableCassie { get; set; } = true;
        public bool EnableWarheadCommands { get; set; } = true;
        public bool EnableSoftRestart { get; set; } = true;
        public bool EnableExit { get; set; } = true;
        public int SoftRestartReconnectDelaySeconds { get; set; } = 5;
        public int MaxListedPlayers { get; set; } = 20;

        // Discord Settings
        public string DiscordBotToken { get; set; } = "";
        public ulong DiscordGuildId { get; set; } = 0;
        
        // Discord role IDs allowed to use privileged/custom commands.
        public List<ulong> DiscordRoleIds { get; set; } = new List<ulong>();
        
        // Discord role IDs that are considered owner roles.
        public List<ulong> DiscordOwnerRoleIds { get; set; } = new List<ulong>();
        
        public List<CustomCommand> CustomCommands { get; set; } = new List<CustomCommand>();

        // Bot channel for REST-based bot posting (optional). If set alongside DiscordBotToken, the plugin
        // will post/update a message in this channel using the bot token via Discord REST API.
        public ulong DiscordChannelId { get; set; } = 0;

        // Webhook / Live list settings
        public bool WebhookEnabled { get; set; } = false;
        public string WebhookUrl { get; set; } = "";
        public int WebhookIntervalSeconds { get; set; } = 30;

        // Server info shown in the webhook
        public int ServerNumber { get; set; } = 1;
        public string ServerIPOverride { get; set; } = ""; // if empty shows "bilinmiyor"
        public int WebhookMaxPlayerList { get; set; } = 50; // how many players to show
        // Language for messages: "tr" for Turkish, "en" for English
        public string Language { get; set; } = "tr";
    }

    public sealed class CustomCommand
    {
        public string Name { get; set; } = "";
        public string Command { get; set; } = "";
        public bool RequiresRole { get; set; } = true;
        public bool Enabled { get; set; } = true;
        public string Description { get; set; } = "";
    }
}
