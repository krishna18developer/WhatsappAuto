using OpenQA.Selenium.Edge;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WhatsappAuto
{
    // Create a custom serializable object
    [Serializable]
    public class SerializedEdgeDriver
    {
        public string Url;
        public string Title;
        public string WindowHandle;
        // Add any additional properties that you need to serialize
    }
    
}
