﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace Diag_Tool_leon
{
    public class DllTest
    {
       // public class DllInvoke
        

            [DllImport("Kernel32.dll")]
            private static extern IntPtr LoadLibrary(string path);

            [DllImport("Kernel32.dll")]
            private static extern IntPtr GetProcAddress(IntPtr lib, string FunName);

            [DllImport("kernel32.dll")]
            public static extern bool FreeLibrary(IntPtr lib);

            private IntPtr libr;

            public DllTest(string path)
            {
                libr = LoadLibrary(path);
            }

             public Delegate Invoke(string funName, Type type)
            {
                IntPtr api = GetProcAddress(libr, funName);
                return (Delegate)Marshal.GetDelegateForFunctionPointer(api, type);
            }

            ~DllTest()
            {
                FreeLibrary(libr);//释放。必须的
            }
    }


}
