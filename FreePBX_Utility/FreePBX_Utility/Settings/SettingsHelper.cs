using System;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;

namespace FreePBX_Utility.Settings
{
    public class SettingsHelper
    {
        public string SettingsFile { get; set; }

        public bool DeleteSettingsFile()
        {
            try
            {
                if (File.Exists(SettingsFile))
                {
                    File.Delete(SettingsFile);
                }
                return !File.Exists(SettingsFile);
            }
            catch (UnauthorizedAccessException)
            {
                return false;
            }
        }

        public object LoadSettings(Type SettingsObjectType)
        {
            object retval = Activator.CreateInstance(SettingsObjectType);

            try
            {
                if (!File.Exists(SettingsFile))
                    return null;

                DataContractSerializer serializer = new DataContractSerializer(SettingsObjectType);

                using (XmlReader reader = XmlReader.Create(SettingsFile))
                {
                    retval = serializer.ReadObject(reader);
                }
            }
            catch (SerializationException)
            {
                //System.Windows.Forms.MessageBox.Show("Error loading configuration file. Default values will be used.\n\n" + e.Message);
                return null;
            }

            return retval;
        }

        public SettingsHelper(SettingFileTypes settingType)
        {
            string devRel = "Release";
#if DEBUG
            devRel = "Debug";
#endif
            string tmpSettingsFile = Regex.Replace(Application.ExecutablePath, @"\.exe\z", ".xml", RegexOptions.IgnoreCase);

            string settingFileName = Path.GetFileName(tmpSettingsFile);
            string settingFilePath = Path.GetDirectoryName(Application.ExecutablePath);

            if (settingType == SettingFileTypes.User)
            {
                settingFilePath = Path.Combine(Application.LocalUserAppDataPath, devRel);
            }

            if (!Directory.Exists(settingFilePath))
                Directory.CreateDirectory(settingFilePath);

            tmpSettingsFile = Path.Combine(settingFilePath, settingFileName);

            SettingsFile = tmpSettingsFile;
        }

        public bool SaveSettings(Object SettingsObject)
        {
            if (SettingsObject == null)
                return false;

            //XmlSerializer serializer = new XmlSerializer(SettingsObject.GetType());
            DataContractSerializer serializer = new DataContractSerializer(SettingsObject.GetType());

            if (!DeleteSettingsFile())
                return false;

            try
            {
                using (XmlTextWriter writer = new XmlTextWriter(SettingsFile, Encoding.UTF8) { Formatting = Formatting.Indented })
                {
                    serializer.WriteObject(writer, SettingsObject);
                }

                return true;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.Message, "Error writing to the configuration file", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

        }
    }
}
