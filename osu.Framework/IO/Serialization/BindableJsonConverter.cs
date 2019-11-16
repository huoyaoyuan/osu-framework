// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using osu.Framework.Bindables;

#nullable enable

namespace osu.Framework.IO.Serialization
{
    /// <summary>
    /// A converter used for serializing/deserializing <see cref="Bindable{T}"/> objects.
    /// </summary>
    internal class BindableJsonConverter : JsonConverter<ISerializableBindable>
    {
        public override void WriteJson(JsonWriter writer, [AllowNull] ISerializableBindable value, JsonSerializer serializer)
        {
            value!.SerializeTo(writer, serializer);
        }

        public override ISerializableBindable ReadJson(JsonReader reader, Type objectType, ISerializableBindable? existingValue, bool hasExistingValue, JsonSerializer serializer)
        {
            if (!(existingValue is ISerializableBindable bindable))
                bindable = (ISerializableBindable)Activator.CreateInstance(objectType, true)!;

            bindable.DeserializeFrom(reader, serializer);

            return bindable;
        }
    }
}
