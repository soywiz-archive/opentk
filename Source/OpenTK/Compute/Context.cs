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
using System.Collections.Generic;

namespace OpenTK.Compute
{
    public sealed class Context
    {
        public Context(IEnumerable<Device> devices,
            ref ContextProperty properties,
            object data,
            out ErrorCode error)
        {
            error = ErrorCode.Success;
            //object_ = ::clCreateContext(
            //    properties, (cl_uint) devices.size(),
            //    (cl_device_id*) &devices.front(),
            //    notifyFptr, data, &error);
    
            //detail::errHandler(error, __CREATE_CONTEXT_FROM_TYPE_ERR);
            //if (err != NULL) {
            //    *err = error;
            //}
        }

        static class UnsafeNativeMethods
        {
//            typedef void (*logging_fn)(const char *, const void *, size_t, const void *);
//  
//            extern CL_API_ENTRY cl_context CL_API_CALL
//            clCreateContext(cl_context_properties * /* properties */,
//                            cl_uint                 /* num_devices */,
//                            const cl_device_id *    /* devices */,
//                            logging_fn              /* pfn_notify */,
//                            void *                  /* user_data */,
//                            cl_int *                /* errcode_ret */) CL_API_SUFFIX__VERSION_1_0;
//            
//            extern CL_API_ENTRY cl_context CL_API_CALL
//            clCreateContextFromType(cl_context_properties * /* properties */,
//                                    cl_device_type          /* device_type */,
//                                    logging_fn              /* pfn_notify */,
//                                    void *                  /* user_data */,
//                                    cl_int *                /* errcode_ret */) CL_API_SUFFIX__VERSION_1_0;
//            
//            extern CL_API_ENTRY cl_int CL_API_CALL
//            clRetainContext(cl_context /* context */) CL_API_SUFFIX__VERSION_1_0;
//            
//            extern CL_API_ENTRY cl_int CL_API_CALL
//            clReleaseContext(cl_context /* context */) CL_API_SUFFIX__VERSION_1_0;
//            
//            extern CL_API_ENTRY cl_int CL_API_CALL
//            clGetContextInfo(cl_context         /* context */, 
//                             cl_context_info    /* param_name */, 
//                             size_t             /* param_value_size */, 
//                             void *             /* param_value */, 
//                             size_t *           /* param_value_size_ret */) CL_API_SUFFIX__VERSION_1_0;

        }
    }
}
