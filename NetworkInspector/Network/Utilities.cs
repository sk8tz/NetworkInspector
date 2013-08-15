﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading;

namespace NetworkInspector.Network {
    public static class Utilities {
        static Utilities() {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.CreateSpecificCulture("en-US");
        }

        // <summary>
        // Returns a list of all available network interfaces
        // </summary>
        public static IList<string> GetNetworkInterfaces() {
            return new PerformanceCounterCategory("Network Interface").GetInstanceNames().ToList();
        }

        // <summary>
        // Returns details about the given network interface
        // </summary>
        public static NetworkInterface GetInterfaceInformation(string name) {
            return NetworkInterface.GetAllNetworkInterfaces().FirstOrDefault(x => x.Description == name);
        }
    }
}