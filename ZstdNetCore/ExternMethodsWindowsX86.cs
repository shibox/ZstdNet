﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using size_t = System.UIntPtr;

namespace ZstdNetCore
{
    internal class ExternMethodsWindowsX86
    {
        private const string DllName = "lib\\x86\\libzstd.dll";

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZDICT_trainFromBuffer(byte[] dictBuffer, size_t dictBufferCapacity, byte[] samplesBuffer, size_t[] samplesSizes, uint nbSamples);
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ZDICT_isError(size_t code);
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ZDICT_getErrorName(size_t code);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ZSTD_createCCtx();
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZSTD_freeCCtx(IntPtr cctx);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ZSTD_createDCtx();
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZSTD_freeDCtx(IntPtr cctx);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZSTD_compressCCtx(IntPtr ctx, IntPtr dst, size_t dstCapacity, IntPtr src, size_t srcSize, int compressionLevel);
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZSTD_decompressDCtx(IntPtr ctx, IntPtr dst, size_t dstCapacity, IntPtr src, size_t srcSize);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ZSTD_createCDict(byte[] dict, size_t dictSize, int compressionLevel);
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZSTD_freeCDict(IntPtr cdict);
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZSTD_compress_usingCDict(IntPtr cctx, IntPtr dst, size_t dstCapacity, IntPtr src, size_t srcSize, IntPtr cdict);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ZSTD_createDDict(byte[] dict, size_t dictSize);
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZSTD_freeDDict(IntPtr ddict);
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZSTD_decompress_usingDDict(IntPtr dctx, IntPtr dst, size_t dstCapacity, IntPtr src, size_t srcSize, IntPtr ddict);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern ulong ZSTD_getDecompressedSize(IntPtr src, size_t srcSize);

        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern int ZSTD_maxCLevel();
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern size_t ZSTD_compressBound(size_t srcSize);
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern uint ZSTD_isError(size_t code);
        [DllImport(DllName, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr ZSTD_getErrorName(size_t code);
    }
}
