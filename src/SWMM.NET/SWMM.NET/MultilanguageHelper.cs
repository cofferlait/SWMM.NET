
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMM.NET
{
    using Newtonsoft.Json;
    using System.Windows.Forms;

    public class TLngJSON
    {
        #region private var

        Dictionary<string, string> resources = null;

        #endregion


        public void LoadLanguage(string language = "")
        {
            if (string.IsNullOrEmpty(language))
            {
                language = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
            }

            this.Resources = new Dictionary<string, string>();
            string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, string.Format("lang/{0}", language));
            if (Directory.Exists(dir))
            {
                var jsonFiles = Directory.GetFiles(dir, "*.json", SearchOption.AllDirectories);
                foreach (string file in jsonFiles)
                {
                    LoadFile(file);
                }
            }
        }

        private void LoadFile(string file)
        {
            var content = File.ReadAllText(file, Encoding.UTF8);
            if (!string.IsNullOrEmpty(content))
            {
                var dict = JsonConvert.DeserializeObject<Dictionary<string, string>>(content);
                foreach (string key in dict.Keys)
                {
                    if (!Resources.ContainsKey(key))
                    {
                        Resources.Add(key, dict[key]);
                    }
                    else
                    {
                        Resources[key] = dict[key];
                    }
                }
            }
        }

        public bool Vaild
        {
            get
            {
                return this.Resources != null && this.Resources.Count > 0;
            }
        }

        public Dictionary<string, string> Resources
        {
            get
            {
                return this.resources;
            }
        }
    }

    public static class MultilanguageHelper
    {
        static TLngJSON JsonLanguage = null;

        public static bool Init(string lng)
        {
            JsonLanguage = new TLngJSON();
            JsonLanguage.LoadLanguage(lng);
            return JsonLanguage.Vaild;
        }
        public static void InitLanguage(Control control)
        {
            if (!JsonLanguage.Vaild)
                return;

            SetControlLanguage(control);
            foreach (Control ctrl in control.Controls)
            {
                InitLanguage(ctrl);
            }

            control.ControlAdded += (sender, e) =>
            {
                InitLanguage(e.Control);
            };
        }
        public static void InitActionLng(SWMM.Components.TActionList actList)
        {
            if (!JsonLanguage.Vaild)
                return;
            foreach (SWMM.Components.TAction act in actList)
            {
                string text = act.Text;
                if (JsonLanguage.Resources.ContainsKey(text))
                    act.Text = JsonLanguage.Resources[text];
            }
        }
        private static void SetControlLanguage(Control ctl)
        {
            if (ctl is TextBox)
            {

            }
            else if (ctl is Label)
            {

            }

        }
    }
}
