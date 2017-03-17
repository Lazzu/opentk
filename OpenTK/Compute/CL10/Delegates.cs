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

#if EXPERIMENTAL

namespace OpenTK.Compute.CL10
{
    using System;
    using System.Text;
    using System.Runtime.InteropServices;
    #pragma warning disable 0649
    #pragma warning disable 3019
    #pragma warning disable 1591

    partial class CL
    {
        internal static partial class Delegates
        {
            
            internal unsafe delegate int BuildProgram(IntPtr program, uint num_devices, IntPtr* device_list, String options, IntPtr pfn_notify, IntPtr user_data);
            internal unsafe static BuildProgram clBuildProgram;
            
            internal unsafe delegate IntPtr CreateBuffer(IntPtr context, MemFlags flags, IntPtr size, IntPtr host_ptr, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            internal unsafe static CreateBuffer clCreateBuffer;
            
            internal unsafe delegate IntPtr CreateCommandQueue(IntPtr context, IntPtr device, CommandQueueFlags properties, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            internal unsafe static CreateCommandQueue clCreateCommandQueue;
            
            internal unsafe delegate IntPtr CreateContext(IntPtr* properties, uint num_devices, IntPtr* devices, IntPtr pfn_notify, IntPtr user_data, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            internal unsafe static CreateContext clCreateContext;
            
            internal unsafe delegate IntPtr CreateContextFromType(IntPtr* properties, DeviceTypeFlags device_type, IntPtr pfn_notify, IntPtr user_data, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            internal unsafe static CreateContextFromType clCreateContextFromType;
            
            internal unsafe delegate IntPtr CreateImage2D(IntPtr context, MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_row_pitch, IntPtr host_ptr, [OutAttribute] int* errcode_ret);
            internal unsafe static CreateImage2D clCreateImage2D;
            
            internal unsafe delegate IntPtr CreateImage3D(IntPtr context, MemFlags flags, ImageFormat* image_format, IntPtr image_width, IntPtr image_height, IntPtr image_depth, IntPtr image_row_pitch, IntPtr image_slice_pitch, IntPtr host_ptr, [OutAttribute] int* errcode_ret);
            internal unsafe static CreateImage3D clCreateImage3D;
            
            internal unsafe delegate IntPtr CreateKernel(IntPtr program, String kernel_name, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            internal unsafe static CreateKernel clCreateKernel;
            
            internal unsafe delegate int CreateKernelsInProgram(IntPtr program, uint num_kernels, IntPtr* kernels, [OutAttribute] uint* num_kernels_ret);
            internal unsafe static CreateKernelsInProgram clCreateKernelsInProgram;
            
            internal unsafe delegate IntPtr CreateProgramWithBinary(IntPtr context, uint num_devices, IntPtr* device_list, IntPtr* lengths, byte** binaries, int* binary_status, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            internal unsafe static CreateProgramWithBinary clCreateProgramWithBinary;
            
            internal unsafe delegate IntPtr CreateProgramWithSource(IntPtr context, uint count, String[] strings, IntPtr* lengths, [OutAttribute] OpenTK.Compute.CL10.ErrorCode* errcode_ret);
            internal unsafe static CreateProgramWithSource clCreateProgramWithSource;
            
            internal unsafe delegate IntPtr CreateSampler(IntPtr context, bool normalized_coords, AddressingMode addressing_mode, FilterMode filter_mode, [OutAttribute] int* errcode_ret);
            internal unsafe static CreateSampler clCreateSampler;
            
            internal delegate int EnqueueBarrier(IntPtr command_queue);
            internal static EnqueueBarrier clEnqueueBarrier;
            
            internal unsafe delegate int EnqueueCopyBuffer(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_buffer, IntPtr src_offset, IntPtr dst_offset, IntPtr cb, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueCopyBuffer clEnqueueCopyBuffer;
            
            internal unsafe delegate int EnqueueCopyBufferToImage(IntPtr command_queue, IntPtr src_buffer, IntPtr dst_image, IntPtr src_offset, IntPtr** dst_origin, IntPtr** region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueCopyBufferToImage clEnqueueCopyBufferToImage;
            
            internal unsafe delegate int EnqueueCopyImage(IntPtr command_queue, IntPtr src_image, IntPtr dst_image, IntPtr** src_origin, IntPtr** dst_origin, IntPtr** region, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueCopyImage clEnqueueCopyImage;
            
            internal unsafe delegate int EnqueueCopyImageToBuffer(IntPtr command_queue, IntPtr src_image, IntPtr dst_buffer, IntPtr** src_origin, IntPtr** region, IntPtr dst_offset, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueCopyImageToBuffer clEnqueueCopyImageToBuffer;
            
            internal unsafe delegate System.IntPtr EnqueueMapBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_map, MapFlags map_flags, IntPtr offset, IntPtr cb, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, [OutAttribute] int* errcode_ret);
            internal unsafe static EnqueueMapBuffer clEnqueueMapBuffer;
            
            internal unsafe delegate System.IntPtr EnqueueMapImage(IntPtr command_queue, IntPtr image, bool blocking_map, MapFlags map_flags, IntPtr** origin, IntPtr** region, IntPtr* image_row_pitch, IntPtr* image_slice_pitch, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event, [OutAttribute] int* errcode_ret);
            internal unsafe static EnqueueMapImage clEnqueueMapImage;
            
            internal unsafe delegate int EnqueueMarker(IntPtr command_queue, IntPtr* @event);
            internal unsafe static EnqueueMarker clEnqueueMarker;
            
            internal unsafe delegate int EnqueueNativeKernel(IntPtr command_queue, IntPtr user_func, IntPtr args, IntPtr cb_args, uint num_mem_objects, IntPtr* mem_list, IntPtr args_mem_loc, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueNativeKernel clEnqueueNativeKernel;
            
            internal unsafe delegate int EnqueueNDRangeKernel(IntPtr command_queue, IntPtr kernel, uint work_dim, IntPtr* global_work_offset, IntPtr* global_work_size, IntPtr* local_work_size, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueNDRangeKernel clEnqueueNDRangeKernel;
            
            internal unsafe delegate int EnqueueReadBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_read, IntPtr offset, IntPtr cb, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueReadBuffer clEnqueueReadBuffer;
            
            internal unsafe delegate int EnqueueReadImage(IntPtr command_queue, IntPtr image, bool blocking_read, IntPtr** origin, IntPtr** region, IntPtr row_pitch, IntPtr slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueReadImage clEnqueueReadImage;
            
            internal unsafe delegate int EnqueueTask(IntPtr command_queue, IntPtr kernel, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueTask clEnqueueTask;
            
            internal unsafe delegate int EnqueueUnmapMemObject(IntPtr command_queue, IntPtr memobj, IntPtr mapped_ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueUnmapMemObject clEnqueueUnmapMemObject;
            
            internal unsafe delegate int EnqueueWaitForEvents(IntPtr command_queue, uint num_events, IntPtr* event_list);
            internal unsafe static EnqueueWaitForEvents clEnqueueWaitForEvents;
            
            internal unsafe delegate int EnqueueWriteBuffer(IntPtr command_queue, IntPtr buffer, bool blocking_write, IntPtr offset, IntPtr cb, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueWriteBuffer clEnqueueWriteBuffer;
            
            internal unsafe delegate int EnqueueWriteImage(IntPtr command_queue, IntPtr image, bool blocking_write, IntPtr** origin, IntPtr** region, IntPtr input_row_pitch, IntPtr input_slice_pitch, IntPtr ptr, uint num_events_in_wait_list, IntPtr* event_wait_list, IntPtr* @event);
            internal unsafe static EnqueueWriteImage clEnqueueWriteImage;
            
            internal delegate int Finish(IntPtr command_queue);
            internal static Finish clFinish;
            
            internal delegate int Flush(IntPtr command_queue);
            internal static Flush clFlush;
            
            internal unsafe delegate int GetCommandQueueInfo(IntPtr command_queue, CommandQueueInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetCommandQueueInfo clGetCommandQueueInfo;
            
            internal unsafe delegate int GetContextInfo(IntPtr context, ContextInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetContextInfo clGetContextInfo;
            
            internal unsafe delegate int GetDeviceIDs(IntPtr platform, DeviceTypeFlags device_type, uint num_entries, IntPtr* devices, uint* num_devices);
            internal unsafe static GetDeviceIDs clGetDeviceIDs;
            
            internal unsafe delegate int GetDeviceInfo(IntPtr device, DeviceInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetDeviceInfo clGetDeviceInfo;
            
            internal unsafe delegate int GetEventInfo(IntPtr @event, EventInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetEventInfo clGetEventInfo;
            
            internal unsafe delegate int GetEventProfilingInfo(IntPtr @event, ProfilingInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetEventProfilingInfo clGetEventProfilingInfo;
            
            internal unsafe delegate int GetImageInfo(IntPtr image, ImageInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetImageInfo clGetImageInfo;
            
            internal unsafe delegate int GetKernelInfo(IntPtr kernel, KernelInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetKernelInfo clGetKernelInfo;
            
            internal unsafe delegate int GetKernelWorkGroupInfo(IntPtr kernel, IntPtr device, KernelWorkGroupInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetKernelWorkGroupInfo clGetKernelWorkGroupInfo;
            
            internal unsafe delegate int GetMemObjectInfo(IntPtr memobj, MemInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetMemObjectInfo clGetMemObjectInfo;
            
            internal unsafe delegate int GetPlatformIDs(uint num_entries, IntPtr* platforms, uint* num_platforms);
            internal unsafe static GetPlatformIDs clGetPlatformIDs;
            
            internal unsafe delegate int GetPlatformInfo(IntPtr platform, PlatformInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetPlatformInfo clGetPlatformInfo;
            
            internal unsafe delegate int GetProgramBuildInfo(IntPtr program, IntPtr device, ProgramBuildInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetProgramBuildInfo clGetProgramBuildInfo;
            
            internal unsafe delegate int GetProgramInfo(IntPtr program, ProgramInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetProgramInfo clGetProgramInfo;
            
            internal unsafe delegate int GetSamplerInfo(IntPtr sampler, SamplerInfo param_name, IntPtr param_value_size, IntPtr param_value, [OutAttribute] IntPtr* param_value_size_ret);
            internal unsafe static GetSamplerInfo clGetSamplerInfo;
            
            internal unsafe delegate int GetSupportedImageFormats(IntPtr context, MemFlags flags, MemObjectType image_type, uint num_entries, ImageFormat* image_formats, uint* num_image_formats);
            internal unsafe static GetSupportedImageFormats clGetSupportedImageFormats;
            
            internal delegate int ReleaseCommandQueue(IntPtr command_queue);
            internal static ReleaseCommandQueue clReleaseCommandQueue;
            
            internal delegate int ReleaseContext(IntPtr context);
            internal static ReleaseContext clReleaseContext;
            
            internal delegate int ReleaseEvent(IntPtr @event);
            internal static ReleaseEvent clReleaseEvent;
            
            internal delegate int ReleaseKernel(IntPtr kernel);
            internal static ReleaseKernel clReleaseKernel;
            
            internal delegate int ReleaseMemObject(IntPtr memobj);
            internal static ReleaseMemObject clReleaseMemObject;
            
            internal delegate int ReleaseProgram(IntPtr program);
            internal static ReleaseProgram clReleaseProgram;
            
            internal delegate int ReleaseSampler(IntPtr sampler);
            internal static ReleaseSampler clReleaseSampler;
            
            internal delegate int RetainCommandQueue(IntPtr command_queue);
            internal static RetainCommandQueue clRetainCommandQueue;
            
            internal delegate int RetainContext(IntPtr context);
            internal static RetainContext clRetainContext;
            
            internal delegate int RetainEvent(IntPtr @event);
            internal static RetainEvent clRetainEvent;
            
            internal delegate int RetainKernel(IntPtr kernel);
            internal static RetainKernel clRetainKernel;
            
            internal delegate int RetainMemObject(IntPtr memobj);
            internal static RetainMemObject clRetainMemObject;
            
            internal delegate int RetainProgram(IntPtr program);
            internal static RetainProgram clRetainProgram;
            
            internal delegate int RetainSampler(IntPtr sampler);
            internal static RetainSampler clRetainSampler;
            
            internal unsafe delegate int SetCommandQueueProperty(IntPtr command_queue, CommandQueueFlags properties, bool enable, CommandQueueFlags* old_properties);
            internal unsafe static SetCommandQueueProperty clSetCommandQueueProperty;
            
            internal delegate int SetKernelArg(IntPtr kernel, uint arg_index, IntPtr arg_size, IntPtr arg_value);
            internal static SetKernelArg clSetKernelArg;
            
            internal delegate int UnloadCompiler();
            internal static UnloadCompiler clUnloadCompiler;
            
            internal unsafe delegate int WaitForEvents(uint num_events, IntPtr* event_list);
            internal unsafe static WaitForEvents clWaitForEvents;
        }
    }
}

#endif