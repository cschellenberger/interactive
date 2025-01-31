﻿// Copyright (c) .NET Foundation and contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.DotNet.Interactive.Commands
{
    public class ParseInteractiveDocument : KernelCommand
    {
        public string FileName { get; }
        public byte[] RawData { get; }

        public ParseInteractiveDocument(string fileName, byte[] rawData, string targetKernelName = null)
            : base(targetKernelName)
        {
            FileName = fileName;
            RawData = rawData;
        }
    }
}
