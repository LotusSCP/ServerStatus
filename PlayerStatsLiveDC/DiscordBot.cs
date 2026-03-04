using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Exiled.API.Features;

namespace PlayerStatsLiveDC
{
    // Minimal stub for Discord functionality. The original implementation relied on Discord.Net and
    // caused build errors when those assemblies weren't available. This stub allows the plugin to compile
    // while leaving webhook-based live updates (implemented in Plugin.cs) active.
    public class DiscordBot
    {
        private readonly string _token;
        private readonly ulong _guildId;
        private readonly List<ulong> _allowedRoles;

        public DiscordBot(string token, ulong guildId, List<ulong> allowedRoles)
        {
            _token = token;
            _guildId = guildId;
            _allowedRoles = allowedRoles;
        }

        public Task StartAsync()
        {
            Log.Warn("[PlayerStatsLiveDC] Discord bot disabled in this build. Slash command support is unavailable.");
            return Task.CompletedTask;
        }

        public Task StopAsync()
        {
            return Task.CompletedTask;
        }
    }
}
