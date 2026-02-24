using System;
using Newtonsoft.Json;

namespace Metaplay.Core.Guild
{
    internal class GuildInviteCodeConverter : JsonConverter
    {
        public GuildInviteCodeConverter()
        {
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }
    }
}