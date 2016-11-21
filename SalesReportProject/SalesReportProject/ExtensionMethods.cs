﻿using System;
using System.Reflection;
using System.Windows.Forms;

namespace SalesReportProject
{
    public static class ExtensionMethods
    {
        public static void DoubleBuffered(this Control dgv, bool setting)
        {
            Type dgvType = dgv.GetType();
            PropertyInfo pi = dgvType.GetProperty("DoubleBuffered",
                BindingFlags.Instance | BindingFlags.NonPublic);
            pi.SetValue(dgv, setting, null);
        }
    }
}
