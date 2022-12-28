using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using Undine.Core;

namespace Undine.Serialization
{
    public class UndineSerializer
    {
        public string Serialize(List<EditorEntity> entities)
        {
            return JsonConvert.SerializeObject(entities);
        }

        public List<EditorEntity> Deserialize(string json)
        {
            var deserialized = JsonConvert.DeserializeObject<List<SerializationEntity>>(json);
            var transformed = deserialized.Select(e => new EditorEntity()
            {
                Name = e.Name,
                Components = e.Components.ToDictionary(x => x.Key, x => x.Value.ToObject(x.Key)),
            }).ToList();
            return transformed;
        }
    }
}