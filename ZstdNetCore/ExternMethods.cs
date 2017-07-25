using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using size_t = System.UIntPtr;

namespace ZstdNetCore
{
    internal static class ExternMethods
    {
        static PlatformID platform = Environment.OSVersion.Platform;

        public static size_t ZDICT_trainFromBuffer(byte[] dictBuffer, size_t dictBufferCapacity, byte[] samplesBuffer, size_t[] samplesSizes, uint nbSamples)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZDICT_trainFromBuffer(dictBuffer, dictBufferCapacity, samplesBuffer, samplesSizes, nbSamples);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZDICT_trainFromBuffer(dictBuffer, dictBufferCapacity, samplesBuffer, samplesSizes, nbSamples);
            }
            else
            {
                return ExternMethodsWindowsX86.ZDICT_trainFromBuffer(dictBuffer, dictBufferCapacity, samplesBuffer, samplesSizes, nbSamples);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static uint ZDICT_isError(size_t code)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZDICT_isError(code);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZDICT_isError(code);
            }
            else
            {
                return ExternMethodsWindowsX86.ZDICT_isError(code);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static IntPtr ZDICT_getErrorName(size_t code)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZDICT_getErrorName(code);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZDICT_getErrorName(code);
            }
            else
            {
                return ExternMethodsWindowsX86.ZDICT_getErrorName(code);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static IntPtr ZSTD_createCCtx()
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_createCCtx();
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_createCCtx();
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_createCCtx();
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static size_t ZSTD_freeCCtx(IntPtr cctx)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_freeCCtx(cctx);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_freeCCtx(cctx);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_freeCCtx(cctx);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static IntPtr ZSTD_createDCtx()
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_createDCtx();
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_createDCtx();
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_createDCtx();
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static size_t ZSTD_freeDCtx(IntPtr cctx)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_freeDCtx(cctx);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_freeDCtx(cctx);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_freeDCtx(cctx);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static size_t ZSTD_compressCCtx(IntPtr ctx, IntPtr dst, size_t dstCapacity, IntPtr src, size_t srcSize, int compressionLevel)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_compressCCtx(ctx, dst, dstCapacity, src, srcSize, compressionLevel);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_compressCCtx(ctx, dst, dstCapacity, src, srcSize, compressionLevel);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_compressCCtx(ctx, dst, dstCapacity, src, srcSize, compressionLevel);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static size_t ZSTD_decompressDCtx(IntPtr ctx, IntPtr dst, size_t dstCapacity, IntPtr src, size_t srcSize)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_decompressDCtx(ctx, dst, dstCapacity, src, srcSize);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_decompressDCtx(ctx, dst, dstCapacity, src, srcSize);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_decompressDCtx(ctx, dst, dstCapacity, src, srcSize);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static IntPtr ZSTD_createCDict(byte[] dict, size_t dictSize, int compressionLevel)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_createCDict(dict, dictSize, compressionLevel);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_createCDict(dict, dictSize, compressionLevel);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_createCDict(dict, dictSize, compressionLevel);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static size_t ZSTD_freeCDict(IntPtr cdict)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_freeCDict(cdict);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_freeCDict(cdict);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_freeCDict(cdict);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static size_t ZSTD_compress_usingCDict(IntPtr cctx, IntPtr dst, size_t dstCapacity, IntPtr src, size_t srcSize, IntPtr cdict)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_compress_usingCDict(cctx, dst, dstCapacity, src, srcSize, cdict);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_compress_usingCDict(cctx, dst, dstCapacity, src, srcSize, cdict);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_compress_usingCDict(cctx, dst, dstCapacity, src, srcSize, cdict);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static IntPtr ZSTD_createDDict(byte[] dict, size_t dictSize)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_createDDict(dict, dictSize);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_createDDict(dict, dictSize);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_createDDict(dict, dictSize);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static size_t ZSTD_freeDDict(IntPtr ddict)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_freeDDict(ddict);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_freeDDict(ddict);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_freeDDict(ddict);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static size_t ZSTD_decompress_usingDDict(IntPtr dctx, IntPtr dst, size_t dstCapacity, IntPtr src, size_t srcSize, IntPtr ddict)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_decompress_usingDDict(dctx, dst, dstCapacity, src, srcSize, ddict);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_decompress_usingDDict(dctx, dst, dstCapacity, src, srcSize, ddict);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_decompress_usingDDict(dctx, dst, dstCapacity, src, srcSize, ddict);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static ulong ZSTD_getDecompressedSize(IntPtr src, size_t srcSize)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_getDecompressedSize(src, srcSize);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_getDecompressedSize(src, srcSize);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_getDecompressedSize(src, srcSize);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static int ZSTD_maxCLevel()
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_maxCLevel();
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_maxCLevel();
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_maxCLevel();
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static size_t ZSTD_compressBound(size_t srcSize)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_compressBound(srcSize);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_compressBound(srcSize);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_compressBound(srcSize);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static uint ZSTD_isError(size_t code)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_isError(code);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_isError(code);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_isError(code);
            }
            throw new Exception("OperatingSystem Not Support");
        }

        public static IntPtr ZSTD_getErrorName(size_t code)
        {
            if (Environment.Is64BitProcess == true)
            {
                if (platform == PlatformID.Win32NT || platform == PlatformID.Win32Windows)
                    return ExternMethodsWindowsX64.ZSTD_getErrorName(code);
                else if (platform == PlatformID.Unix)
                    return ExternMethodsUnix.ZSTD_getErrorName(code);
            }
            else
            {
                return ExternMethodsWindowsX86.ZSTD_getErrorName(code);
            }
            throw new Exception("OperatingSystem Not Support");
        }
	}
}
