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

namespace OpenTK.Compute
{
    public sealed class Memory
    {
        static class UnsafeNativeMethods
        {
//                    
//            extern CL_API_ENTRY cl_mem CL_API_CALL
//            clCreateBuffer(cl_context   /* context */,
//                           cl_mem_flags /* flags */,
//                           size_t       /* size */,
//                           void *       /* host_ptr */,
//                           cl_int *     /* errcode_ret */) CL_API_SUFFIX__VERSION_1_0;
//            
//            extern CL_API_ENTRY cl_mem CL_API_CALL
//            clCreateImage2D(cl_context              /* context */,
//                            cl_mem_flags            /* flags */,
//                            const cl_image_format * /* image_format */,
//                            size_t                  /* image_width */,
//                            size_t                  /* image_height */,
//                            size_t                  /* image_row_pitch */, 
//                            void *                  /* host_ptr */,
//                            cl_int *                /* errcode_ret */) CL_API_SUFFIX__VERSION_1_0;
//                                    
//            extern CL_API_ENTRY cl_mem CL_API_CALL
//            clCreateImage3D(cl_context              /* context */,
//                            cl_mem_flags            /* flags */,
//                            const cl_image_format * /* image_format */,
//                            size_t                  /* image_width */, 
//                            size_t                  /* image_height */,
//                            size_t                  /* image_depth */, 
//                            size_t                  /* image_row_pitch */, 
//                            size_t                  /* image_slice_pitch */, 
//                            void *                  /* host_ptr */,
//                            cl_int *                /* errcode_ret */) CL_API_SUFFIX__VERSION_1_0;
//                                    
//            extern CL_API_ENTRY cl_int CL_API_CALL
//            clRetainMemObject(cl_mem /* memobj */) CL_API_SUFFIX__VERSION_1_0;
//            
//            extern CL_API_ENTRY cl_int CL_API_CALL
//            clReleaseMemObject(cl_mem /* memobj */) CL_API_SUFFIX__VERSION_1_0;
//            
//            extern CL_API_ENTRY cl_int CL_API_CALL
//            clGetSupportedImageFormats(cl_context           /* context */,
//                                       cl_mem_flags         /* flags */,
//                                       cl_mem_object_type   /* image_type */,
//                                       cl_uint              /* num_entries */,
//                                       cl_image_format *    /* image_formats */,
//                                       cl_uint *            /* num_image_formats */) CL_API_SUFFIX__VERSION_1_0;
//                                                
//            extern CL_API_ENTRY cl_int CL_API_CALL
//            clGetMemObjectInfo(cl_mem           /* memobj */,
//                               cl_mem_info      /* param_name */, 
//                               size_t           /* param_value_size */,
//                               void *           /* param_value */,
//                               size_t *         /* param_value_size_ret */) CL_API_SUFFIX__VERSION_1_0;
//            
//            extern CL_API_ENTRY cl_int CL_API_CALL
//            clGetImageInfo(cl_mem           /* image */,
//                           cl_image_info    /* param_name */, 
//                           size_t           /* param_value_size */,
//                           void *           /* param_value */,
//                           size_t *         /* param_value_size_ret */) CL_API_SUFFIX__VERSION_1_0;
        }
    }
}
