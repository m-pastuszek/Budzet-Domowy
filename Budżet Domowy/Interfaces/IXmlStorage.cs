using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Budżet_Domowy.Interfaces
{
    public interface IXmlStorage
    {
        bool FromXml(Stream Stream);
        MemoryStream ToXml();
    }
}