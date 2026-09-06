
using System;
using System.Runtime.InteropServices;
using System.Threading;

class Program
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct DEVMODE
    {
        private const int CCHDEVICENAME = 32;
        private const int CCHFORMNAME = 32;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHDEVICENAME)]
        public string dmDeviceName;
        public short dmSpecVersion;
        public short dmDriverVersion;
        public short dmSize;
        public short dmDriverExtra;
        public int dmFields;
        public int dmPositionX;
        public int dmPositionY;
        public int dmDisplayOrientation;
        public int dmDisplayFixedOutput;
        public short dmColor;
        public short dmDuplex;
        public short dmYResolution;
        public short dmTTOption;
        public short dmCollate;

        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = CCHFORMNAME)]
        public string dmFormName;
        public short dmLogPixels;
        public int dmBitsPerPel;
        public int dmPelsWidth;
        public int dmPelsHeight;
        public int dmDisplayFlags;
        public int dmDisplayFrequency;
        public int dmICMMethod;
        public int dmICMIntent;
        public int dmMediaType;
        public int dmDitherType;
        public int dmReserved1;
        public int dmReserved2;
        public int dmPanningWidth;
        public int dmPanningHeight;
    }

    const int ENUM_CURRENT_SETTINGS = -1;
    const int DM_PELSWIDTH = 0x80000;
    const int DM_PELSHEIGHT = 0x100000;
    const int CDS_TEST = 0x00000002;
    const int CDS_FULLSCREEN = 0x00000004;
    const int DISP_CHANGE_SUCCESSFUL = 0;
    const int DISP_CHANGE_RESTART = 1;

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    static extern bool EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE devMode);

    [DllImport("user32.dll", CharSet = CharSet.Unicode)]
    static extern int ChangeDisplaySettings(ref DEVMODE devMode, int flags);

    static bool SetResolution(int width, int height)
    {
        DEVMODE dm = new DEVMODE();
        dm.dmSize = (short)Marshal.SizeOf(typeof(DEVMODE));

        if (!EnumDisplaySettings(null, ENUM_CURRENT_SETTINGS, ref dm))
            return false;

        dm.dmPelsWidth = width;
        dm.dmPelsHeight = height;
        dm.dmFields = DM_PELSWIDTH | DM_PELSHEIGHT;

        int test = ChangeDisplaySettings(ref dm, CDS_TEST);
        if (test != DISP_CHANGE_SUCCESSFUL)
            return false;

        int result = ChangeDisplaySettings(ref dm, CDS_FULLSCREEN);
        return result == DISP_CHANGE_SUCCESSFUL || result == DISP_CHANGE_RESTART;
    }

    static void Main()
    {
        SetResolution(1920, 1080);
        Thread.Sleep(1000);
        SetResolution(2560, 1080);
    }
}
