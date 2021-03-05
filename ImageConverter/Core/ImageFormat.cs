﻿using ImageConverter.Common;
using ImageConverter.Core.CX;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Windows.Graphics.Imaging;

namespace ImageConverter.Core
{
    [DebuggerDisplay("{CodecInfo.FriendlyName}")]
    public class ImageFormat
    {
        public BitmapCodecInformation CodecInfo { get; }
        public string DisplayName { get; }
        public string DefaultFileExtension { get; }

        public Format Format { get; }

        public ImageFormat(BitmapCodecInformation info)
        {
            CodecInfo = info;
            DisplayName = ImageConverterCore.GetPrefferedDisplayName(info);
            DefaultFileExtension = ImageConverterCore.GetPrefferedFileExtension(info);
            Format = ImageConverterCore.GetFormat(info);
        }
    }
}
