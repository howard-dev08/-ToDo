using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WinFormsAppWithAPIINtegration
{
    public class DataLoader

    {

        //private List<TreatMent> treatments = new List<Treatment>();
        private string folder;
        public string FolderName { set { folder = value; } get { return folder; } }
        private string file;
        public string FileName { set { file = value; } get { return file; } }
        private string GameSaves = "Treatments.txt";

        public void FileStreamer(string file, string folder)
        {
            this.FileName = file;
            this.FolderName = folder;

        }

        public List<Procedure> LoadResource()
        {

            List<Procedure> treatments = new List<Procedure>();
            string path = Path.Combine(this.GameSaves, this.folder, this.file);
            if (Directory.Exists(path))
            {
                var myJson = File.ReadAllText(Path.Combine(this.GameSaves, this.folder, this.file));

                foreach (Procedure treatment in JsonConvert.DeserializeObject<Procedure[]>(myJson)) {
                    treatments.Add(treatment);
                }
                return treatments;
            }
            return treatments;
        }
        
    }
}
