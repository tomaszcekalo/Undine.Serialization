using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Serialization
{
    internal class SerializationEntity
    {
        public string Name { get; set; }
        public Dictionary<Type, JObject> Components { get; set; }
    }
}