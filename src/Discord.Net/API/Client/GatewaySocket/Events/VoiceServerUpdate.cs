﻿using Discord.API.Converters;
using Newtonsoft.Json;

namespace Discord.API.Client.GatewaySocket
{
	public sealed class VoiceServerUpdateEvent
	{
		[JsonProperty("guild_id"), JsonConverter(typeof(LongStringConverter))]
		public ulong GuildId { get; }
        [JsonProperty("endpoint")]
		public string Endpoint { get; }
        [JsonProperty("token")]
		public string Token { get; }
	}
}