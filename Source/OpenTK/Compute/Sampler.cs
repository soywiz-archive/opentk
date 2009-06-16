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
    public sealed class Sampler
    {
        static class UnsafeNativeMethods
        {
//            extern CL_API_ENTRY cl_sampler CL_API_CALL
//clCreateSampler(cl_context          /* context */,
//                cl_bool             /* normalized_coords */, 
//                cl_addressing_mode  /* addressing_mode */, 
//                cl_filter_mode      /* filter_mode */,
//                cl_int *            /* errcode_ret */) CL_API_SUFFIX__VERSION_1_0;
//
//extern CL_API_ENTRY cl_int CL_API_CALL
//clRetainSampler(cl_sampler /* sampler */) CL_API_SUFFIX__VERSION_1_0;
//
//extern CL_API_ENTRY cl_int CL_API_CALL
//clReleaseSampler(cl_sampler /* sampler */) CL_API_SUFFIX__VERSION_1_0;
//
//extern CL_API_ENTRY cl_int CL_API_CALL
//clGetSamplerInfo(cl_sampler         /* sampler */,
//                 cl_sampler_info    /* param_name */,
//                 size_t             /* param_value_size */,
//                 void *             /* param_value */,
//                 size_t *           /* param_value_size_ret */) CL_API_SUFFIX__VERSION_1_0;
        }
    }
}