﻿using FileHelpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace FAAI2020WebAPI_PersistentFile
{
    public abstract class BaseFileHandler<T>
    {
        protected abstract string FileName { get; }

        private readonly string RootPath = @"C:\Users\lechn\Desktop\FileHelper\";

        private readonly FileHelperEngine _Engine;

        protected BaseFileHandler(Type type)
        {
            this._Engine = new FileHelperEngine(type);
        }  

        protected IEnumerable<T> Read() 
        {
            IEnumerable<T> result = null;
            if (this.TryResolveFilePath(out var path))
            {
                if (this._Engine.ReadFile(path) is IEnumerable<T> enumerable)
                    result = enumerable;
            }
            return result;
        }

        protected void Write(T lineItem)
        {
            if (this.TryResolveFilePath(out var path))
                this._Engine.AppendToFile(path, lineItem);
        }

        private bool TryResolveFilePath(out string path)
        {
            path = string.Empty;
            if (!string.IsNullOrWhiteSpace(this.RootPath) && !string.IsNullOrWhiteSpace(this.FileName))
            {
                path = Path.Combine(this.RootPath, this.FileName);
                return true;
            }
            //ToDo: Log!
            return false;
        }

        protected bool TryDelete(T item) // mit baseid
        {
            if (this.TryResolveFilePath(out var path))
            {
                var tempFile = Path.GetTempFileName();
                var linesToKeep = File.ReadLines(path).Where(i => !(i.StartsWith(item.ToString())));
                File.WriteAllLines(tempFile, linesToKeep);
                File.Delete(path);
                File.Move(tempFile, path);
                return true;
            }
            return false;
        }
    }
}
