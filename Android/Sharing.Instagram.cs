﻿using System;

namespace Zebble.Device
{
    public partial class Sharing
    {
        public partial class Instagram
        {
            public static void ShareFile(string url, string title)
                => ShareFileToPackage("com.instagram.android", url, title);
        }
    }
}
