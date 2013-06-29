﻿using CSCore.Utils;
using System;

namespace CSCore.SoundOut.DirectSound
{
    [RemoveObj]
    internal unsafe class InteropCalls
    {
        [MemoryCopy]
        internal static unsafe void* Write<T>(void* pDest, T[] data, int offset, int count) where T : struct
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* arg0, void* arg1, int arg2, void* methodPtr)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* arg0, void* arg1, void* methodPtr)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* arg0, void* arg1, void* arg2, void* arg3, void* methodPtr)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, void* p1, void* intPtr, void* p2)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, int arg0, int arg1, void* arg2, void* arg3, void* arg4, void* arg5, int arg6, void* methodPtr)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, void* p1, int audioBytes1, void* p2, int audioBytes2, void* p3)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, int p1, int p2, int p3, void* p4)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, void* p)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, int volume, void* p)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, void* p1, int p2, void* p3, void* p4)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, int p1, void* pnotifies, void* p2)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, int insideConeAngle, int outsideConeAngle, void* p)
        {
            throw new NotImplementedException();
        }
        
        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, float x, float y, float z, int p1, void* p2)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, float maxDistance, int p1, void* p2)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, float xFront, float yFront, float zFront, float xTop, float yTop, float zTop, int p1, void* p2)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, int flags, int effectsCount, void* presults, void* p)
        {
            throw new NotImplementedException();
        }

        [CSCli]
        internal static unsafe DSResult CalliMethodPtr(void* _basePtr, int effectCount, void* effects, void* results, void* p)
        {
            throw new NotImplementedException();
        }
    }
}