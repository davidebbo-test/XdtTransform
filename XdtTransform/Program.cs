using Microsoft.Web.XmlTransform;
using System;
using System.IO;
using System.Xml;

namespace XdtTransform
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
            {
                Console.WriteLine("XdtTransform <xmlfile> <xdttransform>");
                return;
            }

            var xmlDoc = new XmlDocument();
            xmlDoc.Load(args[0]);

            var transform = new XmlTransformation(args[1]);
            transform.Apply(xmlDoc);

            xmlDoc.Save(Path.ChangeExtension(args[0], "new.xml"));
        }
    }
}
