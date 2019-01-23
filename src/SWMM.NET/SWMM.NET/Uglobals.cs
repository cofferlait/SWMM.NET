using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMM.NET
{
    using System.Drawing;

    /*-------------------------------------------------------------------*/
    /*                    Unit:    Uglobals.pas                          */
    /*                    Project: EPA SWMM                              */
    /*                    Version: 5.1                                   */
    /*                    Date:    12/02/13    (5.1.001}                 */
    /*                             04/04/14    (5.1.003}                 */
    /*                             04/23/14    (5.1.005}                 */
    /*                             08/19/14    (5.1.007}                 */
    /*                             08/05/15    (5.1.010}                 */
    /*                             08/01/16    (5.1.011}                 */
    /*                    Author:  L.Rossman                             */
    /*                                                                   */
    /*   Delphi Pascal unit that defines all global data types and       */
    /*   constants used by EPA SWMM.                                     */
    /*                                                                   */
    /*   5.1.011 - Line width added to profile plot options.             */
    /*-------------------------------------------------------------------*/

    public enum TUnitSystem { usUS, usSI };
    public enum TRunStatus
    {
        rsSuccess, rsWarning, rsError, rsWrongVersion,
        rsFailed, rsShutdown, rsStopped, rsImportError,
        rsNone
    };
    public enum TArrowStyle { asNone, asOpen, asFilled, asFancy };
    public enum TMapUnits { muFeet, muMeters, muDegrees, muNone };
    public enum TInputFileType { iftNone, iftNET, iftINP };

    public static class Uglobals
    {
        //------------------
        // Object categories
        //------------------

        public static string TXT_SUBCATCH = "Subcatch";
        public static string TXT_NODE = "Node";
        public static string TXT_LINK = "Link";
        public static string TXT_SYS = "System";

        //-----------------------------------------
        // Version ID - range of versions supported
        //-----------------------------------------
        public static int VERSIONID1 = 51000;
        public static int VERSIONID2 = 51011;                                                          //(5.1.011}

        //------------------
        // File names
        //------------------
        public static string INIFILE = "epaswmm5.ini";
        public static string HLPFILE = "epaswmm5.chm";
        public static string TUTORFILE = "tutorial.chm";

        //------------------
        // Maximum limits
        //------------------
        public static int MAXINTERVALS = 4;  //Max. color scale interval index
        public static int MAXSERIES = 5;  //Max. graph series index
        public static int MAXCOLS = 10; //Max. columns in a table
        public static int MAXFILTERS = 10; //Max. filter conditions for table
        public static int MAXQUALPARAMS = 3; //Max. types of WQ analyses
        public static int MAXDEGDIGITS = 6; //Max. decimal digits for lat-long degrees
        public static int MAXMRUINDEX = 9; //Max. index of Most Recently Used files

        //---------------
        // Custom cursors
        //---------------
        public static int crXHAIR = 1;
        public static int crZOOMIN = 2;
        public static int crZOOMOUT = 3;
        public static int crFIST = 4;
        public static int crMOVE = 5;
        public static int crPENCIL = 6;
        public static int crARROWTIP = 7;
        public static int crSQUARE = 8;

        //-----------------------
        // Subcatchment variables
        //-----------------------
        public static int AREA = 1;  //Input
        public static int WIDTH = 2;  //Input
        public static int SUBCATCHSLOPE = 3;  //Input
        public static int IMPERVIOUSNESS = 4;  //Input
        public static int LID_USAGE = 5;  //Input
        public static int RAINFALL = 6;  //Output
        public static int SNOWDEPTH = 7;  //Output
        public static int EVAP = 8;  //Output
        public static int INFIL = 9;  //Output
        public static int RUNOFF = 10; //Output
        public static int GW_FLOW = 11; //Output
        public static int GW_ELEV = 12; //Output
        public static int GW_MOIST = 13; //Output
        public static int SUBCATCHQUAL = 14; //Output
        public static int SUBCATCHVIEWS = 14; //Max. display variable index
        public static int SUBCATCHOUTVAR1 = 6;  //Index of 1st output variable

        //-----------------
        // Node variables
        //-----------------
        public static int INVERT = 1;   //Input
        public static int NODEDEPTH = 2;   //Output
        public static int HEAD = 3;   //Output
        public static int VOLUME = 4;   //Output
        public static int LATFLOW = 5;   //Output
        public static int INFLOW = 6;   //Output
        public static int OVERFLOW = 7;   //Output
        public static int NODEQUAL = 8;   //Output
        public static int NODEVIEWS = 8;   //Max. display variable index
        public static int NODEOUTVAR1 = 2;   //Index of 1st output variable

        //--------------------
        // Link view variables
        //--------------------
        public static int DIAMETER = 1;   //Input
        public static int ROUGHNESS = 2;   //Input
        public static int LINKSLOPE = 3;   //Input
        public static int FLOW = 4;   //Output
        public static int LINKDEPTH = 5;   //Output
        public static int VELOCITY = 6;   //Output
        public static int LINKVOLUME = 7;   //Output
        public static int CAPACITY = 8;   //Output
        public static int LINKQUAL = 9;   //Output
        public static int LINKVIEWS = 9;   //Max. display variable index
        public static int LINKOUTVAR1 = 4;   //Index of 1st output variable

        //----------------------
        // System view variables
        //----------------------
        public static int SYS_TEMPERATURE = 0;
        public static int SYS_RAINFALL = 1;
        public static int SYS_SNOWDEPTH = 2;
        public static int SYS_INFIL = 3;
        public static int SYS_RUNOFF = 4;
        public static int SYS_DWFLOW = 5;
        public static int SYS_GWFLOW = 6;
        public static int SYS_IIFLOW = 7;
        public static int SYS_EXFLOW = 8;
        public static int SYS_INFLOW = 9;
        public static int SYS_FLOODING = 10;
        public static int SYS_OUTFLOW = 11;
        public static int SYS_STORAGE = 12;
        public static int SYS_EVAP = 13;
        public static int SYS_PET = 14;                                                        //(5.1.010}
        public static int SYSVIEWS = 14;                                                        //(5.1.010}
        public static int SYSOUTVAR1 = 0;

        //------------------
        // Report-type codes
        //------------------
        public static int TIMESERIESPLOT = 0;
        public static int PROFILEPLOT = 1;
        public static int SCATTERPLOT = 2;
        public static int FREQUENCYPLOT = 3;
        public static int TABLEBYVARIABLE = 4;
        public static int TABLEBYOBJECT = 5;

        //----------------------
        // Reported Object codes
        //----------------------
        public static int SUBCATCHMENTS = 0;
        public static int NODES = 1;
        public static int LINKS = 2;
        public static int SYS = 3;

        //----------------------
        // Network map constants
        //----------------------
        public static int MINMAPSIZE = 100;
        public static int SYMBOLSIZE = 4;
        public static int PIXTOL = 5;

        //------------------------------
        // Map and default legend colors
        //------------------------------
        public static int MAXMAPCOLORINDEX = 9;
        public static System.Drawing.Color[] MapForeColor = new Color[]
           { Color.Black,  Color.Black,  Color.Black,  Color.Black,  Color.White,
     Color.Black, Color.Black,  Color.Black, Color.Silver };
        public static System.Drawing.Color[] MapGrayColor = new Color[]
                { Color.Black,  Color.Black,  Color.Black,  Color.Black,  Color.Gray,
     Color.Black, Color.Black,  Color.Black, Color.Silver };
        public static System.Drawing.Color[] DefLegendColor = new Color[]
    {Color.FromArgb( 0xFF0000),
        Color.FromArgb( 0xFFFF00),
            Color.FromArgb( 0xFF00),
            Color.FromArgb( 0xFFFF),
            Color.FromArgb( 0xFF)};

        //-------------------------
        // Map viewing action codes
        //-------------------------
        public static int SELECT = 101;
        public static int VERTEXSELECT = 102;
        public static int GROUPSELECT = 103;
        public static int PAN = 104;
        public static int ZOOMIN = 105;
        public static int ZOOMOUT = 106;
        public static int FULLEXTENT = 107;
        public static int RULER = 108;

        //--------------------
        //Data reporting units
        //--------------------
        public static string[] USFlowUnits = { "CFS", "GPM", "MGD" };

        public static string[] SIFlowUnits = { "CMS", "LPS", "MLD" };

        public static string[] MassUnits = { "mg/L", "ug/L", "#/L" };

        public static string[] TempUnits = { "deg F", "deg C" };

        public static string[] EvapUnits = { "in/day", "mm/day" };

        public static string[,] BaseSubcatchUnits =
                 { {"",""},                // No View
                  {"ac","ha"},            // Area
                  {"ft","m"},             // Width
                  {"%","%"},              // Slope
                  {"%","%"},              // Imperviousness
                  {"%","%"},              // LID Usage
                  {"in/hr","mm/hr"},      // Rainfall
                  {"in", "mm"},           // Snow Depth
                  {"in/day","mm/day"},    // Evap Rate
                  {"in/hr","mm/hr"},      // Infil Rate
                  {"CFS","CMS"},          // Runoff
                  {"CFS","CMS"},          // GW Flow
                  {"ft","m"},             // GW Elev
                  {"",""},                // Soil Moisture
                  {"mg/L","mg/L"} };       // Washoff

        public static string[,] BaseNodeUnits =
                 {{"",""},                // No View
                  {"ft","m"},             // Elev.
                  {"ft","m"},             // Depth
                  {"ft","m"},             // Head
                  {"ft3","m3"},           // Volume
                  {"CFS","CMS"},          // Lateral Inflow
                  {"CFS","CMS"},          // Total Inflow
                  {"CFS","CMS"},          // Overflow
                  {"mg/L","mg/L"}};       // Quality

        public static string[,] BaseLinkUnits =
                 {{"",""},                // No View
                  {"ft","m"},             // Max. Depth
                  {"",""},                // Manning N
                  {"%","%"},              // Slope
                  {"CFS","CMS"},          // Flow
                  {"ft","m"},             // Depth
                  {"fps","m/s"},          // Velocity
                  {"ft3","m3"},           // Volume.
                  {"",""},                // Fraction Full
                  {"mg/L","mg/L"}};       // Quality

        public static string[] MapUnits =
                  {"Feet", "Meters", "Degrees", "None"};
        public static string[] MapUnitsAbbrev =
                  {"ft", "m", "deg", ""};

        //---------------------
        //Calibration Variables
        //---------------------
        public static string[] CalibVariables =
  { "Subcatchment Runoff", "Subcatchment Washoff", "Node Water Depth",
   "Link Flow Rate", "Node Water Quality", "Node Lateral Inflow",
   "Node Flooding", "Groundwater Flow", "Groundwater Elevation",
   "Snow Pack Depth", "Link Flow Depth", "Link Flow Velocity"};

        //------------------
        //Auto-Length status
        //------------------
        public static string[] AutoLengthStatus = { "Off", "On" };

        //---------------------
        //Map Label meter types (not used}
        //---------------------
        public static string[] MeterType = { "None", "Area", "Node", "Link" };

        //----------------------------------------------------
        // Relations used in search filters
        // (these correspond to the elements of TRelationType
        // which is declared in the unit Uutils.pas}
        //----------------------------------------------------
        public static string[] FilterRelation = { "Below", "Equal To", "Above" };

        //------------------------
        // Unit conversion factors
        //------------------------
        public static double METERSperFOOT = 0.3048;
        public static double FEETperMETER = 3.281;
        public static double ACRESperFOOT2 = 2.2956e-5;
        public static double ACRESperMETER2 = 24.71e-5;
        public static double HECTARESperMETER2 = 0.0001;
        public static double HECTARESperFOOT2 = 0.92903e-5;

        //------------------------
        // Miscellaneous constants
        //------------------------
        public static double FLOWTOL = 0.005;             //Zero flow tolerance
        public static double MISSING = -1.0e10;           //Missing value
        public static int NOXY = -9999999;          //Missing map coordinate

        public static Point NOPOINT = new Point(-9999999, -9999999);
        public static Rectangle NORECT = new Rectangle { X = -9999999, Y = -9999999 };

        //{ Left -9999999; Top: -9999999;
        //                 Right: -9999999; Bottom: -9999999);

        public static int NODATE = -693594;   // 1/1/0001
        public static string NA = "#N/A";
        public static int NONE = 0;
        public static int NOVIEW = 0;
        public static int PLUS = 1;
        public static int MINUS = 2;
        public static int DefMeasError = 5;
        public static int DefIDIncrement = 1;
        public static int DefMaxTrials = 8;
        public static string DefMinSurfAreaUS = "12.557"; //(ft2}
        public static string DefMinSurfAreaSI = "1.14";   //(m2}
        public static string DefHeadTolUS = "0.005";  //(ft}
        public static string DefHeadTolSI = "0.0015"; //(m}


    }


    //-----------------------------------------
    // View variable (visual theme} information
    //-----------------------------------------
    public class TViewVariable
    {
        public string Name { get; set; }
        public int SourceIndex { get; set; }
        public float[] DefIntervals { get; set; }
    }
    public class TVariableUnits
    {
        public string Units { get; set; }
        public int Digits { get; set; }
    }


    //----------------
    // Map legend data
    //----------------
    public class TMapLegend
    {
        public float[] Intervals { get; set; }
        public int Nintervals { get; set; }//# intervals used
        public int Ltype { get; set; }//Legend type (SUBCATCH, NODE or LINK}
        public int ViewVar { get; set; }//View variable index
    }


    //-----------------
    // Map legend frame
    //-----------------
    public class TLegendFrame
    {
        public float X { get; set; }
        public float Y { get; set; }
        public bool Framed { get; set; }
    }


    //-----------------
    // Calibration data
    //-----------------
    public class TCalibData
    {
        public String FileName { get; set; }//File where data resides
        public String Locations { get; set; } //Locations where measurements exist
    }


    //    //----------------------
    //    // Graph display options
    //    //----------------------
    //    TGraphOptions = record
    //      View3D          : Boolean;
    //    Percent3D       : Integer;
    //    PanelColor      : TColor;
    //    BackColor       : TColor;
    //    BackGradColor   : TColor;
    //    LegendPosition  : Integer;
    //    LegendColor     : TColor;
    //    LegendWidth     : Integer;
    //    LegendTransparent: Boolean;
    //    LegendFramed    : Boolean;
    //    LegendVisible   : Boolean;
    //    AxisGridStyle   : array[0..2] of Integer;
    //    AxisGridColor   : TColor;
    //    LineVisible     : array[0..MAXSERIES] of Boolean;
    //    LineStyle       : array[0..MAXSERIES] of Integer;
    //    LineColor       : array[0..MAXSERIES] of TColor;
    //    LineWidth       : array[0..MAXSERIES] of Integer;
    //    PointVisible    : array[0..MAXSERIES] of Boolean;
    //    PointStyle      : array[0..MAXSERIES] of Integer;
    //    PointColor      : array[0..MAXSERIES] of TColor;
    //    PointSize       : array[0..MAXSERIES] of Integer;
    //    TitleFontColor  : TColor;
    //    TitleFontName   : String;
    //    AxisFontName    : String;
    //    TitleFontSize   : Integer;
    //    AxisFontSize    : Integer;
    //    TitleFontBold   : Boolean;
    //    TitleFontItalic : Boolean;
    //    AxisFontBold    : Boolean;
    //    AxisFontItalic  : Boolean;
    //    AreaFillColor   : TColor;
    //    AreaFillStyle   : TBrushStyle;
    //    LabelsVisible   : Boolean;
    //    LabelsTransparent: Boolean;
    //    LabelsArrows    : Boolean;
    //    LabelsBackColor : TColor;
    //    DateTimeFormat  : String;
    //    AxisInverted    : Boolean;
    //  end;

    ////-----------------------------
    //// Profile Plot Display Options
    ////-----------------------------
    //  TProfileOptions = record
    //    ConduitColor       : TColor;
    //    WaterColor         : TColor;
    //    LabelsOnAxis       : Boolean;
    //    LabelsOnPlot       : Boolean;
    //    LabelsArrowLength  : Integer;
    //    LabelsFontSize     : Integer;
    //    LineWidth          : Integer;                                              //(5.1.011)
    //  end;

    ////-------------
    //// Report Item
    ////-------------
    //  TReportItem = record
    //    ObjType    : Integer;
    //    ObjName    : String;
    //    LegendTxt  : String;
    //    Variable   : Integer;
    //    Axis       : Integer;
    //  end;

    ////------------------------
    //// Report Selection Options
    ////------------------------
    //  TReportSelection = record
    //    ReportType     : Integer;
    //    XObjectType    : Integer;
    //    ObjectType     : Integer;
    //    StartDateIndex : LongInt;
    //    EndDateIndex   : LongInt;
    //    Items          : TStrings;
    //    Variables      : array[0..MAXCOLS] of Integer;
    //    ReportItems    : array[0..MAXCOLS] of TReportItem;
    //    ItemCount      : Integer;
    //    VariableCount  : Integer;
    //    DateTimeDisplay: Boolean;
    //  end;

    ////--------------------
    //// Printed Page Layout
    ////--------------------
    //  TPageLayout = record
    //    PaperSize    : TSinglePoint;
    //    LMargin      : Single;
    //    RMargin      : Single;
    //    TMargin      : Single;
    //    BMargin      : Single;
    //  end;

    //const

    //  DefGraphOptions: TGraphOptions =
    //    (View3D          : False;
    //     Percent3D       : 25;
    //     PanelColor      : clBtnFace;
    //     BackColor       : clWhite;
    //     BackGradColor   : clWhite;
    //     LegendPosition  : 2;
    //     LegendColor     : clWhite;
    //     LegendWidth     : 20;
    //     LegendTransparent: True;
    //     LegendFramed    : True;
    //     LegendVisible   : False;
    //     AxisGridStyle   : (1, 1, 0);
    //     AxisGridColor   : clGray;
    //     LineVisible     : (True, True, True, True, True, False);
    //     LineStyle       : (0, 0, 0, 0, 0, 0);
    //     LineColor       : (clRed, clBlue, clFuchsia, clGreen, clGray, clLime);
    //     LineWidth       : (2, 2, 2, 2, 2, 2);
    //     PointVisible    : (False, False, False, False, False, True);
    //     PointStyle      : (0, 0, 0, 0, 0, 0);
    //     PointColor      : (clRed, clBlue, clFuchsia, clGreen, clGray, clLime);
    //     PointSize       : (3, 3, 3, 3, 3, 3);
    //     TitleFontColor  : clBlue;
    //     TitleFontName   : 'Arial';
    //     AxisFontName    : 'Arial';
    //     TitleFontSize   : 12;
    //     AxisFontSize    : 8;
    //     TitleFontBold   : True;
    //     TitleFontItalic : False;
    //     AxisFontBold    : False;
    //     AxisFontItalic  : False;
    //     AreaFillColor   : clBlue;
    //     AreaFillStyle   : bsSolid;
    //     LabelsVisible   : True;
    //     LabelsTransparent: False;
    //     LabelsArrows    : False;
    //     LabelsBackColor : clYellow;
    //     DateTimeFormat  : '';
    //     AxisInverted    : False);


    //  DefProfileOptions: TProfileOptions =
    //    (ConduitColor       : clWhite;
    //     WaterColor         : clAqua;
    //     LabelsOnAxis       : True;
    //     LabelsOnPlot       : False;
    //     LabelsArrowLength  : 10;
    //     LabelsFontSize     : 8;
    //     LineWidth          : 1);  
}
