﻿using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Climax.Web.Http.Cors
{
    public class CorsElement : ConfigurationElement
    {
        [ConfigurationProperty("name", IsKey = true, IsRequired = true)]
        public string Name
        {
            get { return (string)this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("origins", IsRequired = true)]
        public string Origins
        {
            get { return (string)this["origins"]; }
            set { this["origins"] = value; }
        }

        [ConfigurationProperty("methods", IsRequired = true)]
        public string Methods
        {
            get { return (string)this["methods"]; }
            set { this["methods"] = value; }
        }

        [ConfigurationProperty("headers", IsRequired = false)]
        public string Headers
        {
            get { return (string)this["headers"]; }
            set { this["headers"] = value; }
        }

        [ConfigurationProperty("exposedheaders", IsRequired = false)]
        public string ExposedHeaders
        {
            get { return (string)this["exposedheaders"]; }
            set { this["exposedheaders"] = value; }
        }
    }
}
