using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWMMSharp
{
    using System.IO;
    using System.Linq;
    using System.Management;
    using System.Reflection;
    using System.Text;
    using System.Runtime.InteropServices;
    using System.Reflection.Emit;


    public class SWMMLoader : ISwmmLibFun
    {
        #region private var
        private readonly object Lock = new object();
        private bool _haveInit;
        private ISwmmLibFun m_DllInstance = null;


        #endregion
        public ISwmmLibFun DllInstance
        {
            get
            {
                if (m_DllInstance == null)
                {
                    lock (Lock)
                    {
                        if (!_haveInit)
                        {
                            bool bIs64 = Detect3264();
                            if (bIs64)
                                m_DllInstance = new TSwmmDllWapperx64();
                            else m_DllInstance = new TSwmmDllWapperx86();
                        }
                    }
                }
                return this.m_DllInstance;
            }
        }
        #region Constructor
        public SWMMLoader()
        {
            Lock = new object();
        }
        //public void Load()
        //{
        //    lock (Lock)
        //    {
        //        if (!_haveSetPath)
        //        {
        //            bool bIs64 = Detect3264();
        //            string str = string.Format(@"{0}\{1}\{2}", Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
        //                bIs64 ? "x64" : "x86", "SWMM5");
        //            Environment.SetEnvironmentVariable("PATH", str + ";" + Environment.GetEnvironmentVariable("PATH"));
        //            _haveSetPath = true;
        //        }
        //    }
        //}

        public bool Detect3264()
        {
            ConnectionOptions oConn = new ConnectionOptions();
            System.Management.ManagementScope oMs = new System.Management.ManagementScope("\\\\localhost", oConn);
            System.Management.ObjectQuery oQuery = new System.Management.ObjectQuery(" select AddressWidth from Win32_Processor");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(oMs, oQuery);
            ManagementObjectCollection oReturnCollection = oSearcher.Get();
            string addressWidth = null;

            foreach (ManagementObject oReturn in oReturnCollection)
            {
                addressWidth = oReturn["AddressWidth"].ToString();
            }

            return addressWidth == "64";
        }
        #endregion


        #region imp of ISwmmLibFun

        public int swmm_runWapper(string f1, string f2, string f3)
        {
            return this.DllInstance.swmm_runWapper(f1, f2, f3);
        }

        public int swmm_openWapper(string f1, string f2, string f3)
        {
            return this.DllInstance.swmm_openWapper(f1, f2, f3);
        }

        public int swmm_startWapper(int SaveFlag)
        {
            return this.DllInstance.swmm_startWapper(SaveFlag);
        }

        public int swmm_stepWapper(ref double ElapsedTime)
        {
            return this.DllInstance.swmm_stepWapper(ref ElapsedTime);
        }

        public int swmm_endWapper()
        {
            return this.DllInstance.swmm_endWapper();

        }

        public int swmm_reportWapper()
        {
            return this.DllInstance.swmm_reportWapper();
        }

        public int swmm_getMassBalErrWapper(ref float Erunoff, ref float Eflow, ref float Equal)
        {
            return this.DllInstance.swmm_getMassBalErrWapper(ref Erunoff, ref Eflow, ref Equal);
        }

        public int swmm_closeWapper()
        {
            return this.DllInstance.swmm_closeWapper();

        }

        public int swmm_getVersionWapper()
        {
            return this.DllInstance.swmm_getVersionWapper();
        }

        public int swmm_getErrorWapper(string ErrMsg, int MsgLen)
        {
            return this.DllInstance.swmm_getErrorWapper(ErrMsg, MsgLen);
        }

        public int swmm_getWarningsWapper()
        {
            return this.DllInstance.swmm_getWarningsWapper();
        }

        #endregion
    }

    public interface ISwmmLibFun
    {
        int swmm_runWapper(string f1, string f2, string f3);
        int swmm_openWapper(string f1, string f2, string f3);
        int swmm_startWapper(int SaveFlag);
        int swmm_stepWapper(ref double ElapsedTime);
        int swmm_endWapper();
        int swmm_reportWapper();
        int swmm_getMassBalErrWapper(ref float Erunoff, ref float Eflow, ref float Equal);
        int swmm_closeWapper();
        int swmm_getVersionWapper();
        int swmm_getErrorWapper(string ErrMsg, int MsgLen);
        int swmm_getWarningsWapper();
    }

    public class TSwmmDllWapperx86 : ISwmmLibFun
    {

        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_close();

        public int swmm_closeWapper()
        {
            return swmm_close();
        }

        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_end();
        public int swmm_endWapper()
        {
            return swmm_end();
        }

        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_getError(string ErrMsg, int MsgLen);
        public int swmm_getErrorWapper(string ErrMsg, int MsgLen)
        {
            return swmm_getError(ErrMsg, MsgLen);
        }
        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_getMassBalErr(ref float Erunoff, ref float Eflow, ref float Equal);
        public int swmm_getMassBalErrWapper(ref float Erunoff, ref float Eflow, ref float Equal)
        {
            return swmm_getMassBalErr(ref Erunoff, ref Eflow, ref Equal);
        }

        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_getVersion();

        public int swmm_getVersionWapper()
        {
            return swmm_getVersion();
        }
        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_getWarnings();

        public int swmm_getWarningsWapper()
        {
            return swmm_getWarnings();
        }


        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_open(string f1, string f2, string f3);
        public int swmm_openWapper(string f1, string f2, string f3)
        {
            return swmm_open(f1, f2, f3);
        }

        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_report();
        public int swmm_reportWapper()
        {
            return swmm_report();
        }


        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_run(string f1, string f2, string f3);
        public int swmm_runWapper(string f1, string f2, string f3)
        {
            return swmm_run(f1, f2, f3);
        }


        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_start(int SaveFlag);
        public int swmm_startWapper(int SaveFlag)
        {
            return swmm_start(SaveFlag);
        }

        [DllImport("Swmm5-x86.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_step(ref double ElapsedTime);

        public int swmm_stepWapper(ref double ElapsedTime)
        {
            return swmm_step(ref ElapsedTime);
        }
    }

    public class TSwmmDllWapperx64 : ISwmmLibFun
    {

        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_close();

        public int swmm_closeWapper()
        {
            return swmm_close();
        }

        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_end();
        public int swmm_endWapper()
        {
            return swmm_end();
        }

        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_getError(string ErrMsg, int MsgLen);
        public int swmm_getErrorWapper(string ErrMsg, int MsgLen)
        {
            return swmm_getError(ErrMsg, MsgLen);
        }
        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_getMassBalErr(ref float Erunoff, ref float Eflow, ref float Equal);
        public int swmm_getMassBalErrWapper(ref float Erunoff, ref float Eflow, ref float Equal)
        {
            return swmm_getMassBalErr(ref Erunoff, ref Eflow, ref Equal);
        }

        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_getVersion();

        public int swmm_getVersionWapper()
        {
            return swmm_getVersion();
        }
        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_getWarnings();

        public int swmm_getWarningsWapper()
        {
            return swmm_getWarnings();
        }


        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_open(string f1, string f2, string f3);
        public int swmm_openWapper(string f1, string f2, string f3)
        {
            return swmm_open(f1, f2, f3);
        }

        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_report();
        public int swmm_reportWapper()
        {
            return swmm_report();
        }


        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_run(string f1, string f2, string f3);
        public int swmm_runWapper(string f1, string f2, string f3)
        {
            return swmm_run(f1, f2, f3);
        }


        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_start(int SaveFlag);
        public int swmm_startWapper(int SaveFlag)
        {
            return swmm_start(SaveFlag);
        }

        [DllImport("Swmm5-x64.dll", CharSet = CharSet.Ansi,CallingConvention = CallingConvention.StdCall)] public static extern int swmm_step(ref double ElapsedTime);

        public int swmm_stepWapper(ref double ElapsedTime)
        {
            return swmm_step(ref ElapsedTime);
        }
    }


}
