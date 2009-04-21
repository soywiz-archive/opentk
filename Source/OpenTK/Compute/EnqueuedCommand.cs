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
    public sealed class EnqueuedCommand
    {
        
        static class UnsafeNativeMethods
        {
//            extern CL_API_ENTRY cl_int CL_API_CALL
//clEnqueueReadBuffer(cl_command_queue    /* command_queue */,
//                    cl_mem              /* buffer */,
//                    cl_bool             /* blocking_read */,
//                    size_t              /* offset */,
//                    size_t              /* cb */, 
//                    void *              /* ptr */,
//                    cl_uint             /* num_events_in_wait_list */,
//                    const cl_event *    /* event_wait_list */,
//                    cl_event *          /* event */) CL_API_SUFFIX__VERSION_1_0;
//                            
//extern CL_API_ENTRY cl_int CL_API_CALL
//clEnqueueWriteBuffer(cl_command_queue   /* command_queue */, 
//                     cl_mem             /* buffer */, 
//                     cl_bool            /* blocking_write */, 
//                     size_t             /* offset */, 
//                     size_t             /* cb */, 
//                     const void *       /* ptr */, 
//                     cl_uint            /* num_events_in_wait_list */, 
//                     const cl_event *   /* event_wait_list */, 
//                     cl_event *         /* event */) CL_API_SUFFIX__VERSION_1_0;
//                            
//extern CL_API_ENTRY cl_int CL_API_CALL
//clEnqueueCopyBuffer(cl_command_queue    /* command_queue */, 
//                    cl_mem              /* src_buffer */,
//                    cl_mem              /* dst_buffer */, 
//                    size_t              /* src_offset */,
//                    size_t              /* dst_offset */,
//                    size_t              /* cb */, 
//                    cl_uint             /* num_events_in_wait_list */,
//                    const cl_event *    /* event_wait_list */,
//                    cl_event *          /* event */) CL_API_SUFFIX__VERSION_1_0;
//                            
//extern CL_API_ENTRY cl_int CL_API_CALL
//clEnqueueReadImage(cl_command_queue     /* command_queue */,
//                   cl_mem               /* image */,
//                   cl_bool              /* blocking_read */, 
//                   const size_t *       /* origin[3] */,
//                   const size_t *       /* region[3] */,
//                   size_t               /* row_pitch */,
//                   size_t               /* slice_pitch */, 
//                   void *               /* ptr */,
//                   cl_uint              /* num_events_in_wait_list */,
//                   const cl_event *     /* event_wait_list */,
//                   cl_event *           /* event */) CL_API_SUFFIX__VERSION_1_0;
//
//extern CL_API_ENTRY cl_int CL_API_CALL
//clEnqueueWriteImage(cl_command_queue    /* command_queue */,
//                    cl_mem              /* image */,
//                    cl_bool             /* blocking_write */, 
//                    const size_t *      /* origin[3] */,
//                    const size_t *      /* region[3] */,
//                    size_t              /* input_row_pitch */,
//                    size_t              /* input_slice_pitch */, 
//                    const void *        /* ptr */,
//                    cl_uint             /* num_events_in_wait_list */,
//                    const cl_event *    /* event_wait_list */,
//                    cl_event *          /* event */) CL_API_SUFFIX__VERSION_1_0;
//
//extern CL_API_ENTRY cl_int CL_API_CALL
//clEnqueueCopyImage(cl_command_queue     /* command_queue */,
//                   cl_mem               /* src_image */,
//                   cl_mem               /* dst_image */, 
//                   const size_t *       /* src_origin[3] */,
//                   const size_t *       /* dst_origin[3] */,
//                   const size_t *       /* region[3] */, 
//                   cl_uint              /* num_events_in_wait_list */,
//                   const cl_event *     /* event_wait_list */,
//                   cl_event *           /* event */) CL_API_SUFFIX__VERSION_1_0;
//
//extern CL_API_ENTRY cl_int CL_API_CALL
//clEnqueueCopyImageToBuffer(cl_command_queue /* command_queue */,
//                           cl_mem           /* src_image */,
//                           cl_mem           /* dst_buffer */, 
//                           const size_t *   /* src_origin[3] */,
//                           const size_t *   /* region[3] */, 
//                           size_t           /* dst_offset */,
//                           cl_uint          /* num_events_in_wait_list */,
//                           const cl_event * /* event_wait_list */,
//                           cl_event *       /* event */) CL_API_SUFFIX__VERSION_1_0;
//
//extern CL_API_ENTRY cl_int CL_API_CALL
//clEnqueueCopyBufferToImage(cl_command_queue /* command_queue */,
//                           cl_mem           /* src_buffer */,
//                           cl_mem           /* dst_image */, 
//                           size_t           /* src_offset */,
//                           const size_t *   /* dst_origin[3] */,
//                           const size_t *   /* region[3] */, 
//                           cl_uint          /* num_events_in_wait_list */,
//                           const cl_event * /* event_wait_list */,
//                           cl_event *       /* event */) CL_API_SUFFIX__VERSION_1_0;
//
//extern CL_API_ENTRY void * CL_API_CALL
//clEnqueueMapBuffer(cl_command_queue /* command_queue */,
//                   cl_mem           /* buffer */,
//                   cl_bool          /* blocking_map */, 
//                   cl_map_flags     /* map_flags */,
//                   size_t           /* offset */,
//                   size_t           /* cb */,
//                   cl_uint          /* num_events_in_wait_list */,
//                   const cl_event * /* event_wait_list */,
//                   cl_event *       /* event */,
//                   cl_int *         /* errcode_ret */) CL_API_SUFFIX__VERSION_1_0;
//
//extern CL_API_ENTRY void * CL_API_CALL
//clEnqueueMapImage(cl_command_queue  /* command_queue */,
//                  cl_mem            /* image */, 
//                  cl_bool           /* blocking_map */, 
//                  cl_map_flags      /* map_flags */, 
//                  const size_t *    /* origin[3] */,
//                  const size_t *    /* region[3] */,
//                  size_t *          /* image_row_pitch */,
//                  size_t *          /* image_slice_pitch */,
//                  cl_uint           /* num_events_in_wait_list */,
        }
    }
}
