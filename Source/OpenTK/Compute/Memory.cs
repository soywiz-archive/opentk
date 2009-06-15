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
    public abstract class Memory
    {
        static class NativeMethods
        {
            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clCreateBuffer")]
            unsafe public static extern MemoryId CreateBuffer(ContextId context,
                MemFlags flags,
                /* size_t */ IntPtr size,
                void* host_ptr,
                int* errcode_ret);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clCreateImage2D")]
            unsafe public static extern MemoryId CreateImage2D(ContextId context,
                MemFlags flags,
                ImageFormat* image_format,
                /* size_t */ IntPtr image_width,
                /* size_t */ IntPtr image_height,
                /* size_t */ IntPtr image_row_pitch,
                void* host_ptr,
                int* errcode_ret);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clCreateImage3D")]
            unsafe public static extern MemoryId CreateImage3D(ContextId context,
                MemFlags flags,
                ImageFormat* image_format,
                /* size_t */ IntPtr image_width,
                /* size_t */ IntPtr image_height,
                /* size_t */ IntPtr image_row_pitch,
                /* size_t */ IntPtr image_slice_pitch,
                void* host_ptr,
                int* errcode_ret);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clRetainMemObject")]
            public static extern int RetainMemObject(MemoryId memobj);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clReleaseMemObject")]
            public static extern int ReleaseMemObject(MemoryId memobj);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clGetSupportedImageFormats")]
            unsafe public static extern int GetSupportedImageFormats(ContextId context,
                MemFlags flags,
                MemObjectType image_type,
                uint num_entries,
                ImageFormat* image_formats,
                uint* num_image_formats);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clGetMemObjectInfo")]
            unsafe public static extern int GetMemObjectInfo(MemoryId memobj,
                MemInfo param_name,
                /* size_t */ IntPtr param_value_size,
                void* param_value,
                /* size_t * */ IntPtr param_value_size_ret);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clGetImageInfo")]
            unsafe public static extern int GetImageInfo(MemoryId image,
                ImageInfo param_name,
                /* size_t */ IntPtr param_value_size,
                void* param_value,
                /* size_t * */ IntPtr param_value_size_ret);
        }
    }
}
