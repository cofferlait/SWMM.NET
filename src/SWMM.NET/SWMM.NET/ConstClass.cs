using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMM.NET
{
    public static class ConstClass
    {
        public static string MSG_NO_MAP_FILE = "Could not read map file ";
        public static string MSG_NO_CALIB_DATA = "No calibration data has been registered for this project.";
        public static string MSG_NO_INPUT_FILE = "Input file no longer exists.";
        public static string MSG_NOT_EPASWMM_FILE = "Not an EPA-SWMM file.";
        public static string MSG_READONLY = @" is read-only.\r\n" +
    "Use File >> Save As command to save it under a different name.";
        public static string MSG_NO_BACKDROP = "Could not find backdrop file ";
        public static string MSG_FIND_BACKDROP = ". Do you want to search for it?";

        public static string TXT_MAIN_CAPTION = "SWMM 5.1";
        public static string TXT_STATUS_REPORT = "Status Report";
        public static string TXT_SAVE_CHANGES = "Save changes made to current project?";
        public static string TXT_SAVE_RESULTS = "Save current simulation results?";
        public static string TXT_WARNING = "  WARNING:";
        public static string TXT_TITLE = "TITLE:";
        public static string TXT_NOTES = "NOTES:";
        public static string TXT_HIDE = "&Hide";
        public static string TXT_SHOW = "&Show";
        public static string TXT_HOW_DO_I = "How do I";
        public static string TXT_OPEN_PROJECT_TITLE = "Open a Project";
        public static string TXT_OPEN_MAP_TITLE = "Open a Map";
        public static string TXT_SAVE_PROJECT_TITLE = "Save Project As";
        public static string TXT_OPEN_PROJECT_FILTER =
   "Input file (*.INP)|*.INP|" + "Backup files (*.BAK)|*.BAK|All files|*.*";
        public static string TXT_SAVE_PROJECT_FILTER = "Input files (*.INP)|*.INP|All files|*.*";
        public static string TXT_SCENARIO_FILTER = "Scenario files (*.SCN)|*.SCN|All files|*.*";
        public static string TXT_MAP_FILTER = "Map files (*.MAP)|*.MAP|All files|*.*";
        public static string TXT_ADD_RAINGAGE = "  Click the map where the new Rain Gage should be placed.";
        public static string TXT_ADD_SUBCATCH = "  Draw the outline of the new Subcatchment on the map " +
                     "(left-click adds a vertex, right-click closes the outline).";
        public static string TXT_ADD_NODE = "  Click the map where the new Node should be placed.";
        public static string TXT_ADD_LINK = "  Click on the new Link''s start node and then on its end node.";
        public static string TXT_ADD_LABEL = "  Click the map where the new Label should be placed.";

        ////  Additional text constants defined for release 5.1.008.  ////             //(5.1.008)
        public static string TXT_INP = "inp";
        public static string TXT_RPT = "rpt";
        public static string TXT_HSF = "hsf";
        public static string TXT_BAK = "bak";
        public static string MSG_NO_STATUS_RPT = "A Status Report is not available.";
        public static string MSG_NO_EXPORT_RPT = "Could not export Status Report.";
        public static string TXT_SAVE_STATUS_RPT = "Save Status and Summary Report As";
        public static string TXT_SAVE_RPT_FILTER = "Report files (*.rpt)|*.rpt|All files|*.*";
        public static string TXT_SAVE_HOTSTART = @"Do you wish to save the current state of \r\n" +
                      "the conveyance system to a Hotstart file?";
        public static string TXT_SAVE_HOTSTART_AS = "Save Hotstart File As";
        public static string TXT_HOTSTART_FILTER = "Hotstart files (*.HSF)|*.HSF|All files|*.*";
        public static string TXT_AUTO_LENGTH_ON = "Auto-Length: On";
        public static string TXT_AUTO_LENGTH_OFF = "Auto-Length: Off";

        public static string[] RunStatusHint = 
       { "No Results Available","Results Are Current","Results Need Updating",
     "No Results - Last Run Failed" };

        // Max. index of Map Toolbar buttons
        public static int MAXMAPTOOLBARINDEX = 8;

    }
}
