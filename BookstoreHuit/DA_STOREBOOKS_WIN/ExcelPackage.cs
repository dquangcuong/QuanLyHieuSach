using System;
using System.IO;

namespace DA_STOREBOOKS_WIN
{
    internal class ExcelPackage
    {
        public object Workbook { get; internal set; }

        internal void Save(FileStream fileStream)
        {
            throw new NotImplementedException();
        }
    }
}