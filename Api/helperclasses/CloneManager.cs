using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace Api.HelperClasses
{
    public class CloneManager
    {
        /// <summary>
        /// Clones the specified instance.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="instance">The instance.</param>
        /// <returns>A new instance of an object.</returns>
        public static T Clone<T>(T instance)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));
                MemoryStream stream = new MemoryStream();
                serializer.Serialize(stream, instance);
                stream.Seek(0, SeekOrigin.Begin);
                return (T)serializer.Deserialize(stream);
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }

}