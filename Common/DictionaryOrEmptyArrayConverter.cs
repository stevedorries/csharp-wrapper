//----------------------------------------------------------------
// DictionaryOrEmptyArrayConverter.cs
// Copyright Steve Dorries 2021
// This projected is licensed under the terms of the MIT license.
//  (see the attached LICENSE.txt).
//----------------------------------------------------------------

using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace SimplyCast
{
    public interface IObjectArrayPolymorphic { }
    public class DictionaryOrEmptyArrayConverter<T> : JsonConverter<Dictionary<int, T>> where T : IObjectArrayPolymorphic
    {
        public override Dictionary<int, T> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            // Let's check we are dealing with an object adhering to the JSON spec.
            if (reader.TokenType == JsonTokenType.StartObject)
            {
                // Proper array, we can deserialize from this token onwards.
                return JsonSerializer.Deserialize<Dictionary<int, T>>(ref reader, options);
            }

            // If we reached here, it means we are dealing with an array 
            // we will return an empty dictionary 

            Dictionary<int, T> list = new();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.StartArray)
                {
                    list = new();
                }
                if (reader.TokenType == JsonTokenType.EndArray)
                {
                    // finished processing the array.
                    break;
                }
            }

            return list;
        }

        public override void Write(Utf8JsonWriter writer, Dictionary<int, T> value, JsonSerializerOptions options)
        {
            // Nothing special to do in write operation. So use default serialize method.
            JsonSerializer.Serialize(writer, value, value.GetType(), options);
        }
    }
}