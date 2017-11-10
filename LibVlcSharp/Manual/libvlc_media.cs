// ----------------------------------------------------------------------------
// <auto-generated>
// This is autogenerated code by CppSharp.
// Do not edit this file or all your changes will be lost after re-generation.
// </auto-generated>
// ----------------------------------------------------------------------------
using System;
using System.Runtime.InteropServices;
using System.Security;

namespace VideoLAN.LibVLC
{
    public enum TrackType
    {
        Unknown = -1,
        Audio = 0,
        Video = 1,
        Text = 2
    }

    /// <summary>Note the order of libvlc_state_t enum must match exactly the order of</summary>
    /// <remarks>
    /// <para>mediacontrol_PlayerStatus,</para>
    /// <para>input_state_e enums,</para>
    /// <para>and VideoLAN.LibVLC.State (at bindings/cil/src/media.cs).</para>
    /// <para>Expected states by web plugins are:</para>
    /// <para>IDLE/CLOSE=0, OPENING=1, PLAYING=3, PAUSED=4,</para>
    /// <para>STOPPING=5, ENDED=6, ERROR=7</para>
    /// </remarks>
    public enum VLCState
    {
        NothingSpecial = 0,
        Opening = 1,
        Buffering = 2,
        Playing = 3,
        Paused = 4,
        Stopped = 5,
        Ended = 6,
        Error = 7
    }

    [Flags]
    public enum MediaOption
    {
        Trusted = 2,
        Unique = 256
    }

    public enum VideoOrientation
    {
        /// <summary>Normal. Top line represents top, left column left.</summary>
        TopLeft = 0,
        /// <summary>Flipped horizontally</summary>
        TopRight = 1,
        /// <summary>Flipped vertically</summary>
        BottomLeft = 2,
        /// <summary>Rotated 180 degrees</summary>
        BottomRight = 3,
        /// <summary>Transposed</summary>
        LeftTop = 4,
        /// <summary>Rotated 90 degrees clockwise (or 270 anti-clockwise)</summary>
        LeftBottom = 5,
        /// <summary>Rotated 90 degrees anti-clockwise</summary>
        RightTop = 6,
        /// <summary>Anti-transposed</summary>
        RightBottom = 7
    }

    [Flags]
    public enum VideoProjection
    {
        Rectangular = 0,
        /// <summary>360 spherical</summary>
        Equirectangular = 1,
        CubemapLayoutStandard = 256
    }

    
    

   

    /// <summary>Type of a media slave: subtitle or audio.</summary>
    public enum MediaSlaveType
    {
        Subtitle = 0,
        Audio = 1
    }

    
    //public unsafe partial class Media
    //{
    //    [StructLayout(LayoutKind.Explicit, Size = 0)]
    //    public partial struct __Internal
    //    {
    //    }

    //    public global::System.IntPtr __Instance { get; protected set; }

    //    protected int __PointerAdjustment;
    //    internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.Media> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.Media>();
    //    protected void*[] __OriginalVTables;

    //    protected bool __ownsNativeInstance;

    //    internal static global::VideoLAN.LibVLC.Media __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
    //    {
    //        return new global::VideoLAN.LibVLC.Media(native.ToPointer(), skipVTables);
    //    }

    //    internal static global::VideoLAN.LibVLC.Media __CreateInstance(global::VideoLAN.LibVLC.Media.__Internal native, bool skipVTables = false)
    //    {
    //        return new global::VideoLAN.LibVLC.Media(native, skipVTables);
    //    }

    //    private static void* __CopyValue(global::VideoLAN.LibVLC.Media.__Internal native)
    //    {
    //        var ret = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.Media.__Internal));
    //        *(global::VideoLAN.LibVLC.Media.__Internal*) ret = native;
    //        return ret.ToPointer();
    //    }

    //    private Media(global::VideoLAN.LibVLC.Media.__Internal native, bool skipVTables = false)
    //        : this(__CopyValue(native), skipVTables)
    //    {
    //        __ownsNativeInstance = true;
    //        NativeToManagedMap[__Instance] = this;
    //    }

    //    protected Media(void* native, bool skipVTables = false)
    //    {
    //        if (native == null)
    //            return;
    //        __Instance = new global::System.IntPtr(native);
    //    }
    //}

    public unsafe partial class MediaList
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.MediaList> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.MediaList>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::VideoLAN.LibVLC.MediaList __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.MediaList(native.ToPointer(), skipVTables);
        }

        internal static global::VideoLAN.LibVLC.MediaList __CreateInstance(global::VideoLAN.LibVLC.MediaList.__Internal native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.MediaList(native, skipVTables);
        }

        private static void* __CopyValue(global::VideoLAN.LibVLC.MediaList.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.MediaList.__Internal));
            *(global::VideoLAN.LibVLC.MediaList.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private MediaList(global::VideoLAN.LibVLC.MediaList.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected MediaList(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public MediaList(IntPtr ptr)
        {
            __Instance = ptr;
        }
    }

    

    public unsafe partial class MediaTrackInfo : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 28)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint i_codec;

            [FieldOffset(4)]
            internal int i_id;

            [FieldOffset(8)]
            internal global::VideoLAN.LibVLC.TrackType i_type;

            [FieldOffset(12)]
            internal int i_profile;

            [FieldOffset(16)]
            internal int i_level;

            [FieldOffset(20)]
            internal global::VideoLAN.LibVLC.MediaTrackInfo._.__Internal u;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="??0libvlc_media_track_info_t@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public unsafe partial struct _
        {
            [StructLayout(LayoutKind.Explicit, Size = 8)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::VideoLAN.LibVLC.MediaTrackInfo._.__.__Internal audio;

                [FieldOffset(0)]
                internal global::VideoLAN.LibVLC.MediaTrackInfo._.___.__Internal video;
            }

            public unsafe partial class __
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal uint i_channels;

                    [FieldOffset(4)]
                    internal uint i_rate;
                }
            }

            public unsafe partial class ___
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal uint i_height;

                    [FieldOffset(4)]
                    internal uint i_width;
                }
            }
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.MediaTrackInfo> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::VideoLAN.LibVLC.MediaTrackInfo>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::VideoLAN.LibVLC.MediaTrackInfo __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.MediaTrackInfo(native.ToPointer(), skipVTables);
        }

        internal static global::VideoLAN.LibVLC.MediaTrackInfo __CreateInstance(global::VideoLAN.LibVLC.MediaTrackInfo.__Internal native, bool skipVTables = false)
        {
            return new global::VideoLAN.LibVLC.MediaTrackInfo(native, skipVTables);
        }

        private static void* __CopyValue(global::VideoLAN.LibVLC.MediaTrackInfo.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.MediaTrackInfo.__Internal));
            *(global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) ret = native;
            return ret.ToPointer();
        }

        private MediaTrackInfo(global::VideoLAN.LibVLC.MediaTrackInfo.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected MediaTrackInfo(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public MediaTrackInfo()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.MediaTrackInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public MediaTrackInfo(global::VideoLAN.LibVLC.MediaTrackInfo _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::VideoLAN.LibVLC.MediaTrackInfo.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance) = *((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) _0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::VideoLAN.LibVLC.MediaTrackInfo __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint ICodec
        {
            get
            {
                return ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_codec;
            }

            set
            {
                ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_codec = value;
            }
        }

        public int IId
        {
            get
            {
                return ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_id;
            }

            set
            {
                ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_id = value;
            }
        }

        public global::VideoLAN.LibVLC.TrackType IType
        {
            get
            {
                return ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_type;
            }

            set
            {
                ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_type = value;
            }
        }

        public int IProfile
        {
            get
            {
                return ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_profile;
            }

            set
            {
                ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_profile = value;
            }
        }

        public int ILevel
        {
            get
            {
                return ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_level;
            }

            set
            {
                ((global::VideoLAN.LibVLC.MediaTrackInfo.__Internal*) __Instance)->i_level = value;
            }
        }
    }

    public struct AudioTrack 
    {
        public uint Channels;
        public uint Rate;
    }


    public struct VideoTrack
    {
        public uint Height;

        public uint Width;

        public uint SarNum;

        public uint SarDen;

        public uint FrameRateNum;

        public uint FrameRateDen;

        public VideoOrientation Orientation;

        public VideoProjection Projection;

        public VideoViewpoint Pose;
    }

    /// <summary>Viewpoint for video outputs</summary>
    /// <remarks>allocate using libvlc_video_new_viewpoint()</remarks>
    public struct VideoViewpoint
    {
        public float Yaw;
        public float Pitch;
        public float Roll;
        public float Fov;
    }

    public struct SubtitleTrack 
    {
        public IntPtr Encoding;
    }
    
    /// <summary>A slave of a libvlc_media_t</summary>
    /// <remarks>libvlc_media_slaves_get</remarks>
    public struct MediaSlave 
    {
        public IntPtr Uri;
        public MediaSlaveType Type;
        public uint Priority;
    }
    
    public unsafe partial class libvlc_media
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("libvlc", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint="libvlc_media_get_codec_description")]
            internal static extern global::System.IntPtr LibvlcMediaGetCodecDescription(global::VideoLAN.LibVLC.TrackType i_type, uint i_codec);
        }
        
       

            

        ///// <summary>
        ///// <para>Retain a reference to a media descriptor object (libvlc_media_t). Use</para>
        ///// <para>libvlc_media_release() to decrement the reference count of a</para>
        ///// <para>media descriptor object.</para>
        ///// </summary>
        ///// <param name="p_md">the media descriptor</param>
        //public static void LibvlcMediaRetain(global::VideoLAN.LibVLC.Media p_md)
        //{
        //    var __arg0 = ReferenceEquals(p_md, null) ? global::System.IntPtr.Zero : p_md.NativeReference;
        //    __Internal.LibvlcMediaRetain(__arg0);
        //}
      
        
       
        
      
        /// <summary>
        /// <para>Sets media descriptor's user_data. user_data is specialized data</para>
        /// <para>accessed by the host application, VLC.framework uses it as a pointer to</para>
        /// <para>an native object that references a libvlc_media_t pointer</para>
        /// </summary>
        /// <param name="p_md">media descriptor object</param>
        /// <param name="p_new_user_data">pointer to user data</param>
        //public static void LibvlcMediaSetUserData(global::VideoLAN.LibVLC.Media p_md, global::System.IntPtr p_new_user_data)
        //{
        //    var __arg0 = ReferenceEquals(p_md, null) ? global::System.IntPtr.Zero : p_md.NativeReference;
        //    __Internal.LibvlcMediaSetUserData(__arg0, p_new_user_data);
        //}

        ///// <summary>
        ///// <para>Get media descriptor's user_data. user_data is specialized data</para>
        ///// <para>accessed by the host application, VLC.framework uses it as a pointer to</para>
        ///// <para>an native object that references a libvlc_media_t pointer</para>
        ///// </summary>
        ///// <param name="p_md">media descriptor object</param>
        //public static global::System.IntPtr LibvlcMediaGetUserData(global::VideoLAN.LibVLC.Media p_md)
        //{
        //    var __arg0 = ReferenceEquals(p_md, null) ? global::System.IntPtr.Zero : p_md.NativeReference;
        //    var __ret = __Internal.LibvlcMediaGetUserData(__arg0);
        //    return __ret;
        //}

       

        /// <summary>Get codec description from media elementary stream</summary>
        /// <param name="i_type">i_type from libvlc_media_track_t</param>
        /// <param name="i_codec">i_codec or i_original_fourcc from libvlc_media_track_t</param>
        /// <returns>codec description</returns>
        /// <remarks>
        /// <para>LibVLC 3.0.0 and later.</para>
        /// <para>libvlc_media_track_t</para>
        /// </remarks>
        public static string LibvlcMediaGetCodecDescription(global::VideoLAN.LibVLC.TrackType i_type, uint i_codec)
        {
            var __ret = __Internal.LibvlcMediaGetCodecDescription(i_type, i_codec);
            return Marshal.PtrToStringAnsi(__ret);
        }
        

      

      

        

        
    }
}