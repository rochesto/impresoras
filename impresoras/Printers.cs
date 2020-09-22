using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Diagnostics;

namespace impresoras
{
    class Printers
    {
        private string pathFolder;
        private string[] folders;
        private Dictionary<string, string> printerList;

        public Printers(String pathFolder)
        {
            this.pathFolder = pathFolder;
            this.printerList = new Dictionary<string, string>();

            this.folders = getFolders(pathFolder);
        }

        public String[] getFolders(String pathFolder)
        {
            try
            {
            this.folders =  Directory.GetDirectories(pathFolder, "*", SearchOption.TopDirectoryOnly);

            }catch(Exception ex) {
                Debug.WriteLine("Error al cargar directorios");
            }
            return this.folders;
        }

        public String[] getNameFolders()
        {
            string[] arrayTmp;
            if (this.folders != null)
            {
                for (int i = 0; i < this.folders.Length; i++)
                {
                    arrayTmp = this.folders[i].Split('\\');
                    try
                    {
                        this.printerList.Add(arrayTmp[arrayTmp.Length - 1], this.folders[i]);
                    }
                    catch (Exception e)
                    {
                        System.Diagnostics.Debug.WriteLine(e.Message);
                    }

                }
                String[] tmp = new string[this.printerList.Keys.Count];
                this.printerList.Keys.CopyTo(tmp, 0);
                return tmp;
            }
            return null;
        }

        public String getValueFormKey(String key)
        {
            String value = "";

            try
            {
                value = printerList[key];
            }catch(Exception e)
            {
                Debug.WriteLine("Error: No se encuentran registros en el diccionario");
            }

            return value;
        }
    }
}
