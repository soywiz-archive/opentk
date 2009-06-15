#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2009 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;
using System.Runtime.InteropServices;

namespace OpenTK.Compute
{
    public sealed class CommandQueue
    {
        static class UnsafeNativeMethods
        {
            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint="clCreateCommandQueue")]
            unsafe public static extern CommandQueueId CreateCommandQueue(
                ContextId context,
                DeviceId device,
                CommandQueueProperties properties,
                int* errorcode_ret);
            
            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clRetainCommandQueue")]
            public static extern int RetainCommandQueue(CommandQueueId command_queue);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clReleaseCommandQueue")]
            public static extern int ReleaseCommandQueue(CommandQueueId command_queue);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clGetCommandQueueInfo")]
            public static extern int GetCommandQueueInfo(
                CommandQueueId command_queue,
                CommandQueueInfo param_name,
                /* size_t */ IntPtr param_value_size,
                /* void * */ IntPtr param_value,
                /* size_t * */ IntPtr param_value_size_ret);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clSetCommandQueueProperty")]
            unsafe public static extern int SetCommandQueueProperty(
                CommandQueueId command_queue,
                CommandQueueProperties properties,
                bool enable,
                CommandQueueProperties* old_properties);
        }
    }
}
