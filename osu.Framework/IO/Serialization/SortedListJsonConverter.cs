// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using osu.Framework.Lists;

#nullable enable

namespace osu.Framework.IO.Serialization
{
    /// <summary>
    /// A converter used for serializing/deserializing <see cref="SortedList{T}"/> objects.
    /// </summary>
    internal class SortedListJsonConverter : JsonConverter<ISerializableSortedList>
    {
        public override void WriteJson(JsonWriter writer, [AllowNull] ISerializableSortedList value, JsonSerializer serializer)
        {
            value.SerializeTo(writer, serializer);
        }

        public override ISerializableSortedList ReadJson(JsonReader reader, Type objectType, [AllowNull] ISerializableSortedList existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (!(existingValue is ISerializableSortedList iList))
                iList = (ISerializableSortedList)Activator.CreateInstance(objectType)!;

            iList.DeserializeFrom(reader, serializer);

            return iList;
        }
    }
}
