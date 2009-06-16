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
            unsafe public static extern CommandQueueId CreateCommandQueue(ContextId context,
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
            public static extern int GetCommandQueueInfo(CommandQueueId command_queue,
                CommandQueueInfo param_name,
                /* size_t */ IntPtr param_value_size,
                /* void * */ IntPtr param_value,
                /* size_t * */ IntPtr param_value_size_ret);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clSetCommandQueueProperty")]
            unsafe public static extern int SetCommandQueueProperty(CommandQueueId command_queue,
                CommandQueueProperties properties,
                bool enable,
                CommandQueueProperties* old_properties);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueReadBuffer")]
            unsafe public static extern int EnqueueReadBuffer(CommandQueueId command_queue,
                MemoryId buffer,
                bool blocking_read,
                /* size_t */ IntPtr offset,
                /* size_t */ IntPtr cb,
                void* ptr,
                uint num_events_in_wait_list,
                EventId* event_wait_list,
                EventId* @event);
            
            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueWriteBuffer")]
            unsafe public static extern int EnqueueWriteBuffer(CommandQueueId command_queue,
                MemoryId buffer,
                bool blocking_write,
                /* size_t */ IntPtr offset,
                /* size_t */ IntPtr cb,
                void* ptr,
                uint num_events_in_wait_list,
                EventId* event_wait_list,
                EventId* @event);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueCopyBuffer")]
            unsafe public static extern int EnqueueCopyBuffer(CommandQueueId command_queue,
                MemoryId src_buffer,
                MemoryId dst_buffer,
                /* size_t */ IntPtr src_offset,
                /* size_t */ IntPtr dst_offset,
                /* size_t */ IntPtr cb,
                uint num_events_in_wait_list,
                EventId* event_wait_list,
                EventId* @event);
            
            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueReadImage")]
            unsafe public static extern int EnqueueReadImage(CommandQueueId command_queue,
               MemoryId image,
               bool blocking_read,
               [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] origin,
               [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
                /* size_t */ IntPtr row_pitch,
                /* size_t */ IntPtr slice_pitch,
               void* ptr,
               uint num_events_in_wait_list,
               EventId* event_wait_list,
               EventId* @event);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueWriteImage")]
            unsafe public static extern int EnqueueWriteImage(CommandQueueId command_queue,
               MemoryId image,
               bool blocking_write,
               [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] origin,
               [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
                /* size_t */ IntPtr input_row_pitch,
                /* size_t */ IntPtr input_slice_pitch,
               void* ptr,
               uint num_events_in_wait_list,
               EventId* event_wait_list,
               EventId* @event);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueCopyImage")]
            unsafe public static extern int EnqueueCopyImage(CommandQueueId command_queue,
                MemoryId src_image,
                MemoryId dst_image,
                [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] src_origin,
                [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] dst_origin,
                [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
                uint num_events_in_wait_list,
                EventId* event_wait_list,
                EventId* @event);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueCopyImageToBuffer")]
            unsafe public static extern int EnqueueCopyImageToBuffer(CommandQueueId command_queue,
                MemoryId src_image,
                MemoryId dst_buffer,
                [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] src_origin,
                [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
                /* size_t */ IntPtr dst_offset,
                uint num_events_in_wait_list,
                EventId* event_wait_list,
                EventId* @event);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueCopyBufferToImage")]
            unsafe public static extern int EnqueueCopyBufferToImage(CommandQueueId command_queue,
                MemoryId src_buffer,
                MemoryId dst_image,
                /* size_t */ IntPtr src_offset,
                [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] dst_origin,
                [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
                uint num_events_in_wait_list,
                EventId* event_wait_list,
                EventId* @event);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueMapBuffer")]
            unsafe public static extern void* EnqueueMapBuffer(CommandQueueId command_queue,
                MemoryId buffer,
                bool blocking_map,
                MapFlags map_flags,
                /* size_t */ IntPtr offset,
                /* size_t */ IntPtr cb,
                uint num_events_in_wait_list,
                EventId* event_wait_list,
                EventId* @event,
                int* errorcode_ret);
            
            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clEnqueueMapImage")]
            unsafe public static extern void* EnqueueMapImage(CommandQueueId command_queue,
                MemoryId image,
                bool blocking_map,
                MapFlags map_flags,
                [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] origin,
                [MarshalAs(UnmanagedType.LPArray, SizeConst = 3)] /* size_t * */ IntPtr[] region,
                /* size_t * */ IntPtr image_row_pitch,
                /* size_t * */ IntPtr image_slice_pitch,
                uint num_events_in_wait_list,
                EventId* event_wait_list,
                EventId* @event,
                int* errorcode_ret);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clFlush")]
            public static extern int Flush(CommandQueueId command_queue);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clFinish")]
            public static extern int Finish(CommandQueueId command_queue);
        }
    }
}
