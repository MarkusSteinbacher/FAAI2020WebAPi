using FileHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FAAI2020WebAPI_PersistentFile
{
    public abstract class BaseFileHandler<T>
    {
        private readonly string RootPath = @"C:\Users\Administrator\Desktop\FileHelper\";

        private readonly FileHelperEngine _Engine;

        protected abstract string FileName { get;}

        protected BaseFileHandler(Type type)
        {
            this._Engine = new FileHelperEngine(type);
        }

         bool TryResolveFilePath(out string path)
        {
            path = string.Empty;

            if (!string.IsNullOrWhiteSpace(this.RootPath) && !string.IsNullOrWhiteSpace(this.FileName))
            {
                path = Path.Combine(this.RootPath, this.FileName);
                return true;
            }
            //Log!!
            return false;
        }

        protected IEnumerable<T> Read()
        {
            IEnumerable<T> result = null;
            if (this.TryResolveFilePath(out var path))
            {
                
                if (this._Engine.ReadFile(path) is IEnumerable<T> enumerable)
                {
                    result = enumerable;
                }

            }
            return result;
        }

        protected void Write(T lineItem)
        {
            if (this.TryResolveFilePath(out var path))
            {                
                this._Engine.AppendToFile(path, new List<T>() { lineItem });
            }
        }
    }
}
