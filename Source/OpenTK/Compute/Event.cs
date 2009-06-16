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
    public sealed class Event
    {
        
        static class NativeMethods
        {
            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clWaitForEvents")]
            unsafe public static extern int WaitForEvents(uint num_events, EventId* event_list);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clGetEventInfo")]
            unsafe public static extern int GetEventInfo(EventId id,
                EventInfo param_name,
                /* size_t */ IntPtr param_value_size,
                void* param_value,
                /* size_t* */ IntPtr param_value_size_ret);

            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clRetainEvent")]
            unsafe public static extern int RetainEvent(EventId @event);
            
            // OpenCL 1.0
            [DllImport(Configuration.Library, EntryPoint = "clReleaseEvent")]
            unsafe public static extern int ReleaseEvent(EventId @event);
        }
    }
}
