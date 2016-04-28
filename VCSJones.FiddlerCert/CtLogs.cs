﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Security.Cryptography;
using VCSJones.FiddlerCert.Interop;

namespace VCSJones.FiddlerCert
{
    public static class CtLogs
    {
        public static ReadOnlyCollection<CtLogInfo> Logs { get; } = new List<CtLogInfo> {
            new CtLogInfo
            {
                Name = "DigiCert Log Server",
                Url = "https://ct1.digicert-ct.com/log/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x02, 0x46, 0xc5, 0xbe, 0x1b, 0xbb, 0x82
                                 , 0x40, 0x16, 0xe8, 0xc1, 0xd2, 0xac, 0x19, 0x69, 0x13, 0x59, 0xf8, 0xf8, 0x70, 0x85, 0x46, 0x40, 0xb9
                                 , 0x38, 0xb0, 0x23, 0x82, 0xa8, 0x64, 0x4c, 0x7f, 0xbf, 0xbb, 0x34, 0x9f, 0x4a, 0x5f, 0x28, 0x8a, 0xcf
                                 , 0x19, 0xc4, 0x00, 0xf6, 0x36, 0x06, 0x93, 0x65, 0xed, 0x4c, 0xf5, 0xa9, 0x21, 0x62, 0x5a, 0xd8, 0x91
                                 , 0xeb, 0x38, 0x24, 0x40, 0xac, 0xe8 }
            },
            new CtLogInfo
            {
                Name = "Google 'Pilot' Log",
                Url = "https://ct.googleapis.com/pilot/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x7d, 0xa8, 0x4b, 0x12, 0x29, 0x80, 0xa3
                                 , 0x3d, 0xad, 0xd3, 0x5a, 0x77, 0xb8, 0xcc, 0xe2, 0x88, 0xb3, 0xa5, 0xfd, 0xf1, 0xd3, 0x0c, 0xcd, 0x18
                                 , 0x0c, 0xe8, 0x41, 0x46, 0xe8, 0x81, 0x01, 0x1b, 0x15, 0xe1, 0x4b, 0xf1, 0x1b, 0x62, 0xdd, 0x36, 0x0a
                                 , 0x08, 0x18, 0xba, 0xed, 0x0b, 0x35, 0x84, 0xd0, 0x9e, 0x40, 0x3c, 0x2d, 0x9e, 0x9b, 0x82, 0x65, 0xbd
                                 , 0x1f, 0x04, 0x10, 0x41, 0x4c, 0xa0 }
            },
            new CtLogInfo
            {
                Name = "Google 'Aviator' Log",
                Url = "https://ct.googleapis.com/aviator/",
                Key = new byte [] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                  , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0xd7, 0xf4, 0xcc, 0x69, 0xb2, 0xe4, 0x0e
                                  , 0x90, 0xa3, 0x8a, 0xea, 0x5a, 0x70, 0x09, 0x4f, 0xef, 0x13, 0x62, 0xd0, 0x8d, 0x49, 0x60, 0xff, 0x1b
                                  , 0x40, 0x50, 0x07, 0x0c, 0x6d, 0x71, 0x86, 0xda, 0x25, 0x49, 0x8d, 0x65, 0xe1, 0x08, 0x0d, 0x47, 0x34
                                  , 0x6b, 0xbd, 0x27, 0xbc, 0x96, 0x21, 0x3e, 0x34, 0xf5, 0x87, 0x76, 0x31, 0xb1, 0x7f, 0x1d, 0xc9, 0x85
                                  , 0x3b, 0x0d, 0xf7, 0x1f, 0x3f, 0xe9 }
            },
            new CtLogInfo
            {
                Name = "Certly.IO Log",
                Url = "https://log.certly.io/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x0b, 0x23, 0xcb, 0x85, 0x62, 0x98, 0x61
                                 , 0x48, 0x04, 0x73, 0xeb, 0x54, 0x5d, 0xf3, 0xd0, 0x07, 0x8c, 0x2d, 0x19, 0x2d, 0x8c, 0x36, 0xf5, 0xeb
                                 , 0x8f, 0x01, 0x42, 0x0a, 0x7c, 0x98, 0x26, 0x27, 0xc1, 0xb5, 0xdd, 0x92, 0x93, 0xb0, 0xae, 0xf8, 0x9b
                                 , 0x3d, 0x0c, 0xd8, 0x4c, 0x4e, 0x1d, 0xf9, 0x15, 0xfb, 0x47, 0x68, 0x7b, 0xba, 0x66, 0xb7, 0x25, 0x9c
                                 , 0xd0, 0x4a, 0xc2, 0x66, 0xdb, 0x48 }
            },
            new CtLogInfo
            {
                Name = "Izenpe log",
                Url = "https://ct.izenpe.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x27, 0x64, 0x39, 0x0c, 0x2d, 0xdc, 0x50
                                 , 0x18, 0xf8, 0x21, 0x00, 0xa2, 0x0e, 0xed, 0x2c, 0xea, 0x3e, 0x75, 0xba, 0x9f, 0x93, 0x64, 0x09, 0x00
                                 , 0x11, 0xc4, 0x11, 0x17, 0xab, 0x5c, 0xcf, 0x0f, 0x74, 0xac, 0xb5, 0x97, 0x90, 0x93, 0x00, 0x5b, 0xb8
                                 , 0xeb, 0xf7, 0x27, 0x3d, 0xd9, 0xb2, 0x0a, 0x81, 0x5f, 0x2f, 0x0d, 0x75, 0x38, 0x94, 0x37, 0x99, 0x1e
                                 , 0xf6, 0x07, 0x76, 0xe0, 0xee, 0xbe }
            },
            new CtLogInfo
            {
                Name = "Symantec log",
                Url = "https://ct.ws.symantec.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0x96, 0xea, 0xac, 0x1c, 0x46, 0x0c, 0x1b
                                 , 0x55, 0xdc, 0x0d, 0xfc, 0xb5, 0x94, 0x27, 0x46, 0x57, 0x42, 0x70, 0x3a, 0x69, 0x18, 0xe2, 0xbf, 0x3b
                                 , 0xc4, 0xdb, 0xab, 0xa0, 0xf4, 0xb6, 0x6c, 0xc0, 0x53, 0x3f, 0x4d, 0x42, 0x10, 0x33, 0xf0, 0x58, 0x97
                                 , 0x8f, 0x6b, 0xbe, 0x72, 0xf4, 0x2a, 0xec, 0x1c, 0x42, 0xaa, 0x03, 0x2f, 0x1a, 0x7e, 0x28, 0x35, 0x76
                                 , 0x99, 0x08, 0x3d, 0x21, 0x14, 0x86 }
            },
            new CtLogInfo
            {
                Name = "Venafi log",
                Url = "https://ctlog.api.venafi.com/",
                Key = new byte[] { 0x30, 0x82, 0x01, 0x22, 0x30, 0x0d, 0x06, 0x09, 0x2a, 0x86, 0x48, 0x86, 0xf7, 0x0d, 0x01, 0x01, 0x01
                                 , 0x05, 0x00, 0x03, 0x82, 0x01, 0x0f, 0x00, 0x30, 0x82, 0x01, 0x0a, 0x02, 0x82, 0x01, 0x01, 0x00, 0xa2
                                 , 0x5a, 0x48, 0x1f, 0x17, 0x52, 0x95, 0x35, 0xcb, 0xa3, 0x5b, 0x3a, 0x1f, 0x53, 0x82, 0x76, 0x94, 0xa3
                                 , 0xff, 0x80, 0xf2, 0x1c, 0x37, 0x3c, 0xc0, 0xb1, 0xbd, 0xc1, 0x59, 0x8b, 0xab, 0x2d, 0x65, 0x93, 0xd7
                                 , 0xf3, 0xe0, 0x04, 0xd5, 0x9a, 0x6f, 0xbf, 0xd6, 0x23, 0x76, 0x36, 0x4f, 0x23, 0x99, 0xcb, 0x54, 0x28
                                 , 0xad, 0x8c, 0x15, 0x4b, 0x65, 0x59, 0x76, 0x41, 0x4a, 0x9c, 0xa6, 0xf7, 0xb3, 0x3b, 0x7e, 0xb1, 0xa5
                                 , 0x49, 0xa4, 0x17, 0x51, 0x6c, 0x80, 0xdc, 0x2a, 0x90, 0x50, 0x4b, 0x88, 0x24, 0xe9, 0xa5, 0x12, 0x32
                                 , 0x93, 0x04, 0x48, 0x90, 0x02, 0xfa, 0x5f, 0x0e, 0x30, 0x87, 0x8e, 0x55, 0x76, 0x05, 0xee, 0x2a, 0x4c
                                 , 0xce, 0xa3, 0x6a, 0x69, 0x09, 0x6e, 0x25, 0xad, 0x82, 0x76, 0x0f, 0x84, 0x92, 0xfa, 0x38, 0xd6, 0x86
                                 , 0x4e, 0x24, 0x8f, 0x9b, 0xb0, 0x72, 0xcb, 0x9e, 0xe2, 0x6b, 0x3f, 0xe1, 0x6d, 0xc9, 0x25, 0x75, 0x23
                                 , 0x88, 0xa1, 0x18, 0x58, 0x06, 0x23, 0x33, 0x78, 0xda, 0x00, 0xd0, 0x38, 0x91, 0x67, 0xd2, 0xa6, 0x7d
                                 , 0x27, 0x97, 0x67, 0x5a, 0xc1, 0xf3, 0x2f, 0x17, 0xe6, 0xea, 0xd2, 0x5b, 0xe8, 0x81, 0xcd, 0xfd, 0x92
                                 , 0x68, 0xe7, 0xf3, 0x06, 0xf0, 0xe9, 0x72, 0x84, 0xee, 0x01, 0xa5, 0xb1, 0xd8, 0x33, 0xda, 0xce, 0x83
                                 , 0xa5, 0xdb, 0xc7, 0xcf, 0xd6, 0x16, 0x7e, 0x90, 0x75, 0x18, 0xbf, 0x16, 0xdc, 0x32, 0x3b, 0x6d, 0x8d
                                 , 0xab, 0x82, 0x17, 0x1f, 0x89, 0x20, 0x8d, 0x1d, 0x9a, 0xe6, 0x4d, 0x23, 0x08, 0xdf, 0x78, 0x6f, 0xc6
                                 , 0x05, 0xbf, 0x5f, 0xae, 0x94, 0x97, 0xdb, 0x5f, 0x64, 0xd4, 0xee, 0x16, 0x8b, 0xa3, 0x84, 0x6c, 0x71
                                 , 0x2b, 0xf1, 0xab, 0x7f, 0x5d, 0x0d, 0x32, 0xee, 0x04, 0xe2, 0x90, 0xec, 0x41, 0x9f, 0xfb, 0x39, 0xc1
                                 , 0x02, 0x03, 0x01, 0x00, 0x01 }
            },
            new CtLogInfo
            {
                Name = "Symantec 'Vega' log",
                Url = "https://vega.ws.symantec.com/",
                Key = new byte[] { 0x30, 0x59, 0x30, 0x13, 0x06, 0x07, 0x2a, 0x86, 0x48, 0xce, 0x3d, 0x02, 0x01, 0x06, 0x08, 0x2a, 0x86
                                 , 0x48, 0xce, 0x3d, 0x03, 0x01, 0x07, 0x03, 0x42, 0x00, 0x04, 0xea, 0x95, 0x9e, 0x02, 0xff, 0xee, 0xf1
                                 , 0x33, 0x6d, 0x4b, 0x87, 0xbc, 0xcd, 0xfd, 0x19, 0x17, 0x62, 0xff, 0x94, 0xd3, 0xd0, 0x59, 0x07, 0x3f
                                 , 0x02, 0x2d, 0x1c, 0x90, 0xfe, 0xc8, 0x47, 0x30, 0x3b, 0xf1, 0xdd, 0x0d, 0xb8, 0x11, 0x0c, 0x5d, 0x1d
                                 , 0x86, 0xdd, 0xab, 0xd3, 0x2b, 0x46, 0x66, 0xfb, 0x6e, 0x65, 0xb7, 0x3b, 0xfd, 0x59, 0x68, 0xac, 0xdf
                                 , 0xa6, 0xf8, 0xce, 0xd2, 0x18, 0x4d }
            }
        }.AsReadOnly();

        public static CtLogInfo FindByLogId(byte[] logId)
        {
            using (var sha = new SHA256Cng())
            {
                foreach(var log in Logs)
                {
                    var hash = sha.ComputeHash(log.Key);
                    if (logId.Length != hash.Length)
                    {
                        continue;
                    }
                    if (hash.MemoryCompare(logId))
                    {
                        return log;
                    }
                }
            }
            return null;
        }
    }

    public sealed class CtLogInfo
    {
        public string Name { get; set; }
        public byte[] Key { get; set; }
        public string Url { get; set; }
    }
}
