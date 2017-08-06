namespace Newtonsoft.Json.Converters
{
    using System;
    public class StringToIntConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType) => objectType == typeof(string) ||
                                                            objectType == typeof(long) ||
                                                            objectType == typeof(int) ||
                                                            objectType == typeof(short) ||
                                                            objectType == typeof(byte);

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
                return null;
            if (reader.TokenType == JsonToken.Integer)
                return reader.Value;
            if (reader.TokenType == JsonToken.String)
            {
                if (string.IsNullOrEmpty((string)reader.Value))
                    return null;
                int num;
                if (int.TryParse((string)reader.Value, out num))
                    return num;
                throw new JsonReaderException(string.Format("Expected integer, got {0}", reader.Value));
            }
            throw new JsonReaderException(string.Format("Unexcepted token {0}", reader.TokenType));
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value != null && (value.GetType() == typeof(long) ||
                                  value.GetType() == typeof(int) ||
                                  value.GetType() == typeof(short) ||
                                  value.GetType() == typeof(byte)))
            {
                writer.WriteValue(value.ToString());
                return;
            }
            writer.WriteValue(value);
        }
    }
}
