﻿using Exrin.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exrin.Insights
{
    public class DeviceInfo : IDeviceInfo
    {
        public Version GetAppVersion()
        {
            return new Version("0.0.0.0");
        }

        public Task<double?> GetBattery()
        {
            return Task.FromResult((Nullable<double>)0.0);
        }

        public Task<double?> GetConnectionStrength()
        {
            return Task.FromResult((Nullable<double>)0.0);
        }

        public ConnectionType GetConnectionType()
        {
            return ConnectionType.Unknown;
        }

        public Task<string> GetIPAddress()
        {
            return Task.FromResult("255.255.255.255");
        }

        public Task<string> GetModel()
        {
            return Task.FromResult("Unknown");
        }

        public string GetOS()
        {
            return "Unknown";
        }

        public Task<Version> GetOSVersion()
        {
            return Task.FromResult(new Version("0.0.0.0"));
        }

        public Size GetScreenSize()
        {
            return new Size(0, 0);
        }

        public string GetUniqueId()
        {
            return "Unknown";
        }
    }
}
